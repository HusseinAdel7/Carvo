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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
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
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            CategoriesManagement.Size = new Size(177, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة الموزعين";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(textBox1);
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
            panel2.Location = new Point(60, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 432);
            panel2.TabIndex = 1;
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
            SupplierAddressTxt.Location = new Point(796, 129);
            SupplierAddressTxt.Multiline = true;
            SupplierAddressTxt.Name = "SupplierAddressTxt";
            SupplierAddressTxt.Size = new Size(373, 39);
            SupplierAddressTxt.TabIndex = 18;
            SupplierAddressTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(515, 53);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 17;
            label3.Text = " : رقم الهاتف ";
            // 
            // SupplierCompanyTxt
            // 
            SupplierCompanyTxt.AutoSize = true;
            SupplierCompanyTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            SupplierCompanyTxt.ForeColor = Color.White;
            SupplierCompanyTxt.Location = new Point(510, 126);
            SupplierCompanyTxt.Name = "SupplierCompanyTxt";
            SupplierCompanyTxt.Size = new Size(150, 25);
            SupplierCompanyTxt.TabIndex = 15;
            SupplierCompanyTxt.Text = " : الشركة التابع لها ";
            SupplierCompanyTxt.TextAlign = ContentAlignment.TopRight;
            // 
            // SupplierNameTxt
            // 
            SupplierNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierNameTxt.Location = new Point(796, 51);
            SupplierNameTxt.Multiline = true;
            SupplierNameTxt.Name = "SupplierNameTxt";
            SupplierNameTxt.Size = new Size(373, 39);
            SupplierNameTxt.TabIndex = 9;
            SupplierNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1233, 126);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 8;
            label2.Text = " : العنوان ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1222, 52);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 7;
            label1.Text = " : اسم الموزع ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(712, 290);
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
            UpdateSupplierBtn.Location = new Point(576, 290);
            UpdateSupplierBtn.Name = "UpdateSupplierBtn";
            UpdateSupplierBtn.Size = new Size(130, 52);
            UpdateSupplierBtn.TabIndex = 5;
            UpdateSupplierBtn.Text = "تحديث موزع";
            UpdateSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(327, 290);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1102, 290);
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
            AddSupplierBtn.Location = new Point(966, 290);
            AddSupplierBtn.Name = "AddSupplierBtn";
            AddSupplierBtn.Size = new Size(130, 52);
            AddSupplierBtn.TabIndex = 2;
            AddSupplierBtn.Text = "اضافة موزع ";
            AddSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteSupplierBtn
            // 
            DeleteSupplierBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteSupplierBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteSupplierBtn.Location = new Point(191, 290);
            DeleteSupplierBtn.Name = "DeleteSupplierBtn";
            DeleteSupplierBtn.Size = new Size(130, 52);
            DeleteSupplierBtn.TabIndex = 1;
            DeleteSupplierBtn.Text = "مسح موزع";
            DeleteSupplierBtn.UseVisualStyleBackColor = false;
            // 
            // SuppliersGridView
            // 
            SuppliersGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.CornflowerBlue;
            SuppliersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            SuppliersGridView.Anchor = AnchorStyles.None;
            SuppliersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SuppliersGridView.BorderStyle = BorderStyle.None;
            SuppliersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            SuppliersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            SuppliersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            SuppliersGridView.DefaultCellStyle = dataGridViewCellStyle13;
            SuppliersGridView.EnableHeadersVisualStyles = false;
            SuppliersGridView.Location = new Point(60, 583);
            SuppliersGridView.MaximumSize = new Size(1387, 285);
            SuppliersGridView.Name = "SuppliersGridView";
            SuppliersGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            SuppliersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            SuppliersGridView.RowHeadersVisible = false;
            SuppliersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            SuppliersGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            SuppliersGridView.ScrollBars = ScrollBars.Vertical;
            SuppliersGridView.Size = new Size(1387, 234);
            SuppliersGridView.TabIndex = 2;
            SuppliersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(85, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 39);
            textBox1.TabIndex = 20;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // AdminSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1526, 885);
            Name = "AdminSuppliersForm";
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
        private TextBox textBox1;
    }
}