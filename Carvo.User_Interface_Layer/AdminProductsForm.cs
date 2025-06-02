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

namespace Carvo.User_Interface_Layer
{
    public partial class AdminProductsForm : Form
    {
        private IProductService productService;
        public AdminProductsForm(IProductService _productService)
        {
            productService = _productService;
            InitializeComponent();
            this.Load += async (s, e) => await LoadCategoriesAsync();

            /* Testing Grid View */
            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },

            //};

            //var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

            //ProductsGridView.AllowUserToAddRows = false;
            //ProductsGridView.DataSource = GridView;

            //ProductsGridView.Columns[0].HeaderText = "الاسم";
            //ProductsGridView.Columns[1].HeaderText = "الوصف";
            //ProductsGridView.Columns[2].HeaderText = "سعر الوحدة";

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

        private async Task LoadCategoriesAsync()
        {
            var allCategories = await productService.GetAllProductsAsync();

            var categories = allCategories.Select(c => new { ID = c.Id, Description = c.Description, Name = c.Name }).ToList();

            ProductsGridView.DataSource = null;
            ProductsGridView.DataSource = categories;

            ProductsGridView.Columns["ID"].Visible = false;
            ProductsGridView.Columns[1].HeaderText = "الوصف";
            ProductsGridView.Columns[2].HeaderText = "الاسم";
        }
    }
}
