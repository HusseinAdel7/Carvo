using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminProductsForm : Form
    {
        private IProductService productService;
        private ICategoryService categoryService;
        private ISupplierService supplierService;

        private string supplierSearchTxt = "";

        private IEnumerable<Category> allCategories;
        private IEnumerable<Supplier> allSuppliers;
        public AdminProductsForm(IProductService _productService, ICategoryService _categoryService, ISupplierService _supplierService)
        {
            productService = _productService;
            categoryService = _categoryService;
            supplierService = _supplierService;


            InitializeComponent();
            this.Load += async (s, e) => await LoadProductsAsync();
            this.categoryService = categoryService;
            this.supplierService = supplierService;
        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = ProductsGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in ProductsGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            ProductsGridView.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async Task LoadProductsAsync()
        {
            var allProducts = await productService.GetAllProductsAsync();
            allCategories = await categoryService.GetAllCategoryAsync();
            allSuppliers = await supplierService.GetAllSuppliersAsync();


            var products = allProducts.Select(p => new
            {
                ID = p.Id,
                SupplierName = allSuppliers.FirstOrDefault(s => s.Id == p.SupplierId)?.Name ?? "لا يوجد",
                CategoryName = allCategories.FirstOrDefault(c => c.Id == p.CategoryId)?.Name ?? "لا يوجد",
                Quantity = p.Quantity,
                Price = p.Price,
                Description = p.Description,
                Name = p.Name
            }).ToList();

            ProductsGridView.DataSource = null;
            ProductsGridView.DataSource = products;

            ProductsGridView.Columns["ID"].Visible = false;
            ProductsGridView.Columns[1].HeaderText = "الموزع";
            ProductsGridView.Columns[2].HeaderText = "الصنف";
            ProductsGridView.Columns[3].HeaderText = "الكمية";
            ProductsGridView.Columns[4].HeaderText = "السعر";
            ProductsGridView.Columns[5].HeaderText = "الوصف";
            ProductsGridView.Columns[6].HeaderText = "الاسم";

            CategoriesDeopdownList.DisplayMember = "Name";  // What the user sees
            CategoriesDeopdownList.ValueMember = "Id";    // What you use internally
            CategoriesDeopdownList.DataSource = allCategories;

            SupplierNameDropdownList.DisplayMember = "Name";  // What the user sees
            SupplierNameDropdownList.ValueMember = "Id";    // What you use int
            SupplierNameDropdownList.DataSource = allSuppliers;
        }

        private async void ProductsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductsGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ProductsGridView.SelectedRows[0];
                string productDesc = selectedRow.Cells["Description"].Value.ToString();
                string productName = selectedRow.Cells["Name"].Value.ToString();
                int productprice = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                int productQuantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());
                string categoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                string supplierName = selectedRow.Cells["SupplierName"].Value.ToString();

                /*Get Id Of Category , and ID Of Supplier*/
                int categoryId = allCategories.Where(c => c.Name == categoryName)
                    .Select(c => c.Id).FirstOrDefault();
                int supplierId = allSuppliers.Where(s => s.Name == supplierName)
                    .Select(s => s.Id).FirstOrDefault();

                CategoriesDeopdownList.SelectedValue = categoryId;
                SupplierNameDropdownList.SelectedValue = supplierId;

                ProductNameTxt.Text = productName;
                ProductDescTxt.Text = productDesc;
                ProductPriceNumeric.Value = productprice;
                ProductQuantityNumeric.Value = productQuantity;
            }
        }

        private async void AddProductBtn_Click(object sender, EventArgs e)
        {
            string name = ProductNameTxt.Text;
            string desc = ProductDescTxt.Text;
            int quantity = int.Parse(ProductQuantityNumeric.Value.ToString());
            double price = double.Parse(ProductPriceNumeric.Value.ToString());
            int supplierId = (int)SupplierNameDropdownList.SelectedValue;
            int categoryId = (int)CategoriesDeopdownList.SelectedValue;


            if (ValidateProduct(name, desc, quantity, price))
            {
                Product addedProduct = new Product
                {
                    Name = name,
                    Description = desc,
                    Quantity = quantity,
                    Price = price,
                    SupplierId = supplierId,
                    CategoryId = categoryId
                };
                await productService.AddProductAsync(addedProduct);
                await LoadProductsAsync();
            }

        }




        private async void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            string name = ProductNameTxt.Text;
            string desc = ProductDescTxt.Text;
            int quantity = int.Parse(ProductQuantityNumeric.Value.ToString());
            double price = double.Parse(ProductPriceNumeric.Value.ToString());
            int supplierId = (int)SupplierNameDropdownList.SelectedValue;
            int categoryId = (int)CategoriesDeopdownList.SelectedValue;


            if (ValidateProduct(name, desc, quantity, price))
            {
                var selectedRow = ProductsGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                Product product = await productService.GetProductByIdAsync(id);
                product.Name = name;
                product.Description = desc;
                product.Quantity = quantity;
                product.Price = price;
                product.SupplierId = supplierId;
                product.CategoryId = categoryId;

                await productService.UpdateProductAsync(product);
                await LoadProductsAsync();
            }

        }

        private async void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = ProductsGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            await productService.DeleteProductAsync(id);
            await LoadProductsAsync();
        }

        private bool ValidateProduct(string productName, string productDesc, int productQuantity, double productPrice)
        {
            bool isValid = true;

            if (productName.Length < 3 || string.IsNullOrWhiteSpace(productName))
            {
                isValid = false;
                ProdNameErrorMsg.Visible = true;
            }
            else
                ProdNameErrorMsg.Visible = false;

            if (productDesc.Length < 5 || string.IsNullOrWhiteSpace(productDesc))
            {
                isValid = false;
                ProdDescErrorMsg.Visible = true;
            }
            else
                ProdDescErrorMsg.Visible = false;

            if (productPrice > 500000 || productPrice < 0)
            {
                isValid = false;
                ProdPriceErrorMsg.Visible = true;
            }
            else
                ProdPriceErrorMsg.Visible = false;

            if (productQuantity > 10000 || productQuantity < 0)
            {
                isValid = false;
                ProdQuantityErrorMsg.Visible = true;
            }
            else
                ProdQuantityErrorMsg.Visible = false;


            return isValid;
        }

        private void FliterSuppliersTxt_TextChanged(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(FliterSuppliersTxt.Text))
                SupplierNameDropdownList.DataSource = allSuppliers;
            else
            {
                List<Supplier> filteredList = allSuppliers.Where(
                    s => s.Name.ToLower().Contains(FliterSuppliersTxt.Text.ToLower())
                ).ToList();
                SupplierNameDropdownList.DataSource = filteredList;
            }
                
        }
    }
}
