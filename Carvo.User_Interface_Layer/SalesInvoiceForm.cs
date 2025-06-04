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

        private void SetupDataGridViewLayout()
        {
            int horizontalPadding = 30;

            SalesInvoiceGridView1.Left = horizontalPadding;
            SalesInvoiceGridView1.Width = this.ClientSize.Width - (horizontalPadding * 2);

            SalesInvoiceGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesInvoiceGridView1.AllowUserToAddRows = false;
            SalesInvoiceGridView1.AllowUserToResizeRows = false;
            SalesInvoiceGridView1.ReadOnly = true;
            SalesInvoiceGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalesInvoiceGridView1.MultiSelect = false;
            SalesInvoiceGridView1.ScrollBars = ScrollBars.Vertical;

            SalesInvoiceGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 67, 87);
            SalesInvoiceGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SalesInvoiceGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            SalesInvoiceGridView1.EnableHeadersVisualStyles = false;

            SalesInvoiceGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);
            SalesInvoiceGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(80, 90, 110);
            SalesInvoiceGridView1.DefaultCellStyle.BackColor = Color.FromArgb(196, 196, 223);
            SalesInvoiceGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(106, 90, 205);
            SalesInvoiceGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            SalesInvoiceGridView1.GridColor = Color.LightGray;
            SalesInvoiceGridView1.RowHeadersVisible = false;

            // Set Height dynamically based on rows
            SalesInvoiceGridView1.Height = SalesInvoiceGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                                     + SalesInvoiceGridView1.ColumnHeadersHeight + 2;
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

        private void FormatGrid()
        {
            // Set text direction to Right-to-Left for Arabic display
            SalesInvoiceGridView1.RightToLeft = RightToLeft.Yes;

            // Clear existing columns
            SalesInvoiceGridView1.Columns.Clear();

            // Add columns with Arabic headers for display

            SalesInvoiceGridView1.Columns.Add("buyer", "المشتري");
            SalesInvoiceGridView1.Columns.Add("productName", "اسم المنتج");
            SalesInvoiceGridView1.Columns.Add("quantity", "الكمية");
            SalesInvoiceGridView1.Columns.Add("price", "السعر");
            SalesInvoiceGridView1.Columns.Add("productId", "رقم المنتج");

            // Center-align headers and cell content
            foreach (DataGridViewColumn column in SalesInvoiceGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Row coloring
            SalesInvoiceGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            SalesInvoiceGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;

            // Selection styling
            SalesInvoiceGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            SalesInvoiceGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Font styling
            SalesInvoiceGridView1.DefaultCellStyle.Font = new Font("Tahoma", 10);
            SalesInvoiceGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            // Example Arabic data (you can remove this when using real data)
            SalesInvoiceGridView1.Rows.Add("١٠١", "حاسوب محمول", "أحمد محمد", "٢", "٣٥٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠٢", "هاتف ذكي", "منى خالد", "١", "١٨٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠", "حاسوب محمول", "أحمد محمد", "٢", "٣٥٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠٢", "لاب توب", "لولو خالد", "١", "١٨٠٠");
            SalesInvoiceGridView1.Rows.Add("١١", "حاسوب محمول", "رؤى محمد", "٢", "٣٥٠٠");
            SalesInvoiceGridView1.Rows.Add("١٢", "هاتف ذكي", "هدى خالد", "١", "١٨٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠١", "حاسوب محمول", "أحمد محمد", "٢", "٣٥٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠٢", "هاتف ذكي", "منى خالد", "١", "١٨٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠١", "حاسوب محمول", "أحمد محمد", "٢", "٣٥٠٠");
            SalesInvoiceGridView1.Rows.Add("١٠٢", "هاتف ذكي", "منى خالد", "١", "١٨٠٠");

            // Auto sizing and styling
            SalesInvoiceGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesInvoiceGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }


        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SalesInvoiceForm_Shown(object sender, EventArgs e)
        {
            SetupDataGridViewLayout();
        }
    }

}
