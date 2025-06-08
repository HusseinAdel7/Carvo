﻿namespace Carvo.User_Interface_Layer
{
    partial class AdminCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomersForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            LogoutBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            AddVehicleBtnImg = new PictureBox();
            AddVehicleBtn = new Button();
            txtNationalId = new TextBox();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateCustomerImg = new PictureBox();
            btnUpdateCustomer = new Button();
            DeleteCustomerImg = new PictureBox();
            AddCustomerImg = new PictureBox();
            btnAddCustomer = new Button();
            btnDeleteCustomer = new Button();
            dgvCustomers = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddVehicleBtnImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
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
            tableLayoutPanel1.Controls.Add(dgvCustomers, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1494, 724);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeFormBtn);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 127);
            panel1.TabIndex = 0;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1390, 23);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 51);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 4;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1300, 23);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 51);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 3;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(50, 23);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 51);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 2;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(138, 23);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(50, 51);
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
            CategoriesManagement.Size = new Size(153, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة العملاء";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(AddVehicleBtnImg);
            panel2.Controls.Add(AddVehicleBtn);
            panel2.Controls.Add(txtNationalId);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateCustomerImg);
            panel2.Controls.Add(btnUpdateCustomer);
            panel2.Controls.Add(DeleteCustomerImg);
            panel2.Controls.Add(AddCustomerImg);
            panel2.Controls.Add(btnAddCustomer);
            panel2.Controls.Add(btnDeleteCustomer);
            panel2.Location = new Point(4, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1486, 341);
            panel2.TabIndex = 1;
            // 
            // AddVehicleBtnImg
            // 
            AddVehicleBtnImg.Image = (Image)resources.GetObject("AddVehicleBtnImg.Image");
            AddVehicleBtnImg.Location = new Point(255, 211);
            AddVehicleBtnImg.Name = "AddVehicleBtnImg";
            AddVehicleBtnImg.Size = new Size(64, 52);
            AddVehicleBtnImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddVehicleBtnImg.TabIndex = 21;
            AddVehicleBtnImg.TabStop = false;
            AddVehicleBtnImg.Click += AddVehicleBtn_Click;
            // 
            // AddVehicleBtn
            // 
            AddVehicleBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddVehicleBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddVehicleBtn.Location = new Point(119, 211);
            AddVehicleBtn.Name = "AddVehicleBtn";
            AddVehicleBtn.Size = new Size(130, 52);
            AddVehicleBtn.TabIndex = 20;
            AddVehicleBtn.Text = "اضافة سيارة";
            AddVehicleBtn.UseVisualStyleBackColor = false;
            AddVehicleBtn.Click += AddVehicleBtn_Click;
            // 
            // txtNationalId
            // 
            txtNationalId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNationalId.Location = new Point(768, 211);
            txtNationalId.Multiline = true;
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(401, 39);
            txtNationalId.TabIndex = 19;
            txtNationalId.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(768, 129);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(401, 39);
            txtPhoneNumber.TabIndex = 18;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1222, 209);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 17;
            label3.Text = " : الرقم القومي ";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(768, 51);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(401, 39);
            txtCustomerName.TabIndex = 9;
            txtCustomerName.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1241, 129);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 8;
            label2.Text = " : رقم الهاتف ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1233, 51);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 7;
            label1.Text = " : اسم العميل ";
            // 
            // UpdateCustomerImg
            // 
            UpdateCustomerImg.Image = (Image)resources.GetObject("UpdateCustomerImg.Image");
            UpdateCustomerImg.Location = new Point(255, 68);
            UpdateCustomerImg.Name = "UpdateCustomerImg";
            UpdateCustomerImg.Size = new Size(64, 52);
            UpdateCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateCustomerImg.TabIndex = 6;
            UpdateCustomerImg.TabStop = false;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdateCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnUpdateCustomer.Location = new Point(119, 68);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(130, 52);
            btnUpdateCustomer.TabIndex = 5;
            btnUpdateCustomer.Text = "تحديث عميل";
            btnUpdateCustomer.UseVisualStyleBackColor = false;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // DeleteCustomerImg
            // 
            DeleteCustomerImg.Image = (Image)resources.GetObject("DeleteCustomerImg.Image");
            DeleteCustomerImg.Location = new Point(540, 211);
            DeleteCustomerImg.Name = "DeleteCustomerImg";
            DeleteCustomerImg.Size = new Size(64, 52);
            DeleteCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCustomerImg.TabIndex = 4;
            DeleteCustomerImg.TabStop = false;
            // 
            // AddCustomerImg
            // 
            AddCustomerImg.Image = (Image)resources.GetObject("AddCustomerImg.Image");
            AddCustomerImg.Location = new Point(540, 68);
            AddCustomerImg.Name = "AddCustomerImg";
            AddCustomerImg.Size = new Size(64, 52);
            AddCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCustomerImg.TabIndex = 3;
            AddCustomerImg.TabStop = false;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.FromArgb(224, 224, 224);
            btnAddCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(404, 68);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(130, 52);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "اضافة عميل ";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(224, 224, 224);
            btnDeleteCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDeleteCustomer.Location = new Point(404, 211);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(130, 52);
            btnDeleteCustomer.TabIndex = 1;
            btnDeleteCustomer.Text = "مسح عميل";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.Anchor = AnchorStyles.None;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new Point(5, 484);
            dgvCustomers.MaximumSize = new Size(1502, 235);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.ScrollBars = ScrollBars.Vertical;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1484, 235);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // AdminCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1494, 724);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1526, 885);
            Name = "AdminCustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddVehicleBtnImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button btnAddCustomer;
        private Button btnDeleteCustomer;
        private DataGridView dgvCustomers;
        private PictureBox DeleteCustomerImg;
        private PictureBox AddCustomerImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox UpdateCustomerImg;
        private Button btnUpdateCustomer;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label3;
        private TextBox txtNationalId;
        private TextBox txtPhoneNumber;
        private PictureBox MinimizeFormBtn;
        private PictureBox LogoutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox AddVehicleBtnImg;
        private Button AddVehicleBtn;
    }
}