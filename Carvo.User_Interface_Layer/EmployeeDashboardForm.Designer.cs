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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 29);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 0;
            label1.Text = "مرحبًا بك، اسم الموظف";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.97599F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.0240059F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 267F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 100);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 350);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Cursor = Cursors.Hand;
            flowLayoutPanel1.Location = new Point(23, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(150, 150);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 20);
            pictureBox2.Margin = new Padding(10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 90);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "       اضافة فاتورة";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(pictureBox3);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Cursor = Cursors.Hand;
            flowLayoutPanel2.Location = new Point(289, 30);
            flowLayoutPanel2.Margin = new Padding(10);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(150, 150);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 20);
            pictureBox3.Margin = new Padding(10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 90);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 1;
            label3.Text = "            ألعملاء";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top;
            flowLayoutPanel3.BackColor = Color.White;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(pictureBox4);
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Cursor = Cursors.Hand;
            flowLayoutPanel3.Location = new Point(571, 30);
            flowLayoutPanel3.Margin = new Padding(10);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(150, 150);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 20);
            pictureBox4.Margin = new Padding(10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 90);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 1;
            label4.Text = "          المركبات";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // EmployeeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EmployeeDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الصفحة الرئيسية للموظف";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox4;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox5;
    }
}