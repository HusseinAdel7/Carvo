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
            RepairImage.Location = new Point(233, 141);
            RepairImage.Margin = new Padding(4);
            RepairImage.Name = "RepairImage";
            RepairImage.Size = new Size(143, 132);
            RepairImage.SizeMode = PictureBoxSizeMode.Zoom;
            RepairImage.TabIndex = 0;
            RepairImage.TabStop = false;
            RepairImage.Click += RepairImage_Click;
            // 
            // SalesImage
            // 
            SalesImage.Image = (Image)resources.GetObject("SalesImage.Image");
            SalesImage.Location = new Point(757, 141);
            SalesImage.Margin = new Padding(4);
            SalesImage.Name = "SalesImage";
            SalesImage.Size = new Size(143, 132);
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
            RepairBtn.Location = new Point(233, 307);
            RepairBtn.Margin = new Padding(4);
            RepairBtn.Name = "RepairBtn";
            RepairBtn.Size = new Size(143, 45);
            RepairBtn.TabIndex = 2;
            RepairBtn.Text = "تصليح";
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
            SalesBtn.Location = new Point(757, 307);
            SalesBtn.Margin = new Padding(4);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(143, 45);
            SalesBtn.TabIndex = 3;
            SalesBtn.Text = "بيع";
            SalesBtn.UseVisualStyleBackColor = false;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // PrevFormBtn
            // 
            PrevFormBtn.Image = (Image)resources.GetObject("PrevFormBtn.Image");
            PrevFormBtn.Location = new Point(116, 3);
            PrevFormBtn.Name = "PrevFormBtn";
            PrevFormBtn.Size = new Size(50, 50);
            PrevFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevFormBtn.TabIndex = 13;
            PrevFormBtn.TabStop = false;
            PrevFormBtn.Click += PrevFormBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Image = (Image)resources.GetObject("LogOutBtn.Image");
            LogOutBtn.Location = new Point(18, 3);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(50, 50);
            LogOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogOutBtn.TabIndex = 12;
            LogOutBtn.TabStop = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1044, 3);
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
            MinimizeFormBtn.Location = new Point(944, 3);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 14;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PrevFormBtn);
            panel1.Controls.Add(CloseFormBtn);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(MinimizeFormBtn);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 63);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // InvoiceTypeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1143, 630);
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
    }
}