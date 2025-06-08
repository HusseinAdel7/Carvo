using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;
using Microsoft.Extensions.DependencyInjection;


namespace Carvo.User_Interface_Layer
{
    public partial class InvoiceForm : Form
    {

        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
        public Invoice Invoice_ { get; set; }
        public decimal PaidPrice { get; set; }
        public List<DataDispalyedInGrid> ProductsList;
        public InvoiceForm()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadInvoiceFormAsync();


            /* Testing Grid View */
            //List<Product> products = new List<Product>()
            //{
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
            //    new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 }
            //};

            //var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

            //ProductsServicesGrid.AllowUserToAddRows = false;
            //ProductsServicesGrid.DataSource = GridView;

            //ProductsServicesGrid.Columns[0].HeaderText = "الاسم";
            //ProductsServicesGrid.Columns[1].HeaderText = "الوصف";
            //ProductsServicesGrid.Columns[2].HeaderText = "سعر الوحدة";

        }

        private async Task LoadInvoiceFormAsync()
        {
            this.Controls.Remove(ProductsServicesGrid);
            this.Controls.Remove(PartsAndServicesHeaderPanel);

            InvoiceDate.Text = Invoice_.InvoiceDate.ToString();
            InvoiceID.Text = Invoice_.InvoiceNumber.ToString();
            InvoiceType.Text = Invoice_.InvoiceType.ToString();
            EmployeeName.Text = LoggedUser.loggedUserName;
            CustomerName.Text = Customer.Name;
            CustomerPhone.Text = Customer.PhoneNumber.ToString();

            if (Invoice_.InvoiceType == Data_Access_Layer.Enums.InvoiceType.Repair)
            {
                VehicleModel.Text = Vehicle.Model.ToString();
                VehiclePlate.Text = Vehicle.PlateNumber.ToString();
                VehicleVIN.Text = Vehicle.Id.ToString();

                SubTotal.Text = Invoice_.RepairAmount.ToString();
                PaidAmount.Text = PaidPrice.ToString();
                RemainingAmount.Text = (Invoice_.RepairAmount - PaidPrice).ToString();
            }
            else
            {

                //var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

                ProductsServicesGrid.AllowUserToAddRows = false;
                ProductsServicesGrid.DataSource = ProductsList;

                ProductsServicesGrid.Columns["InvoiceId"].Visible = false;
                ProductsServicesGrid.Columns["ProdId"].Visible = false;
                ProductsServicesGrid.Columns[2].HeaderText = "المنتج";
                ProductsServicesGrid.Columns["CustomerName"].Visible = false;
                ProductsServicesGrid.Columns[4].HeaderText = "الكمية";
                ProductsServicesGrid.Columns[5].HeaderText = "السعر";

                SubTotal.Text = Invoice_.SaleAmount.ToString();
                PaidAmount.Text = PaidPrice.ToString();
                RemainingAmount.Text = (Invoice_.SaleAmount - PaidPrice).ToString();
            }




        }

        private void ProductsServicesGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = ProductsServicesGrid.ColumnHeadersHeight;

            foreach (DataGridViewRow row in ProductsServicesGrid.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            ProductsServicesGrid.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            //EmployeeDashboardForm employeeDashboard = serviceProvider.GetRequiredService<EmployeeDashboardForm>();
            //employeeDashboard.Show();
            //this.Close();
        }
    }
}
