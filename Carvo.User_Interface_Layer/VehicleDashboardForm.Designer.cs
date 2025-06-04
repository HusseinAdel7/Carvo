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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDashboardForm));
            label1 = new Label();
            label4 = new Label();
            VehicleNameTxt = new TextBox();
            VehicleModelTxt = new TextBox();
            label3 = new Label();
            VehiclePlateTxt = new TextBox();
            label5 = new Label();
            AddBtn = new Button();
            UpdateBtn = new Button();
            VehicleGridView = new DataGridView();
            button4 = new Button();
            AddImage = new PictureBox();
            UpdateImage = new PictureBox();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            PlateErrorLabel = new Label();
            NameErrorLabel = new Label();
            ModelErrorLabel = new Label();
            DeleteImage = new PictureBox();
            DeleteBtn = new Button();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)VehicleGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteImage).BeginInit();
            SuspendLayout();
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(454, 49);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 3;
            label4.Text = "اسم المركبة";
            // 
            // VehicleNameTxt
            // 
            VehicleNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehicleNameTxt.Location = new Point(36, 49);
            VehicleNameTxt.Multiline = true;
            VehicleNameTxt.Name = "VehicleNameTxt";
            VehicleNameTxt.RightToLeft = RightToLeft.Yes;
            VehicleNameTxt.Size = new Size(397, 39);
            VehicleNameTxt.TabIndex = 5;
            // 
            // VehicleModelTxt
            // 
            VehicleModelTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehicleModelTxt.Location = new Point(627, 49);
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
            label3.Location = new Point(1040, 49);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 8;
            label3.Text = "موديل المركبة";
            // 
            // VehiclePlateTxt
            // 
            VehiclePlateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VehiclePlateTxt.Location = new Point(36, 180);
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
            label5.Location = new Point(466, 180);
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
            AddBtn.Location = new Point(1228, 49);
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
            UpdateBtn.Location = new Point(1228, 122);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 52);
            UpdateBtn.TabIndex = 13;
            UpdateBtn.Text = "تعديل المركبة";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // VehicleGridView
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(95, 158, 160);
            VehicleGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            VehicleGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VehicleGridView.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(252, 9, 121);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            VehicleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            VehicleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(250, 9, 131);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            VehicleGridView.DefaultCellStyle = dataGridViewCellStyle3;
            VehicleGridView.EnableHeadersVisualStyles = false;
            VehicleGridView.GridColor = Color.White;
            VehicleGridView.Location = new Point(23, 464);
            VehicleGridView.Name = "VehicleGridView";
            VehicleGridView.RowHeadersVisible = false;
            VehicleGridView.RowHeadersWidth = 51;
            VehicleGridView.Size = new Size(1491, 200);
            VehicleGridView.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(90, 3);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // AddImage
            // 
            AddImage.BackgroundImageLayout = ImageLayout.Stretch;
            AddImage.Image = (Image)resources.GetObject("AddImage.Image");
            AddImage.Location = new Point(1372, 49);
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
            UpdateImage.Location = new Point(1372, 122);
            UpdateImage.Name = "UpdateImage";
            UpdateImage.Size = new Size(64, 52);
            UpdateImage.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateImage.TabIndex = 21;
            UpdateImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(1, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 104);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(20, 3);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 22;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1442, 3);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 21;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1386, 3);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.Fixed3D;
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
            PlateErrorLabel.Location = new Point(211, 227);
            PlateErrorLabel.Name = "PlateErrorLabel";
            PlateErrorLabel.Size = new Size(0, 20);
            PlateErrorLabel.TabIndex = 28;
            // 
            // NameErrorLabel
            // 
            NameErrorLabel.AutoSize = true;
            NameErrorLabel.Location = new Point(211, 109);
            NameErrorLabel.Name = "NameErrorLabel";
            NameErrorLabel.Size = new Size(0, 20);
            NameErrorLabel.TabIndex = 27;
            // 
            // ModelErrorLabel
            // 
            ModelErrorLabel.AutoSize = true;
            ModelErrorLabel.Location = new Point(744, 106);
            ModelErrorLabel.Name = "ModelErrorLabel";
            ModelErrorLabel.Size = new Size(0, 20);
            ModelErrorLabel.TabIndex = 26;
            // 
            // DeleteImage
            // 
            DeleteImage.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteImage.Image = (Image)resources.GetObject("DeleteImage.Image");
            DeleteImage.Location = new Point(1372, 195);
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
            DeleteBtn.Location = new Point(1228, 195);
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
            label2.Location = new Point(1059, 180);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 23;
            label2.Text = "اسم العميل";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(627, 180);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.RightToLeft = RightToLeft.Yes;
            CustomerComboBox.Size = new Size(397, 36);
            CustomerComboBox.TabIndex = 22;
            // 
            // VehicleDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1526, 676);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(VehicleGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleDashboardForm";
            Text = "CustomerDashboardForm";
            Load += VehicleDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)VehicleGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox VehicleNameTxt;
        private TextBox VehicleModelTxt;
        private Label label3;
        private TextBox VehiclePlateTxt;
        private Label label5;
        private Button AddBtn;
        private Button UpdateBtn;
        private DataGridView VehicleGridView;
        private Button button4;
        private PictureBox AddImage;
        private PictureBox UpdateImage;
        private Panel panel1;
        private Panel panel2;
        private Button button8;
        private Button button7;
        private Button button3;
        private ComboBox CustomerComboBox;
        private Label label2;
        private PictureBox DeleteImage;
        private Button DeleteBtn;
        private Label label6;
        private Label PlateErrorLabel;
        private Label ModelErrorLabel;
        private Label NameErrorLabel;
    }
}