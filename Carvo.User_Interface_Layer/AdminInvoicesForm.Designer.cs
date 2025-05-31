namespace Carvo.User_Interface_Layer
{
    partial class AdminInvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInvoicesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            PrevImgBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeImgBtn = new PictureBox();
            LogoutImageAsBtn = new PictureBox();
            InvoicesManagement = new Label();
            panel2 = new Panel();
            DeleteAllInvoicesImg = new PictureBox();
            DeleteInvoiceImg = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddInvoiceBtn = new Button();
            DeleteInvoiceBtn = new Button();
            DeleteAllInvoicesBtn = new Button();
            InvoicesGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeImgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteAllInvoicesImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).BeginInit();
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
            tableLayoutPanel1.Controls.Add(InvoicesGridView, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 126F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1508, 703);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            tableLayoutPanel1.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(PrevImgBtn);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(MinimizeImgBtn);
            panel1.Controls.Add(LogoutImageAsBtn);
            panel1.Controls.Add(InvoicesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 100);
            panel1.TabIndex = 0;
            // 
            // PrevImgBtn
            // 
            PrevImgBtn.Image = (Image)resources.GetObject("PrevImgBtn.Image");
            PrevImgBtn.Location = new Point(142, 20);
            PrevImgBtn.Name = "PrevImgBtn";
            PrevImgBtn.Size = new Size(52, 53);
            PrevImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImgBtn.TabIndex = 4;
            PrevImgBtn.TabStop = false;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1393, 20);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(52, 53);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 3;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeImgBtn
            // 
            MinimizeImgBtn.Image = (Image)resources.GetObject("MinimizeImgBtn.Image");
            MinimizeImgBtn.Location = new Point(1300, 20);
            MinimizeImgBtn.Name = "MinimizeImgBtn";
            MinimizeImgBtn.Size = new Size(52, 53);
            MinimizeImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeImgBtn.TabIndex = 2;
            MinimizeImgBtn.TabStop = false;
            MinimizeImgBtn.Click += MinimizeImgBtn_Click;
            // 
            // LogoutImageAsBtn
            // 
            LogoutImageAsBtn.Image = (Image)resources.GetObject("LogoutImageAsBtn.Image");
            LogoutImageAsBtn.Location = new Point(42, 20);
            LogoutImageAsBtn.Name = "LogoutImageAsBtn";
            LogoutImageAsBtn.Size = new Size(52, 53);
            LogoutImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutImageAsBtn.TabIndex = 1;
            LogoutImageAsBtn.TabStop = false;
            // 
            // InvoicesManagement
            // 
            InvoicesManagement.AutoSize = true;
            InvoicesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesManagement.Location = new Point(707, 35);
            InvoicesManagement.Name = "InvoicesManagement";
            InvoicesManagement.Size = new Size(158, 38);
            InvoicesManagement.TabIndex = 0;
            InvoicesManagement.Text = "ادارة الفاوتير";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(DeleteAllInvoicesImg);
            panel2.Controls.Add(DeleteInvoiceImg);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(DeleteInvoiceBtn);
            panel2.Controls.Add(DeleteAllInvoicesBtn);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(1502, 120);
            panel2.TabIndex = 1;
            // 
            // DeleteAllInvoicesImg
            // 
            DeleteAllInvoicesImg.Image = (Image)resources.GetObject("DeleteAllInvoicesImg.Image");
            DeleteAllInvoicesImg.Location = new Point(328, 39);
            DeleteAllInvoicesImg.Name = "DeleteAllInvoicesImg";
            DeleteAllInvoicesImg.Size = new Size(64, 52);
            DeleteAllInvoicesImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteAllInvoicesImg.TabIndex = 5;
            DeleteAllInvoicesImg.TabStop = false;
            // 
            // DeleteInvoiceImg
            // 
            DeleteInvoiceImg.Image = (Image)resources.GetObject("DeleteInvoiceImg.Image");
            DeleteInvoiceImg.Location = new Point(764, 39);
            DeleteInvoiceImg.Name = "DeleteInvoiceImg";
            DeleteInvoiceImg.Size = new Size(64, 52);
            DeleteInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoiceImg.TabIndex = 4;
            DeleteInvoiceImg.TabStop = false;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1186, 39);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(64, 52);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(1050, 39);
            AddInvoiceBtn.Name = "AddInvoiceBtn";
            AddInvoiceBtn.Size = new Size(130, 52);
            AddInvoiceBtn.TabIndex = 2;
            AddInvoiceBtn.Text = "اضافة فاتورة ";
            AddInvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceBtn
            // 
            DeleteInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceBtn.Location = new Point(628, 39);
            DeleteInvoiceBtn.Name = "DeleteInvoiceBtn";
            DeleteInvoiceBtn.Size = new Size(130, 52);
            DeleteInvoiceBtn.TabIndex = 1;
            DeleteInvoiceBtn.Text = "مسح فاتورة";
            DeleteInvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteAllInvoicesBtn
            // 
            DeleteAllInvoicesBtn.BackColor = Color.FromArgb(224, 224, 224);
            DeleteAllInvoicesBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteAllInvoicesBtn.Location = new Point(192, 39);
            DeleteAllInvoicesBtn.Name = "DeleteAllInvoicesBtn";
            DeleteAllInvoicesBtn.Size = new Size(130, 52);
            DeleteAllInvoicesBtn.TabIndex = 0;
            DeleteAllInvoicesBtn.Text = "مسح الكل";
            DeleteAllInvoicesBtn.UseVisualStyleBackColor = false;
            // 
            // InvoicesGridView
            // 
            InvoicesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.CornflowerBlue;
            InvoicesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            InvoicesGridView.Anchor = AnchorStyles.None;
            InvoicesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InvoicesGridView.BorderStyle = BorderStyle.None;
            InvoicesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InvoicesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InvoicesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            InvoicesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            InvoicesGridView.EnableHeadersVisualStyles = false;
            InvoicesGridView.Location = new Point(3, 238);
            InvoicesGridView.MaximumSize = new Size(1502, 458);
            InvoicesGridView.Name = "InvoicesGridView";
            InvoicesGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            InvoicesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            InvoicesGridView.RowHeadersVisible = false;
            InvoicesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            InvoicesGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            InvoicesGridView.ScrollBars = ScrollBars.Vertical;
            InvoicesGridView.Size = new Size(1502, 458);
            InvoicesGridView.TabIndex = 2;
            InvoicesGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1508, 703);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminInvoicesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImgBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeImgBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutImageAsBtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DeleteAllInvoicesImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddInvoiceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label InvoicesManagement;
        private Panel panel2;
        private Button AddInvoiceBtn;
        private Button DeleteInvoiceBtn;
        private Button DeleteAllInvoicesBtn;
        private DataGridView InvoicesGridView;
        private PictureBox DeleteInvoiceImg;
        private PictureBox AddInvoiceImg;
        private PictureBox DeleteAllInvoicesImg;
        private PictureBox LogoutImageAsBtn;
        private PictureBox PrevImgBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeImgBtn;
    }
}