namespace Carvo.User_Interface_Layer
{
    partial class InvoiceForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            HeaderPanel = new Panel();
            InvoiceDate = new Label();
            label1 = new Label();
            InvoiceID = new Label();
            Header_HR = new Label();
            Invoice = new Label();
            CompanyEmail = new Label();
            CompanyPhone = new Label();
            CompanyAddress = new Label();
            CompanyName = new Label();
            VehicleInfoPanel = new Panel();
            label9 = new Label();
            VehicleModel = new Label();
            VehiclePlate = new Label();
            label16 = new Label();
            VehicleVIN = new Label();
            VehicleInformation = new Label();
            label17 = new Label();
            label15 = new Label();
            CustomerInfoPanel = new Panel();
            label3 = new Label();
            CustomerName = new Label();
            CustomerPhone = new Label();
            CustomerMail = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            CustomerInformation = new Label();
            InvoiceInfoPanel = new Panel();
            label7 = new Label();
            EmployeeName = new Label();
            InvoiceType = new Label();
            label8 = new Label();
            InvoiceInformation = new Label();
            label2 = new Label();
            panel3 = new Panel();
            ProductsAndServices = new Label();
            ProductsServicesGrid = new DataGridView();
            panel4 = new Panel();
            label10 = new Label();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            SubTotal = new Label();
            LaborCost = new Label();
            Tax = new Label();
            TotalAmount = new Label();
            PaidAmount = new Label();
            RemainingAmount = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            tableLayoutPanel2.SuspendLayout();
            HeaderPanel.SuspendLayout();
            VehicleInfoPanel.SuspendLayout();
            CustomerInfoPanel.SuspendLayout();
            InvoiceInfoPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsServicesGrid).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 782F));
            tableLayoutPanel2.Controls.Add(HeaderPanel, 0, 0);
            tableLayoutPanel2.Controls.Add(VehicleInfoPanel, 0, 2);
            tableLayoutPanel2.Controls.Add(CustomerInfoPanel, 1, 1);
            tableLayoutPanel2.Controls.Add(InvoiceInfoPanel, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 3);
            tableLayoutPanel2.Controls.Add(ProductsServicesGrid, 0, 4);
            tableLayoutPanel2.Controls.Add(panel4, 0, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 184F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 154F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 258F));
            tableLayoutPanel2.Size = new Size(1508, 830);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel2.SetColumnSpan(HeaderPanel, 2);
            HeaderPanel.Controls.Add(InvoiceDate);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Controls.Add(InvoiceID);
            HeaderPanel.Controls.Add(Header_HR);
            HeaderPanel.Controls.Add(Invoice);
            HeaderPanel.Controls.Add(CompanyEmail);
            HeaderPanel.Controls.Add(CompanyPhone);
            HeaderPanel.Controls.Add(CompanyAddress);
            HeaderPanel.Controls.Add(CompanyName);
            HeaderPanel.Dock = DockStyle.Fill;
            HeaderPanel.ForeColor = Color.White;
            HeaderPanel.Location = new Point(3, 3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RightToLeft = RightToLeft.Yes;
            HeaderPanel.Size = new Size(1502, 180);
            HeaderPanel.TabIndex = 1;
            // 
            // InvoiceDate
            // 
            InvoiceDate.AutoSize = true;
            InvoiceDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceDate.Location = new Point(11, 141);
            InvoiceDate.Name = "InvoiceDate";
            InvoiceDate.RightToLeft = RightToLeft.Yes;
            InvoiceDate.Size = new Size(110, 25);
            InvoiceDate.TabIndex = 7;
            InvoiceDate.Text = "تاريخ الفاتورة";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(51, 149, 219);
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 175);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(1502, 5);
            label1.TabIndex = 1;
            // 
            // InvoiceID
            // 
            InvoiceID.AutoSize = true;
            InvoiceID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceID.Location = new Point(1386, 141);
            InvoiceID.Name = "InvoiceID";
            InvoiceID.RightToLeft = RightToLeft.Yes;
            InvoiceID.Size = new Size(98, 25);
            InvoiceID.TabIndex = 6;
            InvoiceID.Text = "رقم الفاتورة";
            // 
            // Header_HR
            // 
            Header_HR.BorderStyle = BorderStyle.Fixed3D;
            Header_HR.Location = new Point(11, 119);
            Header_HR.Name = "Header_HR";
            Header_HR.RightToLeft = RightToLeft.Yes;
            Header_HR.Size = new Size(1468, 2);
            Header_HR.TabIndex = 5;
            // 
            // Invoice
            // 
            Invoice.AutoSize = true;
            Invoice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            Invoice.Location = new Point(9, 6);
            Invoice.Name = "Invoice";
            Invoice.RightToLeft = RightToLeft.Yes;
            Invoice.Size = new Size(72, 31);
            Invoice.TabIndex = 4;
            Invoice.Text = "فاتورة";
            // 
            // CompanyEmail
            // 
            CompanyEmail.AutoSize = true;
            CompanyEmail.Location = new Point(1386, 91);
            CompanyEmail.Name = "CompanyEmail";
            CompanyEmail.RightToLeft = RightToLeft.Yes;
            CompanyEmail.Size = new Size(87, 20);
            CompanyEmail.TabIndex = 3;
            CompanyEmail.Text = "ايميل الشركة";
            // 
            // CompanyPhone
            // 
            CompanyPhone.AutoSize = true;
            CompanyPhone.Location = new Point(1362, 71);
            CompanyPhone.Name = "CompanyPhone";
            CompanyPhone.RightToLeft = RightToLeft.Yes;
            CompanyPhone.Size = new Size(114, 20);
            CompanyPhone.TabIndex = 2;
            CompanyPhone.Text = "رقم هاتف الشركة";
            // 
            // CompanyAddress
            // 
            CompanyAddress.AutoSize = true;
            CompanyAddress.Location = new Point(1386, 51);
            CompanyAddress.Name = "CompanyAddress";
            CompanyAddress.RightToLeft = RightToLeft.Yes;
            CompanyAddress.Size = new Size(90, 20);
            CompanyAddress.TabIndex = 1;
            CompanyAddress.Text = "عنوان الشركة";
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            CompanyName.Location = new Point(1358, 6);
            CompanyName.Name = "CompanyName";
            CompanyName.RightToLeft = RightToLeft.Yes;
            CompanyName.Size = new Size(121, 31);
            CompanyName.TabIndex = 0;
            CompanyName.Text = "اسم الشركة";
            // 
            // VehicleInfoPanel
            // 
            VehicleInfoPanel.Anchor = AnchorStyles.None;
            VehicleInfoPanel.BackColor = Color.FromArgb(255, 243, 205);
            tableLayoutPanel2.SetColumnSpan(VehicleInfoPanel, 2);
            VehicleInfoPanel.Controls.Add(label9);
            VehicleInfoPanel.Controls.Add(VehicleModel);
            VehicleInfoPanel.Controls.Add(VehiclePlate);
            VehicleInfoPanel.Controls.Add(label16);
            VehicleInfoPanel.Controls.Add(VehicleVIN);
            VehicleInfoPanel.Controls.Add(VehicleInformation);
            VehicleInfoPanel.Controls.Add(label17);
            VehicleInfoPanel.Controls.Add(label15);
            VehicleInfoPanel.Location = new Point(63, 376);
            VehicleInfoPanel.Name = "VehicleInfoPanel";
            VehicleInfoPanel.RightToLeft = RightToLeft.Yes;
            VehicleInfoPanel.Size = new Size(1383, 141);
            VehicleInfoPanel.TabIndex = 3;
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(255, 193, 7);
            label9.Location = new Point(1378, 0);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(5, 141);
            label9.TabIndex = 15;
            // 
            // VehicleModel
            // 
            VehicleModel.AutoSize = true;
            VehicleModel.Location = new Point(27, 49);
            VehicleModel.Name = "VehicleModel";
            VehicleModel.RightToLeft = RightToLeft.Yes;
            VehicleModel.Size = new Size(97, 20);
            VehicleModel.TabIndex = 6;
            VehicleModel.Text = "موديل المركبة";
            // 
            // VehiclePlate
            // 
            VehiclePlate.AutoSize = true;
            VehiclePlate.Location = new Point(27, 80);
            VehiclePlate.Name = "VehiclePlate";
            VehiclePlate.RightToLeft = RightToLeft.Yes;
            VehiclePlate.Size = new Size(113, 20);
            VehiclePlate.TabIndex = 5;
            VehiclePlate.Text = "رقم لوحة المركبة";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(1279, 80);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(74, 20);
            label16.TabIndex = 2;
            label16.Text = "رقم اللوحة";
            // 
            // VehicleVIN
            // 
            VehicleVIN.AutoSize = true;
            VehicleVIN.Location = new Point(27, 112);
            VehicleVIN.Name = "VehicleVIN";
            VehicleVIN.RightToLeft = RightToLeft.Yes;
            VehicleVIN.Size = new Size(124, 20);
            VehicleVIN.TabIndex = 4;
            VehicleVIN.Text = "رقم تعريف المركبة";
            // 
            // VehicleInformation
            // 
            VehicleInformation.AutoSize = true;
            VehicleInformation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VehicleInformation.Location = new Point(1186, 11);
            VehicleInformation.Name = "VehicleInformation";
            VehicleInformation.RightToLeft = RightToLeft.Yes;
            VehicleInformation.Size = new Size(167, 25);
            VehicleInformation.TabIndex = 0;
            VehicleInformation.Text = "معلومات عن المركبة";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(1229, 112);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.Yes;
            label17.Size = new Size(124, 20);
            label17.TabIndex = 3;
            label17.Text = "رقم تعريف المركبة";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(1295, 49);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(58, 20);
            label15.TabIndex = 1;
            label15.Text = "الموديل";
            // 
            // CustomerInfoPanel
            // 
            CustomerInfoPanel.Anchor = AnchorStyles.None;
            CustomerInfoPanel.BackColor = Color.FromArgb(245, 246, 247);
            CustomerInfoPanel.Controls.Add(label3);
            CustomerInfoPanel.Controls.Add(CustomerName);
            CustomerInfoPanel.Controls.Add(CustomerPhone);
            CustomerInfoPanel.Controls.Add(CustomerMail);
            CustomerInfoPanel.Controls.Add(label6);
            CustomerInfoPanel.Controls.Add(label5);
            CustomerInfoPanel.Controls.Add(label4);
            CustomerInfoPanel.Controls.Add(CustomerInformation);
            CustomerInfoPanel.Location = new Point(66, 198);
            CustomerInfoPanel.Name = "CustomerInfoPanel";
            CustomerInfoPanel.RightToLeft = RightToLeft.Yes;
            CustomerInfoPanel.Size = new Size(651, 160);
            CustomerInfoPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(51, 149, 219);
            label3.Location = new Point(645, -1);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(5, 164);
            label3.TabIndex = 14;
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Location = new Point(24, 47);
            CustomerName.Name = "CustomerName";
            CustomerName.RightToLeft = RightToLeft.Yes;
            CustomerName.Size = new Size(81, 20);
            CustomerName.TabIndex = 13;
            CustomerName.Text = "اسم العميل";
            // 
            // CustomerPhone
            // 
            CustomerPhone.AutoSize = true;
            CustomerPhone.Location = new Point(24, 83);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.RightToLeft = RightToLeft.Yes;
            CustomerPhone.Size = new Size(115, 20);
            CustomerPhone.TabIndex = 12;
            CustomerPhone.Text = "رقم هاتف العميل";
            // 
            // CustomerMail
            // 
            CustomerMail.AutoSize = true;
            CustomerMail.Location = new Point(24, 121);
            CustomerMail.Name = "CustomerMail";
            CustomerMail.RightToLeft = RightToLeft.Yes;
            CustomerMail.Size = new Size(88, 20);
            CustomerMail.TabIndex = 11;
            CustomerMail.Text = "ايميل العميل";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(530, 121);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(109, 20);
            label6.TabIndex = 10;
            label6.Text = "البريد الالكتروني";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(599, 84);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "الرقم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(595, 48);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "الاسم";
            // 
            // CustomerInformation
            // 
            CustomerInformation.AutoSize = true;
            CustomerInformation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            CustomerInformation.Location = new Point(473, 14);
            CustomerInformation.Name = "CustomerInformation";
            CustomerInformation.RightToLeft = RightToLeft.Yes;
            CustomerInformation.Size = new Size(166, 25);
            CustomerInformation.TabIndex = 7;
            CustomerInformation.Text = "معلومات عن العميل";
            // 
            // InvoiceInfoPanel
            // 
            InvoiceInfoPanel.Anchor = AnchorStyles.None;
            InvoiceInfoPanel.BackColor = Color.FromArgb(245, 246, 247);
            InvoiceInfoPanel.Controls.Add(label7);
            InvoiceInfoPanel.Controls.Add(EmployeeName);
            InvoiceInfoPanel.Controls.Add(InvoiceType);
            InvoiceInfoPanel.Controls.Add(label8);
            InvoiceInfoPanel.Controls.Add(InvoiceInformation);
            InvoiceInfoPanel.Controls.Add(label2);
            InvoiceInfoPanel.Location = new Point(846, 197);
            InvoiceInfoPanel.Name = "InvoiceInfoPanel";
            InvoiceInfoPanel.RightToLeft = RightToLeft.Yes;
            InvoiceInfoPanel.Size = new Size(598, 161);
            InvoiceInfoPanel.TabIndex = 5;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(51, 149, 219);
            label7.Location = new Point(593, -3);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(5, 164);
            label7.TabIndex = 15;
            // 
            // EmployeeName
            // 
            EmployeeName.AutoSize = true;
            EmployeeName.Location = new Point(19, 84);
            EmployeeName.Name = "EmployeeName";
            EmployeeName.RightToLeft = RightToLeft.Yes;
            EmployeeName.Size = new Size(97, 20);
            EmployeeName.TabIndex = 9;
            EmployeeName.Text = "اسم الموظف ";
            // 
            // InvoiceType
            // 
            InvoiceType.AutoSize = true;
            InvoiceType.BackColor = Color.OrangeRed;
            InvoiceType.ForeColor = SystemColors.ButtonHighlight;
            InvoiceType.Location = new Point(19, 49);
            InvoiceType.Name = "InvoiceType";
            InvoiceType.RightToLeft = RightToLeft.Yes;
            InvoiceType.Size = new Size(82, 20);
            InvoiceType.TabIndex = 8;
            InvoiceType.Text = "نوع الفاتورة";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(477, 84);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(93, 20);
            label8.TabIndex = 7;
            label8.Text = "صانع الفاتورة";
            // 
            // InvoiceInformation
            // 
            InvoiceInformation.AutoSize = true;
            InvoiceInformation.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            InvoiceInformation.Location = new Point(406, 15);
            InvoiceInformation.Name = "InvoiceInformation";
            InvoiceInformation.RightToLeft = RightToLeft.Yes;
            InvoiceInformation.Size = new Size(170, 25);
            InvoiceInformation.TabIndex = 6;
            InvoiceInformation.Text = "معلومات عن الفاتورة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(530, 48);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(40, 20);
            label2.TabIndex = 5;
            label2.Text = "النوع";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            tableLayoutPanel2.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(ProductsAndServices);
            panel3.Location = new Point(60, 527);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.Yes;
            panel3.Size = new Size(1389, 27);
            panel3.TabIndex = 6;
            // 
            // ProductsAndServices
            // 
            ProductsAndServices.AutoSize = true;
            ProductsAndServices.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsAndServices.Location = new Point(1253, 0);
            ProductsAndServices.Name = "ProductsAndServices";
            ProductsAndServices.RightToLeft = RightToLeft.Yes;
            ProductsAndServices.Size = new Size(136, 25);
            ProductsAndServices.TabIndex = 0;
            ProductsAndServices.Text = "الاجزاء والخدمات";
            // 
            // ProductsServicesGrid
            // 
            ProductsServicesGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            ProductsServicesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductsServicesGrid.Anchor = AnchorStyles.None;
            ProductsServicesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsServicesGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ProductsServicesGrid.BackgroundColor = Color.White;
            ProductsServicesGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductsServicesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductsServicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(ProductsServicesGrid, 2);
            ProductsServicesGrid.EnableHeadersVisualStyles = false;
            ProductsServicesGrid.GridColor = Color.White;
            ProductsServicesGrid.Location = new Point(61, 560);
            ProductsServicesGrid.Name = "ProductsServicesGrid";
            ProductsServicesGrid.ReadOnly = true;
            ProductsServicesGrid.RightToLeft = RightToLeft.Yes;
            ProductsServicesGrid.RowHeadersVisible = false;
            ProductsServicesGrid.RowHeadersWidth = 51;
            ProductsServicesGrid.ScrollBars = ScrollBars.None;
            ProductsServicesGrid.Size = new Size(1386, 10);
            ProductsServicesGrid.TabIndex = 7;
            ProductsServicesGrid.DataBindingComplete += ProductsServicesGrid_DataBindingComplete;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            tableLayoutPanel2.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label35);
            panel4.Controls.Add(label34);
            panel4.Controls.Add(label33);
            panel4.Controls.Add(SubTotal);
            panel4.Controls.Add(LaborCost);
            panel4.Controls.Add(Tax);
            panel4.Controls.Add(TotalAmount);
            panel4.Controls.Add(PaidAmount);
            panel4.Controls.Add(RemainingAmount);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label24);
            panel4.Controls.Add(label23);
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel4.Location = new Point(59, 587);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.Yes;
            panel4.Size = new Size(1390, 230);
            panel4.TabIndex = 8;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(48, 67, 87);
            label10.Location = new Point(-5, 0);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(1398, 10);
            label10.TabIndex = 16;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label35.Location = new Point(1256, 160);
            label35.Name = "label35";
            label35.RightToLeft = RightToLeft.Yes;
            label35.Size = new Size(101, 20);
            label35.TabIndex = 15;
            label35.Text = "المبلغ المدفوع";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label34.Location = new Point(1258, 190);
            label34.Name = "label34";
            label34.RightToLeft = RightToLeft.Yes;
            label34.Size = new Size(99, 20);
            label34.TabIndex = 14;
            label34.Text = "المبلغ المتبقي";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label33.Location = new Point(1254, 13);
            label33.Name = "label33";
            label33.RightToLeft = RightToLeft.Yes;
            label33.Size = new Size(103, 20);
            label33.TabIndex = 13;
            label33.Text = "المبلغ الاجمالي";
            // 
            // SubTotal
            // 
            SubTotal.AutoSize = true;
            SubTotal.Location = new Point(31, 13);
            SubTotal.Name = "SubTotal";
            SubTotal.RightToLeft = RightToLeft.Yes;
            SubTotal.Size = new Size(67, 20);
            SubTotal.TabIndex = 12;
            SubTotal.Text = "360.00$";
            // 
            // LaborCost
            // 
            LaborCost.AutoSize = true;
            LaborCost.Location = new Point(31, 41);
            LaborCost.Name = "LaborCost";
            LaborCost.RightToLeft = RightToLeft.Yes;
            LaborCost.Size = new Size(67, 20);
            LaborCost.TabIndex = 11;
            LaborCost.Text = "170.00$";
            // 
            // Tax
            // 
            Tax.AutoSize = true;
            Tax.Location = new Point(31, 70);
            Tax.Name = "Tax";
            Tax.RightToLeft = RightToLeft.Yes;
            Tax.Size = new Size(58, 20);
            Tax.TabIndex = 10;
            Tax.Text = "30.60$";
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSize = true;
            TotalAmount.Location = new Point(31, 127);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.RightToLeft = RightToLeft.Yes;
            TotalAmount.Size = new Size(67, 20);
            TotalAmount.TabIndex = 9;
            TotalAmount.Text = "390.60$";
            // 
            // PaidAmount
            // 
            PaidAmount.AutoSize = true;
            PaidAmount.ForeColor = Color.LimeGreen;
            PaidAmount.Location = new Point(31, 160);
            PaidAmount.Name = "PaidAmount";
            PaidAmount.RightToLeft = RightToLeft.Yes;
            PaidAmount.Size = new Size(67, 20);
            PaidAmount.TabIndex = 8;
            PaidAmount.Text = "200.00$";
            // 
            // RemainingAmount
            // 
            RemainingAmount.AutoSize = true;
            RemainingAmount.ForeColor = Color.Red;
            RemainingAmount.Location = new Point(31, 190);
            RemainingAmount.Name = "RemainingAmount";
            RemainingAmount.RightToLeft = RightToLeft.Yes;
            RemainingAmount.Size = new Size(67, 20);
            RemainingAmount.TabIndex = 7;
            RemainingAmount.Text = "190.60$";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label26.Location = new Point(1270, 127);
            label26.Name = "label26";
            label26.RightToLeft = RightToLeft.Yes;
            label26.Size = new Size(85, 20);
            label26.TabIndex = 6;
            label26.Text = "المبلغ الكلي";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label25.Location = new Point(1264, 41);
            label25.Name = "label25";
            label25.RightToLeft = RightToLeft.Yes;
            label25.Size = new Size(91, 20);
            label25.TabIndex = 5;
            label25.Text = "تكلفة العمالة";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label24.Location = new Point(1256, 70);
            label24.Name = "label24";
            label24.RightToLeft = RightToLeft.Yes;
            label24.Size = new Size(99, 20);
            label24.TabIndex = 4;
            label24.Text = "ضريبة (8.5%)";
            // 
            // label23
            // 
            label23.BackColor = Color.FromArgb(51, 149, 219);
            label23.Location = new Point(41, 109);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.Yes;
            label23.Size = new Size(1308, 2);
            label23.TabIndex = 3;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1508, 830);
            Controls.Add(tableLayoutPanel2);
            Name = "InvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceForm";
            tableLayoutPanel2.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            VehicleInfoPanel.ResumeLayout(false);
            VehicleInfoPanel.PerformLayout();
            CustomerInfoPanel.ResumeLayout(false);
            CustomerInfoPanel.PerformLayout();
            InvoiceInfoPanel.ResumeLayout(false);
            InvoiceInfoPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsServicesGrid).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel HeaderPanel;
        private Label InvoiceDate;
        private Label label1;
        private Label InvoiceID;
        private Label Header_HR;
        private Label Invoice;
        private Label CompanyEmail;
        private Label CompanyPhone;
        private Label CompanyAddress;
        private Label CompanyName;
        private Panel CustomerInfoPanel;
        private Panel VehicleInfoPanel;
        private Label VehicleModel;
        private Label VehiclePlate;
        private Label VehicleVIN;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label VehicleInformation;
        private Label CustomerName;
        private Label CustomerPhone;
        private Label CustomerMail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label CustomerInformation;
        private Panel InvoiceInfoPanel;
        private Label EmployeeName;
        private Label InvoiceType;
        private Label label8;
        private Label InvoiceInformation;
        private Label label2;
        private Panel panel3;
        private Label ProductsAndServices;
        private Panel panel4;
        private Label label33;
        private Label SubTotal;
        private Label LaborCost;
        private Label Tax;
        private Label TotalAmount;
        private Label PaidAmount;
        private Label RemainingAmount;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label35;
        private Label label34;
        private Label label3;
        private Label label7;
        private Label label9;
        private Label label10;
        private DataGridView ProductsServicesGrid;
    }
}