namespace Carvo.User_Interface_Layer
{
    partial class AdminVehiclesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVehiclesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LogoutBtn = new PictureBox();
            CloseBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            VehicleModelTxt = new TextBox();
            PlateNumberTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CustomersDropdownList = new ComboBox();
            VehicleNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UpdateVehicleBtn = new Button();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddVehicleBtn = new Button();
            DeleteVehicleBtn = new Button();
            VehiclesGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VehiclesGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(VehiclesGridView, 0, 2);
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
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 127);
            panel1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(73, 23);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 4;
            LogoutBtn.TabStop = false;
            // 
            // CloseBtn
            // 
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(1378, 23);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(50, 50);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 3;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(1278, 23);
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
            PrevImageAsBtn.Location = new Point(165, 23);
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
            CategoriesManagement.Size = new Size(175, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة المركبات";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(VehicleModelTxt);
            panel2.Controls.Add(PlateNumberTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(CustomersDropdownList);
            panel2.Controls.Add(VehicleNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(UpdateVehicleBtn);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddVehicleBtn);
            panel2.Controls.Add(DeleteVehicleBtn);
            panel2.Location = new Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 432);
            panel2.TabIndex = 1;
            // 
            // VehicleModelTxt
            // 
            VehicleModelTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VehicleModelTxt.Location = new Point(129, 55);
            VehicleModelTxt.Multiline = true;
            VehicleModelTxt.Name = "VehicleModelTxt";
            VehicleModelTxt.Size = new Size(373, 39);
            VehicleModelTxt.TabIndex = 19;
            VehicleModelTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // PlateNumberTxt
            // 
            PlateNumberTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlateNumberTxt.Location = new Point(868, 133);
            PlateNumberTxt.Multiline = true;
            PlateNumberTxt.Name = "PlateNumberTxt";
            PlateNumberTxt.Size = new Size(373, 39);
            PlateNumberTxt.TabIndex = 18;
            PlateNumberTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(576, 56);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 17;
            label3.Text = " : الموديل ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(544, 131);
            label4.Name = "label4";
            label4.Size = new Size(131, 28);
            label4.TabIndex = 15;
            label4.Text = " : اسم العميل ";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // CustomersDropdownList
            // 
            CustomersDropdownList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomersDropdownList.FormattingEnabled = true;
            CustomersDropdownList.Location = new Point(129, 141);
            CustomersDropdownList.Name = "CustomersDropdownList";
            CustomersDropdownList.Size = new Size(373, 31);
            CustomersDropdownList.TabIndex = 12;
            // 
            // VehicleNameTxt
            // 
            VehicleNameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VehicleNameTxt.Location = new Point(868, 55);
            VehicleNameTxt.Multiline = true;
            VehicleNameTxt.Name = "VehicleNameTxt";
            VehicleNameTxt.Size = new Size(373, 39);
            VehicleNameTxt.TabIndex = 9;
            VehicleNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1305, 130);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 8;
            label2.Text = " : رقم اللوحة ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1294, 56);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 7;
            label1.Text = " : اسم المركبة ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(796, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UpdateVehicleBtn
            // 
            UpdateVehicleBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateVehicleBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateVehicleBtn.Location = new Point(660, 293);
            UpdateVehicleBtn.Name = "UpdateVehicleBtn";
            UpdateVehicleBtn.Size = new Size(130, 52);
            UpdateVehicleBtn.TabIndex = 5;
            UpdateVehicleBtn.Text = "تحديث مركبة";
            UpdateVehicleBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(411, 293);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1186, 293);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddVehicleBtn
            // 
            AddVehicleBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddVehicleBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddVehicleBtn.Location = new Point(1050, 293);
            AddVehicleBtn.Name = "AddVehicleBtn";
            AddVehicleBtn.Size = new Size(130, 52);
            AddVehicleBtn.TabIndex = 2;
            AddVehicleBtn.Text = "اضافة مركبة ";
            AddVehicleBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteVehicleBtn
            // 
            DeleteVehicleBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteVehicleBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteVehicleBtn.Location = new Point(275, 293);
            DeleteVehicleBtn.Name = "DeleteVehicleBtn";
            DeleteVehicleBtn.Size = new Size(130, 52);
            DeleteVehicleBtn.TabIndex = 1;
            DeleteVehicleBtn.Text = "مسح مركبة";
            DeleteVehicleBtn.UseVisualStyleBackColor = false;
            // 
            // VehiclesGridView
            // 
            VehiclesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            VehiclesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            VehiclesGridView.Anchor = AnchorStyles.None;
            VehiclesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VehiclesGridView.BorderStyle = BorderStyle.None;
            VehiclesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            VehiclesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            VehiclesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            VehiclesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            VehiclesGridView.EnableHeadersVisualStyles = false;
            VehiclesGridView.Location = new Point(3, 578);
            VehiclesGridView.MaximumSize = new Size(1502, 243);
            VehiclesGridView.Name = "VehiclesGridView";
            VehiclesGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            VehiclesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            VehiclesGridView.RowHeadersVisible = false;
            VehiclesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            VehiclesGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            VehiclesGridView.ScrollBars = ScrollBars.Vertical;
            VehiclesGridView.Size = new Size(1502, 243);
            VehiclesGridView.TabIndex = 2;
            VehiclesGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminVehiclesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 829);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1526, 885);
            Name = "AdminVehiclesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)VehiclesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddVehicleBtn;
        private Button DeleteVehicleBtn;
        private DataGridView VehiclesGridView;
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Button UpdateVehicleBtn;
        private TextBox VehicleNameTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CustomersDropdownList;
        private TextBox VehicleModelTxt;
        private TextBox PlateNumberTxt;
        private PictureBox LogoutBtn;
        private PictureBox CloseBtn;
        private PictureBox MinimizeBtn;
    }
}