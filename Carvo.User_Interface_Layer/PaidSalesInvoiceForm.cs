using System;
using System.Collections.Generic;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class PaidSalesInvoiceForm : Form
    {
        private IServiceProvider serviceProvider;
        private ICustomerService customerService;

        public Invoice Invoice;
        public Customer Customer;
        public List<DataDispalyedInGrid> ProductsList;
        public PaidSalesInvoiceForm(IServiceProvider _serviceProvider, ICustomerService _customerService)
        {
            serviceProvider = _serviceProvider;
            customerService = _customerService;
            InitializeComponent();
            this.Load += async (s, e) => await LoadInvoicesAsync();
            this.Paint += Form1_Paint;
        }


        private async Task LoadInvoicesAsync()
        {
            TotalPriceNumeric.Value = Invoice.SaleAmount;

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int borderThickness = 4;
            Color borderColor = Color.LightGray;

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.DrawRectangle(pen,
                    new Rectangle(0, 0, this.Width - borderThickness, this.Height - borderThickness));
            }
        }

        private async void PrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            PaidPriceErrorMsg.Visible = false;
            if (PaidPriceNumeric.Value > TotalPriceNumeric.Value)
            {
                PaidPriceErrorMsg.Visible = true;
                return;
            }
            Customer.RemainingBalance += (double)(TotalPriceNumeric.Value - PaidPriceNumeric.Value);
            await customerService.UpdateCustomerAsync(Customer);

            InvoiceForm invoiceForm = serviceProvider.GetRequiredService<InvoiceForm>();
            invoiceForm.Invoice_ = Invoice;
            invoiceForm.Customer = Customer;
            invoiceForm.ProductsList = ProductsList;
            invoiceForm.PaidPrice = PaidPriceNumeric.Value;
            invoiceForm.Show();
            this.Close();
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
