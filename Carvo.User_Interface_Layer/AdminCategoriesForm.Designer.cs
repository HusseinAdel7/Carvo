namespace Carvo.User_Interface_Layer
{
    partial class AdminCategoriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCategoriesForm));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LogoutBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            label7 = new Label();
            cancelImg = new PictureBox();
            cancelBtn = new Button();
            DescErrorMsg = new Label();
            NameErrorMsg = new Label();
            CategoryDescTxt = new TextBox();
            CategoryNameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            UpdateCategoryImg = new PictureBox();
            UpdateCategoryBtn = new Button();
            DeleteCategoryImg = new PictureBox();
            AddCategoryImg = new PictureBox();
            AddCategoryBtn = new Button();
            DeleteCategoryBtn = new Button();
            CategoryGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cancelImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCategoryImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCategoryImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddCategoryImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(CategoryGridView, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.90625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.09375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1510, 829);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeBtn);
            panel1.Controls.Add(PrevImageAsBtn);
            panel1.Controls.Add(CategoriesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 157);
            panel1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(37, 23);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 4;
            LogoutBtn.TabStop = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1416, 23);
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
            MinimizeBtn.Location = new Point(1334, 23);
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
            PrevImageAsBtn.Location = new Point(116, 23);
            PrevImageAsBtn.Name = "PrevImageAsBtn";
            PrevImageAsBtn.Size = new Size(50, 50);
            PrevImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImageAsBtn.TabIndex = 1;
            PrevImageAsBtn.TabStop = false;
            PrevImageAsBtn.Click += PrevImageAsBtn_Click;
            // 
            // CategoriesManagement
            // 
            CategoriesManagement.AutoSize = true;
            CategoriesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoriesManagement.Location = new Point(707, 35);
            CategoriesManagement.Name = "CategoriesManagement";
            CategoriesManagement.Size = new Size(195, 38);
            CategoriesManagement.TabIndex = 0;
            CategoriesManagement.Text = "ادارة التصنيفات";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cancelImg);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(DescErrorMsg);
            panel2.Controls.Add(NameErrorMsg);
            panel2.Controls.Add(CategoryDescTxt);
            panel2.Controls.Add(CategoryNameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateCategoryImg);
            panel2.Controls.Add(UpdateCategoryBtn);
            panel2.Controls.Add(DeleteCategoryImg);
            panel2.Controls.Add(AddCategoryImg);
            panel2.Controls.Add(AddCategoryBtn);
            panel2.Controls.Add(DeleteCategoryBtn);
            panel2.Location = new Point(4, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 396);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1109, 326);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 36;
            // 
            // cancelImg
            // 
            cancelImg.BackgroundImageLayout = ImageLayout.Stretch;
            cancelImg.Image = (Image)resources.GetObject("cancelImg.Image");
            cancelImg.Location = new Point(1110, 282);
            cancelImg.Name = "cancelImg";
            cancelImg.Size = new Size(44, 38);
            cancelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            cancelImg.TabIndex = 35;
            cancelImg.TabStop = false;
            cancelImg.Click += cancelBtn_Click_1;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(244, 244, 244);
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(976, 282);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(127, 38);
            cancelBtn.TabIndex = 34;
            cancelBtn.Text = "اعادة تعيين";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click_1;
            // 
            // DescErrorMsg
            // 
            DescErrorMsg.AutoSize = true;
            DescErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            DescErrorMsg.Location = new Point(512, 136);
            DescErrorMsg.Name = "DescErrorMsg";
            DescErrorMsg.Size = new Size(156, 28);
            DescErrorMsg.TabIndex = 12;
            DescErrorMsg.Text = "الوصف قصير جدا";
            DescErrorMsg.Visible = false;
            // 
            // NameErrorMsg
            // 
            NameErrorMsg.AutoSize = true;
            NameErrorMsg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameErrorMsg.ForeColor = Color.FromArgb(255, 220, 80);
            NameErrorMsg.Location = new Point(528, 60);
            NameErrorMsg.Name = "NameErrorMsg";
            NameErrorMsg.Size = new Size(140, 28);
            NameErrorMsg.TabIndex = 11;
            NameErrorMsg.Text = "الاسم قصير جدا";
            NameErrorMsg.Visible = false;
            // 
            // CategoryDescTxt
            // 
            CategoryDescTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDescTxt.Location = new Point(674, 124);
            CategoryDescTxt.Multiline = true;
            CategoryDescTxt.Name = "CategoryDescTxt";
            CategoryDescTxt.Size = new Size(480, 126);
            CategoryDescTxt.TabIndex = 10;
            CategoryDescTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryNameTxt
            // 
            CategoryNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryNameTxt.Location = new Point(674, 49);
            CategoryNameTxt.Multiline = true;
            CategoryNameTxt.Name = "CategoryNameTxt";
            CategoryNameTxt.Size = new Size(480, 53);
            CategoryNameTxt.TabIndex = 9;
            CategoryNameTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1328, 123);
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
            label1.Location = new Point(1295, 50);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 7;
            label1.Text = " : اسم الصنف ";
            // 
            // UpdateCategoryImg
            // 
            UpdateCategoryImg.Image = (Image)resources.GetObject("UpdateCategoryImg.Image");
            UpdateCategoryImg.Location = new Point(300, 169);
            UpdateCategoryImg.Name = "UpdateCategoryImg";
            UpdateCategoryImg.Size = new Size(64, 52);
            UpdateCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateCategoryImg.TabIndex = 6;
            UpdateCategoryImg.TabStop = false;
            UpdateCategoryImg.Click += UpdateCategoryBtn_Click;
            // 
            // UpdateCategoryBtn
            // 
            UpdateCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateCategoryBtn.Location = new Point(164, 169);
            UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            UpdateCategoryBtn.Size = new Size(130, 52);
            UpdateCategoryBtn.TabIndex = 5;
            UpdateCategoryBtn.Text = "تحديث صنف";
            UpdateCategoryBtn.UseVisualStyleBackColor = false;
            UpdateCategoryBtn.Click += UpdateCategoryBtn_Click;
            // 
            // DeleteCategoryImg
            // 
            DeleteCategoryImg.Image = (Image)resources.GetObject("DeleteCategoryImg.Image");
            DeleteCategoryImg.Location = new Point(300, 259);
            DeleteCategoryImg.Name = "DeleteCategoryImg";
            DeleteCategoryImg.Size = new Size(64, 52);
            DeleteCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCategoryImg.TabIndex = 4;
            DeleteCategoryImg.TabStop = false;
            DeleteCategoryImg.Click += DeleteCategoryBtn_Click;
            // 
            // AddCategoryImg
            // 
            AddCategoryImg.Image = (Image)resources.GetObject("AddCategoryImg.Image");
            AddCategoryImg.Location = new Point(300, 83);
            AddCategoryImg.Name = "AddCategoryImg";
            AddCategoryImg.Size = new Size(64, 52);
            AddCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCategoryImg.TabIndex = 3;
            AddCategoryImg.TabStop = false;
            AddCategoryImg.Click += AddCategoryBtn_Click;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddCategoryBtn.Location = new Point(164, 83);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(130, 52);
            AddCategoryBtn.TabIndex = 2;
            AddCategoryBtn.Text = "اضافة صنف ";
            AddCategoryBtn.UseVisualStyleBackColor = false;
            AddCategoryBtn.Click += AddCategoryBtn_Click;
            // 
            // DeleteCategoryBtn
            // 
            DeleteCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteCategoryBtn.Location = new Point(164, 259);
            DeleteCategoryBtn.Name = "DeleteCategoryBtn";
            DeleteCategoryBtn.Size = new Size(130, 52);
            DeleteCategoryBtn.TabIndex = 1;
            DeleteCategoryBtn.Text = "مسح صنف";
            DeleteCategoryBtn.UseVisualStyleBackColor = false;
            DeleteCategoryBtn.Click += DeleteCategoryBtn_Click;
            // 
            // CategoryGridView
            // 
            CategoryGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            CategoryGridView.Anchor = AnchorStyles.None;
            CategoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGridView.BorderStyle = BorderStyle.None;
            CategoryGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CategoryGridView.DefaultCellStyle = dataGridViewCellStyle8;
            CategoryGridView.EnableHeadersVisualStyles = false;
            CategoryGridView.Location = new Point(4, 568);
            CategoryGridView.Name = "CategoryGridView";
            CategoryGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            CategoryGridView.RowHeadersVisible = false;
            CategoryGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            CategoryGridView.ScrollBars = ScrollBars.Vertical;
            CategoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGridView.Size = new Size(1502, 257);
            CategoryGridView.TabIndex = 2;
            CategoryGridView.SelectionChanged += CategoryGridView_SelectionChanged;
            // 
            // AdminCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1510, 829);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cancelImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateCategoryImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteCategoryImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddCategoryImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label CategoriesManagement;
        private Panel panel2;
        private Button AddCategoryBtn;
        private Button DeleteCategoryBtn;
        private DataGridView CategoryGridView;
        private PictureBox DeleteCategoryImg;
        private PictureBox AddCategoryImg;
        private PictureBox PrevImageAsBtn;
        private Label label1;
        private PictureBox UpdateCategoryImg;
        private Button UpdateCategoryBtn;
        private TextBox CategoryDescTxt;
        private TextBox CategoryNameTxt;
        private Label label2;
        private PictureBox LogoutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeBtn;
        private Label NameErrorMsg;
        private Label DescErrorMsg;
        private Label label7;
        private PictureBox cancelImg;
        private Button cancelBtn;
    }
}