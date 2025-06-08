namespace Carvo.User_Interface_Layer
{
    partial class AdminSuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSuppliersForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            Logoutbtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            SupplierCompanyFollowedTxt = new TextBox();
            SupplierPhoneTxt = new TextBox();
            SupplierAddressTxt = new TextBox();
            label3 = new Label();
            SupplierCompanyTxt = new Label();
            SupplierNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateSupplierBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddSupplierBtn = new Button();
            DeleteSupplierBtn = new Button();
            SuppliersGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logoutbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SuppliersGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(SuppliersGridView, 0, 2);
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
            panel1.Controls.Add(Logoutbtn);
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
            CloseFormBtn.Location = new Point(1387, 23);
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
            MinimizeBtn.Location = new Point(1290, 23);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(50, 50);
            MinimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // Logoutbtn
            // 
            Logoutbtn.Image = (Image)resources.GetObject("Logoutbtn.Image");
            Logoutbtn.Location = new Point(63, 23);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(50, 50);
            Logoutbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            Logoutbtn.TabIndex = 2;
            Logoutbtn.TabStop = false;
            Logoutbtn.Click += Logoutbtn_Click;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(155, 23);
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
            CategoriesManagement.Size = new Size(175, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة الموردين";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(SupplierCompanyFollowedTxt);
            panel2.Controls.Add(SupplierPhoneTxt);
            panel2.Controls.Add(SupplierAddressTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(SupplierCompanyTxt);
            panel2.Controls.Add(SupplierNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateSupplierBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddSupplierBtn);
            panel2.Controls.Add(DeleteSupplierBtn);
            panel2.Location = new Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 432);
            panel2.TabIndex = 1;
            // 
            // SupplierCompanyFollowedTxt
            // 
            SupplierCompanyFollowedTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierCompanyFollowedTxt.Location = new Point(85, 143);
            SupplierCompanyFollowedTxt.Multiline = true;
            SupplierCompanyFollowedTxt.Name = "SupplierCompanyFollowedTxt";
            SupplierCompanyFollowedTxt.Size = new Size(373, 39);
            SupplierCompanyFollowedTxt.TabIndex = 20;
            SupplierCompanyFollowedTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // SupplierPhoneTxt
            // 
            SupplierPhoneTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierPhoneTxt.Location = new Point(85, 52);
            SupplierPhoneTxt.Multiline = true;
            SupplierPhoneTxt.Name = "SupplierPhoneTxt";
            SupplierPhoneTxt.Size = new Size(373, 39);
            SupplierPhoneTxt.TabIndex = 19;
            SupplierPhoneTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // SupplierAddressTxt
            // 
            SupplierAddressTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierAddressTxt.Location = new Point(839, 141);
            SupplierAddressTxt.Multiline = true;
            SupplierAddressTxt.Name = "SupplierAddressTxt";
            SupplierAddressTxt.Size = new Size(373, 39);
            SupplierAddressTxt.TabIndex = 18;
            SupplierAddressTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(541, 53);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 17;
            label3.Text = " : رقم الهاتف ";
            // 
            // SupplierCompanyTxt
            // 
            SupplierCompanyTxt.AutoSize = true;
            SupplierCompanyTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SupplierCompanyTxt.ForeColor = Color.White;
            SupplierCompanyTxt.Location = new Point(499, 141);
            SupplierCompanyTxt.Name = "SupplierCompanyTxt";
            SupplierCompanyTxt.Size = new Size(165, 28);
            SupplierCompanyTxt.TabIndex = 15;
            SupplierCompanyTxt.Text = " : الشركة التابع لها ";
            SupplierCompanyTxt.TextAlign = ContentAlignment.TopRight;
            // 
            // SupplierNameTxt
            // 
            SupplierNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierNameTxt.Location = new Point(839, 52);
            SupplierNameTxt.Multiline = true;
            SupplierNameTxt.Name = "SupplierNameTxt";
            SupplierNameTxt.Size = new Size(373, 39);
            SupplierNameTxt.TabIndex = 9;
            SupplierNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1325, 141);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 8;
            label2.Text = " : العنوان ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1290, 53);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 7;
            label1.Text = " : اسم الموزع ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(819, 324);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UpdateSupplierBtn
            // 
            UpdateSupplierBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateSupplierBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateSupplierBtn.Location = new Point(683, 324);
            UpdateSupplierBtn.Name = "UpdateSupplierBtn";
            UpdateSupplierBtn.Size = new Size(130, 52);
            UpdateSupplierBtn.TabIndex = 5;
            UpdateSupplierBtn.Text = "تحديث موزع";
            UpdateSupplierBtn.UseVisualStyleBackColor = false;
            UpdateSupplierBtn.Click += UpdateSupplierBtn_Click;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(434, 324);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1209, 324);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddSupplierBtn
            // 
            AddSupplierBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddSupplierBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddSupplierBtn.Location = new Point(1073, 324);
            AddSupplierBtn.Name = "AddSupplierBtn";
            AddSupplierBtn.Size = new Size(130, 52);
            AddSupplierBtn.TabIndex = 2;
            AddSupplierBtn.Text = "اضافة موزع ";
            AddSupplierBtn.UseVisualStyleBackColor = false;
            AddSupplierBtn.Click += AddSupplierBtn_Click;
            // 
            // DeleteSupplierBtn
            // 
            DeleteSupplierBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteSupplierBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteSupplierBtn.Location = new Point(298, 324);
            DeleteSupplierBtn.Name = "DeleteSupplierBtn";
            DeleteSupplierBtn.Size = new Size(130, 52);
            DeleteSupplierBtn.TabIndex = 1;
            DeleteSupplierBtn.Text = "مسح موزع";
            DeleteSupplierBtn.UseVisualStyleBackColor = false;
            DeleteSupplierBtn.Click += DeleteSupplierBtn_Click;
            // 
            // SuppliersGridView
            // 
            SuppliersGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            SuppliersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SuppliersGridView.Anchor = AnchorStyles.None;
            SuppliersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuppliersGridView.BorderStyle = BorderStyle.None;
            SuppliersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SuppliersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SuppliersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SuppliersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            SuppliersGridView.EnableHeadersVisualStyles = false;
            SuppliersGridView.Location = new Point(3, 578);
            SuppliersGridView.MaximumSize = new Size(1502, 243);
            SuppliersGridView.Name = "SuppliersGridView";
            SuppliersGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SuppliersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SuppliersGridView.RowHeadersVisible = false;
            SuppliersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            SuppliersGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            SuppliersGridView.ScrollBars = ScrollBars.Vertical;
            SuppliersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SuppliersGridView.Size = new Size(1502, 243);
            SuppliersGridView.TabIndex = 2;
            SuppliersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            SuppliersGridView.SelectionChanged += SuppliersGridView_SelectionChanged;
            // 
            // AdminSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1526, 885);
            Name = "AdminSuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logoutbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)SuppliersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddSupplierBtn;
        private Button DeleteSupplierBtn;
        private DataGridView SuppliersGridView;
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button UpdateSupplierBtn;
        private TextBox SupplierNameTxt;
        private Label label2;
        private Label label3;
        private Label SupplierCompanyTxt;
        private TextBox SupplierPhoneTxt;
        private TextBox SupplierAddressTxt;
        private TextBox SupplierCompanyFollowedTxt;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeBtn;
        private PictureBox Logoutbtn;
    }
}