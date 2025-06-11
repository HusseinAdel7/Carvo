namespace Carvo.User_Interface_Layer
{
    partial class InvoiceTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceTypeForm));
            RepairImage = new PictureBox();
            SalesImage = new PictureBox();
            RepairBtn = new Button();
            SalesBtn = new Button();
            PrevFormBtn = new PictureBox();
            LogOutBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)RepairImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalesImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RepairImage
            // 
            RepairImage.Image = (Image)resources.GetObject("RepairImage.Image");
            RepairImage.Location = new Point(877, 257);
            RepairImage.Margin = new Padding(4);
            RepairImage.Name = "RepairImage";
            RepairImage.Size = new Size(381, 327);
            RepairImage.SizeMode = PictureBoxSizeMode.Zoom;
            RepairImage.TabIndex = 0;
            RepairImage.TabStop = false;
            RepairImage.Click += RepairImage_Click;
            // 
            // SalesImage
            // 
            SalesImage.Image = (Image)resources.GetObject("SalesImage.Image");
            SalesImage.Location = new Point(269, 257);
            SalesImage.Margin = new Padding(4);
            SalesImage.Name = "SalesImage";
            SalesImage.Size = new Size(381, 327);
            SalesImage.SizeMode = PictureBoxSizeMode.Zoom;
            SalesImage.TabIndex = 1;
            SalesImage.TabStop = false;
            SalesImage.Click += SalesImage_Click;
            // 
            // RepairBtn
            // 
            RepairBtn.BackColor = Color.FromArgb(244, 244, 244);
            RepairBtn.Cursor = Cursors.Hand;
            RepairBtn.FlatStyle = FlatStyle.Flat;
            RepairBtn.ForeColor = Color.FromArgb(48, 67, 87);
            RepairBtn.Location = new Point(877, 637);
            RepairBtn.Margin = new Padding(4);
            RepairBtn.Name = "RepairBtn";
            RepairBtn.Size = new Size(381, 51);
            RepairBtn.TabIndex = 2;
            RepairBtn.Text = "صيانة";
            RepairBtn.UseVisualStyleBackColor = false;
            RepairBtn.Click += RepairBtn_Click;
            // 
            // SalesBtn
            // 
            SalesBtn.BackColor = Color.FromArgb(244, 244, 244);
            SalesBtn.Cursor = Cursors.Hand;
            SalesBtn.FlatStyle = FlatStyle.Flat;
            SalesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalesBtn.ForeColor = Color.FromArgb(48, 67, 87);
            SalesBtn.Location = new Point(269, 637);
            SalesBtn.Margin = new Padding(4);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(381, 51);
            SalesBtn.TabIndex = 3;
            SalesBtn.Text = "مشتريات";
            SalesBtn.UseVisualStyleBackColor = false;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // PrevFormBtn
            // 
            PrevFormBtn.Image = (Image)resources.GetObject("PrevFormBtn.Image");
            PrevFormBtn.Location = new Point(113, 8);
            PrevFormBtn.Name = "PrevFormBtn";
            PrevFormBtn.Size = new Size(45, 45);
            PrevFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevFormBtn.TabIndex = 13;
            PrevFormBtn.TabStop = false;
            PrevFormBtn.Click += PrevFormBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Image = (Image)resources.GetObject("LogOutBtn.Image");
            LogOutBtn.Location = new Point(33, 8);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(45, 45);
            LogOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogOutBtn.TabIndex = 12;
            LogOutBtn.TabStop = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1399, 3);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 15;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1318, 3);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 14;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PrevFormBtn);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(MinimizeFormBtn);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 63);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(644, -1);
            label1.Name = "label1";
            label1.Size = new Size(210, 54);
            label1.TabIndex = 17;
            label1.Text = "نوع الفاتورة";
            // 
            // InvoiceTypeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1510, 829);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(SalesBtn);
            Controls.Add(RepairBtn);
            Controls.Add(SalesImage);
            Controls.Add(RepairImage);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceTypeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نموذج اختيار نوع الفاتورة";
            ((System.ComponentModel.ISupportInitialize)RepairImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalesImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox RepairImage;
        private PictureBox SalesImage;
        private Button RepairBtn;
        private Button SalesBtn;
        private PictureBox PrevFormBtn;
        private PictureBox LogOutBtn;
        private PictureBox CloseFormBtn;
        private PictureBox MinimizeFormBtn;
        private Panel panel1;
        private Label label1;
    }
}