namespace Carvo.User_Interface_Layer
{
    partial class MainWindowFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowFrom));
            label1 = new Label();
            label2 = new Label();
            employeePictureBox = new PictureBox();
            adminPictureBox = new PictureBox();
            adminBtn = new Button();
            employeeBtn = new Button();
            closeBtn = new Button();
            minimizeBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 30);
            label1.Name = "label1";
            label1.Size = new Size(568, 54);
            label1.TabIndex = 0;
            label1.Text = "شركة الاستاذ للاطارات والبطاريات";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 22);
            label2.Name = "label2";
            label2.Size = new Size(1296, 46);
            label2.TabIndex = 1;
            label2.Text = "مرحباً بك في نظام إدارة الورشة يمكنك إدارة عمليات الصيانة والمخزون والفواتير بسهولة وأمان";
            // 
            // employeePictureBox
            // 
            employeePictureBox.Image = (Image)resources.GetObject("employeePictureBox.Image");
            employeePictureBox.Location = new Point(296, 189);
            employeePictureBox.Margin = new Padding(3, 4, 3, 4);
            employeePictureBox.Name = "employeePictureBox";
            employeePictureBox.Size = new Size(197, 193);
            employeePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            employeePictureBox.TabIndex = 2;
            employeePictureBox.TabStop = false;
            employeePictureBox.Tag = "2";
            employeePictureBox.Click += PictureBox_Click;
            // 
            // adminPictureBox
            // 
            adminPictureBox.Image = (Image)resources.GetObject("adminPictureBox.Image");
            adminPictureBox.Location = new Point(889, 189);
            adminPictureBox.Margin = new Padding(3, 4, 3, 4);
            adminPictureBox.Name = "adminPictureBox";
            adminPictureBox.Size = new Size(197, 193);
            adminPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            adminPictureBox.TabIndex = 3;
            adminPictureBox.TabStop = false;
            adminPictureBox.Tag = "1";
            adminPictureBox.Click += PictureBox_Click;
            // 
            // adminBtn
            // 
            adminBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminBtn.Location = new Point(889, 403);
            adminBtn.Margin = new Padding(3, 4, 3, 4);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(197, 53);
            adminBtn.TabIndex = 4;
            adminBtn.Tag = "1";
            adminBtn.Text = "مدير";
            adminBtn.UseVisualStyleBackColor = true;
            adminBtn.Click += Btn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeBtn.Location = new Point(296, 403);
            employeeBtn.Margin = new Padding(3, 4, 3, 4);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(197, 53);
            employeeBtn.TabIndex = 5;
            employeeBtn.Tag = "2";
            employeeBtn.Text = "موظف";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += Btn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImage = (Image)resources.GetObject("closeBtn.BackgroundImage");
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Location = new Point(1393, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(50, 50);
            closeBtn.TabIndex = 8;
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // minimizeBtn
            // 
            minimizeBtn.BackgroundImage = (Image)resources.GetObject("minimizeBtn.BackgroundImage");
            minimizeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            minimizeBtn.FlatAppearance.BorderSize = 0;
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Location = new Point(1337, 3);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(50, 50);
            minimizeBtn.TabIndex = 9;
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(minimizeBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(29, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1459, 125);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(adminPictureBox);
            panel2.Controls.Add(employeeBtn);
            panel2.Controls.Add(adminBtn);
            panel2.Controls.Add(employeePictureBox);
            panel2.Location = new Point(68, 187);
            panel2.Name = "panel2";
            panel2.Size = new Size(1371, 587);
            panel2.TabIndex = 11;
            // 
            // MainWindowFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1510, 829);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindowFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindowFrom";
            ((System.ComponentModel.ISupportInitialize)employeePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox employeePictureBox;
        private PictureBox adminPictureBox;
        private Button adminBtn;
        private Button employeeBtn;
        private Button closeBtn;
        private Button minimizeBtn;
        private Panel panel1;
        private Panel panel2;
    }
}