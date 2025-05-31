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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            LogoutBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeBtn = new PictureBox();
            PrevImageAsBtn = new PictureBox();
            CategoriesManagement = new Label();
            panel2 = new Panel();
            CategoryDescTxt = new TextBox();
            CategorynameTxt = new TextBox();
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
            tableLayoutPanel1.Controls.Add(CategoryGridView, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.90625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.09375F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1508, 766);
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
            panel1.Size = new Size(1502, 110);
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
            panel2.Controls.Add(CategoryDescTxt);
            panel2.Controls.Add(CategorynameTxt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UpdateCategoryImg);
            panel2.Controls.Add(UpdateCategoryBtn);
            panel2.Controls.Add(DeleteCategoryImg);
            panel2.Controls.Add(AddCategoryImg);
            panel2.Controls.Add(AddCategoryBtn);
            panel2.Controls.Add(DeleteCategoryBtn);
            panel2.Location = new Point(3, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 278);
            panel2.TabIndex = 1;
            // 
            // CategoryDescTxt
            // 
            CategoryDescTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryDescTxt.Location = new Point(674, 124);
            CategoryDescTxt.Multiline = true;
            CategoryDescTxt.Name = "CategoryDescTxt";
            CategoryDescTxt.Size = new Size(480, 126);
            CategoryDescTxt.TabIndex = 10;
            CategoryDescTxt.TextAlign = HorizontalAlignment.Right;
            // 
            // CategorynameTxt
            // 
            CategorynameTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategorynameTxt.Location = new Point(674, 49);
            CategorynameTxt.Multiline = true;
            CategorynameTxt.Name = "CategorynameTxt";
            CategorynameTxt.Size = new Size(480, 39);
            CategorynameTxt.TabIndex = 9;
            CategorynameTxt.TextAlign = HorizontalAlignment.Right;
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
            UpdateCategoryImg.Location = new Point(323, 112);
            UpdateCategoryImg.Name = "UpdateCategoryImg";
            UpdateCategoryImg.Size = new Size(64, 52);
            UpdateCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateCategoryImg.TabIndex = 6;
            UpdateCategoryImg.TabStop = false;
            // 
            // UpdateCategoryBtn
            // 
            UpdateCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            UpdateCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            UpdateCategoryBtn.Location = new Point(187, 112);
            UpdateCategoryBtn.Name = "UpdateCategoryBtn";
            UpdateCategoryBtn.Size = new Size(130, 52);
            UpdateCategoryBtn.TabIndex = 5;
            UpdateCategoryBtn.Text = "تحديث صنف";
            UpdateCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteCategoryImg
            // 
            DeleteCategoryImg.Image = (Image)resources.GetObject("DeleteCategoryImg.Image");
            DeleteCategoryImg.Location = new Point(323, 202);
            DeleteCategoryImg.Name = "DeleteCategoryImg";
            DeleteCategoryImg.Size = new Size(64, 52);
            DeleteCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteCategoryImg.TabIndex = 4;
            DeleteCategoryImg.TabStop = false;
            // 
            // AddCategoryImg
            // 
            AddCategoryImg.Image = (Image)resources.GetObject("AddCategoryImg.Image");
            AddCategoryImg.Location = new Point(323, 26);
            AddCategoryImg.Name = "AddCategoryImg";
            AddCategoryImg.Size = new Size(64, 52);
            AddCategoryImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddCategoryImg.TabIndex = 3;
            AddCategoryImg.TabStop = false;
            // 
            // AddCategoryBtn
            // 
            AddCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddCategoryBtn.Location = new Point(187, 26);
            AddCategoryBtn.Name = "AddCategoryBtn";
            AddCategoryBtn.Size = new Size(130, 52);
            AddCategoryBtn.TabIndex = 2;
            AddCategoryBtn.Text = "اضافة صنف ";
            AddCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteCategoryBtn
            // 
            DeleteCategoryBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteCategoryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteCategoryBtn.Location = new Point(187, 202);
            DeleteCategoryBtn.Name = "DeleteCategoryBtn";
            DeleteCategoryBtn.Size = new Size(130, 52);
            DeleteCategoryBtn.TabIndex = 1;
            DeleteCategoryBtn.Text = "مسح صنف";
            DeleteCategoryBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryGridView
            // 
            CategoryGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.CornflowerBlue;
            CategoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            CategoryGridView.Anchor = AnchorStyles.None;
            CategoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGridView.BorderStyle = BorderStyle.None;
            CategoryGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            CategoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.White;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            CategoryGridView.DefaultCellStyle = dataGridViewCellStyle13;
            CategoryGridView.EnableHeadersVisualStyles = false;
            CategoryGridView.Location = new Point(3, 404);
            CategoryGridView.Name = "CategoryGridView";
            CategoryGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            CategoryGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            CategoryGridView.RowHeadersVisible = false;
            CategoryGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            CategoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            CategoryGridView.ScrollBars = ScrollBars.Vertical;
            CategoryGridView.Size = new Size(1502, 358);
            CategoryGridView.TabIndex = 2;
            CategoryGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminCategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 766);
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
        private TextBox CategorynameTxt;
        private Label label2;
        private PictureBox LogoutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeBtn;
    }
}