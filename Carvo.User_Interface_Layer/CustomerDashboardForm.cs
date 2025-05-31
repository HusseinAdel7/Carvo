using Carvo.User_Interface_Layer.UIHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carvo.User_Interface_Layer
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();
            HoverHelper.ApplyHoverToAllButtons(this); // Apply hover effects to all buttons in this form
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetupDataGridView(customerGrid);

            // apply rounded corners to the form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is Button)
                {
                    UIHelper.MakeControlRounded(ctrl, 16); // degree of rounding
                }
            }

            // dummy temporary data for testing
            customerGrid.Columns.Add("Id", "مسلسل");
            customerGrid.Columns.Add("Name", "الاسم");
            customerGrid.Columns.Add("Phone", "الهاتف");
            customerGrid.Columns.Add("Address", "العنوان");
            customerGrid.Columns.Add("NationalID", "الرقم القومي");

            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");
            customerGrid.Rows.Add(2, "محمود", "01012345678", "المنيا", "29901162404756");
            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");

            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");
            customerGrid.Rows.Add(2, "محمود", "01012345678", "المنيا", "29901162404756");
            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756"); customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");
            customerGrid.Rows.Add(2, "محمود", "01012345678", "المنيا", "29901162404756");
            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756"); customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");
            customerGrid.Rows.Add(2, "محمود", "01012345678", "المنيا", "29901162404756");
            customerGrid.Rows.Add(1, "احمد", "01012345678", "القاهرة", "29901162404756");

            // to icrease the height of the DataGridView to fit all rows
            customerGrid.Height = customerGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                                  + customerGrid.ColumnHeadersHeight;

            // to set the form height to fit the DataGridView and add some padding
            this.Height = customerGrid.Bottom + 50; // empty space at the bottom


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
