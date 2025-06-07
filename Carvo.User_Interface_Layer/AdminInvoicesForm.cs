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
    public partial class AdminInvoicesForm : Form
    {
        public AdminInvoicesForm()
        {
            InitializeComponent();

            /* Testing Grid View */
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                //new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },

            };

            var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

            InvoicesGridView.AllowUserToAddRows = false;
            InvoicesGridView.DataSource = GridView;

            InvoicesGridView.Columns[0].HeaderText = "الاسم";
            InvoicesGridView.Columns[1].HeaderText = "الوصف";
            InvoicesGridView.Columns[2].HeaderText = "سعر الوحدة";

        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = InvoicesGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in InvoicesGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            InvoicesGridView.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeImgBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
