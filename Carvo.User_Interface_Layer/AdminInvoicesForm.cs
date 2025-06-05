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

namespace Carvo.User_Interface_Layer
{
    public partial class AdminInvoicesForm : Form
    {
        private readonly IInvoiceService _invoiceService;
        private BindingList<Invoice> _invoicesBindingList;

        public AdminInvoicesForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;

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
                var invoices = await _invoiceService.GetAllInvoicesAsync();
                _invoicesBindingList = new BindingList<Invoice>(invoices.ToList());

                InvoicesGridView.AllowUserToAddRows = false;
                InvoicesGridView.DataSource = _invoicesBindingList;

                // إعادة تسمية الأعمدة (مع التأكد من وجود الأعمدة)
                InvoicesGridView.Columns[nameof(Invoice.Id)].HeaderText = "رقم الفاتورة";
                InvoicesGridView.Columns[nameof(Invoice.InvoiceNumber)].HeaderText = "رقم الفاتورة الخارجي";
                InvoicesGridView.Columns[nameof(Invoice.InvoiceType)].HeaderText = "نوع الفاتورة";
                InvoicesGridView.Columns[nameof(Invoice.SaleAmount)].HeaderText = "قيمة البيع";
                InvoicesGridView.Columns[nameof(Invoice.RepairAmount)].HeaderText = "قيمة الصيانة";
                InvoicesGridView.Columns[nameof(Invoice.InvoiceDate)].HeaderText = "تاريخ الفاتورة";
                InvoicesGridView.Columns[nameof(Invoice.CustomerId)].HeaderText = "رقم العميل";
                InvoicesGridView.Columns[nameof(Invoice.UserId)].HeaderText = "رقم الموظف";
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
                var selectedInvoice = (Invoice)InvoicesGridView.CurrentRow.DataBoundItem;

                var confirm = MessageBox.Show($"هل أنت متأكد من حذف الفاتورة رقم {selectedInvoice.Id}؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool deleted = await _invoiceService.DeleteInvoiceAsync(selectedInvoice.Id);
                    if (deleted)
                    {
                        _invoicesBindingList.Remove(selectedInvoice);
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
                foreach (var invoice in _invoicesBindingList.ToList())
                {
                    await _invoiceService.DeleteInvoiceAsync(invoice.Id);
                    _invoicesBindingList.Remove(invoice);
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
            this.Close();
        }

        private void MinimizeImgBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
