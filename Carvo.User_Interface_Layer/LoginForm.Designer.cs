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
            loginBtn = new Button();
            passwordTxt = new TextBox();
            panel1 = new Panel();
            errorPasswordLabel = new Label();
            errorUserLabel = new Label();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            minimizeBtn = new Button();
            backBtn = new Button();
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
            label3.Location = new Point(277, 168);
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
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(157, 62, 81);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(165, 311);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(163, 47);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "دخول";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(44, 209);
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
            panel1.Controls.Add(errorPasswordLabel);
            panel1.Controls.Add(errorUserLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(userNameTxt);
            panel1.Controls.Add(loginBtn);
            panel1.Location = new Point(485, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 380);
            panel1.TabIndex = 8;
            // 
            // errorPasswordLabel
            // 
            errorPasswordLabel.AutoSize = true;
            errorPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorPasswordLabel.ForeColor = Color.Red;
            errorPasswordLabel.Location = new Point(271, 257);
            errorPasswordLabel.Name = "errorPasswordLabel";
            errorPasswordLabel.RightToLeft = RightToLeft.Yes;
            errorPasswordLabel.Size = new Size(0, 23);
            errorPasswordLabel.TabIndex = 6;
            // 
            // errorUserLabel
            // 
            errorUserLabel.AutoSize = true;
            errorUserLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorUserLabel.ForeColor = Color.Red;
            errorUserLabel.Location = new Point(170, 122);
            errorUserLabel.Name = "errorUserLabel";
            errorUserLabel.RightToLeft = RightToLeft.Yes;
            errorUserLabel.Size = new Size(0, 23);
            errorUserLabel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = (Image)resources.GetObject("closeBtn.BackgroundImage");
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(938, 9);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(50, 50);
            closeBtn.TabIndex = 10;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackgroundImage = (Image)resources.GetObject("minimizeBtn.BackgroundImage");
            minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(873, 9);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(50, 50);
            minimizeBtn.TabIndex = 11;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackgroundImage = (Image)resources.GetObject("backBtn.BackgroundImage");
            backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(30, 9);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(50, 50);
            backBtn.TabIndex = 12;
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += closeBtn_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 582);
            Controls.Add(backBtn);
            Controls.Add(minimizeBtn);
            Controls.Add(closeBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
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
        private Button loginBtn;
        private TextBox passwordTxt;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button closeBtn;
        private Button minimizeBtn;
        private Button backBtn;
        private Label errorPasswordLabel;
        private Label errorUserLabel;
    }
}