using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class EmployeeDashboardForm : Form
    {
        private IServiceProvider serviceProvider;

        public EmployeeDashboardForm(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
            InitializeComponent();
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManageVehiclesBtn_Click(object sender, EventArgs e)
        {
            VehicleDashboardForm vehiclesForm = serviceProvider.GetRequiredService<VehicleDashboardForm>();
            this.Hide();
            vehiclesForm.ShowDialog();
            this.Show();
        }

        private void ManageCustomersBtn_Click(object sender, EventArgs e)
        {
            AdminCustomersForm customersForm = serviceProvider.GetRequiredService<AdminCustomersForm>();
            this.Hide();
            customersForm.ShowDialog();
            this.Show();
        }

        private void ManageInvoicesBtn_Click(object sender, EventArgs e)
        {
            InvoiceTypeForm invoiceTypeForm = serviceProvider.GetRequiredService<InvoiceTypeForm>();
            this.Hide();
            invoiceTypeForm.ShowDialog();
            this.Show();
        }
    }
}
