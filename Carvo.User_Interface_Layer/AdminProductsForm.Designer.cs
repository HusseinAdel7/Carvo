namespace Carvo.User_Interface_Layer
{
    partial class AdminProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductsForm));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LogoutImgBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            label7 = new Label();
            FliterSuppliersTxt = new TextBox();
            ProdQuantityErrorMsg = new Label();
            ProdPriceErrorMsg = new Label();
            ProdDescErrorMsg = new Label();
            ProdNameErrorMsg = new Label();
            label6 = new Label();
            SupplierNameDropdownList = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            ProductQuantityNumeric = new NumericUpDown();
            CategoriesDeopdownList = new ComboBox();
            ProductPriceNumeric = new NumericUpDown();
            ProductDescTxt = new TextBox();
            ProductNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateProductBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddProductBtn = new Button();
            DeleteProductBtn = new Button();
            ProductsGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutImgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(ProductsGridView, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 460F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1510, 829);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(LogoutImgBtn);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 127);
            panel1.TabIndex = 0;
            // 
            // LogoutImgBtn
            // 
            LogoutImgBtn.Image = (Image)resources.GetObject("LogoutImgBtn.Image");
            LogoutImgBtn.Location = new Point(45, 28);
            LogoutImgBtn.Name = "LogoutImgBtn";
            LogoutImgBtn.Size = new Size(45, 45);
            LogoutImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutImgBtn.TabIndex = 4;
            LogoutImgBtn.TabStop = false;
            LogoutImgBtn.Click += LogoutImgBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1393, 23);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 3;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(1304, 23);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(50, 50);
            MinimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeBtn.TabIndex = 2;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(127, 28);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(45, 45);
            PrevImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImageAsBtn.TabIndex = 1;
            PrevImageAsBtn.TabStop = false;
            PrevImageAsBtn.Click += PrevImageAsBtn_Click;
            // 
            // CategoriesManagement
            // 
            CategoriesManagement.AutoSize = true;
            CategoriesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesManagement.Location = new Point(659, 35);
            CategoriesManagement.Name = "CategoriesManagement";
            CategoriesManagement.Size = new Size(176, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة المنتجات";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(FliterSuppliersTxt);
            panel2.Controls.Add(ProdQuantityErrorMsg);
            panel2.Controls.Add(ProdPriceErrorMsg);
            panel2.Controls.Add(ProdDescErrorMsg);
            panel2.Controls.Add(ProdNameErrorMsg);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(SupplierNameDropdownList);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ProductQuantityNumeric);
            panel2.Controls.Add(CategoriesDeopdownList);
            panel2.Controls.Add(ProductPriceNumeric);
            panel2.Controls.Add(ProductDescTxt);
            panel2.Controls.Add(ProductNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateProductBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddProductBtn);
            panel2.Controls.Add(DeleteProductBtn);
            panel2.Location = new Point(4, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 454);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(213, 9);
            label7.Name = "label7";
            label7.Size = new Size(194, 28);
            label7.TabIndex = 25;
            label7.Text = "تصفية قائمة الموزعين";
            // 
            // FliterSuppliersTxt
            // 
            FliterSuppliersTxt.Font = new Font("Segoe UI", 12F);
            FliterSuppliersTxt.Location = new Point(126, 49);
            FliterSuppliersTxt.Name = "FliterSuppliersTxt";
            FliterSuppliersTxt.Size = new Size(281, 34);
            FliterSuppliersTxt.TabIndex = 24;
            FliterSuppliersTxt.TextChanged += FliterSuppliersTxt_TextChanged;
            // 
            // ProdQuantityErrorMsg
            // 
            ProdQuantityErrorMsg.AutoSize = true;
            ProdQuantityErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            ProdQuantityErrorMsg.Location = new Point(299, 329);
            ProdQuantityErrorMsg.Name = "ProdQuantityErrorMsg";
            ProdQuantityErrorMsg.Size = new Size(108, 20);
            ProdQuantityErrorMsg.TabIndex = 23;
            ProdQuantityErrorMsg.Text = "الكمية كبيرة جدا";
            ProdQuantityErrorMsg.Visible = false;
            // 
            // ProdPriceErrorMsg
            // 
            ProdPriceErrorMsg.AutoSize = true;
            ProdPriceErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            ProdPriceErrorMsg.Location = new Point(273, 193);
            ProdPriceErrorMsg.Name = "ProdPriceErrorMsg";
            ProdPriceErrorMsg.Size = new Size(134, 20);
            ProdPriceErrorMsg.TabIndex = 22;
            ProdPriceErrorMsg.Text = "سعر المنتج عال جدا ";
            ProdPriceErrorMsg.Visible = false;
            // 
            // ProdDescErrorMsg
            // 
            ProdDescErrorMsg.AutoSize = true;
            ProdDescErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            ProdDescErrorMsg.Location = new Point(1096, 304);
            ProdDescErrorMsg.Name = "ProdDescErrorMsg";
            ProdDescErrorMsg.Size = new Size(151, 20);
            ProdDescErrorMsg.TabIndex = 21;
            ProdDescErrorMsg.Text = "وصف المنتج قصير جدا";
            ProdDescErrorMsg.Visible = false;
            // 
            // ProdNameErrorMsg
            // 
            ProdNameErrorMsg.AutoSize = true;
            ProdNameErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            ProdNameErrorMsg.Location = new Point(1108, 95);
            ProdNameErrorMsg.Name = "ProdNameErrorMsg";
            ProdNameErrorMsg.Size = new Size(139, 20);
            ProdNameErrorMsg.TabIndex = 20;
            ProdNameErrorMsg.Text = "اسم المنتج قصير جدا";
            ProdNameErrorMsg.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(459, 95);
            label6.Name = "label6";
            label6.Size = new Size(129, 28);
            label6.TabIndex = 19;
            label6.Text = " : اسم الموزع ";
            // 
            // SupplierNameDropdownList
            // 
            SupplierNameDropdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            SupplierNameDropdownList.FormattingEnabled = true;
            SupplierNameDropdownList.Location = new Point(126, 95);
            SupplierNameDropdownList.Name = "SupplierNameDropdownList";
            SupplierNameDropdownList.Size = new Size(281, 31);
            SupplierNameDropdownList.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(464, 161);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 17;
            label3.Text = " : سعر المنتج ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(502, 294);
            label5.Name = "label5";
            label5.Size = new Size(86, 28);
            label5.TabIndex = 16;
            label5.Text = " : الكمية ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(459, 223);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 15;
            label4.Text = " : اسم الصنف ";
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProductQuantityNumeric.Location = new Point(126, 296);
            ProductQuantityNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(281, 30);
            ProductQuantityNumeric.TabIndex = 13;
            ProductQuantityNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoriesDeopdownList
            // 
            CategoriesDeopdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            CategoriesDeopdownList.FormattingEnabled = true;
            CategoriesDeopdownList.Location = new Point(126, 227);
            CategoriesDeopdownList.Name = "CategoriesDeopdownList";
            CategoriesDeopdownList.Size = new Size(281, 31);
            CategoriesDeopdownList.TabIndex = 12;
            // 
            // ProductPriceNumeric
            // 
            ProductPriceNumeric.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProductPriceNumeric.Location = new Point(126, 160);
            ProductPriceNumeric.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            ProductPriceNumeric.Name = "ProductPriceNumeric";
            ProductPriceNumeric.Size = new Size(281, 30);
            ProductPriceNumeric.TabIndex = 11;
            ProductPriceNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductDescTxt
            // 
            ProductDescTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDescTxt.Location = new Point(767, 129);
            ProductDescTxt.Multiline = true;
            ProductDescTxt.Name = "ProductDescTxt";
            ProductDescTxt.Size = new Size(480, 172);
            ProductDescTxt.TabIndex = 10;
            ProductDescTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // ProductNameTxt
            // 
            ProductNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductNameTxt.Location = new Point(767, 53);
            ProductNameTxt.Multiline = true;
            ProductNameTxt.Name = "ProductNameTxt";
            ProductNameTxt.Size = new Size(480, 39);
            ProductNameTxt.TabIndex = 9;
            ProductNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1332, 132);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 8;
            label2.Text = " : الوصف ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1304, 53);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 7;
            label1.Text = " : اسم المنتج ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += UpdateProductBtn_Click;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateProductBtn.Location = new Point(685, 376);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(130, 52);
            UpdateProductBtn.TabIndex = 5;
            UpdateProductBtn.Text = "تحديث منتج";
            UpdateProductBtn.UseVisualStyleBackColor = false;
            UpdateProductBtn.Click += UpdateProductBtn_Click;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(436, 376);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            DeleteInvoiceImg.Click += DeleteProductBtn_Click;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1211, 376);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            AddInvoiceImg.Click += AddProductBtn_Click;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddProductBtn.Location = new Point(1075, 376);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(130, 52);
            AddProductBtn.TabIndex = 2;
            AddProductBtn.Text = "اضافة منتج ";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteProductBtn.Location = new Point(300, 376);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(130, 52);
            DeleteProductBtn.TabIndex = 1;
            DeleteProductBtn.Text = "مسح منتج";
            DeleteProductBtn.UseVisualStyleBackColor = false;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // ProductsGridView
            // 
            ProductsGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            ProductsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            ProductsGridView.Anchor = AnchorStyles.None;
            ProductsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsGridView.BorderStyle = BorderStyle.None;
            ProductsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ProductsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            ProductsGridView.DefaultCellStyle = dataGridViewCellStyle8;
            ProductsGridView.EnableHeadersVisualStyles = false;
            ProductsGridView.Location = new Point(4, 596);
            ProductsGridView.MaximumSize = new Size(1502, 243);
            ProductsGridView.Name = "ProductsGridView";
            ProductsGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ProductsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            ProductsGridView.RowHeadersVisible = false;
            ProductsGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            ProductsGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            ProductsGridView.ScrollBars = ScrollBars.Vertical;
            ProductsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsGridView.Size = new Size(1502, 243);
            ProductsGridView.TabIndex = 2;
            ProductsGridView.SelectionChanged += ProductsGridView_SelectionChanged;
            // 
            // AdminProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1510, 829);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1526, 885);
            Name = "AdminProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutImgBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductQuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductPriceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddProductBtn;
        private Button DeleteProductBtn;
        private DataGridView ProductsGridView;
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button UpdateProductBtn;
        private TextBox ProductDescTxt;
        private TextBox ProductNameTxt;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private NumericUpDown ProductQuantityNumeric;
        private ComboBox CategoriesDeopdownList;
        private NumericUpDown ProductPriceNumeric;
        private Label label6;
        private ComboBox SupplierNameDropdownList;
        private PictureBox LogoutImgBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeBtn;
        private Label ProdDescErrorMsg;
        private Label ProdNameErrorMsg;
        private Label ProdQuantityErrorMsg;
        private Label ProdPriceErrorMsg;
        private TextBox FliterSuppliersTxt;
        private Label label7;
    }
}