using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminInvoicesForm : Form
    {
        private IInvoiceService _invoiceService;
        private IUserService _userService;
        private ICustomerService _customerService;
        private BindingList<DisplayedInvoice> _invoicesBindingList;
        private IServiceProvider _serviceProvider;

        private IEnumerable<Invoice> invoices;
        private List<DisplayedInvoice> displayedInvoices = new List<DisplayedInvoice>();

        public AdminInvoicesForm(IServiceProvider serviceProvider, IInvoiceService invoiceService, IUserService userService, ICustomerService customerService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _customerService = customerService;
            _userService = userService;
            _serviceProvider = serviceProvider;

            // ✅ استخدم الحدث Load بدلاً من استدعاء مباشر
            this.Load += AdminInvoicesForm_Load;
        }

        // ✅ حدث تحميل الفورم
        private async void AdminInvoicesForm_Load(object? sender, EventArgs e)
        {
            await LoadInvoicesAsync();
        }

        // ✅ أصبح Task وليس void
        private async Task LoadInvoicesAsync()
        {
            try
            {
                invoices = await _invoiceService.GetAllInvoicesAsync();
                var users = await _userService.GetAllUsersAsync();
                var customers = await _customerService.GetAllCustomersAsync();

                InvoicesGridView.AllowUserToAddRows = false;



                foreach (var invoice in invoices)
                {
                    string customerName = customers.FirstOrDefault(c => c.Id == invoice.CustomerId).Name;
                    string employeeName = users.FirstOrDefault(u => u.Id == invoice.UserId).UserName;

                    displayedInvoices.Add(new DisplayedInvoice
                    {
                        InvoiceId = invoice.Id,
                        InvoiceNumer = invoice.InvoiceNumber,
                        InvoiceType = invoice.InvoiceType,
                        InvoicePrice = invoice.RepairAmount + invoice.SaleAmount,
                        InvoiceDate = invoice.InvoiceDate,
                        CustomerName = customerName,
                        EmployeeName = employeeName
                    });

                }
                _invoicesBindingList = new BindingList<DisplayedInvoice>(displayedInvoices);
                InvoicesGridView.DataSource = _invoicesBindingList;

                InvoicesGridView.Columns["InvoiceId"].Visible = false;
                InvoicesGridView.Columns[6].HeaderText = "رقم الفاتورة";
                InvoicesGridView.Columns[5].HeaderText = "نوع الفاتورة";
                InvoicesGridView.Columns[4].HeaderText = "السعر";
                InvoicesGridView.Columns[3].HeaderText = "العميل";
                InvoicesGridView.Columns[2].HeaderText = "الموظف";
                InvoicesGridView.Columns[1].HeaderText = "التاريخ";


                // إعادة تسمية الأعمدة (مع التأكد من وجود الأعمدة)
                //InvoicesGridView.Columns[nameof(Invoice.Id)].HeaderText = "رقم الفاتورة";
                //InvoicesGridView.Columns[nameof(Invoice.InvoiceNumber)].HeaderText = "رقم الفاتورة الخارجي";
                //InvoicesGridView.Columns[nameof(Invoice.InvoiceType)].HeaderText = "نوع الفاتورة";
                //InvoicesGridView.Columns[nameof(Invoice.SaleAmount)].HeaderText = "قيمة البيع";
                //InvoicesGridView.Columns[nameof(Invoice.RepairAmount)].HeaderText = "قيمة الصيانة";
                //InvoicesGridView.Columns[nameof(Invoice.InvoiceDate)].HeaderText = "تاريخ الفاتورة";
                //InvoicesGridView.Columns[nameof(Invoice.CustomerId)].HeaderText = "رقم العميل";
                //InvoicesGridView.Columns[nameof(Invoice.UserId)].HeaderText = "رقم الموظف";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الفواتير: {ex.Message}");
            }
        }

        private async void DeleteInvoice_Click(object sender, EventArgs e)
        {
            if (InvoicesGridView.CurrentRow != null)
            {
                var selectedDisplayedInvoice = (DisplayedInvoice)InvoicesGridView.CurrentRow.DataBoundItem;
                Invoice selectedInvoice = invoices.FirstOrDefault(i => i.Id == selectedDisplayedInvoice.InvoiceId);

                var confirm = MessageBox.Show($"هل أنت متأكد من حذف الفاتورة رقم {selectedInvoice.Id}؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool deleted = await _invoiceService.DeleteInvoiceAsync(selectedInvoice.Id);
                    if (deleted)
                    {
                        _invoicesBindingList.Remove(selectedDisplayedInvoice);
                        DeleteAlertForm deleteAlert = _serviceProvider.GetRequiredService<DeleteAlertForm>();
                        deleteAlert.ShowDialog();
                        //displayedInvoices.Remove(selectedDisplayedInvoice);
                    }
                    else
                    {
                        MessageBox.Show("فشل في حذف الفاتورة.");
                    }
                }
            }
        }

        private async void DeleteAllInvoices_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("هل أنت متأكد من حذف جميع الفواتير؟", "تأكيد الحذف الكلي", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                displayedInvoices = new List<DisplayedInvoice>();
                _invoicesBindingList = new BindingList<DisplayedInvoice>(displayedInvoices);
                InvoicesGridView.DataSource = _invoicesBindingList;

                DeleteAlertForm deleteAlert = _serviceProvider.GetRequiredService<DeleteAlertForm>();
                deleteAlert.ShowDialog();

                foreach (var invoice in invoices)
                {
                    await _invoiceService.DeleteInvoiceAsync(invoice.Id);
                }
                
            }
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

        private void PrevImgBtn_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = _serviceProvider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }

        private void LogoutImageAsBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }
    }


    public class DisplayedInvoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumer {  get; set; }
        public InvoiceType InvoiceType { get; set; }
        public decimal InvoicePrice { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName {  get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
