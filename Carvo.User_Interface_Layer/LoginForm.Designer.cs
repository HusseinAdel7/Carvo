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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userNameTxt = new TextBox();
            roleComboBox = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            passwordTxt = new TextBox();
            closeBtn = new Button();
            minimizeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(24, 23, 53);
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(482, 81);
            label1.TabIndex = 0;
            label1.Text = " تسجيــــل الدخــــول";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 111);
            label2.Name = "label2";
            label2.Size = new Size(181, 38);
            label2.TabIndex = 1;
            label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 206);
            label3.Name = "label3";
            label3.Size = new Size(146, 38);
            label3.TabIndex = 2;
            label3.Text = "كلمة المرور";
            // 
            // userNameTxt
            // 
            userNameTxt.BackColor = Color.White;
            userNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTxt.Location = new Point(95, 153);
            userNameTxt.Multiline = true;
            userNameTxt.Name = "userNameTxt";
            userNameTxt.RightToLeft = RightToLeft.Yes;
            userNameTxt.Size = new Size(379, 34);
            userNameTxt.TabIndex = 0;
            // 
            // roleComboBox
            // 
            roleComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Location = new Point(156, 323);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.RightToLeft = RightToLeft.Yes;
            roleComboBox.Size = new Size(318, 36);
            roleComboBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 64);
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(91, 323);
            label4.Name = "label4";
            label4.Size = new Size(73, 38);
            label4.TabIndex = 5;
            label4.Text = "الدور";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 62, 81);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(214, 377);
            button1.Name = "button1";
            button1.Size = new Size(163, 47);
            button1.TabIndex = 4;
            button1.Text = "دخول";
            button1.UseVisualStyleBackColor = false;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.Location = new Point(92, 249);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.RightToLeft = RightToLeft.Yes;
            passwordTxt.Size = new Size(382, 34);
            passwordTxt.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.Red;
            closeBtn.Location = new Point(1402, 1);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(94, 41);
            closeBtn.TabIndex = 6;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizeBtn.ForeColor = Color.White;
            minimizeBtn.Location = new Point(1314, 1);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(94, 41);
            minimizeBtn.TabIndex = 7;
            minimizeBtn.Text = "-";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 23, 53);
            ClientSize = new Size(1508, 450);
            Controls.Add(minimizeBtn);
            Controls.Add(closeBtn);
            Controls.Add(passwordTxt);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(roleComboBox);
            Controls.Add(userNameTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userNameTxt;
        private ComboBox roleComboBox;
        private Label label4;
        private Button button1;
        private TextBox passwordTxt;
        private Button closeBtn;
        private Button minimizeBtn;
    }
}