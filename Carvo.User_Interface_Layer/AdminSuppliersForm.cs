using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminSuppliersForm : Form
    {
        private ISupplierService _supplierService;
        private IServiceProvider _serviceProvider;

        public AdminSuppliersForm(ISupplierService supplierService, IServiceProvider serviceProvider)
        {
            _supplierService = supplierService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Load += async (s, e) => await LoadSuppliersAsync();
        }
        private async Task LoadSuppliersAsync()
        {
            var allSuppliers = await _supplierService.GetAllSuppliersAsync();

            var suppliers = allSuppliers.Select(c => new
            {
                ID = c.Id,
                RemainingBalance = c.RemainingBalance,
                CompanyFollowed = c.ComapayName,
                PhoneNumber = c.PhoneNumber,
                Address = c.Address,
                Name = c.Name
            }).ToList();

            SuppliersGridView.DataSource = null;
            SuppliersGridView.DataSource = suppliers;

            SuppliersGridView.Columns["ID"].Visible = false;
            SuppliersGridView.Columns[1].HeaderText = "المبلغ المتبقي";
            SuppliersGridView.Columns[2].HeaderText = "الشركة التابع لها";
            SuppliersGridView.Columns[3].HeaderText = "رقم الهاتف";
            SuppliersGridView.Columns[4].HeaderText = "العنوان";
            SuppliersGridView.Columns[5].HeaderText = "الاسم";
        }

        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = SuppliersGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in SuppliersGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            SuppliersGridView.Height = totalHeight + 2; // 2px padding
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            string supplierName = SupplierNameTxt.Text;
            string supplierAddress = SupplierAddressTxt.Text;
            string supplierPhone = SupplierPhoneTxt.Text;
            string supplierCompanyFollowed = SupplierCompanyFollowedTxt.Text;
            // string supplierRemainingBalance = SupplierRemainigBalanceTxt.Text;

            FillAllFields(supplierName, supplierAddress, supplierPhone, supplierCompanyFollowed);
            if (ValidateSupplier(supplierName, supplierAddress, supplierPhone, supplierCompanyFollowed, out var errors))
            {
                Supplier newSupplier = new Supplier
                {
                    Name = supplierName,
                    Address = supplierAddress,
                    PhoneNumber = supplierPhone,
                    ComapayName = supplierCompanyFollowed,
                    // RemainingBalance = double.Parse(supplierRemainingBalance)
                };

                AddAlertForm addAlert = _serviceProvider.GetRequiredService<AddAlertForm>();
                addAlert.ShowDialog();

                await _supplierService.AddSupplierAsync(newSupplier);
                await LoadSuppliersAsync();
            }
            else
            {
                string errorMessage = "من فضلك اتبع التالي:\n\n" + string.Join("\n", errors);
                MessageBox.Show(errorMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void UpdateSupplierBtn_Click(object sender, EventArgs e)
        {
            string supplierName = SupplierNameTxt.Text;
            string supplierAddress = SupplierAddressTxt.Text;
            string supplierPhone = SupplierPhoneTxt.Text;
            string supplierCompanyFollowed = SupplierCompanyFollowedTxt.Text;
            // string supplierRemainingBalance = SupplierRemainigBalanceTxt.Text;

            FillAllFields(supplierName, supplierAddress, supplierPhone, supplierCompanyFollowed);

            if (ValidateSupplier(supplierName, supplierAddress, supplierPhone, supplierCompanyFollowed, out var errors))
            {
                try
                {
                    if (SuppliersGridView.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("يرجى تحديد مورد للتعديل عليه.", "لم يتم تحديد مورد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var selectedRow = SuppliersGridView.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    Supplier supplier = await _supplierService.GetSupplierByIdAsync(id);

                    if (supplier == null)
                    {
                        MessageBox.Show("لم يتم العثور على المورد المحدد.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update properties
                    supplier.Name = supplierName;
                    supplier.Address = supplierAddress;
                    supplier.PhoneNumber = supplierPhone;
                    supplier.ComapayName = supplierCompanyFollowed;
                    // supplier.RemainingBalance = double.Parse(supplierRemainingBalance);

                    UpdateAlertForm updateAlert = _serviceProvider.GetRequiredService<UpdateAlertForm>();
                    updateAlert.ShowDialog();

                    await _supplierService.UpdateSupplierAsync(supplier);
                    await LoadSuppliersAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء تحديث المورد:\n" + ex.Message, "فشل التحديث", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string errorMessage = "يرجى تصحيح الأخطاء التالية:\n\n" + string.Join("\n", errors);
                MessageBox.Show(errorMessage, "فشل التحقق", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void DeleteSupplierBtn_Click(object sender, EventArgs e)
        {



            try
            {
                if (SuppliersGridView.SelectedRows.Count > 0)
                {
                    var selectedRow = SuppliersGridView.SelectedRows[0];
                    int supplierId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                    await _supplierService.DeleteSupplierAsync(supplierId);
                    await LoadSuppliersAsync();

                    DeleteAlertForm deleteAlert = _serviceProvider.GetRequiredService<DeleteAlertForm>();
                    deleteAlert.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حذف المورد:\n" + ex.Message,
                                "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SuppliersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (SuppliersGridView.SelectedRows.Count > 0)
            {
                var selectedRow = SuppliersGridView.SelectedRows[0];
                SupplierNameTxt.Text = selectedRow.Cells["Name"].Value.ToString();
                SupplierAddressTxt.Text = selectedRow.Cells["Address"].Value.ToString();
                SupplierPhoneTxt.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                SupplierCompanyFollowedTxt.Text = selectedRow.Cells["CompanyFollowed"].Value.ToString();
                // SupplierRemainigBalanceTxt.Text = selectedRow.Cells["RemainingBalance"].Value.ToString();
            }
            else
            {
                SupplierNameTxt.Clear();
                SupplierAddressTxt.Clear();
                SupplierPhoneTxt.Clear();
                SupplierCompanyFollowedTxt.Clear();
                //SupplierRemainigBalanceTxt.Clear();

            }
        }
        private bool ValidateSupplier(string name, string address, string phone, string company, out List<string> errors)
        {
            errors = new List<string>();

            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
                errors.Add("الأسم يجب ان يكون اكثر من ثلاث حروف.");

            if (string.IsNullOrWhiteSpace(address) || address.Length < 5)
                errors.Add("العنوان يجب ان يكون اكثر من خمس حروف.");

            if (string.IsNullOrWhiteSpace(phone) || phone.Length == 10 || !phone.All(char.IsDigit))
                errors.Add(" يجب ان يكون رقم التليفون 11 رقم.ولا يزجد به حروف");

            if (string.IsNullOrWhiteSpace(company))
                errors.Add("يجب ادخال اسم الشركة.");


            return errors.Count == 0;
        }

        private void FillAllFields(string name, string address, string phone, string company)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(company))
            {
                AlertIncompleteInformationForm alertForm = new AlertIncompleteInformationForm();
                alertForm.ShowDialog();
                return;

            }
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void PrevImageAsBtn_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = _serviceProvider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }
    }
}
