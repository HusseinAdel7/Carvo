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
            label1 = new Label();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            PrevFormBtn = new PictureBox();
            LogOutBtn = new PictureBox();
            panel2 = new Panel();
            DeleteCustomerImg = new PictureBox();
            DeleteInvoiceBtn = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            UpdateCustomerImg = new PictureBox();
            UpdateInvoiceBtn = new Button();
            AddCustomerImg = new PictureBox();
            AddInvoiceBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SalesInvoiceGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalesInvoiceGridView1).BeginInit();
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
            panel1.MouseDown += panel1_MouseDown;
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
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(DeleteCustomerImg);
            panel2.Controls.Add(DeleteInvoiceBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(UpdateCustomerImg);
            panel2.Controls.Add(UpdateInvoiceBtn);
            panel2.Controls.Add(AddCustomerImg);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(0, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(1526, 408);
            panel2.TabIndex = 4;
            // 
            // DeleteCustomerImg
            // 
            DeleteCustomerImg.Image = (Image)resources.GetObject("DeleteCustomerImg.Image");
            DeleteCustomerImg.Location = new Point(226, 274);
            DeleteCustomerImg.Name = "DeleteCustomerImg";
            DeleteCustomerImg.Size = new Size(64, 52);
            DeleteCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCustomerImg.TabIndex = 14;
            DeleteCustomerImg.TabStop = false;
            // 
            // DeleteInvoiceBtn
            // 
            DeleteInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceBtn.Location = new Point(90, 274);
            DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            DeleteInvoiceBtn.Size = new Size(130, 52);
            DeleteInvoiceBtn.TabIndex = 13;
            DeleteInvoiceBtn.Text = "مسح فاتورة";
            DeleteInvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1343, 274);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button3.Location = new Point(1207, 274);
            button3.Name = "button3";
            button3.Size = new Size(130, 52);
            button3.TabIndex = 11;
            button3.Text = "طباعة";
            button3.UseVisualStyleBackColor = false;
            // 
            // UpdateCustomerImg
            // 
            UpdateCustomerImg.Image = (Image)resources.GetObject("UpdateCustomerImg.Image");
            UpdateCustomerImg.Location = new Point(505, 274);
            UpdateCustomerImg.Name = "UpdateCustomerImg";
            UpdateCustomerImg.Size = new Size(64, 52);
            UpdateCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateCustomerImg.TabIndex = 10;
            UpdateCustomerImg.TabStop = false;
            // 
            // UpdateInvoiceBtn
            // 
            UpdateInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateInvoiceBtn.Location = new Point(369, 274);
            UpdateInvoiceBtn.Name = "UpdateInvoiceBtn";
            UpdateInvoiceBtn.Size = new Size(130, 52);
            UpdateInvoiceBtn.TabIndex = 9;
            UpdateInvoiceBtn.Text = "تحديث فاتورة";
            UpdateInvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // AddCustomerImg
            // 
            AddCustomerImg.Image = (Image)resources.GetObject("AddCustomerImg.Image");
            AddCustomerImg.Location = new Point(775, 274);
            AddCustomerImg.Name = "AddCustomerImg";
            AddCustomerImg.Size = new Size(64, 52);
            AddCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCustomerImg.TabIndex = 8;
            AddCustomerImg.TabStop = false;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(639, 274);
            AddInvoiceBtn.Name = "AddInvoiceBtn";
            AddInvoiceBtn.Size = new Size(130, 52);
            AddInvoiceBtn.TabIndex = 7;
            AddInvoiceBtn.Text = "اضافة فاتورة ";
            AddInvoiceBtn.UseVisualStyleBackColor = false;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(244, 244, 244);
            label4.Location = new Point(409, 182);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "1234";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(244, 244, 244);
            numericUpDown1.Location = new Point(995, 165);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(242, 27);
            numericUpDown1.TabIndex = 4;
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
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaption;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Product1", "Product2", "Product3" });
            comboBox2.Location = new Point(995, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "" });
            comboBox1.Location = new Point(306, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 28);
            comboBox1.TabIndex = 0;
            // 
            // SalesInvoiceGridView1
            // 
            SalesInvoiceGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesInvoiceGridView1.GridColor = Color.FromArgb(48, 67, 87);
            SalesInvoiceGridView1.Location = new Point(0, 547);
            SalesInvoiceGridView1.Name = "SalesInvoiceGridView1";
            SalesInvoiceGridView1.RowHeadersWidth = 51;
            SalesInvoiceGridView1.Size = new Size(1526, 203);
            SalesInvoiceGridView1.TabIndex = 5;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 774);
            Controls.Add(SalesInvoiceGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاتورة مبيعات";
            Load += SalesInvoiceForm_Load;
            Shown += SalesInvoiceForm_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalesInvoiceGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView SalesInvoiceGridView1;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox UpdateCustomerImg;
        private Button UpdateInvoiceBtn;
        private PictureBox AddCustomerImg;
        private Button AddInvoiceBtn;
        private PictureBox LogOutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
        private PictureBox PrevFormBtn;
        private PictureBox DeleteCustomerImg;
        private Button DeleteInvoiceBtn;
    }
}