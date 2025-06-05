using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Business_Logic_Layer.Services;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.User_Interface_Layer.UIHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;




namespace Carvo.User_Interface_Layer
{
    public partial class VehicleDashboardForm : Form
    {
        private IVehicleService _vehicleService; //have a service to handle vehicle data
        private ICustomerService _customerService;
        public VehicleDashboardForm(IVehicleService vehicleService, ICustomerService customerService)
        {
            _vehicleService = vehicleService; // initialize the service
            _customerService = customerService; // initialize the customer service
            InitializeComponent();

            AddImage.Click += AddBtn_Click;
            UpdateImage.Click += UpdateBtn_Click;
            DeleteImage.Click += DeleteBtn_Click;

            this.Load += async (s, e) => await LoadDataVehicles(); // load vehicles when the form loads

        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string _PlateNumber = VehiclePlateTxt.Text;
                int _CustomerId = (int)CustomerComboBox.SelectedValue; // get the selected customer ID from the ComboBox
                string _Name = VehicleNameTxt.Text;
                string _Model = VehicleModelTxt.Text;
                if (string.IsNullOrWhiteSpace(VehicleNameTxt.Text) ||
                string.IsNullOrWhiteSpace(VehicleModelTxt.Text) ||
                string.IsNullOrWhiteSpace(VehiclePlateTxt.Text))
                {
                    MessageBox.Show("يرجى إدخال اسم المركبة والموديل ورقم اللوحة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidateVehicle(_Name, _PlateNumber, _Model))
                {
                    Vehicle addedVehicle = new Vehicle { PlateNumber = _PlateNumber, CustomerId = _CustomerId, Name = _Name, Model = _Model };
                    await _vehicleService.AddVehicleAsync(addedVehicle);
                    await LoadDataVehicles();
                }
                MessageBox.Show("تم إضافة السيارة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الإضافة: {ex.Message}");
            }

        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            string _Name = VehicleNameTxt.Text;
            string _Model = VehicleModelTxt.Text;
            string _PlateNumber = VehiclePlateTxt.Text;
            int _CustomerId = (int)CustomerComboBox.SelectedValue;

            if (ValidateVehicle(_Name, _PlateNumber, _Model))
            {

                if (VehiclesGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("من فضلك اختر السيارة التي تريد تعديلها.");
                    return;
                }


                var selectedRow = VehiclesGridView.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);


                Vehicle updatedVehicle = await _vehicleService.GetVehicleByIdAsync(id);


                updatedVehicle.Name = _Name;
                updatedVehicle.Model = _Model;
                updatedVehicle.PlateNumber = _PlateNumber;
                updatedVehicle.CustomerId = _CustomerId;


                await _vehicleService.UpdateVehicleAsync(updatedVehicle);
                await LoadDataVehicles();

                MessageBox.Show("تم تعديل بيانات السيارة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء التأكد من صحة البيانات المدخلة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (VehiclesGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("الرجاء اختيار سيارة للحذف.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = VehiclesGridView.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            var confirmResult = MessageBox.Show("هل أنت متأكد من حذف السيارة؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _vehicleService.DeleteVehicleAsync(id); // حذف من قاعدة البيانات
                    await LoadDataVehicles(); // تحديث البيانات

                    MessageBox.Show("تم حذف السيارة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void VehicleGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (VehiclesGridView.SelectedRows.Count > 0)
            {

                var selectedRow = VehiclesGridView.SelectedRows[0];
                string _Name = (string)selectedRow.Cells["Name"].Value;
                string _Model = (string)selectedRow.Cells["Model"].Value;
                string _platNumber = (string)selectedRow.Cells["PlateNumber"].Value;
                string _CustomerName = (string)selectedRow.Cells["CustomerName"].Value;

                VehicleNameTxt.Text = _Name; // set the text of the name textbox
                VehicleModelTxt.Text = _Model;
                VehiclePlateTxt.Text = _platNumber; // set the text of the plate number textbox
                CustomerComboBox.SelectedIndex = CustomerComboBox.FindStringExact(_CustomerName);

            }
        }

        private bool ValidateVehicle(string vehicleName, string VehiclePlate, string VehicleModel)
        {
            // simple validation for empty fields
            bool isValid = true;

            if (vehicleName.Length < 3 || string.IsNullOrWhiteSpace(vehicleName))
            {
                isValid = false;
                NameErrorLabel.Visible = true;
            }
            else
                NameErrorLabel.Visible = false;

            if (VehiclePlate.Length < 2 || string.IsNullOrWhiteSpace(VehiclePlate))
            {
                isValid = false;
                PlateErrorLabel.Visible = true;
            }
            else
                PlateErrorLabel.Visible = false;
            if (VehicleModel.Length < 2 || string.IsNullOrWhiteSpace(VehicleModel))
            {
                isValid = false;
                ModelErrorLabel.Visible = true;
            }
            else
                ModelErrorLabel.Visible = false;

            return isValid;
        }

        private async Task LoadDataVehicles()
        {
            try
            {
                var allVehicles = await _vehicleService.GetAllVehiclesAsync(); // get all vehicles
                var customers = await _customerService.GetAllCustomersAsync(); // get all customers

                var vehicles = allVehicles.Select(v => new
                {
                    Id = v.Id,
                    Name = v.Name,
                    Model = v.Model,
                    PlateNumber = v.PlateNumber,
                    CustomerName = customers.FirstOrDefault(c => c.Id == v.CustomerId)?.Name ?? "غير معروف"
                }).ToList();



                VehiclesGridView.DataSource = null;
                VehiclesGridView.DataSource = vehicles;


                CustomerComboBox.DataSource = customers.ToList();
                //SetupDataGridViewLayout();
                CustomerComboBox.DisplayMember = "Name";
                CustomerComboBox.ValueMember = "Id";
                VehiclesGridView.Columns["ID"].Visible = false;

                VehiclesGridView.Columns[4].HeaderText = "اسم العميل";
                VehiclesGridView.Columns[3].HeaderText = "رقم اللوحة";
                VehiclesGridView.Columns[2].HeaderText = "موديل المركبة ";
                VehiclesGridView.Columns[1].HeaderText = "اسم المركبة ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Win32 API - لتحريك الفورم يدويًا
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

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
