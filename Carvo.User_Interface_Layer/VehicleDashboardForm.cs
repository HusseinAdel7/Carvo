using System.Data;
using System.Runtime.InteropServices;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;
using Microsoft.Extensions.DependencyInjection;


namespace Carvo.User_Interface_Layer
{
    public partial class VehicleDashboardForm : Form
    {
        private IVehicleService _vehicleService; //have a service to handle vehicle data
        private ICustomerService _customerService;
        private IServiceProvider _serviceProvider;

        private IEnumerable<Customer> customers;
        public VehicleDashboardForm(IServiceProvider serviceProvider, IVehicleService vehicleService, ICustomerService customerService)
        {
            _serviceProvider = serviceProvider;
            _vehicleService = vehicleService; // initialize the service
            _customerService = customerService; // initialize the customer service
            InitializeComponent();

            AddImage.Click += AddBtn_Click;
            UpdateImage.Click += UpdateBtn_Click;
            DeleteImage.Click += DeleteBtn_Click;
            this.Paint += Form1_Paint;

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

                AddAlertForm addAlert = _serviceProvider.GetRequiredService<AddAlertForm>();
                addAlert.ShowDialog();
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

                UpdateAlertForm updateAlert = _serviceProvider.GetRequiredService<UpdateAlertForm>();
                updateAlert.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء التأكد من صحة البيانات المدخلة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    DeleteAlertForm deleteAlert = _serviceProvider.GetRequiredService<DeleteAlertForm>();
                    deleteAlert.ShowDialog();
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
                customers = await _customerService.GetAllCustomersAsync(); // get all customers

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

        private void CustomersFilterTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomersFilterTxt.Text))
                CustomerComboBox.DataSource = customers;
            else
            {
                List<Customer> filteredList = customers.Where(
                    s => s.Name.ToLower().Contains(CustomersFilterTxt.Text.ToLower())
                ).ToList();
                CustomerComboBox.DataSource = filteredList;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }

        private void PrevImageAsBtn_Click(object sender, EventArgs e)
        {
            if (LoggedUser.Role == Role.Admin)
            {
                HomeDashboardForm homeDashboardForm = _serviceProvider.GetRequiredService<HomeDashboardForm>();
                homeDashboardForm.Show();
            }
            else
            {
                EmployeeDashboardForm employeeDashboardForm = _serviceProvider.GetRequiredService<EmployeeDashboardForm>();
                employeeDashboardForm.Show();
            }
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CustomersFilterTxt.Text = string.Empty;
            VehicleModelTxt.Text = string.Empty;
            VehicleNameTxt.Text = string.Empty;
            VehiclePlateTxt.Text = string.Empty;
        }
    }
}
