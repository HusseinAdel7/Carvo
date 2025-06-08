using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Carvo.User_Interface_Layer
{
    public partial class AdminEmployeesForm : Form
    {
        // Services for user management and dependency injection
        IUserService userService;
        IServiceProvider provider;
        bool isInitialLoad = true; // Flag to avoid triggering selection changed logic during initial load

        public AdminEmployeesForm(IUserService _userService, IServiceProvider _provider)
        {
            InitializeComponent();
            userService = _userService;
            provider = _provider;

            // Events setup for form load and input validation
            this.Load += async (s, e) => await LoadUsersAsync();
            UserNameTxt.Leave += (s, e) => ValidateUserName();
            UserEmailTxt.Leave += (s, e) => ValidateEmail();
            UserpassTxt.Leave += (s, e) => ValidatePassword();

            // Load role options in Arabic for the dropdown
            var roles = Enum.GetValues(typeof(Role))
                            .Cast<Role>()
                            .Select(r => new
                            {
                                label = MakeRoleLabelsArabic(r),
                                value = r
                            }).ToList();

            UserRoleDropdownList.DisplayMember = "label";
            UserRoleDropdownList.ValueMember = "value";
            UserRoleDropdownList.DataSource = roles;

            // Disable adding rows manually in DataGridView
            UsersGridView.AllowUserToAddRows = false;
        }

        // Resize DataGridView height based on its content
        private void InvoicesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeDataGridViewHeight();
        }

        private void ResizeDataGridViewHeight()
        {
            int totalHeight = UsersGridView.ColumnHeadersHeight;

            foreach (DataGridViewRow row in UsersGridView.Rows)
            {
                if (row.Visible) totalHeight += row.Height;
            }

            UsersGridView.Height = totalHeight + 2; // 2px padding
        }

        // Close button event handler
        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize button event handler
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Load all users and bind to the DataGridView
        public async Task LoadUsersAsync()
        {
            var AllUsers = await userService.GetAllUsersAsync();
            var Users = AllUsers.Select(c => new
            {
                c.Id,
                c.Password,
                c.CreatedAt,
                Role = (c.Role == Role.Admin) ? "مدير" : "موظف",
                c.Email,
                الاسم = c.UserName,
            }).ToList();

            UsersGridView.DataSource = Users;
            UsersGridView.Columns["id"].Visible = false;
            UsersGridView.Columns["Password"].Visible = false;
            UsersGridView.Columns["CreatedAt"].Visible = false;
            UsersGridView.Columns[UsersGridView.ColumnCount - 2].HeaderText = "البريد الالكتروني";
            UsersGridView.Columns[UsersGridView.ColumnCount - 3].HeaderText = "المسئولية";
        }

        // Add new user button click handler
        private async void AddUserBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxt.Text;
            string email = UserEmailTxt.Text;
            string password = UserpassTxt.Text;
            Role selectedRole = (Role)UserRoleDropdownList.SelectedIndex;
            Role role = (selectedRole == Role.None) ? Role.Employee : selectedRole;


            if (ValidateUserName() && ValidatePassword() && ValidateEmail())
            {
                User newUser = new User()
                {
                    UserName = userName,
                    Email = email,
                    Password = password,
                    Role = role,
                    CreatedAt = DateTime.Now,
                };

                bool ExistedUser = await IsExist(userName, password);
                if (!ExistedUser)
                {
                    AddAlertForm addAlert = provider.GetRequiredService<AddAlertForm>();
                    addAlert.ShowDialog();

                    await userService.AddUserAsync(newUser);
                    await LoadUsersAsync();

                    // Clear input fields
                    UserNameTxt.Text = "";
                    UserEmailTxt.Text = "";
                    UserpassTxt.Text = "";
                    UserRoleDropdownList.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("هذا الحساب موجود بالفعل", "Existing Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Convert enum roles to Arabic labels
        public string MakeRoleLabelsArabic(Role role)
        {
            return role switch
            {
                Role.Admin => "مدير",
                Role.Employee => "موظف",
                Role.None => "غير محدد"
            };
        }

        // Validate user name using regex
        // Rules:
        // - Name must contain at least one word with 3 or more letters
        // - Each additional word (optional) must also have at least 3 letters
        // - Only Unicode letters are allowed (supports Arabic and other languages)
        // - Words are separated by single spaces
        public bool ValidateUserName()
        {
            string namePattern = @"^(\p{L}{3,})(\s\p{L}{3,})*$";
            if (!Regex.IsMatch(UserNameTxt.Text, namePattern))
            {
                userNameErrorLabel.Visible = true;
                return false;
            }
            else
            {
                userNameErrorLabel.Visible = false;
                return true;
            }
        }

        // Validate email using regex
        // Rules:
        // - Email must have text before and after '@'
        // - A domain and top-level domain (e.g., .com, .net) must exist
        // - No spaces are allowed
        public bool ValidateEmail()
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(UserEmailTxt.Text, emailPattern))
            {
                userEmailErrorLabel.Visible = true;
                return false;
            }
            else
            {
                userEmailErrorLabel.Visible = false;
                return true;
            }
        }

        // Validate password using regex
        // Rules:
        // - Password must be 4 to 30 characters long
        // - Allowed characters: a-z, A-Z, 0-9, and @ # $ % ^ & + = !
        // - No spaces allowed
        public bool ValidatePassword()
        {
            string passPattern = @"^[a-zA-Z0-9@#$%^&+=!]{4,30}$";
            if (!Regex.IsMatch(UserpassTxt.Text, passPattern))
            {
                userPassErrorLabel.Visible = true;
                return false;
            }
            else
            {
                userPassErrorLabel.Visible = false;
                return true;
            }
        }


        // Check if a user with the same name and password exists
        public async Task<bool> IsExist(string userName, string password)
        {
            var AllUsers = await userService.GetAllUsersAsync();
            bool ExistedUser = AllUsers.Any(u => u.UserName == userName && u.Password == password);
            return ExistedUser;
        }

        // Handle DataGridView selection change to populate input fields
        private void UsersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (isInitialLoad)
            {
                isInitialLoad = false;
                return;
            }

            if (UsersGridView.SelectedRows.Count > 0)
            {
                var selectedRow = UsersGridView.SelectedRows[0];
                UserNameTxt.Text = selectedRow.Cells["الاسم"].Value.ToString();
                UserEmailTxt.Text = selectedRow.Cells["Email"].Value.ToString();
                //UserpassTxt.Text = selectedRow.Cells["Password"].Value.ToString();
            }
        }

        // Update user data on button click
        private async void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            string userName = UserNameTxt.Text;
            string passWord = UserpassTxt.Text;
            string email = UserEmailTxt.Text;
            Role selectedRole = (Role)UserRoleDropdownList.SelectedIndex;
            Role role = (selectedRole == Role.None) ? Role.Employee : selectedRole;

            var selectedRow = UsersGridView.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            User selectedUser = await userService.GetUserByIdAsync(selectedID);

            if (ValidateUserName() && ValidatePassword() && ValidateEmail())
            {
                selectedUser.UserName = userName;
                selectedUser.Email = email;
                selectedUser.Password = passWord;
                selectedUser.Role = role;
                selectedUser.CreatedAt = DateTime.Now;

                UpdateAlertForm updateAlert = provider.GetRequiredService<UpdateAlertForm>();
                updateAlert.ShowDialog();

                await userService.UpdateUserAsync(selectedUser);
                await LoadUsersAsync();
            }
        }

        // Delete user on button click with confirmation
        private async void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (UsersGridView.SelectedRows.Count > 0)
            {
                var selectedRow = UsersGridView.SelectedRows[0];
                int selectedID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                DialogResult result = MessageBox.Show("هل تريد مسح هذا المستخدم", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await userService.DeleteUserAsync(selectedID);
                    await LoadUsersAsync();

                    DeleteAlertForm deleteAlert = new DeleteAlertForm();
                    deleteAlert.ShowDialog();
                }
            }        
        }

        // Navigate to home dashboard form
        private void PrevImageAsBtn_Click(object sender, EventArgs e)
        {
            HomeDashboardForm homeDashboardForm = provider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }

        // Logout and go back to main window
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.loggedUserId = 0;
            LoggedUser.loggedUserName = "";
            LoggedUser.mainWindowForm.Show();
            this.Close();
        }
    }
}
