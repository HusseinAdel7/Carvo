namespace Carvo.User_Interface_Layer
{
    partial class AdminEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEmployeesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            LogoutBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            cancelImg = new PictureBox();
            cancelBtn = new Button();
            checkBox1 = new CheckBox();
            userPassErrorLabel = new Label();
            userEmailErrorLabel = new Label();
            userNameErrorLabel = new Label();
            UserpassTxt = new TextBox();
            label5 = new Label();
            UserEmailTxt = new TextBox();
            label4 = new Label();
            UserRoleDropdownList = new ComboBox();
            UserNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateUserImg = new PictureBox();
            UpdateUserBtn = new Button();
            DeleteUserImg = new PictureBox();
            AddUserImg = new PictureBox();
            AddUserBtn = new Button();
            DeleteUserBtn = new Button();
            UsersGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateUserImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteUserImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUserImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(UsersGridView, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 438F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1508, 829);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 127);
            panel1.TabIndex = 0;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1398, 23);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 4;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(1315, 23);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(50, 50);
            MinimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(61, 23);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 2;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(151, 23);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(50, 50);
            PrevImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImageAsBtn.TabIndex = 1;
            PrevImageAsBtn.TabStop = false;
            PrevImageAsBtn.Click += PrevImageAsBtn_Click;
            // 
            // CategoriesManagement
            // 
            CategoriesManagement.AutoSize = true;
            CategoriesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesManagement.Location = new Point(707, 35);
            CategoriesManagement.Name = "CategoriesManagement";
            CategoriesManagement.Size = new Size(215, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة المستخدمين";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(cancelImg);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(userPassErrorLabel);
            panel2.Controls.Add(userEmailErrorLabel);
            panel2.Controls.Add(userNameErrorLabel);
            panel2.Controls.Add(UserpassTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UserEmailTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UserRoleDropdownList);
            panel2.Controls.Add(UserNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateUserImg);
            panel2.Controls.Add(UpdateUserBtn);
            panel2.Controls.Add(DeleteUserImg);
            panel2.Controls.Add(AddUserImg);
            panel2.Controls.Add(AddUserBtn);
            panel2.Controls.Add(DeleteUserBtn);
            panel2.Location = new Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 432);
            panel2.TabIndex = 1;
            // 
            // cancelImg
            // 
            cancelImg.BackgroundImageLayout = ImageLayout.Stretch;
            cancelImg.Image = (Image)resources.GetObject("cancelImg.Image");
            cancelImg.Location = new Point(1095, 200);
            cancelImg.Name = "cancelImg";
            cancelImg.Size = new Size(44, 38);
            cancelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelImg.TabIndex = 37;
            cancelImg.TabStop = false;
            cancelImg.Click += cancelBtn_Click_1;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(244, 244, 244);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(991, 206);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(98, 32);
            cancelBtn.TabIndex = 36;
            cancelBtn.Text = "اعادة تعيين";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(317, 206);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(141, 24);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "اظهار كلمة المرور";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // userPassErrorLabel
            // 
            userPassErrorLabel.AutoSize = true;
            userPassErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userPassErrorLabel.ForeColor = Color.Red;
            userPassErrorLabel.Location = new Point(-31, 173);
            userPassErrorLabel.Name = "userPassErrorLabel";
            userPassErrorLabel.Size = new Size(489, 20);
            userPassErrorLabel.TabIndex = 23;
            userPassErrorLabel.Text = "كلمة المرور لا يجب ان تكون فارغة او اقل من (4)حروف او أن تزيد عن(30) حرفا";
            userPassErrorLabel.Visible = false;
            // 
            // userEmailErrorLabel
            // 
            userEmailErrorLabel.AutoSize = true;
            userEmailErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userEmailErrorLabel.ForeColor = Color.Red;
            userEmailErrorLabel.Location = new Point(592, 172);
            userEmailErrorLabel.Name = "userEmailErrorLabel";
            userEmailErrorLabel.RightToLeft = RightToLeft.Yes;
            userEmailErrorLabel.Size = new Size(543, 20);
            userEmailErrorLabel.TabIndex = 22;
            userEmailErrorLabel.Text = "الصيغة الصحيحة للبريد \"example@gmail.com\" ويجب ان لا يزيد طوله عن (30) حرفا";
            userEmailErrorLabel.Visible = false;
            // 
            // userNameErrorLabel
            // 
            userNameErrorLabel.AutoSize = true;
            userNameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameErrorLabel.ForeColor = Color.Red;
            userNameErrorLabel.Location = new Point(682, 95);
            userNameErrorLabel.Name = "userNameErrorLabel";
            userNameErrorLabel.Size = new Size(453, 20);
            userNameErrorLabel.TabIndex = 21;
            userNameErrorLabel.Text = "الاسم لا يجب ان يكون فارغا او اقل من (3) حروف او أن يزيد عن(30) حرفا";
            userNameErrorLabel.Visible = false;
            // 
            // UserpassTxt
            // 
            UserpassTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserpassTxt.Location = new Point(85, 131);
            UserpassTxt.Multiline = true;
            UserpassTxt.Name = "UserpassTxt";
            UserpassTxt.PasswordChar = '*';
            UserpassTxt.Size = new Size(373, 39);
            UserpassTxt.TabIndex = 5;
            UserpassTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(527, 131);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 20;
            label5.Text = " : كلمة المرور ";
            // 
            // UserEmailTxt
            // 
            UserEmailTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserEmailTxt.Location = new Point(762, 130);
            UserEmailTxt.Multiline = true;
            UserEmailTxt.Name = "UserEmailTxt";
            UserEmailTxt.Size = new Size(373, 39);
            UserEmailTxt.TabIndex = 3;
            UserEmailTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(575, 61);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 15;
            label4.Text = " : الدور ";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // UserRoleDropdownList
            // 
            UserRoleDropdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserRoleDropdownList.FormattingEnabled = true;
            UserRoleDropdownList.Location = new Point(85, 61);
            UserRoleDropdownList.Name = "UserRoleDropdownList";
            UserRoleDropdownList.Size = new Size(373, 31);
            UserRoleDropdownList.TabIndex = 4;
            // 
            // UserNameTxt
            // 
            UserNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTxt.Location = new Point(762, 53);
            UserNameTxt.Multiline = true;
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(373, 39);
            UserNameTxt.TabIndex = 1;
            UserNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1170, 131);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 8;
            label2.Text = " : البريد الالكتروني ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1248, 52);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 7;
            label1.Text = " : الاسم ";
            // 
            // UpdateUserImg
            // 
            UpdateUserImg.Image = (Image)resources.GetObject("UpdateUserImg.Image");
            UpdateUserImg.Location = new Point(716, 331);
            UpdateUserImg.Name = "UpdateUserImg";
            UpdateUserImg.Size = new Size(64, 52);
            UpdateUserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateUserImg.TabIndex = 6;
            UpdateUserImg.TabStop = false;
            UpdateUserImg.Click += UpdateUserBtn_Click;
            // 
            // UpdateUserBtn
            // 
            UpdateUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateUserBtn.Location = new Point(559, 331);
            UpdateUserBtn.Name = "UpdateUserBtn";
            UpdateUserBtn.Size = new Size(151, 52);
            UpdateUserBtn.TabIndex = 7;
            UpdateUserBtn.Text = "تحديث مستخدم";
            UpdateUserBtn.UseVisualStyleBackColor = false;
            UpdateUserBtn.Click += UpdateUserBtn_Click;
            // 
            // DeleteUserImg
            // 
            DeleteUserImg.Image = (Image)resources.GetObject("DeleteUserImg.Image");
            DeleteUserImg.Location = new Point(331, 331);
            DeleteUserImg.Name = "DeleteUserImg";
            DeleteUserImg.Size = new Size(64, 52);
            DeleteUserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteUserImg.TabIndex = 4;
            DeleteUserImg.TabStop = false;
            DeleteUserImg.Click += DeleteUserBtn_Click;
            // 
            // AddUserImg
            // 
            AddUserImg.Image = (Image)resources.GetObject("AddUserImg.Image");
            AddUserImg.Location = new Point(1106, 331);
            AddUserImg.Name = "AddUserImg";
            AddUserImg.Size = new Size(64, 52);
            AddUserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddUserImg.TabIndex = 3;
            AddUserImg.TabStop = false;
            AddUserImg.Click += AddUserBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddUserBtn.Location = new Point(960, 331);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(140, 52);
            AddUserBtn.TabIndex = 6;
            AddUserBtn.Text = "اضافة مستخدم ";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteUserBtn.Location = new Point(188, 331);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(137, 52);
            DeleteUserBtn.TabIndex = 8;
            DeleteUserBtn.Text = "مسح مستخدم";
            DeleteUserBtn.UseVisualStyleBackColor = false;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // UsersGridView
            // 
            UsersGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            UsersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UsersGridView.Anchor = AnchorStyles.None;
            UsersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGridView.BorderStyle = BorderStyle.None;
            UsersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UsersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UsersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UsersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            UsersGridView.EnableHeadersVisualStyles = false;
            UsersGridView.Location = new Point(3, 583);
            UsersGridView.MaximumSize = new Size(1502, 234);
            UsersGridView.Name = "UsersGridView";
            UsersGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UsersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            UsersGridView.RowHeadersVisible = false;
            UsersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            UsersGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UsersGridView.ScrollBars = ScrollBars.Vertical;
            UsersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGridView.Size = new Size(1502, 234);
            UsersGridView.TabIndex = 2;
            UsersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            UsersGridView.SelectionChanged += UsersGridView_SelectionChanged;
            // 
            // AdminEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1526, 885);
            Name = "AdminEmployeesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cancelImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateUserImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteUserImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUserImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddUserBtn;
        private Button DeleteUserBtn;
        private DataGridView UsersGridView;
        private PictureBox DeleteUserImg;
        private PictureBox AddUserImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox UpdateUserImg;
        private Button UpdateUserBtn;
        private TextBox UserNameTxt;
        private Label label2;
        private Label label4;
        private ComboBox UserRoleDropdownList;
        private TextBox UserEmailTxt;
        private TextBox UserpassTxt;
        private Label label5;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeBtn;
        private PictureBox LogoutBtn;
        private Label userNameErrorLabel;
        private Label userEmailErrorLabel;
        private Label userPassErrorLabel;
        private CheckBox checkBox1;
        private PictureBox cancelImg;
        private Button cancelBtn;
    }
}