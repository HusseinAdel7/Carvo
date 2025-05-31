namespace Carvo.User_Interface_Layer
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            CustomerNationalIDTxt = new TextBox();
            CustomerPhoneTxt = new TextBox();
            label3 = new Label();
            CustomerNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateCustomerBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddCustomerBtn = new Button();
            DeleteCustomerBtn = new Button();
            CustomersGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(CustomersGridView, 0, 2);
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
            CategoriesManagement.Size = new Size(153, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة العملاء";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(CustomerNationalIDTxt);
            panel2.Controls.Add(CustomerPhoneTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(CustomerNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateCustomerBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddCustomerBtn);
            panel2.Controls.Add(DeleteCustomerBtn);
            panel2.Location = new Point(60, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 432);
            panel2.TabIndex = 1;
            // 
            // CustomerNationalIDTxt
            // 
            CustomerNationalIDTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNationalIDTxt.Location = new Point(796, 211);
            CustomerNationalIDTxt.Multiline = true;
            CustomerNationalIDTxt.Name = "CustomerNationalIDTxt";
            CustomerNationalIDTxt.Size = new Size(373, 39);
            CustomerNationalIDTxt.TabIndex = 19;
            CustomerNationalIDTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // CustomerPhoneTxt
            // 
            CustomerPhoneTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneTxt.Location = new Point(796, 129);
            CustomerPhoneTxt.Multiline = true;
            CustomerPhoneTxt.Name = "CustomerPhoneTxt";
            CustomerPhoneTxt.Size = new Size(373, 39);
            CustomerPhoneTxt.TabIndex = 18;
            CustomerPhoneTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1222, 212);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 17;
            label3.Text = " : الرقم القومي ";
            // 
            // CustomerNameTxt
            // 
            CustomerNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameTxt.Location = new Point(796, 51);
            CustomerNameTxt.Multiline = true;
            CustomerNameTxt.Name = "CustomerNameTxt";
            CustomerNameTxt.Size = new Size(373, 39);
            CustomerNameTxt.TabIndex = 9;
            CustomerNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1233, 126);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 8;
            label2.Text = " : رقم الهاتف ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1222, 52);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 7;
            label1.Text = " : اسم العميل ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UpdateCustomerBtn
            // 
            UpdateCustomerBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateCustomerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateCustomerBtn.Location = new Point(191, 129);
            UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            UpdateCustomerBtn.Size = new Size(130, 52);
            UpdateCustomerBtn.TabIndex = 5;
            UpdateCustomerBtn.Text = "تحديث عميل";
            UpdateCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(327, 226);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(327, 38);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddCustomerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddCustomerBtn.Location = new Point(191, 38);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(130, 52);
            AddCustomerBtn.TabIndex = 2;
            AddCustomerBtn.Text = "اضافة عميل ";
            AddCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteCustomerBtn
            // 
            DeleteCustomerBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteCustomerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteCustomerBtn.Location = new Point(191, 226);
            DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            DeleteCustomerBtn.Size = new Size(130, 52);
            DeleteCustomerBtn.TabIndex = 1;
            DeleteCustomerBtn.Text = "مسح عميل";
            DeleteCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // CustomersGridView
            // 
            CustomersGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            CustomersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            CustomersGridView.Anchor = AnchorStyles.None;
            CustomersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGridView.BorderStyle = BorderStyle.None;
            CustomersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CustomersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            CustomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CustomersGridView.DefaultCellStyle = dataGridViewCellStyle8;
            CustomersGridView.EnableHeadersVisualStyles = false;
            CustomersGridView.Location = new Point(60, 583);
            CustomersGridView.MaximumSize = new Size(1387, 285);
            CustomersGridView.Name = "CustomersGridView";
            CustomersGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            CustomersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            CustomersGridView.RowHeadersVisible = false;
            CustomersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            CustomersGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            CustomersGridView.ScrollBars = ScrollBars.Vertical;
            CustomersGridView.Size = new Size(1387, 234);
            CustomersGridView.TabIndex = 2;
            CustomersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1526, 885);
            Name = "AdminCustomersForm";
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
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddCustomerBtn;
        private Button DeleteCustomerBtn;
        private DataGridView CustomersGridView;
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button UpdateCustomerBtn;
        private TextBox CustomerNameTxt;
        private Label label2;
        private Label label3;
        private TextBox CustomerNationalIDTxt;
        private TextBox CustomerPhoneTxt;
    }
}