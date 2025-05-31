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
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            UserpassTxt = new TextBox();
            label5 = new Label();
            UsernationalIDTxt = new TextBox();
            UserEmailTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            UserRoleDropdownList = new ComboBox();
            UserNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateUserBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddUserBtn = new Button();
            DeleteUserBtn = new Button();
            UsersGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
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
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 127);
            panel1.TabIndex = 0;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(42, 20);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(50, 50);
            PrevImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImageAsBtn.TabIndex = 1;
            PrevImageAsBtn.TabStop = false;
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
            panel2.Controls.Add(UserpassTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UsernationalIDTxt);
            panel2.Controls.Add(UserEmailTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UserRoleDropdownList);
            panel2.Controls.Add(UserNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateUserBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddUserBtn);
            panel2.Controls.Add(DeleteUserBtn);
            panel2.Location = new Point(60, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 432);
            panel2.TabIndex = 1;
            // 
            // UserpassTxt
            // 
            UserpassTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserpassTxt.Location = new Point(762, 221);
            UserpassTxt.Multiline = true;
            UserpassTxt.Name = "UserpassTxt";
            UserpassTxt.Size = new Size(373, 39);
            UserpassTxt.TabIndex = 21;
            UserpassTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1205, 222);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 20;
            label5.Text = " : كلمة المرور ";
            // 
            // UsernationalIDTxt
            // 
            UsernationalIDTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernationalIDTxt.Location = new Point(85, 52);
            UsernationalIDTxt.Multiline = true;
            UsernationalIDTxt.Name = "UsernationalIDTxt";
            UsernationalIDTxt.Size = new Size(373, 39);
            UsernationalIDTxt.TabIndex = 19;
            UsernationalIDTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // UserEmailTxt
            // 
            UserEmailTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserEmailTxt.Location = new Point(762, 130);
            UserEmailTxt.Multiline = true;
            UserEmailTxt.Name = "UserEmailTxt";
            UserEmailTxt.Size = new Size(373, 39);
            UserEmailTxt.TabIndex = 18;
            UserEmailTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(515, 53);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 17;
            label3.Text = " : الرقم القومي ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(575, 130);
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
            UserRoleDropdownList.Location = new Point(85, 130);
            UserRoleDropdownList.Name = "UserRoleDropdownList";
            UserRoleDropdownList.Size = new Size(373, 31);
            UserRoleDropdownList.TabIndex = 12;
            // 
            // UserNameTxt
            // 
            UserNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameTxt.Location = new Point(762, 53);
            UserNameTxt.Multiline = true;
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(373, 39);
            UserNameTxt.TabIndex = 9;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(716, 331);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UpdateUserBtn
            // 
            UpdateUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateUserBtn.Location = new Point(559, 331);
            UpdateUserBtn.Name = "UpdateUserBtn";
            UpdateUserBtn.Size = new Size(151, 52);
            UpdateUserBtn.TabIndex = 5;
            UpdateUserBtn.Text = "تحديث مستخدم";
            UpdateUserBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(331, 331);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1106, 331);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddUserBtn.Location = new Point(960, 331);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(140, 52);
            AddUserBtn.TabIndex = 2;
            AddUserBtn.Text = "اضافة مستخدم ";
            AddUserBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteUserBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteUserBtn.Location = new Point(188, 331);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(137, 52);
            DeleteUserBtn.TabIndex = 1;
            DeleteUserBtn.Text = "مسح مستخدم";
            DeleteUserBtn.UseVisualStyleBackColor = false;
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
            UsersGridView.Location = new Point(60, 583);
            UsersGridView.MaximumSize = new Size(1387, 285);
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
            UsersGridView.Size = new Size(1387, 234);
            UsersGridView.TabIndex = 2;
            UsersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1526, 885);
            Name = "AdminEmployeesForm";
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
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
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button UpdateUserBtn;
        private TextBox UserNameTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox UserRoleDropdownList;
        private TextBox UsernationalIDTxt;
        private TextBox UserEmailTxt;
        private TextBox UserpassTxt;
        private Label label5;
    }
}