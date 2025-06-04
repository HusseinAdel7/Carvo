using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities.Users;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminCustomersForm : Form
    {
        private readonly ICustomerService _customerService;

        public AdminCustomersForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadCustomersAsync();
        }
      //  الداله الصح
        private async Task LoadCustomersAsync()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.DataSource = customers.ToList();

            if (dgvCustomers.Columns.Contains("Name"))
                dgvCustomers.Columns["Name"].HeaderText = "الاسم";
            if (dgvCustomers.Columns.Contains("PhoneNumber"))
                dgvCustomers.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
            //if (dgvCustomers.Columns.Contains("NationalId"))
            //dgvCustomers.Columns["NationalId"].HeaderText = "الرقم القومي";
        }


//        private async Task LoadCustomersAsync()
//{
//    var customers = await _customerService.GetAllCustomersAsync();

//    dgvCustomers.AllowUserToAddRows = false;
//    dgvCustomers.AutoGenerateColumns = false;
//    dgvCustomers.Columns.Clear();

//    // Id (Hidden)
//    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
//    {
//        DataPropertyName = "Id",
//        Name = "Id",
//        Visible = false // نخفيه
//    });

//    // Name
//    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
//    {
//        DataPropertyName = "Name",
//        HeaderText = "الاسم",
//        Name = "Name"
//    });

//    // Phone Number
//    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
//    {
//        DataPropertyName = "PhoneNumber",
//        HeaderText = "رقم الهاتف",
//        Name = "PhoneNumber"
//    });

//    // National ID
//    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
//    {
//        DataPropertyName = "NationalId",
//        HeaderText = "الرقم القومي",
//        Name = "NationalId"
//    });

//    dgvCustomers.DataSource = customers.ToList();
//}



        //
        //private async Task LoadCustomersAsync()
        //{
        //    var customers = await _customerService.GetAllCustomersAsync();

        //    dgvCustomers.AllowUserToAddRows = false;
        //    dgvCustomers.AutoGenerateColumns = false;
        //    dgvCustomers.Columns.Clear();

        //    // Id (Hidden)
        //    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Id",
        //        Name = "Id",
        //        Visible = false
        //    });

        //    // Name
        //    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Name",
        //        HeaderText = "الاسم",
        //        Name = "Name"
        //    });

        //    // Phone Number
        //    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "PhoneNumber",
        //        HeaderText = "رقم الهاتف",
        //        Name = "PhoneNumber"
        //    });

        //    // CreatedAt
        //    dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "CreatedAt",
        //        HeaderText = "تاريخ الإضافة",
        //        Name = "CreatedAt"
        //    });

        //    dgvCustomers.DataSource = customers.ToList();
        //}







        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow != null && dgvCustomers.CurrentRow.Index >= 0)
            {
                txtCustomerName.Text = dgvCustomers.CurrentRow.Cells["Name"].Value?.ToString();
                txtPhoneNumber.Text = dgvCustomers.CurrentRow.Cells["PhoneNumber"].Value?.ToString();
                //txtNationalId.Text = dgvCustomers.CurrentRow.Cells["NationalId"].Value?.ToString();
            }
        }


        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var customer = new Customer
            {
                Name = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                //NationalId = txtNationalId.Text
            };

            await _customerService.AddCustomerAsync(customer);
            LoadCustomersAsync();
            ClearInputs();
        }

        private async void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null || !ValidateInputs()) return;

            int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;

            var updatedCustomer = new Customer
            {
                Id = id,
                Name = txtCustomerName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                //NationalId = txtNationalId.Text
            };

            await _customerService.UpdateCustomerAsync(updatedCustomer);

            MessageBox.Show("تم تحديث بيانات العميل بنجاح ✅");

            await LoadCustomersAsync();
            ClearInputs();
        }


        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            int id = (int)dgvCustomers.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show("هل أنت متأكد من حذف العميل؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                await _customerService.DeleteCustomerAsync(id);

                MessageBox.Show("تم حذف العميل بنجاح ✅");

                await LoadCustomersAsync();
                ClearInputs();
            }
        }


        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم العميل.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف.");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtNationalId.Clear();
        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = dgvCustomers.ColumnHeadersHeight;

            foreach (DataGridViewRow row in dgvCustomers.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            dgvCustomers.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeFormBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     
        



    }
}
