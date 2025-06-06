namespace Carvo.User_Interface_Layer
{
    partial class PaidSalesInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaidSalesInvoiceForm));
            PaidPriceNumeric = new NumericUpDown();
            label3 = new Label();
            label1 = new Label();
            TotalPriceNumeric = new NumericUpDown();
            pictureBox1 = new PictureBox();
            PrintInvoiceBtn = new Button();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PaidPriceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            SuspendLayout();
            // 
            // PaidPriceNumeric
            // 
            PaidPriceNumeric.Location = new Point(123, 333);
            PaidPriceNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            PaidPriceNumeric.Name = "PaidPriceNumeric";
            PaidPriceNumeric.Size = new Size(265, 27);
            PaidPriceNumeric.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(244, 244, 244);
            label3.Location = new Point(197, 270);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 4;
            label3.Text = "المبلغ المدفوع";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(207, 114);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 6;
            label1.Text = "المبلغ الكلي";
            // 
            // TotalPriceNumeric
            // 
            TotalPriceNumeric.Enabled = false;
            TotalPriceNumeric.Location = new Point(123, 182);
            TotalPriceNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            TotalPriceNumeric.Name = "TotalPriceNumeric";
            TotalPriceNumeric.Size = new Size(265, 27);
            TotalPriceNumeric.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(294, 446);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // PrintInvoiceBtn
            // 
            PrintInvoiceBtn.BackColor = Color.FromArgb(224, 224, 224);
            PrintInvoiceBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            PrintInvoiceBtn.Location = new Point(158, 446);
            PrintInvoiceBtn.Name = "PrintInvoiceBtn";
            PrintInvoiceBtn.Size = new Size(130, 52);
            PrintInvoiceBtn.TabIndex = 13;
            PrintInvoiceBtn.Text = "طباعة";
            PrintInvoiceBtn.UseVisualStyleBackColor = false;
            PrintInvoiceBtn.Click += PrintInvoiceBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(463, 21);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 16;
            CloseFormBtn.TabStop = false;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(384, 21);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 15;
            MinimizeFormBtn.TabStop = false;
            // 
            // PaidSalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(525, 537);
            Controls.Add(CloseFormBtn);
            Controls.Add(MinimizeFormBtn);
            Controls.Add(pictureBox1);
            Controls.Add(PrintInvoiceBtn);
            Controls.Add(label1);
            Controls.Add(TotalPriceNumeric);
            Controls.Add(label3);
            Controls.Add(PaidPriceNumeric);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaidSalesInvoiceForm";
            Text = "PaidSalesInvoiceForm";
            ((System.ComponentModel.ISupportInitialize)PaidPriceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalPriceNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown PaidPriceNumeric;
        private Label label3;
        private Label label1;
        private NumericUpDown TotalPriceNumeric;
        private PictureBox pictureBox1;
        private Button PrintInvoiceBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
    }
}