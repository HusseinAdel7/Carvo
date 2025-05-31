namespace Carvo.User_Interface_Layer
{
    partial class VehicleDashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDashboardForm));
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            vehicleGrid = new DataGridView();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(556, 36);
            label1.Name = "label1";
            label1.Size = new Size(415, 38);
            label1.TabIndex = 0;
            label1.Text = "مرحبا بكم في صفحة ادارة المركبات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(608, 65);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 3;
            label4.Text = "اسم المركبة";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(124, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(467, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(124, 139);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(467, 39);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(608, 142);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 8;
            label3.Text = "موديل المركبة";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(124, 212);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(467, 39);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(608, 215);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 10;
            label5.Text = "رقم اللوحة";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 244, 244);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(963, 65);
            button1.Name = "button1";
            button1.Size = new Size(135, 71);
            button1.TabIndex = 12;
            button1.Text = "اضافة المركبة";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(244, 244, 244);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(963, 164);
            button2.Name = "button2";
            button2.Size = new Size(135, 71);
            button2.TabIndex = 13;
            button2.Text = "تعديل المركبة";
            button2.UseVisualStyleBackColor = false;
            // 
            // vehicleGrid
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(252, 9, 121);
            vehicleGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            vehicleGrid.BackgroundColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(252, 9, 121);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            vehicleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            vehicleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 67, 87);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(250, 9, 131);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            vehicleGrid.DefaultCellStyle = dataGridViewCellStyle3;
            vehicleGrid.EnableHeadersVisualStyles = false;
            vehicleGrid.Location = new Point(72, 492);
            vehicleGrid.Name = "vehicleGrid";
            vehicleGrid.RowHeadersVisible = false;
            vehicleGrid.RowHeadersWidth = 51;
            vehicleGrid.Size = new Size(1369, 172);
            vehicleGrid.TabIndex = 15;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(90, 3);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1114, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1114, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(1, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1523, 104);
            panel1.TabIndex = 22;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(20, 3);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 22;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(1442, 3);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 21;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1386, 3);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(72, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(1369, 305);
            panel2.TabIndex = 23;
            // 
            // VehicleDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1526, 676);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(vehicleGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleDashboardForm";
            Text = "CustomerDashboardForm";
            Load += CustomerDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)vehicleGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private DataGridView vehicleGrid;
        private Button button4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Button button8;
        private Button button7;
        private Button button3;
    }
}