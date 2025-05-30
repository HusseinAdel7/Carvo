namespace Carvo.User_Interface_Layer
{
    partial class AlertIncompleteInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertIncompleteInformationForm));
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(48, 67, 87);
            button5.Location = new Point(99, 274);
            button5.Name = "button5";
            button5.Size = new Size(163, 46);
            button5.TabIndex = 17;
            button5.Text = "موافق";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(48, 67, 87);
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label5.ForeColor = Color.White;
            label5.Location = new Point(62, 199);
            label5.Name = "label5";
            label5.Size = new Size(247, 31);
            label5.TabIndex = 15;
            label5.Text = "الرجاء تعبئة جميع الحقول";
            // 
            // AlertIncompleteInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(352, 450);
            Controls.Add(button5);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Name = "AlertIncompleteInformationForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "AlertIncompleteInformationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private PictureBox pictureBox1;
        private Label label5;
    }
}