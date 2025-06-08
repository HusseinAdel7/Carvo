﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Data_Access_Layer.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminVehiclesForm : Form
    {
        private IServiceProvider _serviceProvider;
        public AdminVehiclesForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            /* Testing Grid View */
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },

            };

            var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

            VehiclesGridView.AllowUserToAddRows = false;
            VehiclesGridView.DataSource = GridView;

            VehiclesGridView.Columns[0].HeaderText = "الاسم";
            VehiclesGridView.Columns[1].HeaderText = "الوصف";
            VehiclesGridView.Columns[2].HeaderText = "سعر الوحدة";
            _serviceProvider = serviceProvider;
        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = VehiclesGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in VehiclesGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            VehiclesGridView.Height = totalHeight + 2; // 2px padding
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void PrevImageAsBtn_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = _serviceProvider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }
    }
}
