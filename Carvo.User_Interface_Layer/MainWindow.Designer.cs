namespace Carvo.User_Interface_Layer
{
    partial class MainWindow
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
            button1 = new Button();
            button2 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244, 244);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.Location = new Point(298, 376);
            button1.Name = "button1";
            button1.Size = new Size(140, 46);
            button1.TabIndex = 3;
            button1.Text = "موظف";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 244, 244, 244);
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(819, 376);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 4;
            button2.Text = "مدير";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 67, 87);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(362, 48);
            label1.Name = "label1";
            label1.Size = new Size(487, 45);
            label1.TabIndex = 7;
            label1.Text = "شركة الاستاذ للاطارات والبطاريات";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.software_engineer;
            pictureBox1.Location = new Point(298, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.employee;
            pictureBox2.Location = new Point(819, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 128);
            label2.Name = "label2";
            label2.Size = new Size(1128, 40);
            label2.TabIndex = 10;
            label2.Text = "مرحباً بك في نظام إدارة الورشة يمكنك إدارة عمليات الصيانة والمخزون والفواتير بسهولة وأمان";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1370, 522);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}