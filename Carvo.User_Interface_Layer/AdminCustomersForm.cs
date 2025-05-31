using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Data_Access_Layer.Entities;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminCustomersForm : Form
    {
        public AdminCustomersForm()
        {
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

            CustomersGridView.AllowUserToAddRows = false;
            CustomersGridView.DataSource = GridView;

            CustomersGridView.Columns[0].HeaderText = "الاسم";
            CustomersGridView.Columns[1].HeaderText = "الوصف";
            CustomersGridView.Columns[2].HeaderText = "سعر الوحدة";

        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = CustomersGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in CustomersGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            CustomersGridView.Height = totalHeight + 2; // 2px padding
        }
    }
}
