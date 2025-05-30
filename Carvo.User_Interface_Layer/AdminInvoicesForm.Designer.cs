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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            BackBtn = new Button();
            InvoicesManagement = new Label();
            panel2 = new Panel();
            AddInvoiceBtn = new Button();
            DeleteInvoiceBtn = new Button();
            DeleteAllInvoicesBtn = new Button();
            InvoicesGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(InvoicesManagement);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1502, 100);
            panel1.TabIndex = 0;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(224, 224, 224);
            BackBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.Black;
            BackBtn.Location = new Point(17, 16);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(156, 42);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "العودة للخلف ";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // InvoicesManagement
            // 
            InvoicesManagement.AutoSize = true;
            InvoicesManagement.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesManagement.Location = new Point(707, 20);
            InvoicesManagement.Name = "InvoicesManagement";
            InvoicesManagement.Size = new Size(158, 38);
            InvoicesManagement.TabIndex = 0;
            InvoicesManagement.Text = "ادارة الفاوتير";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(AddInvoiceBtn);
            panel2.Controls.Add(DeleteInvoiceBtn);
            panel2.Controls.Add(DeleteAllInvoicesBtn);
            panel2.Location = new Point(60, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(1388, 120);
            panel2.TabIndex = 1;
            // 
            // AddInvoiceBtn
            // 
            AddInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            AddInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            AddInvoiceBtn.Location = new Point(1017, 39);
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
            DeleteInvoiceBtn.Location = new Point(665, 39);
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
            DeleteAllInvoicesBtn.Location = new Point(332, 39);
            DeleteAllInvoicesBtn.Name = "DeleteAllInvoicesBtn";
            DeleteAllInvoicesBtn.Size = new Size(130, 52);
            DeleteAllInvoicesBtn.TabIndex = 0;
            DeleteAllInvoicesBtn.Text = "مسح الكل";
            DeleteAllInvoicesBtn.UseVisualStyleBackColor = false;
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
            InvoicesGridView.Location = new Point(60, 242);
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
            InvoicesGridView.Size = new Size(1387, 451);
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
            Name = "AdminInvoicesForm";
            Text = "AdminInvoicesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InvoicesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button BackBtn;
        private Label InvoicesManagement;
        private Panel panel2;
        private Button AddInvoiceBtn;
        private Button DeleteInvoiceBtn;
        private Button DeleteAllInvoicesBtn;
        private DataGridView InvoicesGridView;
    }
}