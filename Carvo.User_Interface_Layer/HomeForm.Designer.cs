namespace Carvo.User_Interface_Layer
{
    partial class HomeForm
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
            LablName = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // LablName
            // 
            LablName.AutoSize = true;
            LablName.Font = new Font("Segoe UI", 18F);
            LablName.Location = new Point(347, 46);
            LablName.Name = "LablName";
            LablName.Size = new Size(343, 32);
            LablName.TabIndex = 0;
            LablName.Text = "شركة الاستاذ للاطارات والبطاريات";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(223, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(565, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "أهلاً بك في نظام إدارة الورشة، يرجى اختيار نوع المستخدم";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(611, 274);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 2;
            button1.Text = "مدير";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(415, 279);
            button2.Name = "button2";
            button2.Size = new Size(97, 39);
            button2.TabIndex = 3;
            button2.Text = "موظف";
            button2.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ph_jpj;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(LablName);
            Name = "HomeForm";
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LablName;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}