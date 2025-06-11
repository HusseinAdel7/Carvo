namespace Carvo.User_Interface_Layer
{
    partial class AlertSelectAndDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertSelectAndDeleteForm));
            button4 = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(48, 67, 87);
            button4.Location = new Point(153, 400);
            button4.Name = "button4";
            button4.Size = new Size(163, 46);
            button4.TabIndex = 16;
            button4.Text = "موافق";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(177, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(48, 67, 87);
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.White;
            label4.Location = new Point(108, 281);
            label4.Name = "label4";
            label4.Size = new Size(254, 31);
            label4.TabIndex = 14;
            label4.Text = "الرجاء تحديد عنصر للحذف";
            // 
            // AlertSelectAndDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(462, 586);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertSelectAndDeleteForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlertSelectAndDelete";
            Load += AlertSelectAndDelete_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private PictureBox pictureBox2;
        private Label label4;
    }
}