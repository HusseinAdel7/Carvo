namespace Carvo.User_Interface_Layer
{
    partial class SalesInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceForm));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            button3 = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            المشتري = new DataGridViewTextBoxColumn();
            المنتج = new DataGridViewTextBoxColumn();
            الكمية = new DataGridViewTextBoxColumn();
            السعر = new DataGridViewTextBoxColumn();
            رقم_المنتج = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.FromArgb(244, 244, 244);
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "فاتورة مبيعات ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.Location = new Point(547, 46);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "طباعة الفاتورة ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 244, 244);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(36, 28);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
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
            panel1.Size = new Size(694, 94);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 348);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(244, 244, 244);
            label6.Location = new Point(579, 30);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 10;
            label6.Text = "المنتج";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.FromArgb(244, 244, 244);
            label5.Location = new Point(204, 26);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 9;
            label5.Text = "المشتري";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(244, 244, 244);
            numericUpDown2.Location = new Point(525, 218);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(116, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(244, 244, 244);
            button4.Location = new Point(386, 218);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "حذف";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(244, 244, 244);
            button3.Location = new Point(191, 218);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "إضافة";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(244, 244, 244);
            label4.Location = new Point(439, 132);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "1234";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(244, 244, 244);
            numericUpDown1.Location = new Point(36, 130);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(244, 244, 244);
            label3.Location = new Point(516, 125);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 3;
            label3.Text = "اجمالي السعر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(244, 244, 244);
            label2.Location = new Point(210, 125);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 2;
            label2.Text = "الكمية  ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaption;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Product1", "Product2", "Product3" });
            comboBox2.Location = new Point(329, 30);
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
            comboBox1.Location = new Point(33, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(48, 67, 87);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { المشتري, المنتج, الكمية, السعر, رقم_المنتج });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = Color.FromArgb(48, 67, 87);
            dataGridView1.Location = new Point(0, 448);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 300);
            dataGridView1.TabIndex = 5;
            // 
            // المشتري
            // 
            المشتري.HeaderText = "المشتري";
            المشتري.MinimumWidth = 6;
            المشتري.Name = "المشتري";
            المشتري.Width = 125;
            // 
            // المنتج
            // 
            المنتج.HeaderText = "المنتج";
            المنتج.MinimumWidth = 6;
            المنتج.Name = "المنتج";
            المنتج.Width = 125;
            // 
            // الكمية
            // 
            الكمية.HeaderText = "الكمية";
            الكمية.MinimumWidth = 6;
            الكمية.Name = "الكمية";
            الكمية.Width = 125;
            // 
            // السعر
            // 
            السعر.HeaderText = "السعر";
            السعر.MinimumWidth = 6;
            السعر.Name = "السعر";
            السعر.Width = 125;
            // 
            // رقم_المنتج
            // 
            رقم_المنتج.HeaderText = "رقم_المنتج";
            رقم_المنتج.MinimumWidth = 6;
            رقم_المنتج.Name = "رقم_المنتج";
            رقم_المنتج.Width = 125;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 748);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SalesInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "فاتورة مبيعات";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button button4;
        private Button button3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn المشتري;
        private DataGridViewTextBoxColumn المنتج;
        private DataGridViewTextBoxColumn الكمية;
        private DataGridViewTextBoxColumn السعر;
        private DataGridViewTextBoxColumn رقم_المنتج;
    }
}