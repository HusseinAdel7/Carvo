namespace Carvo.User_Interface_Layer
{
    partial class UpdateAlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAlertForm));
            button3 = new Button();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(244, 244, 244);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button3.ForeColor = Color.FromArgb(48, 67, 87);
            button3.Location = new Point(74, 257);
            button3.Name = "button3";
            button3.Size = new Size(163, 46);
            button3.TabIndex = 15;
            button3.Text = "موافق";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(74, 65);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(163, 103);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(48, 67, 87);
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 184);
            label3.Name = "label3";
            label3.Size = new Size(171, 35);
            label3.TabIndex = 13;
            label3.Text = "تم التعديل بنجاح";
            // 
            // UpdateAlertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(322, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateAlertForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateAlertForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private PictureBox pictureBox5;
        private Label label3;
    }
}