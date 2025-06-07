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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            PrevImgBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeImgBtn = new PictureBox();
            LogoutImageAsBtn = new PictureBox();
            InvoicesManagement = new Label();
            panel2 = new Panel();
            DeleteAllPictureBox = new PictureBox();
            DeleteInvoicePictureBox = new PictureBox();
            AddInvoiceImg = new PictureBox();
            AddInvoiceBtn = new Button();
            DeleteInvoiceButton = new Button();
            DeleteAllButton = new Button();
            InvoicesGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevImgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeImgBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutImageAsBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteAllPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoicePictureBox).BeginInit();
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1213, 527);
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
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 76);
            panel1.TabIndex = 0;
            // 
            // PrevImgBtn
            // 
            PrevImgBtn.Image = (Image)resources.GetObject("PrevImgBtn.Image");
            PrevImgBtn.Location = new Point(124, 15);
            PrevImgBtn.Margin = new Padding(3, 2, 3, 2);
            PrevImgBtn.Name = "PrevImgBtn";
            PrevImgBtn.Size = new Size(46, 40);
            PrevImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImgBtn.TabIndex = 4;
            PrevImgBtn.TabStop = false;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1219, 15);
            CloseFormBtn.Margin = new Padding(3, 2, 3, 2);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(46, 40);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 3;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeImgBtn
            // 
            MinimizeImgBtn.Image = (Image)resources.GetObject("MinimizeImgBtn.Image");
            MinimizeImgBtn.Location = new Point(1138, 15);
            MinimizeImgBtn.Margin = new Padding(3, 2, 3, 2);
            MinimizeImgBtn.Name = "MinimizeImgBtn";
            MinimizeImgBtn.Size = new Size(46, 40);
            MinimizeImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeImgBtn.TabIndex = 2;
            MinimizeImgBtn.TabStop = false;
            MinimizeImgBtn.Click += MinimizeImgBtn_Click;
            // 
            // LogoutImageAsBtn
            // 
            LogoutImageAsBtn.Image = (Image)resources.GetObject("LogoutImageAsBtn.Image");
            LogoutImageAsBtn.Location = new Point(37, 15);
            LogoutImageAsBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutImageAsBtn.Name = "LogoutImageAsBtn";
            LogoutImageAsBtn.Size = new Size(46, 40);
            LogoutImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutImageAsBtn.TabIndex = 1;
            LogoutImageAsBtn.TabStop = false;
            // 
            // InvoicesManagement
            // 
            InvoicesManagement.AutoSize = true;
            InvoicesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesManagement.Location = new Point(619, 26);
            InvoicesManagement.Name = "InvoicesManagement";
            InvoicesManagement.Size = new Size(124, 30);
            InvoicesManagement.TabIndex = 0;
            InvoicesManagement.Text = "ادارة الفاوتير";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(DeleteAllPictureBox);
            panel2.Controls.Add(DeleteInvoicePictureBox);
            panel2.Controls.Add(AddInvoiceImg);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(DeleteInvoiceButton);
            panel2.Controls.Add(DeleteAllButton);
            panel2.Location = new Point(3, 82);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 90);
            panel2.TabIndex = 1;
            // 
            // DeleteAllPictureBox
            // 
            DeleteAllPictureBox.Image = (Image)resources.GetObject("DeleteAllPictureBox.Image");
            DeleteAllPictureBox.Location = new Point(287, 29);
            DeleteAllPictureBox.Margin = new Padding(3, 2, 3, 2);
            DeleteAllPictureBox.Name = "DeleteAllPictureBox";
            DeleteAllPictureBox.Size = new Size(56, 39);
            DeleteAllPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteAllPictureBox.TabIndex = 5;
            DeleteAllPictureBox.TabStop = false;
            DeleteAllPictureBox.Click += DeleteAllInvoices_Click;
            // 
            // DeleteInvoicePictureBox
            // 
            DeleteInvoicePictureBox.Image = (Image)resources.GetObject("DeleteInvoicePictureBox.Image");
            DeleteInvoicePictureBox.Location = new Point(668, 29);
            DeleteInvoicePictureBox.Margin = new Padding(3, 2, 3, 2);
            DeleteInvoicePictureBox.Name = "DeleteInvoicePictureBox";
            DeleteInvoicePictureBox.Size = new Size(56, 39);
            DeleteInvoicePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoicePictureBox.TabIndex = 4;
            DeleteInvoicePictureBox.TabStop = false;
            DeleteInvoicePictureBox.Click += DeleteInvoice_Click;
            // 
            // AddInvoiceImg
            // 
            AddInvoiceImg.Image = (Image)resources.GetObject("AddInvoiceImg.Image");
            AddInvoiceImg.Location = new Point(1038, 29);
            AddInvoiceImg.Margin = new Padding(3, 2, 3, 2);
            AddInvoiceImg.Name = "AddInvoiceImg";
            AddInvoiceImg.Size = new Size(56, 39);
            AddInvoiceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            AddInvoiceImg.TabIndex = 3;
            AddInvoiceImg.TabStop = false;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(919, 29);
            AddInvoiceBtn.Margin = new Padding(3, 2, 3, 2);
            AddInvoiceBtn.Name = "AddInvoiceBtn";
            AddInvoiceBtn.Size = new Size(114, 39);
            AddInvoiceBtn.TabIndex = 2;
            AddInvoiceBtn.Text = "اضافة فاتورة ";
            AddInvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteInvoiceButton
            // 
            DeleteInvoiceButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceButton.Location = new Point(550, 29);
            DeleteInvoiceButton.Margin = new Padding(3, 2, 3, 2);
            DeleteInvoiceButton.Name = "DeleteInvoiceButton";
            DeleteInvoiceButton.Size = new Size(114, 39);
            DeleteInvoiceButton.TabIndex = 1;
            DeleteInvoiceButton.Text = "مسح فاتورة";
            DeleteInvoiceButton.UseVisualStyleBackColor = false;
            DeleteInvoiceButton.Click += DeleteInvoice_Click;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteAllButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteAllButton.Location = new Point(168, 29);
            DeleteAllButton.Margin = new Padding(3, 2, 3, 2);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(114, 39);
            DeleteAllButton.TabIndex = 0;
            DeleteAllButton.Text = "مسح الكل";
            DeleteAllButton.UseVisualStyleBackColor = false;
            DeleteAllButton.Click += DeleteAllInvoices_Click;
            // 
            // InvoicesGridView
            // 
            InvoicesGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.CornflowerBlue;
            InvoicesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            InvoicesGridView.Anchor = AnchorStyles.None;
            InvoicesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InvoicesGridView.BorderStyle = BorderStyle.None;
            InvoicesGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            InvoicesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            InvoicesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new Padding(0, 2, 2, 2);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            InvoicesGridView.DefaultCellStyle = dataGridViewCellStyle8;
            InvoicesGridView.EnableHeadersVisualStyles = false;
            InvoicesGridView.Location = new Point(3, 178);
            InvoicesGridView.Margin = new Padding(3, 2, 3, 2);
            InvoicesGridView.MaximumSize = new Size(1314, 344);
            InvoicesGridView.Name = "InvoicesGridView";
            InvoicesGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            InvoicesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            InvoicesGridView.RowHeadersVisible = false;
            InvoicesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            InvoicesGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            InvoicesGridView.ScrollBars = ScrollBars.Vertical;
            InvoicesGridView.Size = new Size(1207, 344);
            InvoicesGridView.TabIndex = 2;
            InvoicesGridView.DataBindingComplete += InvoicesGridView_DataBindingComplete;
            // 
            // AdminInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1213, 527);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
            ((System.ComponentModel.ISupportInitialize)DeleteAllPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoicePictureBox).EndInit();
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
        private Button DeleteInvoiceButton;
        private Button DeleteAllButton;
        private DataGridView InvoicesGridView;
        private PictureBox DeleteInvoicePictureBox;
        private PictureBox AddInvoiceImg;
        private PictureBox DeleteAllPictureBox;
        private PictureBox LogoutImageAsBtn;
        private PictureBox PrevImgBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeImgBtn;
    }
}