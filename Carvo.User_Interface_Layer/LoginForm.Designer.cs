namespace Carvo.User_Interface_Layer
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameTxt = new TextBox();
            roleComboBox = new ComboBox();
            button1 = new Button();
            passwordTxt = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 67, 87);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 81);
            label1.TabIndex = 0;
            label1.Text = " تسجيــــل الدخــــول";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(198, 198, 198);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(242, 33);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 1;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(198, 198, 198);
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(277, 155);
            label3.Name = "label3";
            label3.Size = new Size(146, 38);
            label3.TabIndex = 2;
            label3.Text = "كلمة المرور";
            // 
            // userNameTxt
            // 
            userNameTxt.BackColor = Color.White;
            userNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTxt.Location = new Point(44, 74);
            userNameTxt.Multiline = true;
            userNameTxt.Name = "userNameTxt";
            userNameTxt.RightToLeft = RightToLeft.Yes;
            userNameTxt.Size = new Size(379, 45);
            userNameTxt.TabIndex = 0;
            // 
            // roleComboBox
            // 
            roleComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(44, 298);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.RightToLeft = RightToLeft.Yes;
            roleComboBox.Size = new Size(382, 36);
            roleComboBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 62, 81);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(166, 373);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 4;
            button1.Text = "دخول";
            button1.UseVisualStyleBackColor = false;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(44, 196);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.RightToLeft = RightToLeft.Yes;
            passwordTxt.Size = new Size(379, 45);
            passwordTxt.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(198, 198, 198);
            panel1.Controls.Add(roleComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(userNameTxt);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(485, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 436);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(939, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(873, 0);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 582);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameTxt;
        private ComboBox roleComboBox;
        private Button button1;
        private TextBox passwordTxt;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}