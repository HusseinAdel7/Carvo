namespace Carvo.User_Interface_Layer
{
    partial class EmployeeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboardForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ManageInvoicesBtn = new Button();
            ManageInvoicesImgBtn = new PictureBox();
            panel2 = new Panel();
            ManageCustomersBtn = new Button();
            ManageCustomersImgBtn = new PictureBox();
            panel3 = new Panel();
            ManageVehiclesBtn = new Button();
            ManageVehiclesImgBtn = new PictureBox();
            panel4 = new Panel();
            WelcomeMsgLabel = new Label();
            PrevFormBtn = new PictureBox();
            MinimizeFormBtn = new PictureBox();
            CloseFormBtn = new PictureBox();
            LogoutBtn = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageInvoicesImgBtn).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageCustomersImgBtn).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ManageVehiclesImgBtn).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33533F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3323326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3323326F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.166666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.8333359F));
            tableLayoutPanel1.Size = new Size(1518, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(ManageInvoicesBtn);
            panel1.Controls.Add(ManageInvoicesImgBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 473);
            panel1.TabIndex = 0;
            // 
            // ManageInvoicesBtn
            // 
            ManageInvoicesBtn.BackColor = Color.FromArgb(224, 224, 224);
            ManageInvoicesBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ManageInvoicesBtn.Location = new Point(155, 336);
            ManageInvoicesBtn.Name = "ManageInvoicesBtn";
            ManageInvoicesBtn.Size = new Size(249, 52);
            ManageInvoicesBtn.TabIndex = 17;
            ManageInvoicesBtn.Text = "ادارة الفواتير";
            ManageInvoicesBtn.UseVisualStyleBackColor = false;
            ManageInvoicesBtn.Click += ManageInvoicesBtn_Click;
            // 
            // ManageInvoicesImgBtn
            // 
            ManageInvoicesImgBtn.Image = (Image)resources.GetObject("ManageInvoicesImgBtn.Image");
            ManageInvoicesImgBtn.Location = new Point(155, 27);
            ManageInvoicesImgBtn.Name = "ManageInvoicesImgBtn";
            ManageInvoicesImgBtn.Size = new Size(249, 223);
            ManageInvoicesImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ManageInvoicesImgBtn.TabIndex = 0;
            ManageInvoicesImgBtn.TabStop = false;
            ManageInvoicesImgBtn.Click += ManageInvoicesBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ManageCustomersBtn);
            panel2.Controls.Add(ManageCustomersImgBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(509, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 473);
            panel2.TabIndex = 1;
            // 
            // ManageCustomersBtn
            // 
            ManageCustomersBtn.BackColor = Color.FromArgb(224, 224, 224);
            ManageCustomersBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ManageCustomersBtn.Location = new Point(131, 336);
            ManageCustomersBtn.Name = "ManageCustomersBtn";
            ManageCustomersBtn.Size = new Size(249, 52);
            ManageCustomersBtn.TabIndex = 18;
            ManageCustomersBtn.Text = "ادارة العملاء";
            ManageCustomersBtn.UseVisualStyleBackColor = false;
            ManageCustomersBtn.Click += ManageCustomersBtn_Click;
            // 
            // ManageCustomersImgBtn
            // 
            ManageCustomersImgBtn.Image = (Image)resources.GetObject("ManageCustomersImgBtn.Image");
            ManageCustomersImgBtn.Location = new Point(131, 27);
            ManageCustomersImgBtn.Name = "ManageCustomersImgBtn";
            ManageCustomersImgBtn.Size = new Size(249, 223);
            ManageCustomersImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ManageCustomersImgBtn.TabIndex = 1;
            ManageCustomersImgBtn.TabStop = false;
            ManageCustomersImgBtn.Click += ManageCustomersBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ManageVehiclesBtn);
            panel3.Controls.Add(ManageVehiclesImgBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1014, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 473);
            panel3.TabIndex = 2;
            // 
            // ManageVehiclesBtn
            // 
            ManageVehiclesBtn.BackColor = Color.FromArgb(224, 224, 224);
            ManageVehiclesBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            ManageVehiclesBtn.Location = new Point(118, 336);
            ManageVehiclesBtn.Name = "ManageVehiclesBtn";
            ManageVehiclesBtn.Size = new Size(249, 52);
            ManageVehiclesBtn.TabIndex = 19;
            ManageVehiclesBtn.Text = "ادارة المركبات";
            ManageVehiclesBtn.UseVisualStyleBackColor = false;
            ManageVehiclesBtn.Click += ManageVehiclesBtn_Click;
            // 
            // ManageVehiclesImgBtn
            // 
            ManageVehiclesImgBtn.Image = (Image)resources.GetObject("ManageVehiclesImgBtn.Image");
            ManageVehiclesImgBtn.Location = new Point(118, 27);
            ManageVehiclesImgBtn.Name = "ManageVehiclesImgBtn";
            ManageVehiclesImgBtn.Size = new Size(249, 223);
            ManageVehiclesImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ManageVehiclesImgBtn.TabIndex = 2;
            ManageVehiclesImgBtn.TabStop = false;
            ManageVehiclesImgBtn.Click += ManageVehiclesBtn_Click;
            // 
            // panel4
            // 
            tableLayoutPanel1.SetColumnSpan(panel4, 3);
            panel4.Controls.Add(WelcomeMsgLabel);
            panel4.Controls.Add(PrevFormBtn);
            panel4.Controls.Add(MinimizeFormBtn);
            panel4.Controls.Add(CloseFormBtn);
            panel4.Controls.Add(LogoutBtn);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1512, 115);
            panel4.TabIndex = 3;
            // 
            // WelcomeMsgLabel
            // 
            WelcomeMsgLabel.AutoSize = true;
            WelcomeMsgLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeMsgLabel.ForeColor = Color.White;
            WelcomeMsgLabel.Location = new Point(569, 31);
            WelcomeMsgLabel.Name = "WelcomeMsgLabel";
            WelcomeMsgLabel.Size = new Size(317, 41);
            WelcomeMsgLabel.TabIndex = 4;
            WelcomeMsgLabel.Text = "مرحبا بك , اسم الموظف";
            // 
            // PrevFormBtn
            // 
            PrevFormBtn.Image = (Image)resources.GetObject("PrevFormBtn.Image");
            PrevFormBtn.Location = new Point(132, 22);
            PrevFormBtn.Name = "PrevFormBtn";
            PrevFormBtn.Size = new Size(50, 50);
            PrevFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PrevFormBtn.TabIndex = 3;
            PrevFormBtn.TabStop = false;
            // 
            // MinimizeFormBtn
            // 
            MinimizeFormBtn.Image = (Image)resources.GetObject("MinimizeFormBtn.Image");
            MinimizeFormBtn.Location = new Point(1328, 22);
            MinimizeFormBtn.Name = "MinimizeFormBtn";
            MinimizeFormBtn.Size = new Size(50, 50);
            MinimizeFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeFormBtn.TabIndex = 2;
            MinimizeFormBtn.TabStop = false;
            MinimizeFormBtn.Click += MinimizeFormBtn_Click;
            // 
            // CloseFormBtn
            // 
            CloseFormBtn.Image = (Image)resources.GetObject("CloseFormBtn.Image");
            CloseFormBtn.Location = new Point(1415, 22);
            CloseFormBtn.Name = "CloseFormBtn";
            CloseFormBtn.Size = new Size(50, 50);
            CloseFormBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseFormBtn.TabIndex = 1;
            CloseFormBtn.TabStop = false;
            CloseFormBtn.Click += CloseFormBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Image = (Image)resources.GetObject("LogoutBtn.Image");
            LogoutBtn.Location = new Point(38, 22);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(50, 50);
            LogoutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoutBtn.TabIndex = 0;
            LogoutBtn.TabStop = false;
            // 
            // EmployeeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1518, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الصفحة الرئيسية للموظف";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageInvoicesImgBtn).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageCustomersImgBtn).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ManageVehiclesImgBtn).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrevFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseFormBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoutBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox ManageInvoicesImgBtn;
        private Panel panel2;
        private Panel panel3;
        private PictureBox ManageVehiclesImgBtn;
        private PictureBox ManageCustomersImgBtn;
        private Panel panel4;
        private PictureBox PrevFormBtn;
        private PictureBox MinimizeFormBtn;
        private PictureBox CloseFormBtn;
        private PictureBox LogoutBtn;
        private Label WelcomeMsgLabel;
        private Button ManageInvoicesBtn;
        private Button ManageCustomersBtn;
        private Button ManageVehiclesBtn;
    }
}