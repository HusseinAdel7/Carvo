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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            button9 = new Button();
            button8 = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            button3 = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label1.Location = new Point(666, 31);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 0;
            label1.Text = "فاتورة مبيعات ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1408, 3);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(101, 12);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 67, 87);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1526, 112);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(12, 6);
            button7.Name = "button7";
            button7.Size = new Size(54, 57);
            button7.TabIndex = 5;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(1444, 13);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(1379, 13);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(48, 67, 87);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1526, 340);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(763, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(244, 244, 244);
            button9.Location = new Point(645, 266);
            button9.Name = "button9";
            button9.Size = new Size(112, 50);
            button9.TabIndex = 16;
            button9.Text = "تحديث";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button8.ForeColor = Color.FromArgb(48, 67, 87);
            button8.Location = new Point(1218, 14);
            button8.Name = "button8";
            button8.Size = new Size(174, 39);
            button8.TabIndex = 13;
            button8.Text = "استخراج الفاتورة ";
            button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label6.ForeColor = Color.FromArgb(244, 244, 244);
            label6.Location = new Point(1292, 69);
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
            label5.Location = new Point(524, 69);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 10;
            label5.Text = "المشتري";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(244, 244, 244);
            numericUpDown2.Location = new Point(927, 279);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(247, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(244, 244, 244);
            button3.Location = new Point(330, 266);
            button3.Name = "button3";
            button3.Size = new Size(112, 50);
            button3.TabIndex = 6;
            button3.Text = "إضافة";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(244, 244, 244);
            label4.Location = new Point(1111, 180);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "1234";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(244, 244, 244);
            numericUpDown1.Location = new Point(287, 146);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.FromArgb(244, 244, 244);
            label3.Location = new Point(1229, 180);
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
            label2.Location = new Point(530, 141);
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
            comboBox2.Location = new Point(1023, 73);
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
            comboBox1.Location = new Point(284, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 28);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(48, 67, 87);
            dataGridView1.Location = new Point(0, 464);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1526, 247);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 748);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesInvoiceForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فاتورة مبيعات";
            Load += SalesInvoiceForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button6;
        private Button button5;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button button7;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button button8;
        private PictureBox pictureBox3;
        private Button button9;
    }
}