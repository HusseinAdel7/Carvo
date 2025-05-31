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
using Carvo.User_Interface_Layer.UIHelpers;

namespace Carvo.User_Interface_Layer
{
    public partial class LoginForm : Form
    {
        // enum for user roles
        public enum Role
        {
            مشرف,
            موظف
        }
        public LoginForm()
        {
            InitializeComponent();
            roleComboBox.DataSource = Enum.GetValues(typeof(Role));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is Button)
                {
                    UIHelper.MakeControlRounded(ctrl, 16); // degree of rounding
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
