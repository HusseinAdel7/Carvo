using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carvo.User_Interface_Layer
{
    public partial class DashboardForm : Form
    {
        ICustomerService _customerService;
        ISupplierService _supplierService;
        IInvoiceService _invoiceService;
        IProductService _productService;
        ICategoryService _categoryService;
        IUserService _userService;
        IServiceProvider _serviceProvider;
        public DashboardForm(IServiceProvider serviceProvider,ICustomerService customerService, ISupplierService supplierService, IInvoiceService invoiceService, IProductService productService, ICategoryService categoryService, IUserService userService)
        {
            InitializeComponent();
            _customerService = customerService;
            _supplierService = supplierService;
            _invoiceService = invoiceService;
            _productService = productService;
            _categoryService = categoryService;
            _userService = userService;
            _serviceProvider = serviceProvider;
            LoadData();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private async void LoadData()
        {
            try
            {
                var customers = await _customerService.GetAllCustomersAsync();
                var suppliers = await _supplierService.GetAllSuppliersAsync();
                var invoices = await _invoiceService.GetAllInvoicesAsync();
                var products = await _productService.GetAllProductsAsync();
                var categories = await _categoryService.GetAllCategoryAsync();
                var users = await _userService.GetAllUsersAsync();

                int customerCount = customers.Count();
                CustomersNum.Text = customerCount.ToString();
                int supplierCount = suppliers.Count();
                supplierNum.Text = supplierCount.ToString();
                int invoiceCount = invoices.Count();
                InvoiceNum.Text = invoiceCount.ToString();
                int productCount = products.Count();
                ProductNum.Text = productCount.ToString();
                int categoryCount = categories.Count();
                CategoryNum.Text = categoryCount.ToString();
                int userCount = users.Count();
                UserNum.Text = userCount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = _serviceProvider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }
    }
}
