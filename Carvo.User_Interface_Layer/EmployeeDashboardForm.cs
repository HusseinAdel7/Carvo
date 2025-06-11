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
            this.Load += async (s, e) => LoadEmployeeDashboard();
            this.Paint += Form1_Paint;
        }


        private void LoadEmployeeDashboard()
        {
            WelcomeMsgLabel.Text = $"{LoggedUser.loggedUserName} مرحبا بك ";
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManageVehiclesBtn_Click(object sender, EventArgs e)
        {
            VehicleDashboardForm vehiclesForm = serviceProvider.GetRequiredService<VehicleDashboardForm>();
            vehiclesForm.Show();
            this.Close();
        }

        private void ManageCustomersBtn_Click(object sender, EventArgs e)
        {
            AdminCustomersForm customersForm = serviceProvider.GetRequiredService<AdminCustomersForm>();
            customersForm.Show();
            this.Close();
        }

        private void ManageInvoicesBtn_Click(object sender, EventArgs e)
        {
            InvoiceTypeForm invoiceTypeForm = serviceProvider.GetRequiredService<InvoiceTypeForm>();
            invoiceTypeForm.Show();
            this.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

    }
}
