namespace Carvo.User_Interface_Layer
{
    partial class RepairInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairInvoiceForm));
            panel2 = new Panel();
            PrintErrorMsg = new Label();
            PaidPriceErrorMsg = new Label();
            label11 = new Label();
            PaidMoneyNumeric = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            RestMoneyLabel = new Label();
            label10 = new Label();
            PaidMoneyLabel = new Label();
            label4 = new Label();
            TotalPriceLabel = new Label();
            label9 = new Label();
            VehicleNameLabel = new Label();
            label8 = new Label();
            CustomerNameLabel = new Label();
            label2 = new Label();
            CustomersFilterTxt = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            DeleteCustomerImg = new PictureBox();
            DeleteInvoiceBtn = new Button();
            PrintInvoiceImg = new PictureBox();
            PrintInvoice = new Button();
            UpdateInvoiceImg = new PictureBox();
            UpdateInvoiceBtn = new Button();
            AddInvoiceImg = new PictureBox();
            AddInvoiceBtn = new Button();
            RepairPriceNumeric = new NumericUpDown();
            VehicleDropDownList = new ComboBox();
            CustomerDropdowwnList = new ComboBox();
            panel1 = new Panel();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            PrevFormBtn = new PictureBox();
            LogOutBtn = new PictureBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaidMoneyNumeric).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrintInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RepairPriceNumeric).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(PrintErrorMsg);
            panel2.Controls.Add(PaidPriceErrorMsg);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(PaidMoneyNumeric);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CustomersFilterTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(DeleteCustomerImg);
            panel2.Controls.Add(DeleteInvoiceBtn);
            panel2.Controls.Add(PrintInvoiceImg);
            panel2.Controls.Add(PrintInvoice);
            panel2.Controls.Add(UpdateInvoiceImg);
            panel2.Controls.Add(UpdateInvoiceBtn);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(RepairPriceNumeric);
            panel2.Controls.Add(VehicleDropDownList);
            panel2.Controls.Add(CustomerDropdowwnList);
            panel2.Location = new Point(0, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1508, 712);
            panel2.TabIndex = 6;
            // 
            // PrintErrorMsg
            // 
            PrintErrorMsg.AutoSize = true;
            PrintErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrintErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            PrintErrorMsg.Location = new Point(1007, 425);
            PrintErrorMsg.Name = "PrintErrorMsg";
            PrintErrorMsg.Size = new Size(201, 28);
            PrintErrorMsg.TabIndex = 46;
            PrintErrorMsg.Text = "يجب اضافة الفاتورة اولا";
            PrintErrorMsg.Visible = false;
            // 
            // PaidPriceErrorMsg
            // 
            PaidPriceErrorMsg.AutoSize = true;
            PaidPriceErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaidPriceErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            PaidPriceErrorMsg.Location = new Point(141, 268);
            PaidPriceErrorMsg.Name = "PaidPriceErrorMsg";
            PaidPriceErrorMsg.Size = new Size(435, 28);
            PaidPriceErrorMsg.TabIndex = 45;
            PaidPriceErrorMsg.Text = "المبلغ المدفوع يجب ان يكون اقل من السعر الاجمالي";
            PaidPriceErrorMsg.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label11.ForeColor = Color.FromArgb(244, 244, 244);
            label11.Location = new Point(621, 218);
            label11.Name = "label11";
            label11.Size = new Size(145, 28);
            label11.TabIndex = 44;
            label11.Text = "المبلغ المدفوع :";
            // 
            // PaidMoneyNumeric
            // 
            PaidMoneyNumeric.Font = new Font("Segoe UI", 12F);
            PaidMoneyNumeric.Location = new Point(267, 218);
            PaidMoneyNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            PaidMoneyNumeric.Name = "PaidMoneyNumeric";
            PaidMoneyNumeric.Size = new Size(309, 34);
            PaidMoneyNumeric.TabIndex = 43;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(RestMoneyLabel, 4, 1);
            tableLayoutPanel1.Controls.Add(label10, 4, 0);
            tableLayoutPanel1.Controls.Add(PaidMoneyLabel, 3, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(TotalPriceLabel, 2, 1);
            tableLayoutPanel1.Controls.Add(label9, 3, 0);
            tableLayoutPanel1.Controls.Add(VehicleNameLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 2, 0);
            tableLayoutPanel1.Controls.Add(CustomerNameLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(97, 566);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1341, 97);
            tableLayoutPanel1.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(244, 244, 244);
            label3.Location = new Point(1210, 3);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 32;
            label3.Text = "اسم العميل : ";
            // 
            // RestMoneyLabel
            // 
            RestMoneyLabel.AutoSize = true;
            RestMoneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            RestMoneyLabel.ForeColor = Color.FromArgb(244, 244, 244);
            RestMoneyLabel.Location = new Point(267, 50);
            RestMoneyLabel.Name = "RestMoneyLabel";
            RestMoneyLabel.Size = new Size(0, 28);
            RestMoneyLabel.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label10.ForeColor = Color.FromArgb(244, 244, 244);
            label10.Location = new Point(117, 3);
            label10.Name = "label10";
            label10.Size = new Size(150, 28);
            label10.TabIndex = 36;
            label10.Text = "المبلغ المتبقي : ";
            // 
            // PaidMoneyLabel
            // 
            PaidMoneyLabel.AutoSize = true;
            PaidMoneyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            PaidMoneyLabel.ForeColor = Color.FromArgb(244, 244, 244);
            PaidMoneyLabel.Location = new Point(534, 50);
            PaidMoneyLabel.Name = "PaidMoneyLabel";
            PaidMoneyLabel.Size = new Size(0, 28);
            PaidMoneyLabel.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.FromArgb(244, 244, 244);
            label4.Location = new Point(947, 3);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 33;
            label4.Text = "نوع المركبة : ";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.AutoSize = true;
            TotalPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            TotalPriceLabel.ForeColor = Color.FromArgb(244, 244, 244);
            TotalPriceLabel.Location = new Point(801, 50);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(0, 28);
            TotalPriceLabel.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label9.ForeColor = Color.FromArgb(244, 244, 244);
            label9.Location = new Point(383, 3);
            label9.Name = "label9";
            label9.Size = new Size(151, 28);
            label9.TabIndex = 35;
            label9.Text = "المبلغ المدفوع : ";
            // 
            // VehicleNameLabel
            // 
            VehicleNameLabel.AutoSize = true;
            VehicleNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            VehicleNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            VehicleNameLabel.Location = new Point(1068, 50);
            VehicleNameLabel.Name = "VehicleNameLabel";
            VehicleNameLabel.Size = new Size(0, 28);
            VehicleNameLabel.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label8.ForeColor = Color.FromArgb(244, 244, 244);
            label8.Location = new Point(647, 3);
            label8.Name = "label8";
            label8.Size = new Size(154, 28);
            label8.TabIndex = 34;
            label8.Text = "السعر الاجمالي : ";
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            CustomerNameLabel.ForeColor = Color.FromArgb(244, 244, 244);
            CustomerNameLabel.Location = new Point(1335, 50);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(0, 28);
            CustomerNameLabel.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(244, 244, 244);
            label2.Location = new Point(1083, 51);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 31;
            label2.Text = "تصفية العملاء بالاسم";
            // 
            // CustomersFilterTxt
            // 
            CustomersFilterTxt.Font = new Font("Segoe UI", 12F);
            CustomersFilterTxt.Location = new Point(961, 92);
            CustomersFilterTxt.Name = "CustomersFilterTxt";
            CustomersFilterTxt.Size = new Size(309, 34);
            CustomersFilterTxt.TabIndex = 30;
            CustomersFilterTxt.TextChanged += CustomersFilterTxt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.FromArgb(244, 244, 244);
            label5.Location = new Point(640, 133);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 29;
            label5.Text = "سعر الصيانة :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label7.ForeColor = Color.FromArgb(244, 244, 244);
            label7.Location = new Point(1359, 143);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 28;
            label7.Text = "العميل :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(244, 244, 244);
            label6.Location = new Point(646, 46);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 27;
            label6.Text = "نوع المركبة : ";
            // 
            // DeleteCustomerImg
            // 
            DeleteCustomerImg.Image = (Image)resources.GetObject("DeleteCustomerImg.Image");
            DeleteCustomerImg.Location = new Point(233, 414);
            DeleteCustomerImg.Name = "DeleteCustomerImg";
            DeleteCustomerImg.Size = new Size(64, 52);
            DeleteCustomerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCustomerImg.TabIndex = 26;
            DeleteCustomerImg.TabStop = false;
            DeleteCustomerImg.Click += DeleteInvoiceBtn_Click;
            // 
            // DeleteInvoiceBtn
            // 
            DeleteInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceBtn.Location = new Point(97, 414);
            DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            DeleteInvoiceBtn.Size = new Size(130, 52);
            DeleteInvoiceBtn.TabIndex = 25;
            DeleteInvoiceBtn.Text = "مسح فاتورة";
            DeleteInvoiceBtn.UseVisualStyleBackColor = false;
            DeleteInvoiceBtn.Click += DeleteInvoiceBtn_Click;
            // 
            // PrintInvoiceImg
            // 
            PrintInvoiceImg.Image = (Image)resources.GetObject("PrintInvoiceImg.Image");
            PrintInvoiceImg.Location = new Point(1350, 414);
            PrintInvoiceImg.Name = "PrintInvoiceImg";
            PrintInvoiceImg.Size = new Size(64, 52);
            PrintInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            PrintInvoiceImg.TabIndex = 24;
            PrintInvoiceImg.TabStop = false;
            // 
            // PrintInvoice
            // 
            PrintInvoice.BackColor = Color.FromArgb(224, 224, 224);
            PrintInvoice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            PrintInvoice.Location = new Point(1214, 414);
            PrintInvoice.Name = "PrintInvoice";
            PrintInvoice.Size = new Size(130, 52);
            PrintInvoice.TabIndex = 23;
            PrintInvoice.Text = "طباعة";
            PrintInvoice.UseVisualStyleBackColor = false;
            PrintInvoice.Click += PrintInvoice_Click;
            // 
            // UpdateInvoiceImg
            // 
            UpdateInvoiceImg.Image = (Image)resources.GetObject("UpdateInvoiceImg.Image");
            UpdateInvoiceImg.Location = new Point(512, 414);
            UpdateInvoiceImg.Name = "UpdateInvoiceImg";
            UpdateInvoiceImg.Size = new Size(64, 52);
            UpdateInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateInvoiceImg.TabIndex = 22;
            UpdateInvoiceImg.TabStop = false;
            UpdateInvoiceImg.Click += UpdateInvoiceBtn_Click;
            // 
            // UpdateInvoiceBtn
            // 
            UpdateInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateInvoiceBtn.Location = new Point(376, 414);
            UpdateInvoiceBtn.Name = "UpdateInvoiceBtn";
            UpdateInvoiceBtn.Size = new Size(130, 52);
            UpdateInvoiceBtn.TabIndex = 21;
            UpdateInvoiceBtn.Text = "تحديث فاتورة";
            UpdateInvoiceBtn.UseVisualStyleBackColor = false;
            UpdateInvoiceBtn.Click += UpdateInvoiceBtn_Click;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(782, 414);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 20;
            AddInvoiceImg.TabStop = false;
            AddInvoiceImg.Click += AddInvoiceBtn_Click;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(646, 414);
            AddInvoiceBtn.Name = "AddInvoiceBtn";
            AddInvoiceBtn.Size = new Size(130, 52);
            AddInvoiceBtn.TabIndex = 19;
            AddInvoiceBtn.Text = "اضافة فاتورة ";
            AddInvoiceBtn.UseVisualStyleBackColor = false;
            AddInvoiceBtn.Click += AddInvoiceBtn_Click;
            // 
            // RepairPriceNumeric
            // 
            RepairPriceNumeric.Font = new Font("Segoe UI", 12F);
            RepairPriceNumeric.Location = new Point(268, 134);
            RepairPriceNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            RepairPriceNumeric.Name = "RepairPriceNumeric";
            RepairPriceNumeric.Size = new Size(309, 34);
            RepairPriceNumeric.TabIndex = 17;
            // 
            // VehicleDropDownList
            // 
            VehicleDropDownList.BackColor = SystemColors.ActiveCaption;
            VehicleDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            VehicleDropDownList.Font = new Font("Segoe UI", 12F);
            VehicleDropDownList.FormattingEnabled = true;
            VehicleDropDownList.Items.AddRange(new object[] { "عربية ", "موتوسيكل ", "عجلة" });
            VehicleDropDownList.Location = new Point(268, 50);
            VehicleDropDownList.Name = "VehicleDropDownList";
            VehicleDropDownList.Size = new Size(309, 36);
            VehicleDropDownList.TabIndex = 1;
            // 
            // CustomerDropdowwnList
            // 
            CustomerDropdowwnList.BackColor = SystemColors.ActiveCaption;
            CustomerDropdowwnList.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerDropdowwnList.Font = new Font("Segoe UI", 12F);
            CustomerDropdowwnList.FormattingEnabled = true;
            CustomerDropdowwnList.Items.AddRange(new object[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "" });
            CustomerDropdowwnList.Location = new Point(961, 147);
            CustomerDropdowwnList.Name = "CustomerDropdowwnList";
            CustomerDropdowwnList.Size = new Size(309, 36);
            CustomerDropdowwnList.TabIndex = 0;
            CustomerDropdowwnList.SelectedIndexChanged += CustomerDropdowwnList_SelectedIndexChanged;
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
            panel1.Size = new Size(1510, 113);
            panel1.TabIndex = 5;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1426, 29);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 13;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1327, 29);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 12;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // PrevFormBtn
            // 
            PrevFormBtn.Image = (Image)resources.GetObject("PrevFormBtn.Image");
            PrevFormBtn.Location = new Point(119, 34);
            PrevFormBtn.Name = "PrevFormBtn";
            PrevFormBtn.Size = new Size(45, 45);
            PrevFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevFormBtn.TabIndex = 11;
            PrevFormBtn.TabStop = false;
            PrevFormBtn.Click += PrevFormBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Image = (Image)resources.GetObject("LogOutBtn.Image");
            LogOutBtn.Location = new Point(33, 34);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(45, 45);
            LogOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogOutBtn.TabIndex = 10;
            LogOutBtn.TabStop = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(633, 25);
            label1.Name = "label1";
            label1.Size = new Size(238, 54);
            label1.TabIndex = 9;
            label1.Text = "فاتورة صيانة ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RepairInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 829);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RepairInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاتورة صيانة";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaidMoneyNumeric).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteCustomerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrintInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)RepairPriceNumeric).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private ComboBox VehicleDropDownList;
        private ComboBox CustomerDropdowwnList;
        private Panel panel1;
        private NumericUpDown RepairPriceNumeric;
        private PictureBox DeleteCustomerImg;
        private Button DeleteInvoiceBtn;
        private PictureBox PrintInvoiceImg;
        private Button PrintInvoice;
        private PictureBox UpdateInvoiceImg;
        private Button UpdateInvoiceBtn;
        private PictureBox AddInvoiceImg;
        private Button AddInvoiceBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
        private PictureBox PrevFormBtn;
        private PictureBox LogOutBtn;
        private Label label1;
        private Label label7;
        private Label label6;
        private TextBox CustomersFilterTxt;
        private Label label5;
        private Label label2;
        private Label RestMoneyLabel;
        private Label PaidMoneyLabel;
        private Label TotalPriceLabel;
        private Label VehicleNameLabel;
        private Label CustomerNameLabel;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private NumericUpDown PaidMoneyNumeric;
        private Label PaidPriceErrorMsg;
        private Label PrintErrorMsg;
    }
}