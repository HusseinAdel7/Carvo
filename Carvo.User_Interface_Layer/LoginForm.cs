// Required namespaces
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities.Users;
using Carvo.Data_Access_Layer.Enums;
using Carvo.User_Interface_Layer.UIHelpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Carvo.User_Interface_Layer
{
    public partial class LoginForm : Form
    {
        // Service to access user-related operations (e.g., fetching users)
        private IUserService userService;

        // Dependency injection container for resolving other forms/services
        private IServiceProvider provider;

        // Represents the user role selected (Admin or Employee)
        public Role role { get; set; }

        // Variables to hold entered username and password
        private string userName;
        private string password;

        // Constructor: initializes DI dependencies and form controls
        public LoginForm(IServiceProvider _provider, IUserService _userService)
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            userService = _userService;
            provider = _provider;
        }

        // Closes the login form when the "close" button is clicked
        private void closeBtn_Click(object sender, EventArgs e)
        {
            LoggedUser.mainWindowForm.Show();
            this.Close();
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

        // Minimizes the login form window when the "minimize" button is clicked
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Triggered when the login button is clicked
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            // Trim and store input values
            userName = userNameTxt.Text.Trim();
            password = passwordTxt.Text.Trim();

            // Clear any previous error messages
            errorUserLabel.Text = "";
            errorPasswordLabel.Text = "";

            // Call validation logic
            await Validate(userName, password);
        }

        // Validates the entered credentials against the user list and role
        public async Task Validate(string userName, string password)
        {
            // Fetch all registered users from the database
            var users = await userService.GetAllUsersAsync();

            // Get users matching the entered username and selected role
            var matchedUsers = users.Where(u => u.UserName == userName && u.Role == role).ToList();

            // If no users match the username + role combination
            if (!matchedUsers.Any())
            {
                errorUserLabel.Text = "خطأ في اسم المستخدم أو الوظيفة";
            }
            else
            {
                // Check if any of the matched users has the correct password
                var matchedUser = matchedUsers.FirstOrDefault(u => u.Password == password);

                if (matchedUser != null)
                {
                    // Show success message with user's name
                    //MessageBox.Show($"مرحبا {userName} تم تسجيل دخولك بنجاح", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoggedUser.loggedUserId = matchedUser.Id;
                    LoggedUser.loggedUserName = matchedUser.UserName;

                    // Redirect to appropriate dashboard based on role
                    if (role == Role.Admin)
                    {
                        OpenHomeDashboardForm();
                    }
                    else
                    {
                        OpenEmployeeDashboardForm();
                    }
                }
                else
                {
                    // Password was incorrect for the matched username and role
                    errorPasswordLabel.Text = "خطأ في كلمة المرور";
                }
            }
        }

        // Opens the Admin dashboard form and closes the login form
        public void OpenHomeDashboardForm()
        {
            var homeDashboardForm = provider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.Show();
        }

        // Opens the Employee dashboard form and closes the login form
        public void OpenEmployeeDashboardForm()
        {
            var employeeDashboardForm = provider.GetRequiredService<EmployeeDashboardForm>();
            this.Close();
            employeeDashboardForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '*';

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
