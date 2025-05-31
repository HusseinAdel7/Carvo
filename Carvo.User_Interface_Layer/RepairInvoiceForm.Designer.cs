namespace Carvo.User_Interface_Layer
{
    partial class RepairInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairInvoiceForm));
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(244, 244, 244);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 273);
            panel2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(244, 244, 244);
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(48, 67, 87);
            label6.Location = new Point(551, 52);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 10;
            label6.Text = "نوع المركبة";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(244, 244, 244);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.FromArgb(48, 67, 87);
            label5.Location = new Point(237, 52);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 9;
            label5.Text = "المشتري";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(244, 244, 244);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.FromArgb(48, 67, 87);
            label4.Location = new Point(423, 150);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 5;
            label4.Text = "1234";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(244, 244, 244);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(48, 67, 87);
            label3.Location = new Point(502, 150);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 3;
            label3.Text = "اجمالي سعر الصيانة ";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaption;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "عربية ", "موتوسيكل ", "عجلة" });
            comboBox2.Location = new Point(375, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "" });
            comboBox1.Location = new Point(49, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 94);
            panel1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 244, 244);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 15);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 0;
            label1.Text = "فاتورة صيانة ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244);
            button1.Location = new Point(547, 46);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "طباعة الفاتورة ";
            button1.UseVisualStyleBackColor = false;
            // 
            // RepairInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 370);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RepairInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "فاتورة صيانة";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button button1;
    }
}