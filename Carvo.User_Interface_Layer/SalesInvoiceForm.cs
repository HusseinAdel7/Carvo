using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;
using Microsoft.Extensions.DependencyInjection;


namespace Carvo.User_Interface_Layer
{




    public partial class SalesInvoiceForm : Form
    {
        private IServiceProvider serviceProvider;
        private ICustomerService customerService;
        private IProductService productService;
        private IInvoiceService invoiceService;
        private IInvoiceProductService invoiceProductService;

        private IEnumerable<Product> allProducts;
        private IEnumerable<Customer> allCustomers;

        private List<DataDispalyedInGrid> dispalyedInGrids = new List<DataDispalyedInGrid>();

        private Invoice addedInvoice = null;
        private InvoiceProduct addedInvoiceProduct = null;


        public SalesInvoiceForm(IServiceProvider _serviceProvider, IProductService _productService, ICustomerService _customerService, IInvoiceService _invoiceService, IInvoiceProductService _invoiceProductService)
        {
            serviceProvider = _serviceProvider;
            customerService = _customerService;
            productService = _productService;
            invoiceService = _invoiceService;
            invoiceProductService = _invoiceProductService;
            InitializeComponent();
            this.Load += async (s, e) => await LoadInvoicesAsync();
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private async Task LoadInvoicesAsync()
        {
            allProducts = await productService.GetAllProductsAsync();
            allCustomers = await customerService.GetAllCustomersAsync();

            SalesInvoiceGridView.DataSource = new BindingList<DataDispalyedInGrid>(dispalyedInGrids);

            SalesInvoiceGridView.Columns["InvoiceId"].Visible = false;
            SalesInvoiceGridView.Columns["ProdId"].Visible = false;
            SalesInvoiceGridView.Columns[2].HeaderText = "المنتج";
            SalesInvoiceGridView.Columns[3].HeaderText = "العميل";
            SalesInvoiceGridView.Columns[4].HeaderText = "الكمية";
            SalesInvoiceGridView.Columns[5].HeaderText = "السعر";

            ProductsDropdownList.DisplayMember = "Name";  // What the user sees
            ProductsDropdownList.ValueMember = "Id";    // What you use internally
            ProductsDropdownList.DataSource = allProducts;

            if (dispalyedInGrids.Count == 0)
            {
                CustomersDropdownList.DisplayMember = "Name";  // What the user sees
                CustomersDropdownList.ValueMember = "Id";    // What you use int
                CustomersDropdownList.DataSource = allCustomers;

                CustomersDropdownList.Enabled = true;
            }

        }

        private async void AddInvoiceBtn_Click(object sender, EventArgs e)
        {

            try
            {
                quantityErrorMsg.Visible = false;
                PrintErrorMsg.Visible = false;

                int quantity = int.Parse(ProductQuantityNumeric.Value.ToString());
                int customerId = (int)CustomersDropdownList.SelectedValue;
                int productId = (int)ProductsDropdownList.SelectedValue;


                Product product = allProducts.FirstOrDefault(p => p.Id == productId);
                Customer customer = allCustomers.FirstOrDefault(c => c.Id == customerId);

                decimal totalPrice = (decimal)product.Price * quantity;

                if(quantity > product.Quantity)
                {
                    quantityErrorMsg.Text = $"الكمية المتاحة حاليا {product.Quantity}";
                    quantityErrorMsg.Visible = true;
                    return;
                }

                if (dispalyedInGrids.Count == 0)
                {
                    Invoice invoice = new Invoice
                    {
                        InvoiceType = InvoiceType.Sale,
                        CustomerId = customerId,
                        SaleAmount = totalPrice,
                        UserId = LoggedUser.loggedUserId,
                        InvoiceNumber = "Abc123"
                    };

                    addedInvoice = await invoiceService.AddInvoiceAsync(invoice);

                    CustomersDropdownList.Enabled = false;
                    CustomersDropdownList.SelectedValue = customerId;
                }

                InvoiceProduct invoiceProduct = new InvoiceProduct { InvoiceId = addedInvoice.Id, ProductId = productId, Quantity = quantity };

                addedInvoiceProduct = await invoiceProductService.AddInvoiceProductAsync(invoiceProduct);

                dispalyedInGrids.Add(new DataDispalyedInGrid
                {
                    CustomerName = customer.Name,
                    ProdName = product.Name,
                    Quantity = quantity,
                    TotalPrice = (double)totalPrice,
                    InvoiceId = addedInvoice.Id,
                    ProdId = productId
                });

                AddAlertForm addAlert = serviceProvider.GetRequiredService<AddAlertForm>();
                addAlert.ShowDialog();

                TotalPriceNumeric.Value = (decimal)dispalyedInGrids.Sum(g => g.TotalPrice);
                addedInvoice.SaleAmount = (decimal)dispalyedInGrids.Sum(g => g.TotalPrice);

                await LoadInvoicesAsync();
                await invoiceService.UpdateInvoiceAsync(addedInvoice);
            }
            catch
            {

            }
            
        }

        private async void DeleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            quantityErrorMsg.Visible = false;
            PrintErrorMsg.Visible = false;

            if (SalesInvoiceGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = SalesInvoiceGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["ProdId"].Value);


            dispalyedInGrids.Remove(dispalyedInGrids.Find(i => i.ProdId == id));
            TotalPriceNumeric.Value = (decimal)dispalyedInGrids.Sum(g => g.TotalPrice);
            addedInvoice.SaleAmount = (decimal)dispalyedInGrids.Sum(g => g.TotalPrice);
            await LoadInvoicesAsync();

            DeleteAlertForm deleteAlert = serviceProvider.GetRequiredService<DeleteAlertForm>();
            deleteAlert.ShowDialog();

            IEnumerable<InvoiceProduct> invoicePSList = await invoiceProductService.GetAllInvoiceProductsAsync();

            InvoiceProduct invoiceP = invoicePSList.FirstOrDefault(ips => ips.ProductId == id && ips.InvoiceId == addedInvoice.Id);

            await invoiceProductService.DeleteInvoiceProductAsync(invoiceP.Id);

            if (dispalyedInGrids.Count == 0)
                await invoiceService.DeleteInvoiceAsync(invoiceP.InvoiceId);
        }

        private async void ExtractInvoiceBtn_Click(object sender, EventArgs e)
        {
            if(dispalyedInGrids.Count == 0)
            {
                PrintErrorMsg.Visible = true;
            }
            else
            {
                int customerId = (int)CustomersDropdownList.SelectedValue;
                Customer customer = allCustomers.FirstOrDefault(c => c.Id == customerId);

                PaidSalesInvoiceForm paidSalesInvoiceForm = serviceProvider.GetRequiredService<PaidSalesInvoiceForm>();
                paidSalesInvoiceForm.Invoice = addedInvoice;
                paidSalesInvoiceForm.Customer = customer;
                paidSalesInvoiceForm.ProductsList = dispalyedInGrids;
                paidSalesInvoiceForm.Show();

                foreach(var product in dispalyedInGrids)
                {
                    Product dbProduct = await productService.GetProductByIdAsync(product.ProdId);
                    dbProduct.Quantity -= product.Quantity;
                    await productService.UpdateProductAsync(dbProduct);
                }

                this.Close();
            }         
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void PrevFormBtn_Click(object sender, EventArgs e)
        {
            EmployeeDashboardForm employeeDashboard = serviceProvider.GetRequiredService<EmployeeDashboardForm>();
            employeeDashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class DataDispalyedInGrid
    {
        public int InvoiceId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

    }

}
