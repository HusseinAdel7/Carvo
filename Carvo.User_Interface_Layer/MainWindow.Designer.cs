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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(990, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(793, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "شركة الاستاذ للاطارات والبطاريات";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonFace;
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(235, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(912, 39);
            textBox2.TabIndex = 2;
            textBox2.Text = "مرحباً بك في نظام إدارة الورشة يمكنك إدارة عمليات الصيانة والمخزون والفواتير بسهولة وأمان";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244, 244);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.Location = new Point(507, 289);
            button1.Name = "button1";
            button1.Size = new Size(126, 46);
            button1.TabIndex = 3;
            button1.Text = "موظف";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 244, 244, 244);
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(1025, 285);
            button2.Name = "button2";
            button2.Size = new Size(122, 50);
            button2.TabIndex = 4;
            button2.Text = "مدير";
            button2.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1370, 522);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}