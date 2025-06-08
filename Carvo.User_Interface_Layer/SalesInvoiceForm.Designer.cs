namespace Carvo.User_Interface_Layer
{
    partial class SalesInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            PrevFormBtn = new PictureBox();
            LogOutBtn = new PictureBox();
            panel2 = new Panel();
            PrintErrorMsg = new Label();
            TotalPriceNumeric = new NumericUpDown();
            DeleteCustomerImg = new PictureBox();
            DeleteInvoiceBtn = new Button();
            pictureBox1 = new PictureBox();
            ExtractInvoiceBtn = new Button();
            AddCustomerImg = new PictureBox();
            AddInvoiceBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            ProductQuantityNumeric = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            ProductsDropdownList = new ComboBox();
            CustomersDropdownList = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SalesInvoiceGridView = new DataGridView();
            quantityErrorMsg = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TotalPriceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalesInvoiceGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(671, 22);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "فاتورة مبيعات ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeFormBtn);
            panel1.Controls.Add(PrevFormBtn);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1526, 117);
            panel1.TabIndex = 3;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1431, 22);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 8;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1332, 22);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 7;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // PrevFormBtn
            // 
            PrevFormBtn.Image = (Image)resources.GetObject("PrevFormBtn.Image");
            PrevFormBtn.Location = new Point(135, 22);
            PrevFormBtn.Name = "PrevFormBtn";
            PrevFormBtn.Size = new Size(50, 50);
            PrevFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevFormBtn.TabIndex = 6;
            PrevFormBtn.TabStop = false;
            PrevFormBtn.Click += PrevFormBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Image = (Image)resources.GetObject("LogOutBtn.Image");
            LogOutBtn.Location = new Point(37, 22);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(50, 50);
            LogOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogOutBtn.TabIndex = 5;
            LogOutBtn.TabStop = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(quantityErrorMsg);
            panel2.Controls.Add(PrintErrorMsg);
            panel2.Controls.Add(TotalPriceNumeric);
            panel2.Controls.Add(DeleteCustomerImg);
            panel2.Controls.Add(DeleteInvoiceBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(ExtractInvoiceBtn);
            panel2.Controls.Add(AddCustomerImg);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(ProductQuantityNumeric);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ProductsDropdownList);
            panel2.Controls.Add(CustomersDropdownList);
            panel2.Location = new Point(0, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(1526, 408);
            panel2.TabIndex = 4;
            // 
            // PrintErrorMsg
            // 
            PrintErrorMsg.AutoSize = true;
            PrintErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrintErrorMsg.ForeColor = Color.Red;
            PrintErrorMsg.Location = new Point(943, 307);
            PrintErrorMsg.Name = "PrintErrorMsg";
            PrintErrorMsg.Size = new Size(201, 28);
            PrintErrorMsg.TabIndex = 47;
            PrintErrorMsg.Text = "يجب اضافة الفاتورة اولا";
            PrintErrorMsg.Visible = false;
            // 
            // TotalPriceNumeric
            // 
            TotalPriceNumeric.DecimalPlaces = 2;
            TotalPriceNumeric.Enabled = false;
            TotalPriceNumeric.Location = new Point(356, 179);
            TotalPriceNumeric.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            TotalPriceNumeric.Name = "TotalPriceNumeric";
            TotalPriceNumeric.Size = new Size(150, 27);
            TotalPriceNumeric.TabIndex = 15;
            // 
            // DeleteCustomerImg
            // 
            DeleteCustomerImg.Image = (Image)resources.GetObject("DeleteCustomerImg.Image");
            DeleteCustomerImg.Location = new Point(324, 296);
            DeleteCustomerImg.Name = "DeleteCustomerImg";
            DeleteCustomerImg.Size = new Size(64, 52);
            DeleteCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCustomerImg.TabIndex = 14;
            DeleteCustomerImg.TabStop = false;
            DeleteCustomerImg.Click += DeleteInvoiceBtn_Click;
            // 
            // DeleteInvoiceBtn
            // 
            DeleteInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceBtn.Location = new Point(135, 296);
            DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            DeleteInvoiceBtn.Size = new Size(183, 52);
            DeleteInvoiceBtn.TabIndex = 13;
            DeleteInvoiceBtn.Text = "مسح من الفاتورة";
            DeleteInvoiceBtn.UseVisualStyleBackColor = false;
            DeleteInvoiceBtn.Click += DeleteInvoiceBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1286, 296);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ExtractInvoiceBtn
            // 
            ExtractInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            ExtractInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ExtractInvoiceBtn.Location = new Point(1150, 296);
            ExtractInvoiceBtn.Name = "ExtractInvoiceBtn";
            ExtractInvoiceBtn.Size = new Size(130, 52);
            ExtractInvoiceBtn.TabIndex = 11;
            ExtractInvoiceBtn.Text = "استخراج";
            ExtractInvoiceBtn.UseVisualStyleBackColor = false;
            ExtractInvoiceBtn.Click += ExtractInvoiceBtn_Click;
            // 
            // AddCustomerImg
            // 
            AddCustomerImg.Image = (Image)resources.GetObject("AddCustomerImg.Image");
            AddCustomerImg.Location = new Point(641, 296);
            AddCustomerImg.Name = "AddCustomerImg";
            AddCustomerImg.Size = new Size(64, 52);
            AddCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCustomerImg.TabIndex = 8;
            AddCustomerImg.TabStop = false;
            AddCustomerImg.Click += AddInvoiceBtn_Click;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(469, 296);
            AddInvoiceBtn.Name = "AddInvoiceBtn";
            AddInvoiceBtn.Size = new Size(166, 52);
            AddInvoiceBtn.TabIndex = 7;
            AddInvoiceBtn.Text = "اضافة الى الفاتورة ";
            AddInvoiceBtn.UseVisualStyleBackColor = false;
            AddInvoiceBtn.Click += AddInvoiceBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(244, 244, 244);
            label6.Location = new Point(1292, 69);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 10;
            label6.Text = "المنتج";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.FromArgb(244, 244, 244);
            label5.Location = new Point(617, 69);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 10;
            label5.Text = "المشتري";
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.BackColor = Color.FromArgb(244, 244, 244);
            ProductQuantityNumeric.Location = new Point(995, 165);
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(242, 27);
            ProductQuantityNumeric.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(244, 244, 244);
            label3.Location = new Point(573, 174);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 3;
            label3.Text = "اجمالي السعر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(244, 244, 244);
            label2.Location = new Point(1279, 160);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "الكمية  ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductsDropdownList
            // 
            ProductsDropdownList.BackColor = SystemColors.ActiveCaption;
            ProductsDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductsDropdownList.FormattingEnabled = true;
            ProductsDropdownList.Items.AddRange(new object[] { "Product1", "Product2", "Product3" });
            ProductsDropdownList.Location = new Point(995, 73);
            ProductsDropdownList.Name = "ProductsDropdownList";
            ProductsDropdownList.Size = new Size(242, 28);
            ProductsDropdownList.TabIndex = 1;
            // 
            // CustomersDropdownList
            // 
            CustomersDropdownList.BackColor = SystemColors.ActiveCaption;
            CustomersDropdownList.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersDropdownList.FormattingEnabled = true;
            CustomersDropdownList.Items.AddRange(new object[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "" });
            CustomersDropdownList.Location = new Point(306, 73);
            CustomersDropdownList.Name = "CustomersDropdownList";
            CustomersDropdownList.Size = new Size(242, 28);
            CustomersDropdownList.TabIndex = 0;
            // 
            // SalesInvoiceGridView
            // 
            SalesInvoiceGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            SalesInvoiceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            SalesInvoiceGridView.Anchor = AnchorStyles.None;
            SalesInvoiceGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesInvoiceGridView.BorderStyle = BorderStyle.None;
            SalesInvoiceGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SalesInvoiceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SalesInvoiceGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SalesInvoiceGridView.DefaultCellStyle = dataGridViewCellStyle3;
            SalesInvoiceGridView.EnableHeadersVisualStyles = false;
            SalesInvoiceGridView.Location = new Point(12, 537);
            SalesInvoiceGridView.MaximumSize = new Size(1502, 243);
            SalesInvoiceGridView.Name = "SalesInvoiceGridView";
            SalesInvoiceGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            SalesInvoiceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            SalesInvoiceGridView.RowHeadersVisible = false;
            SalesInvoiceGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            SalesInvoiceGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            SalesInvoiceGridView.ScrollBars = ScrollBars.Vertical;
            SalesInvoiceGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalesInvoiceGridView.Size = new Size(1502, 243);
            SalesInvoiceGridView.TabIndex = 16;
            // 
            // quantityErrorMsg
            // 
            quantityErrorMsg.AutoSize = true;
            quantityErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityErrorMsg.ForeColor = Color.Red;
            quantityErrorMsg.Location = new Point(1065, 207);
            quantityErrorMsg.Name = "quantityErrorMsg";
            quantityErrorMsg.Size = new Size(172, 28);
            quantityErrorMsg.TabIndex = 48;
            quantityErrorMsg.Text = "الكمية المتاحة حاليا ";
            quantityErrorMsg.Visible = false;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 774);
            Controls.Add(SalesInvoiceGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاتورة مبيعات";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TotalPriceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalesInvoiceGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox CustomersDropdownList;
        private ComboBox ProductsDropdownList;
        private NumericUpDown ProductQuantityNumeric;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox1;
        private Button ExtractInvoiceBtn;
        private PictureBox AddCustomerImg;
        private Button AddInvoiceBtn;
        private PictureBox LogOutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
        private PictureBox PrevFormBtn;
        private PictureBox DeleteCustomerImg;
        private Button DeleteInvoiceBtn;
        private NumericUpDown TotalPriceNumeric;
        private DataGridView SalesInvoiceGridView;
        private Label PrintErrorMsg;
        private Label quantityErrorMsg;
    }
}