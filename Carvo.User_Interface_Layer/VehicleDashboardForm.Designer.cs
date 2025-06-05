namespace Carvo.User_Interface_Layer
{
    partial class VehicleDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDashboardForm));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            label4 = new Label();
            VehicleNameTxt = new TextBox();
            VehicleModelTxt = new TextBox();
            label3 = new Label();
            VehiclePlateTxt = new TextBox();
            label5 = new Label();
            AddBtn = new Button();
            UpdateBtn = new Button();
            AddImage = new PictureBox();
            UpdateImage = new PictureBox();
            panel2 = new Panel();
            PlateErrorLabel = new Label();
            NameErrorLabel = new Label();
            ModelErrorLabel = new Label();
            DeleteImage = new PictureBox();
            DeleteBtn = new Button();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            LogoutBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            VehiclesGridView = new DataGridView();
            CustomersFilterTxt = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)AddImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VehiclesGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1345, 188);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 3;
            label4.Text = "اسم المركبة";
            // 
            // VehicleNameTxt
            // 
            VehicleNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehicleNameTxt.Location = new Point(914, 185);
            VehicleNameTxt.Multiline = true;
            VehicleNameTxt.Name = "VehicleNameTxt";
            VehicleNameTxt.RightToLeft = RightToLeft.Yes;
            VehicleNameTxt.Size = new Size(397, 39);
            VehicleNameTxt.TabIndex = 5;
            // 
            // VehicleModelTxt
            // 
            VehicleModelTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehicleModelTxt.Location = new Point(914, 83);
            VehicleModelTxt.Multiline = true;
            VehicleModelTxt.Name = "VehicleModelTxt";
            VehicleModelTxt.RightToLeft = RightToLeft.Yes;
            VehicleModelTxt.Size = new Size(397, 39);
            VehicleModelTxt.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1327, 83);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 8;
            label3.Text = "موديل المركبة";
            // 
            // VehiclePlateTxt
            // 
            VehiclePlateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehiclePlateTxt.Location = new Point(323, 185);
            VehiclePlateTxt.Multiline = true;
            VehiclePlateTxt.Name = "VehiclePlateTxt";
            VehiclePlateTxt.RightToLeft = RightToLeft.Yes;
            VehiclePlateTxt.Size = new Size(397, 39);
            VehiclePlateTxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(755, 188);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 10;
            label5.Text = "رقم اللوحة";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(244, 244, 244);
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Black;
            AddBtn.Location = new Point(36, 33);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(138, 52);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "اضافة المركبة ";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(244, 244, 244);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Black;
            UpdateBtn.Location = new Point(36, 106);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 52);
            UpdateBtn.TabIndex = 13;
            UpdateBtn.Text = "تعديل المركبة";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddImage
            // 
            AddImage.BackgroundImageLayout = ImageLayout.Stretch;
            AddImage.Image = (Image)resources.GetObject("AddImage.Image");
            AddImage.Location = new Point(180, 33);
            AddImage.Name = "AddImage";
            AddImage.Size = new Size(64, 52);
            AddImage.SizeMode = PictureBoxSizeMode.StretchImage;
            AddImage.TabIndex = 20;
            AddImage.TabStop = false;
            // 
            // UpdateImage
            // 
            UpdateImage.BackgroundImageLayout = ImageLayout.Stretch;
            UpdateImage.Image = (Image)resources.GetObject("UpdateImage.Image");
            UpdateImage.Location = new Point(180, 106);
            UpdateImage.Name = "UpdateImage";
            UpdateImage.Size = new Size(64, 52);
            UpdateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateImage.TabIndex = 21;
            UpdateImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(CustomersFilterTxt);
            panel2.Controls.Add(PlateErrorLabel);
            panel2.Controls.Add(NameErrorLabel);
            panel2.Controls.Add(ModelErrorLabel);
            panel2.Controls.Add(DeleteImage);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CustomerComboBox);
            panel2.Controls.Add(VehiclePlateTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UpdateImage);
            panel2.Controls.Add(VehicleNameTxt);
            panel2.Controls.Add(AddImage);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(VehicleModelTxt);
            panel2.Controls.Add(UpdateBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(AddBtn);
            panel2.Location = new Point(23, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(1491, 305);
            panel2.TabIndex = 23;
            // 
            // PlateErrorLabel
            // 
            PlateErrorLabel.AutoSize = true;
            PlateErrorLabel.Location = new Point(180, 227);
            PlateErrorLabel.Name = "PlateErrorLabel";
            PlateErrorLabel.Size = new Size(0, 20);
            PlateErrorLabel.TabIndex = 28;
            // 
            // NameErrorLabel
            // 
            NameErrorLabel.AutoSize = true;
            NameErrorLabel.Location = new Point(180, 109);
            NameErrorLabel.Name = "NameErrorLabel";
            NameErrorLabel.Size = new Size(0, 20);
            NameErrorLabel.TabIndex = 27;
            // 
            // ModelErrorLabel
            // 
            ModelErrorLabel.AutoSize = true;
            ModelErrorLabel.Location = new Point(1348, 179);
            ModelErrorLabel.Name = "ModelErrorLabel";
            ModelErrorLabel.Size = new Size(0, 20);
            ModelErrorLabel.TabIndex = 26;
            // 
            // DeleteImage
            // 
            DeleteImage.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteImage.Image = (Image)resources.GetObject("DeleteImage.Image");
            DeleteImage.Location = new Point(180, 179);
            DeleteImage.Name = "DeleteImage";
            DeleteImage.Size = new Size(64, 52);
            DeleteImage.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteImage.TabIndex = 25;
            DeleteImage.TabStop = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(244, 244, 244);
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(36, 179);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 52);
            DeleteBtn.TabIndex = 24;
            DeleteBtn.Text = "حذف المركبة";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(755, 83);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 23;
            label2.Text = "اسم العميل";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(323, 83);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.RightToLeft = RightToLeft.Yes;
            CustomerComboBox.Size = new Size(397, 36);
            CustomerComboBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(556, 36);
            label1.Name = "label1";
            label1.Size = new Size(415, 38);
            label1.TabIndex = 0;
            label1.Text = "مرحبا بكم في صفحة ادارة المركبات";
            // 
            // panel1
            // 
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Location = new Point(1, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 104);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(41, 13);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 34;
            LogoutBtn.TabStop = false;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1420, 13);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 33;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // PrevImageAsBtn
            // 
            PrevImageAsBtn.Image = (Image)resources.GetObject("PrevImageAsBtn.Image");
            PrevImageAsBtn.Location = new Point(120, 13);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(50, 50);
            PrevImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImageAsBtn.TabIndex = 31;
            PrevImageAsBtn.TabStop = false;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(1338, 13);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(50, 50);
            MinimizeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeBtn.TabIndex = 32;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // VehiclesGridView
            // 
            VehiclesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            VehiclesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            VehiclesGridView.Anchor = AnchorStyles.None;
            VehiclesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VehiclesGridView.BorderStyle = BorderStyle.None;
            VehiclesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            VehiclesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            VehiclesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            VehiclesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            VehiclesGridView.EnableHeadersVisualStyles = false;
            VehiclesGridView.Location = new Point(12, 464);
            VehiclesGridView.MaximumSize = new Size(1502, 243);
            VehiclesGridView.Name = "VehiclesGridView";
            VehiclesGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            VehiclesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            VehiclesGridView.RowHeadersVisible = false;
            VehiclesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            VehiclesGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            VehiclesGridView.ScrollBars = ScrollBars.Vertical;
            VehiclesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            VehiclesGridView.Size = new Size(1502, 243);
            VehiclesGridView.TabIndex = 29;
            VehiclesGridView.SelectionChanged += VehicleGridView_SelectionChanged;
            // 
            // CustomersFilterTxt
            // 
            CustomersFilterTxt.Font = new Font("Segoe UI", 12F);
            CustomersFilterTxt.Location = new Point(323, 42);
            CustomersFilterTxt.Name = "CustomersFilterTxt";
            CustomersFilterTxt.Size = new Size(397, 34);
            CustomersFilterTxt.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(533, 0);
            label6.Name = "label6";
            label6.Size = new Size(187, 28);
            label6.TabIndex = 30;
            label6.Text = "تصفية العملاء بالاسم";
            // 
            // VehicleDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1526, 736);
            Controls.Add(VehiclesGridView);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleDashboardForm";
            Text = "CustomerDashboardForm";
            ((System.ComponentModel.ISupportInitialize)AddImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)VehiclesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TextBox VehicleNameTxt;
        private TextBox VehicleModelTxt;
        private Label label3;
        private TextBox VehiclePlateTxt;
        private Label label5;
        private Button AddBtn;
        private Button UpdateBtn;
        private PictureBox AddImage;
        private PictureBox UpdateImage;
        private Panel panel2;
        private ComboBox CustomerComboBox;
        private Label label2;
        private PictureBox DeleteImage;
        private Button DeleteBtn;
        private Label label6;
        private Label PlateErrorLabel;
        private Label ModelErrorLabel;
        private Label NameErrorLabel;
        private Label label1;
        private Panel panel1;
        private DataGridView VehiclesGridView;
        private PictureBox LogoutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox PrevImageAsBtn;
        private PictureBox MinimizeBtn;
        private TextBox CustomersFilterTxt;
    }
}