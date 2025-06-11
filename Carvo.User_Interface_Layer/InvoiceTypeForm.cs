using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.User_Interface_Layer;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Carvo.User_Interface_Layer
{
    public partial class InvoiceTypeForm : Form
    {
        // This field is used to store the service provider for dependency injection
        private IServiceProvider _serviceProvider;

        public InvoiceTypeForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            SalesImage.Click += SalesBtn_Click;
            RepairImage.Click += RepairBtn_Click;
            this.Paint += Form1_Paint;
        }




        /// <summary>
        ///  يقوم بفتح SalesInvoiceForm عند الضغط عليه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesBtn_Click(object sender, EventArgs e)
        {
            var salesInvoiceForm = _serviceProvider.GetService(typeof(SalesInvoiceForm)) as SalesInvoiceForm;
            salesInvoiceForm.Show();
            this.Hide();
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
        /// <summary>
        /// Handles the click event for the Repair button.
        /// </summary>
        /// <remarks>This method displays the <see cref="RepairInvoiceForm"/> and hides the current
        /// form.</remarks>
        /// <param name="sender">The source of the event, typically the Repair button.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void RepairBtn_Click(object sender, EventArgs e)
        {
            var repairInvoiceForm = _serviceProvider.GetService(typeof(RepairInvoiceForm)) as RepairInvoiceForm;
            repairInvoiceForm.Show();
            this.Hide();
        }

        private void RepairImage_Click(object sender, EventArgs e)
        {

        }

        private void SalesImage_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Handles the click event for the PrevFormBtn button.
        /// Navigates the user back to the Employee Dashboard form.
        /// </summary>
        /// <param name="sender">The source of the event (Back button).</param>
        /// <param name="e">Event data for the click event.</param>
        private void PrevFormBtn_Click(object sender, EventArgs e)

        {
            var EmployeeForm = _serviceProvider.GetService(typeof(EmployeeDashboardForm)) as EmployeeDashboardForm;
            EmployeeForm.Show();
            this.Close();
        }
        /// <summary>
        /// Handles the click event for the Logout button.
        /// Logs the user out and navigates to the main window form.
        /// </summary>
        /// <param name="sender">The source of the event (Logout button).</param>
        /// <param name="e">Event data for the click event.</param>
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
