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
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class RepairInvoiceForm : Form
    {

        private IInvoiceService invoiceService;
        private ICustomerService customerService;
        private IVehicleService vehicleService;
        private IServiceProvider serviceProvider;

        private IEnumerable<Vehicle> allVehicles = new List<Vehicle>();
        private IEnumerable<Customer> allCustomers = new List<Customer>();

        Invoice addedInvoice = null;

        public RepairInvoiceForm(IServiceProvider _serviceProvider, IInvoiceService _invoiceService, ICustomerService _customerService, IVehicleService _vehicleService)
        {
            invoiceService = _invoiceService;
            customerService = _customerService;
            vehicleService = _vehicleService;
            serviceProvider = _serviceProvider;
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
            allCustomers = await customerService.GetAllCustomersAsync();
            allVehicles = await vehicleService.GetAllVehiclesAsync();

            CustomerDropdowwnList.DisplayMember = "Name";  // What the user sees
            CustomerDropdowwnList.ValueMember = "Id";    // What you use internally
            CustomerDropdowwnList.DataSource = allCustomers;

        }

        private async void CustomerDropdowwnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerId = (int)CustomerDropdowwnList.SelectedValue;
            List<Vehicle> vehicles = allVehicles.Where(v => v.CustomerId == customerId).ToList();

            VehicleDropDownList.DisplayMember = "Name";  // What the user sees
            VehicleDropDownList.ValueMember = "Id";    // What you use internally
            VehicleDropDownList.DataSource = vehicles;
        }

        private void CustomersFilterTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomersFilterTxt.Text))
                CustomerDropdowwnList.DataSource = allCustomers;
            else
            {
                List<Customer> filteredList = allCustomers.Where(
                    s => s.Name.ToLower().Contains(CustomersFilterTxt.Text.ToLower())
                ).ToList();
                CustomerDropdowwnList.DataSource = filteredList;
            }
        }

        private async void AddInvoiceBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)CustomerDropdowwnList.SelectedValue;
            int vehicleId = (int)VehicleDropDownList.SelectedValue;

            decimal repairAmount = (decimal)RepairPriceNumeric.Value;

            Invoice invoice = new Invoice { CustomerId = customerId, InvoiceNumber = "Abc123", InvoiceType = InvoiceType.Repair, RepairAmount = repairAmount, UserId = LoggedUser.loggedUserId };

            CustomerNameLabel.Text = allCustomers.FirstOrDefault(c => c.Id == customerId).Name;
            VehicleNameLabel.Text = allVehicles.FirstOrDefault(v => v.Id == vehicleId).Name;
            TotalPriceLabel.Text = RepairPriceNumeric.Value.ToString();
            PaidMoneyLabel.Text = PaidMoneyNumeric.Value.ToString();
            RestMoneyLabel.Text = (RepairPriceNumeric.Value - PaidMoneyNumeric.Value).ToString();

            PaidMoneyNumeric.Maximum = RepairPriceNumeric.Value;


            addedInvoice = await invoiceService.AddInvoiceAsync(invoice);
        }

        private async void UpdateInvoiceBtn_Click(object sender, EventArgs e)
        {
            int customerId = (int)CustomerDropdowwnList.SelectedValue;
            int vehicleId = (int)VehicleDropDownList.SelectedValue;

            decimal repairAmount = (decimal)RepairPriceNumeric.Value;

            addedInvoice.CustomerId = customerId;
            addedInvoice.RepairAmount = repairAmount;


            CustomerNameLabel.Text = allCustomers.FirstOrDefault(c => c.Id == customerId).Name;
            VehicleNameLabel.Text = allVehicles.FirstOrDefault(v => v.Id == vehicleId).Name;
            TotalPriceLabel.Text = RepairPriceNumeric.Value.ToString();
            PaidMoneyLabel.Text = PaidMoneyNumeric.Value.ToString();
            RestMoneyLabel.Text = (RepairPriceNumeric.Value - PaidMoneyNumeric.Value).ToString();

            PaidMoneyNumeric.Maximum = RepairPriceNumeric.Value;


            await invoiceService.UpdateInvoiceAsync(addedInvoice);
        }

        private async void DeleteInvoiceBtn_Click(object sender, EventArgs e)
        {
            CustomerNameLabel.Text = "";
            VehicleNameLabel.Text = "";
            TotalPriceLabel.Text = "";
            PaidMoneyLabel.Text = "";
            RestMoneyLabel.Text = "";

            await invoiceService.DeleteInvoiceAsync(addedInvoice.Id);
        }

        private async void PrintInvoice_Click(object sender, EventArgs e)
        {
            int customerId = (int)CustomerDropdowwnList.SelectedValue;
            Customer customer = await customerService.GetCustomerByIdAsync(customerId);
            customer.RemainingBalance = (double)(RepairPriceNumeric.Value - PaidMoneyNumeric.Value);
            await customerService.UpdateCustomerAsync(customer);

            InvoiceForm invoiceForm = serviceProvider.GetRequiredService<InvoiceForm>();
            invoiceForm.Show();
            this.Close();

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
    }
}
