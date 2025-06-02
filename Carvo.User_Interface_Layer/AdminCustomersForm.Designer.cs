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
            CustomerNationalIDTxt = new TextBox();
            CustomerPhoneTxt = new TextBox();
            label3 = new Label();
            CustomerNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateCustomerImg = new PictureBox();
            UpdateCustomerBtn = new Button();
            DeleteCustomerImg = new PictureBox();
            AddCustomerImg = new PictureBox();
            AddCustomerBtn = new Button();
            DeleteCustomerBtn = new Button();
            CustomersGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).BeginInit();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1508, 724);
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
            panel1.Size = new Size(1502, 127);
            panel1.TabIndex = 0;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1409, 23);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 4;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1314, 23);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
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
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 2;
            LogoutBtn.TabStop = false;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(139, 23);
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
            panel2.Controls.Add(UpdateCustomerImg);
            panel2.Controls.Add(UpdateCustomerBtn);
            panel2.Controls.Add(DeleteCustomerImg);
            panel2.Controls.Add(AddCustomerImg);
            panel2.Controls.Add(AddCustomerBtn);
            panel2.Controls.Add(DeleteCustomerBtn);
            panel2.Location = new Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 340);
            panel2.TabIndex = 1;
            // 
            // CustomerNationalIDTxt
            // 
            CustomerNationalIDTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNationalIDTxt.Location = new Point(768, 211);
            CustomerNationalIDTxt.Multiline = true;
            CustomerNationalIDTxt.Name = "CustomerNationalIDTxt";
            CustomerNationalIDTxt.Size = new Size(401, 39);
            CustomerNationalIDTxt.TabIndex = 19;
            CustomerNationalIDTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // CustomerPhoneTxt
            // 
            CustomerPhoneTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerPhoneTxt.Location = new Point(768, 129);
            CustomerPhoneTxt.Multiline = true;
            CustomerPhoneTxt.Name = "CustomerPhoneTxt";
            CustomerPhoneTxt.Size = new Size(401, 39);
            CustomerPhoneTxt.TabIndex = 18;
            CustomerPhoneTxt.TextAlign = HorizontalAlignment.Right;
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
            // CustomerNameTxt
            // 
            CustomerNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameTxt.Location = new Point(768, 51);
            CustomerNameTxt.Multiline = true;
            CustomerNameTxt.Name = "CustomerNameTxt";
            CustomerNameTxt.Size = new Size(401, 39);
            CustomerNameTxt.TabIndex = 9;
            CustomerNameTxt.TextAlign = HorizontalAlignment.Right;
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
            UpdateCustomerImg.Location = new Point(375, 129);
            UpdateCustomerImg.Name = "UpdateCustomerImg";
            UpdateCustomerImg.Size = new Size(64, 52);
            UpdateCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateCustomerImg.TabIndex = 6;
            UpdateCustomerImg.TabStop = false;
            // 
            // UpdateCustomerBtn
            // 
            UpdateCustomerBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateCustomerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateCustomerBtn.Location = new Point(239, 129);
            UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            UpdateCustomerBtn.Size = new Size(130, 52);
            UpdateCustomerBtn.TabIndex = 5;
            UpdateCustomerBtn.Text = "تحديث عميل";
            UpdateCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteCustomerImg
            // 
            DeleteCustomerImg.Image = (Image)resources.GetObject("DeleteCustomerImg.Image");
            DeleteCustomerImg.Location = new Point(375, 226);
            DeleteCustomerImg.Name = "DeleteCustomerImg";
            DeleteCustomerImg.Size = new Size(64, 52);
            DeleteCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCustomerImg.TabIndex = 4;
            DeleteCustomerImg.TabStop = false;
            // 
            // AddCustomerImg
            // 
            AddCustomerImg.Image = (Image)resources.GetObject("AddCustomerImg.Image");
            AddCustomerImg.Location = new Point(375, 38);
            AddCustomerImg.Name = "AddCustomerImg";
            AddCustomerImg.Size = new Size(64, 52);
            AddCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCustomerImg.TabIndex = 3;
            AddCustomerImg.TabStop = false;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddCustomerBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddCustomerBtn.Location = new Point(239, 38);
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
            DeleteCustomerBtn.Location = new Point(239, 226);
            DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            DeleteCustomerBtn.Size = new Size(130, 52);
            DeleteCustomerBtn.TabIndex = 1;
            DeleteCustomerBtn.Text = "مسح عميل";
            DeleteCustomerBtn.UseVisualStyleBackColor = false;
            // 
            // CustomersGridView
            // 
            CustomersGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            CustomersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            CustomersGridView.Anchor = AnchorStyles.None;
            CustomersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGridView.BorderStyle = BorderStyle.None;
            CustomersGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            CustomersGridView.EnableHeadersVisualStyles = false;
            CustomersGridView.Location = new Point(3, 484);
            CustomersGridView.MaximumSize = new Size(1502, 234);
            CustomersGridView.Name = "CustomersGridView";
            CustomersGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CustomersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CustomersGridView.RowHeadersVisible = false;
            CustomersGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            CustomersGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            CustomersGridView.ScrollBars = ScrollBars.Vertical;
            CustomersGridView.Size = new Size(1502, 234);
            CustomersGridView.TabIndex = 2;
            CustomersGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminCustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 724);
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
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).EndInit();
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
        private PictureBox DeleteCustomerImg;
        private PictureBox AddCustomerImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox UpdateCustomerImg;
        private Button UpdateCustomerBtn;
        private TextBox CustomerNameTxt;
        private Label label2;
        private Label label3;
        private TextBox CustomerNationalIDTxt;
        private TextBox CustomerPhoneTxt;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
        private PictureBox LogoutBtn;
    }
}