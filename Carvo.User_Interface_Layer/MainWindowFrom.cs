// Required namespaces
using Carvo.Data_Access_Layer.Enums;
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

namespace Carvo.User_Interface_Layer
{
    public partial class MainWindowFrom : Form
    {
        // Dependency injection provider to resolve services like LoginForm
        IServiceProvider provider;

        // Property to hold the role of the current user
        public Role UserRole { get; set; }

        // Constructor that initializes the form and sets up the DI provider
        public MainWindowFrom(IServiceProvider _provider)
        {
            InitializeComponent();
            provider = _provider;

        }

        // Event handler for the close button - closes the application
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for the minimize button - minimizes the window
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Generic event handler for role-based buttons (Admin/Employee)
        private void Btn_Click(object sender, EventArgs e)
        {
            // Cast the sender to a Button and retrieve the role from its Tag
            Button btn = sender as Button;

            // Parse the role value from the button's Tag and convert to Role enum
            Role clickedRole = (Role)int.Parse(btn.Tag.ToString());

            // Open the login form with the selected role
            OpenLoginForm(clickedRole);
        }


        // Generic event handler for PictureBox click events acting as role selectors
        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Cast the sender to a PictureBox and retrieve the role from its Tag
            PictureBox pictureBox = sender as PictureBox;

            // Parse and convert the role to the Role enum
            Role clickedRole = (Role)int.Parse(pictureBox.Tag.ToString());

            // Open the login form with the selected role
            OpenLoginForm(clickedRole);
        }


        // Opens the LoginForm with the given user role
        public void OpenLoginForm(Role _role)
        {
            // Resolve the login form from the DI container
            var loginform = provider.GetRequiredService<LoginForm>();

            // Set the role for the login form
            loginform.role = _role;

            // Hide the main window, show login form modally, then show main again
           
            loginform.Show();
            this.Hide();
        }
    }
}