// Required namespaces
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Enums;
using Carvo.User_Interface_Layer.UIHelpers;
using Microsoft.Extensions.DependencyInjection;
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
        // Service for accessing user data
        private IUserService userService;

        // Dependency injection provider
        private IServiceProvider provider;

        // Role to determine which type of user is trying to log in (Admin or Employee)
        public Role role { get; set; }

        // Variables to store user input
        private string userName;
        private string password;

        // Constructor to initialize form with DI provider and user service
        public LoginForm(IServiceProvider _provider, IUserService _userService)
        {
            InitializeComponent();
            userService = _userService;
            provider = _provider;
        }

        // Event handler to close the login form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler to minimize the login form
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Event handler for the login button click
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            // Retrieve and trim user input from textboxes
            userName = userNameTxt.Text.Trim();
            password = passwordTxt.Text.Trim();

            // Validate credentials
            await Validate(userName, password);
        }

        // Validates the entered username and password based on the selected role
        public async Task Validate(string userName, string password)
        {
            // Get all users from the database
            var users = await userService.GetAllUsersAsync();

            // Try to find a matching user with provided credentials
            var user = users.FirstOrDefault(u => u.UserName == userName && u.Password == password);

            // If Admin role was selected from main window
            if (role == Role.Admin)
            {
                if (user != null && user.Role == Role.Admin)
                {
                    MessageBox.Show($"مرحبا {userName} تم تسجيل دخولك بنجاح", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenHomeDashboardForm();
                }
                else if (user != null && user.Role != Role.Admin)
                {
                    MessageBox.Show($"معذرة {userName} يبدو انك اخطأت في اختيار الوظيفة المناسبة", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // If Employee role was selected from main window
            if (role == Role.Employee)
            {
                if (user != null && user.Role == Role.Employee)
                {
                    MessageBox.Show($"مرحبا {userName} تم تسجيل دخولك بنجاح", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenEmployeeDashboardForm();
                }
                else if (user != null && user.Role != Role.Employee)
                {
                    MessageBox.Show($"معذرة {userName} يبدو انك اخطأت في اختيار الوظيفة المناسبة", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("خطأ في اسم المستخدم او كلمة المرور", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Opens the Admin dashboard after successful Admin login
        public void OpenHomeDashboardForm()
        {
            var homeDashboardForm = provider.GetRequiredService<HomeDashboardForm>();
            this.Close();
            homeDashboardForm.ShowDialog();
        }

        // Opens the Employee dashboard after successful Employee login
        public void OpenEmployeeDashboardForm()
        {
            var employeeDashboardForm = provider.GetRequiredService<EmployeeDashboardForm>();
            this.Close();
            employeeDashboardForm.ShowDialog();
        }


    }
}
