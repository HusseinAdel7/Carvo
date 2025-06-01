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


namespace Carvo.User_Interface_Layer
{
    public partial class SalesInvoiceForm : Form
    {
        public SalesInvoiceForm()
        {
            InitializeComponent();
        }
        // كود خاص بسحب الفورم بدون شريط عنوان
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void SalesInvoiceForm_Load(object sender, EventArgs e)
        {
            FormatGrid();

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormatGrid()
        {
            // Set text direction to Right-to-Left for Arabic display
            dataGridView1.RightToLeft = RightToLeft.Yes;

            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns with Arabic headers for display

            dataGridView1.Columns.Add("buyer", "المشتري");
            dataGridView1.Columns.Add("productName", "اسم المنتج");
            dataGridView1.Columns.Add("quantity", "الكمية");
            dataGridView1.Columns.Add("price", "السعر");
            dataGridView1.Columns.Add("productId", "رقم المنتج");

            // Center-align headers and cell content
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Row coloring
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Selection styling
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Font styling
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            // Example Arabic data (you can remove this when using real data)
            dataGridView1.Rows.Add("١٠١", "حاسوب محمول", "أحمد محمد", "٢", "٣٥٠٠");
            dataGridView1.Rows.Add("١٠٢", "هاتف ذكي", "منى خالد", "١", "١٨٠٠");

            // Auto sizing and styling
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
