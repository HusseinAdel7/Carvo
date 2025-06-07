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
            DeleteAllPictureBox = new PictureBox();
            DeleteInvoicePictureBox = new PictureBox();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1375, 630);
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
            panel1.Size = new Size(1369, 101);
            panel1.TabIndex = 0;
            // 
            // PrevImgBtn
            // 
            PrevImgBtn.Image = (Image)resources.GetObject("PrevImgBtn.Image");
            PrevImgBtn.Location = new Point(142, 20);
            PrevImgBtn.Name = "PrevImgBtn";
            PrevImgBtn.Size = new Size(53, 53);
            PrevImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevImgBtn.TabIndex = 4;
            PrevImgBtn.TabStop = false;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1288, 20);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(53, 53);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 3;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeImgBtn
            // 
            MinimizeImgBtn.Image = (Image)resources.GetObject("MinimizeImgBtn.Image");
            MinimizeImgBtn.Location = new Point(1196, 20);
            MinimizeImgBtn.Name = "MinimizeImgBtn";
            MinimizeImgBtn.Size = new Size(53, 53);
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
            LogoutImageAsBtn.Size = new Size(53, 53);
            LogoutImageAsBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutImageAsBtn.TabIndex = 1;
            LogoutImageAsBtn.TabStop = false;
            // 
            // InvoicesManagement
            // 
            InvoicesManagement.AutoSize = true;
            InvoicesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesManagement.Location = new Point(638, 35);
            InvoicesManagement.Name = "InvoicesManagement";
            InvoicesManagement.Size = new Size(158, 38);
            InvoicesManagement.TabIndex = 0;
            InvoicesManagement.Text = "ادارة الفاوتير";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(DeleteAllPictureBox);
            panel2.Controls.Add(DeleteInvoicePictureBox);
            panel2.Controls.Add(DeleteInvoiceButton);
            panel2.Controls.Add(DeleteAllButton);
            panel2.Location = new Point(3, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(1369, 246);
            panel2.TabIndex = 1;
            // 
            // DeleteAllPictureBox
            // 
            DeleteAllPictureBox.Image = (Image)resources.GetObject("DeleteAllPictureBox.Image");
            DeleteAllPictureBox.Location = new Point(533, 94);
            DeleteAllPictureBox.Name = "DeleteAllPictureBox";
            DeleteAllPictureBox.Size = new Size(64, 52);
            DeleteAllPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteAllPictureBox.TabIndex = 5;
            DeleteAllPictureBox.TabStop = false;
            DeleteAllPictureBox.Click += DeleteAllInvoices_Click;
            // 
            // DeleteInvoicePictureBox
            // 
            DeleteInvoicePictureBox.Image = (Image)resources.GetObject("DeleteInvoicePictureBox.Image");
            DeleteInvoicePictureBox.Location = new Point(968, 94);
            DeleteInvoicePictureBox.Name = "DeleteInvoicePictureBox";
            DeleteInvoicePictureBox.Size = new Size(64, 52);
            DeleteInvoicePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeleteInvoicePictureBox.TabIndex = 4;
            DeleteInvoicePictureBox.TabStop = false;
            DeleteInvoicePictureBox.Click += DeleteInvoice_Click;
            // 
            // DeleteInvoiceButton
            // 
            DeleteInvoiceButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteInvoiceButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteInvoiceButton.Location = new Point(834, 94);
            DeleteInvoiceButton.Name = "DeleteInvoiceButton";
            DeleteInvoiceButton.Size = new Size(130, 52);
            DeleteInvoiceButton.TabIndex = 1;
            DeleteInvoiceButton.Text = "مسح فاتورة";
            DeleteInvoiceButton.UseVisualStyleBackColor = false;
            DeleteInvoiceButton.Click += DeleteInvoice_Click;
            // 
            // DeleteAllButton
            // 
            DeleteAllButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteAllButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            DeleteAllButton.Location = new Point(397, 94);
            DeleteAllButton.Name = "DeleteAllButton";
            DeleteAllButton.Size = new Size(130, 52);
            DeleteAllButton.TabIndex = 0;
            DeleteAllButton.Text = "مسح الكل";
            DeleteAllButton.UseVisualStyleBackColor = false;
            DeleteAllButton.Click += DeleteAllInvoices_Click;
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
            InvoicesGridView.Location = new Point(3, 371);
            InvoicesGridView.MaximumSize = new Size(1502, 243);
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
            InvoicesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InvoicesGridView.Size = new Size(1369, 243);
            InvoicesGridView.TabIndex = 17;
            // 
            // AdminInvoicesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1375, 630);
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
            ((System.ComponentModel.ISupportInitialize)DeleteAllPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteInvoicePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label InvoicesManagement;
        private Panel panel2;
        private Button DeleteInvoiceButton;
        private Button DeleteAllButton;
        private PictureBox DeleteInvoicePictureBox;
        private PictureBox DeleteAllPictureBox;
        private PictureBox LogoutImageAsBtn;
        private PictureBox PrevImgBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeImgBtn;
        private DataGridView InvoicesGridView;
    }
}