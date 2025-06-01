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
    public partial class VehicleDashboardForm : Form
    {
        public VehicleDashboardForm()
        {
            InitializeComponent();
            HoverHelper.ApplyHoverToAllButtons(this); // Apply hover effects to all buttons in this form
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            UIHelper.SetupDataGridView(vehicleGrid);

            // apply rounded corners to the form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is Button)
                {
                    UIHelper.MakeControlRounded(ctrl, 16); // degree of rounding
                }
            }

            // dummy temporary data for testing
            vehicleGrid.Columns.Add("Id", "مسلسل");
            vehicleGrid.Columns.Add("Name", "اسم المركبة");
            vehicleGrid.Columns.Add("Model", "موديل المركبة");
            vehicleGrid.Columns.Add("PlateNumber", "رقم اللوحة");
            vehicleGrid.Columns.Add("CustomerName", "اسم العميل");

            vehicleGrid.Rows.Add(1, "لانسر", "بوما 2008", "2512", "احمد");
            vehicleGrid.Rows.Add(2, "تويوتا", "كورولا 2015", "1234", "محمد ");
            vehicleGrid.Rows.Add(3, "هوندا", "أكورد 2020", "5678", "محمود");
            vehicleGrid.Rows.Add(4, "فورد", "إكسبلورر 2019", "9101", "احمد");
            vehicleGrid.Rows.Add(5, "نيسان", "باترول 2021", "1122", "محمد");
            vehicleGrid.Rows.Add(6, "كيا", "سبورتاج 2018", "3344", "محمود");
            vehicleGrid.Rows.Add(7, "هيونداي", "سوناتا 2017", "5566", "احمد");
            vehicleGrid.Rows.Add(8, "شيفروليه", "ماليبو 2016", "7788", "محمد");
            vehicleGrid.Rows.Add(9, "مرسيدس", "E-Class 2022", "9900", "محمود");

            List<string> customers = new List<string>
            {
                "احمد",
                "محمد",
                "محمود"
            };
            customerCombo.DataSource = customers;

            // to icrease the height of the DataGridView to fit all rows
            vehicleGrid.Height = vehicleGrid.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                                  + vehicleGrid.ColumnHeadersHeight;

            // to set the form height to fit the DataGridView and add some padding
            this.Height = vehicleGrid.Bottom + 50; // empty space at the bottom


        }


        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
