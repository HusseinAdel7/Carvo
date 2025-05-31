namespace Carvo.User_Interface_Layer
{
    partial class DeleteAlertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAlertForm));
            pictureBox4 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(81, 109);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(138, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            button1.ForeColor = Color.FromArgb(48, 67, 87);
            button1.Location = new Point(68, 278);
            button1.Name = "button1";
            button1.Size = new Size(163, 46);
            button1.TabIndex = 11;
            button1.Text = "موافق";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(48, 67, 87);
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 197);
            label2.Name = "label2";
            label2.Size = new Size(207, 41);
            label2.TabIndex = 10;
            label2.Text = "تم الحذف بنجاح";
            // 
            // DeleteAlertForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(300, 450);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "DeleteAlertForm";
            Text = "DeleteAlertForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private Button button1;
        private Label label2;
    }
}