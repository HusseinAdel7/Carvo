namespace Carvo.User_Interface_Layer
{
    partial class HomeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboardForm));
            welcomemsgLabel = new Label();
            pictureBox1 = new PictureBox();
            picUsers = new PictureBox();
            picCategories = new PictureBox();
            picProducts = new PictureBox();
            picSuppliers = new PictureBox();
            btnUsers = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnCustomers = new Button();
            picCustomers = new PictureBox();
            picreports = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            btnVehicles = new Button();
            picVehicles = new PictureBox();
            btnreports = new Button();
            InvoicesImgBtn = new PictureBox();
            InvoicesBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picreports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVehicles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesImgBtn).BeginInit();
            SuspendLayout();
            // 
            // welcomemsgLabel
            // 
            welcomemsgLabel.AutoSize = true;
            welcomemsgLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcomemsgLabel.ForeColor = Color.White;
            welcomemsgLabel.Location = new Point(553, 63);
            welcomemsgLabel.Name = "welcomemsgLabel";
            welcomemsgLabel.Size = new Size(351, 50);
            welcomemsgLabel.TabIndex = 0;
            welcomemsgLabel.Text = "مرحبا بك ,مدير النظام";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // picUsers
            // 
            picUsers.Image = (Image)resources.GetObject("picUsers.Image");
            picUsers.Location = new Point(1120, 252);
            picUsers.Margin = new Padding(3, 4, 3, 4);
            picUsers.Name = "picUsers";
            picUsers.Size = new Size(143, 129);
            picUsers.SizeMode = PictureBoxSizeMode.StretchImage;
            picUsers.TabIndex = 3;
            picUsers.TabStop = false;
            // 
            // picCategories
            // 
            picCategories.Image = (Image)resources.GetObject("picCategories.Image");
            picCategories.Location = new Point(818, 252);
            picCategories.Margin = new Padding(3, 4, 3, 4);
            picCategories.Name = "picCategories";
            picCategories.Size = new Size(147, 129);
            picCategories.SizeMode = PictureBoxSizeMode.StretchImage;
            picCategories.TabIndex = 4;
            picCategories.TabStop = false;
            // 
            // picProducts
            // 
            picProducts.Image = (Image)resources.GetObject("picProducts.Image");
            picProducts.Location = new Point(512, 252);
            picProducts.Margin = new Padding(3, 4, 3, 4);
            picProducts.Name = "picProducts";
            picProducts.Size = new Size(147, 129);
            picProducts.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducts.TabIndex = 5;
            picProducts.TabStop = false;
            // 
            // picSuppliers
            // 
            picSuppliers.Image = (Image)resources.GetObject("picSuppliers.Image");
            picSuppliers.Location = new Point(206, 252);
            picSuppliers.Margin = new Padding(3, 4, 3, 4);
            picSuppliers.Name = "picSuppliers";
            picSuppliers.Size = new Size(147, 129);
            picSuppliers.SizeMode = PictureBoxSizeMode.StretchImage;
            picSuppliers.TabIndex = 6;
            picSuppliers.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Location = new Point(1120, 404);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(147, 44);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "المستخدمين";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Location = new Point(818, 404);
            btnCategories.Margin = new Padding(3, 4, 3, 4);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(147, 44);
            btnCategories.TabIndex = 8;
            btnCategories.Text = "التصنيفات";
            btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.Black;
            btnProducts.Location = new Point(512, 404);
            btnProducts.Margin = new Padding(3, 4, 3, 4);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(147, 44);
            btnProducts.TabIndex = 9;
            btnProducts.Text = "المنتجات";
            btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.Black;
            btnSuppliers.Location = new Point(206, 404);
            btnSuppliers.Margin = new Padding(3, 4, 3, 4);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(147, 44);
            btnSuppliers.TabIndex = 10;
            btnSuppliers.Text = "الموردين";
            btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.Black;
            btnCustomers.Location = new Point(511, 639);
            btnCustomers.Margin = new Padding(3, 4, 3, 4);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(151, 44);
            btnCustomers.TabIndex = 13;
            btnCustomers.Text = "العملاء";
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // picCustomers
            // 
            picCustomers.Image = (Image)resources.GetObject("picCustomers.Image");
            picCustomers.Location = new Point(511, 487);
            picCustomers.Margin = new Padding(3, 4, 3, 4);
            picCustomers.Name = "picCustomers";
            picCustomers.Size = new Size(147, 129);
            picCustomers.SizeMode = PictureBoxSizeMode.StretchImage;
            picCustomers.TabIndex = 17;
            picCustomers.TabStop = false;
            // 
            // picreports
            // 
            picreports.Image = (Image)resources.GetObject("picreports.Image");
            picreports.Location = new Point(1128, 487);
            picreports.Margin = new Padding(3, 4, 3, 4);
            picreports.Name = "picreports";
            picreports.Size = new Size(143, 129);
            picreports.SizeMode = PictureBoxSizeMode.StretchImage;
            picreports.TabIndex = 18;
            picreports.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(1366, 32);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(50, 50);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 19;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(1279, 32);
            pictureBox12.Margin = new Padding(3, 4, 3, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(50, 50);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 20;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVehicles.ForeColor = Color.Black;
            btnVehicles.Location = new Point(818, 639);
            btnVehicles.Margin = new Padding(3, 4, 3, 4);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(147, 44);
            btnVehicles.TabIndex = 21;
            btnVehicles.Text = "المركبات";
            btnVehicles.UseVisualStyleBackColor = true;
            // 
            // picVehicles
            // 
            picVehicles.Image = (Image)resources.GetObject("picVehicles.Image");
            picVehicles.Location = new Point(818, 487);
            picVehicles.Margin = new Padding(3, 4, 3, 4);
            picVehicles.Name = "picVehicles";
            picVehicles.Size = new Size(147, 129);
            picVehicles.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehicles.TabIndex = 22;
            picVehicles.TabStop = false;
            // 
            // btnreports
            // 
            btnreports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnreports.ForeColor = Color.Black;
            btnreports.Location = new Point(1128, 639);
            btnreports.Margin = new Padding(3, 4, 3, 4);
            btnreports.Name = "btnreports";
            btnreports.Size = new Size(147, 44);
            btnreports.TabIndex = 23;
            btnreports.Text = "التقارير";
            btnreports.UseVisualStyleBackColor = true;
            // 
            // InvoicesImgBtn
            // 
            InvoicesImgBtn.Image = (Image)resources.GetObject("InvoicesImgBtn.Image");
            InvoicesImgBtn.Location = new Point(206, 487);
            InvoicesImgBtn.Margin = new Padding(3, 4, 3, 4);
            InvoicesImgBtn.Name = "InvoicesImgBtn";
            InvoicesImgBtn.Size = new Size(147, 129);
            InvoicesImgBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            InvoicesImgBtn.TabIndex = 25;
            InvoicesImgBtn.TabStop = false;
            // 
            // InvoicesBtn
            // 
            InvoicesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoicesBtn.ForeColor = Color.Black;
            InvoicesBtn.Location = new Point(206, 639);
            InvoicesBtn.Margin = new Padding(3, 4, 3, 4);
            InvoicesBtn.Name = "InvoicesBtn";
            InvoicesBtn.Size = new Size(151, 44);
            InvoicesBtn.TabIndex = 24;
            InvoicesBtn.Text = "الفواتير";
            InvoicesBtn.UseVisualStyleBackColor = true;
            // 
            // HomeDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 67, 87);
            ClientSize = new Size(1453, 755);
            Controls.Add(InvoicesImgBtn);
            Controls.Add(InvoicesBtn);
            Controls.Add(btnreports);
            Controls.Add(picVehicles);
            Controls.Add(btnVehicles);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(picreports);
            Controls.Add(picCustomers);
            Controls.Add(btnCustomers);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnCategories);
            Controls.Add(btnUsers);
            Controls.Add(picSuppliers);
            Controls.Add(picProducts);
            Controls.Add(picCategories);
            Controls.Add(picUsers);
            Controls.Add(pictureBox1);
            Controls.Add(welcomemsgLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeDashboardForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picreports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVehicles).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoicesImgBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomemsgLabel;
        private PictureBox pictureBox1;
        private PictureBox picUsers;
        private PictureBox picCategories;
        private PictureBox picProducts;
        private PictureBox picSuppliers;
        private Button btnUsers;
        private Button btnCategories;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button button5;
        private Button btnCustomers;
        private Button button8;
        private PictureBox pictureBox7;
        private PictureBox picCustomers;
        private PictureBox picreports;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private Button btnVehicles;
        private PictureBox picVehicles;
        private Button btnreports;
        private PictureBox InvoicesImgBtn;
        private Button InvoicesBtn;
    }
}