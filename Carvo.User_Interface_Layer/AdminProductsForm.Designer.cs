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
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            ProductQuantityNumeric = new NumericUpDown();
            CategoriesDeopdownList = new ComboBox();
            ProductPriceNumeric = new NumericUpDown();
            CategoryDescTxt = new TextBox();
            CategorynameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateProductBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddProductBtn = new Button();
            DeleteProductBtn = new Button();
            ProductsGridView = new DataGridView();
            label6 = new Label();
            SupplierNameDropdownList = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            CategoriesManagement.Size = new Size(176, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة المنتجات";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(SupplierNameDropdownList);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ProductQuantityNumeric);
            panel2.Controls.Add(CategoriesDeopdownList);
            panel2.Controls.Add(ProductPriceNumeric);
            panel2.Controls.Add(CategoryDescTxt);
            panel2.Controls.Add(CategorynameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateProductBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddProductBtn);
            panel2.Controls.Add(DeleteProductBtn);
            panel2.Location = new Point(60, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 432);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(464, 52);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 17;
            label3.Text = " : سعر المنتج ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(502, 196);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 16;
            label5.Text = " : الكمية ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(459, 125);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 15;
            label4.Text = " : اسم الصنف ";
            // 
            // ProductQuantityNumeric
            // 
            ProductQuantityNumeric.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProductQuantityNumeric.Location = new Point(126, 198);
            ProductQuantityNumeric.Name = "ProductQuantityNumeric";
            ProductQuantityNumeric.Size = new Size(281, 30);
            ProductQuantityNumeric.TabIndex = 13;
            ProductQuantityNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoriesDeopdownList
            // 
            CategoriesDeopdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            CategoriesDeopdownList.FormattingEnabled = true;
            CategoriesDeopdownList.Location = new Point(126, 129);
            CategoriesDeopdownList.Name = "CategoriesDeopdownList";
            CategoriesDeopdownList.Size = new Size(281, 31);
            CategoriesDeopdownList.TabIndex = 12;
            // 
            // ProductPriceNumeric
            // 
            ProductPriceNumeric.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            ProductPriceNumeric.Location = new Point(126, 51);
            ProductPriceNumeric.Name = "ProductPriceNumeric";
            ProductPriceNumeric.Size = new Size(281, 30);
            ProductPriceNumeric.TabIndex = 11;
            ProductPriceNumeric.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryDescTxt
            // 
            CategoryDescTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDescTxt.Location = new Point(689, 127);
            CategoryDescTxt.Multiline = true;
            CategoryDescTxt.Name = "CategoryDescTxt";
            CategoryDescTxt.Size = new Size(480, 172);
            CategoryDescTxt.TabIndex = 10;
            CategoryDescTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // CategorynameTxt
            // 
            CategorynameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategorynameTxt.Location = new Point(689, 51);
            CategorynameTxt.Multiline = true;
            CategorynameTxt.Name = "CategorynameTxt";
            CategorynameTxt.Size = new Size(480, 39);
            CategorynameTxt.TabIndex = 9;
            CategorynameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1255, 125);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 8;
            label2.Text = " : الوصف ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1222, 52);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 7;
            label1.Text = " : اسم المنتج ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(714, 340);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UpdateProductBtn
            // 
            UpdateProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateProductBtn.Location = new Point(578, 340);
            UpdateProductBtn.Name = "UpdateProductBtn";
            UpdateProductBtn.Size = new Size(130, 52);
            UpdateProductBtn.TabIndex = 5;
            UpdateProductBtn.Text = "تحديث منتج";
            UpdateProductBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(329, 340);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1104, 340);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddProductBtn.Location = new Point(968, 340);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(130, 52);
            AddProductBtn.TabIndex = 2;
            AddProductBtn.Text = "اضافة منتج ";
            AddProductBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteProductBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteProductBtn.Location = new Point(193, 340);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(130, 52);
            DeleteProductBtn.TabIndex = 1;
            DeleteProductBtn.Text = "مسح منتج";
            DeleteProductBtn.UseVisualStyleBackColor = false;
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
            ProductsGridView.Location = new Point(60, 583);
            ProductsGridView.MaximumSize = new Size(1387, 285);
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
            ProductsGridView.Size = new Size(1387, 234);
            ProductsGridView.TabIndex = 2;
            ProductsGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(459, 268);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 19;
            label6.Text = " : اسم الموزع ";
            // 
            // SupplierNameDropdownList
            // 
            SupplierNameDropdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            SupplierNameDropdownList.FormattingEnabled = true;
            SupplierNameDropdownList.Location = new Point(126, 268);
            SupplierNameDropdownList.Name = "SupplierNameDropdownList";
            SupplierNameDropdownList.Size = new Size(281, 31);
            SupplierNameDropdownList.TabIndex = 18;
            // 
            // AdminProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1526, 885);
            Name = "AdminProductsForm";
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox CategoryDescTxt;
        private TextBox CategorynameTxt;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private NumericUpDown ProductQuantityNumeric;
        private ComboBox CategoriesDeopdownList;
        private NumericUpDown ProductPriceNumeric;
        private Label label6;
        private ComboBox SupplierNameDropdownList;
    }
}