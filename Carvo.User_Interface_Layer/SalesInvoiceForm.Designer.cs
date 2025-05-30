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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            numericUpDown2 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            المشتري = new DataGridViewTextBoxColumn();
            المنتج = new DataGridViewTextBoxColumn();
            الكمية = new DataGridViewTextBoxColumn();
            السعر = new DataGridViewTextBoxColumn();
            رقم_المنتج = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "فاتورة مبيعات ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(547, 46);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "طباعة الفاتورة ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(79, 46);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 2;
            button2.Text = "الرجوع للخلف";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
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
            panel2.Size = new Size(694, 407);
            panel2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaption;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5", "" });
            comboBox1.Location = new Point(180, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaption;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Product1", "Product2", "Product3" });
            comboBox2.Location = new Point(490, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(79, 126);
            label2.Name = "label2";
            label2.Size = new Size(66, 43);
            label2.TabIndex = 2;
            label2.Text = "الكمية  ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 145);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "اجمالي السعر";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ActiveCaption;
            numericUpDown1.Location = new Point(180, 138);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(600, 149);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "1234";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(79, 226);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "إضافة";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(314, 226);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "حذف";
            button4.UseVisualStyleBackColor = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = SystemColors.ActiveCaption;
            numericUpDown2.Location = new Point(491, 228);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { المشتري, المنتج, الكمية, السعر, رقم_المنتج });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(0, 507);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(694, 241);
            dataGridView1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 38);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "المشتري";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(434, 33);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 10;
            label6.Text = "المنتج";
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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