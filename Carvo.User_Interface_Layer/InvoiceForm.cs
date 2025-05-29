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
using Carvo.Data_Access_Layer.Entities;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;


namespace Carvo.User_Interface_Layer
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();


            /* Testing Grid View */
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 },
                new Product() { Id = 1, Description = "vdsfvdsv", Name = "vfdfv", Price = 2551 }
            };

            var GridView = products.Select(p => new { Name = p.Name, Description = p.Description, Price = p.Price }).ToList();

            ProductsServicesGrid.AllowUserToAddRows = false;
            ProductsServicesGrid.DataSource = GridView;

            ProductsServicesGrid.Columns[0].HeaderText = "الاسم";
            ProductsServicesGrid.Columns[1].HeaderText = "الوصف";
            ProductsServicesGrid.Columns[2].HeaderText = "سعر الوحدة";

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

    }
}
