using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class HomeDashboardForm : Form
    {

        private readonly IServiceProvider _serviceProvider;


        public HomeDashboardForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            InitializeComponent();
            this.Load += async (s, e) =>  LoadHomeDashboard();
            RegisterControlEvents();
        }

        private void LoadHomeDashboard()
        {
            welcomemsgLabel.Text = $"{LoggedUser.loggedUserName} مرحبا بك ";
        }

        private void RegisterControlEvents()
        {

            btnSuppliers.Click += OpenSuppliersForm;
            picSuppliers.Click += OpenSuppliersForm;


            btnProducts.Click += OpenProductsForm;
            picProducts.Click += OpenProductsForm;


            btnCategories.Click += OpenCategoriesForm;
            picCategories.Click += OpenCategoriesForm;


            btnUsers.Click += OpenUsersForm;
            picUsers.Click += OpenUsersForm;


            btnCustomers.Click += OpenCustomersForm;
            picCustomers.Click += OpenCustomersForm;


            btnVehicles.Click += OpenVehiclesForm;
            picVehicles.Click += OpenVehiclesForm;


            btnreports.Click += OpenDashboardForm;
            picreports.Click += OpenDashboardForm;

        }


        private void OpenSuppliersForm(object? sender, EventArgs e) => ShowChildForm<AdminSuppliersForm>();
        private void OpenProductsForm(object? sender, EventArgs e) => ShowChildForm<AdminProductsForm>();
        private void OpenCategoriesForm(object? sender, EventArgs e) => ShowChildForm<AdminCategoriesForm>();
        private void OpenUsersForm(object? sender, EventArgs e) => ShowChildForm<AdminEmployeesForm>();
        private void OpenCustomersForm(object? sender, EventArgs e) => ShowChildForm<AdminCustomersForm>();
        private void OpenVehiclesForm(object? sender, EventArgs e) => ShowChildForm<VehicleDashboardForm>();
        private void OpenDashboardForm(object? sender, EventArgs e) => ShowChildForm<DashboardForm>();

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           // this buton for close form
           Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // this buton for Minimize form
            this.WindowState = FormWindowState.Minimized;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this picture for go to Admin Dashboard Form
            ShowChildForm<MainWindowFrom>();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ShowChildForm<TForm>() where TForm : Form
        {
            var form = _serviceProvider.GetRequiredService<TForm>();
            form.ShowDialog(this);
        }
    }
}
