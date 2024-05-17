namespace SuperShopManagementSystemWindowsApplication
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnMngSupplier = new MetroFramework.Controls.MetroButton();
            this.btnManageCategory = new MetroFramework.Controls.MetroButton();
            this.btnMngUser = new MetroFramework.Controls.MetroButton();
            this.btnMngProduct = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.lblUserName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.btnMngSupplier);
            this.metroPanel1.Controls.Add(this.btnManageCategory);
            this.metroPanel1.Controls.Add(this.btnMngUser);
            this.metroPanel1.Controls.Add(this.btnMngProduct);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(0, 6);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(267, 1113);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Gray;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUserName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUserName.Location = new System.Drawing.Point(89, 70);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(36, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Mr. ";
            this.lblUserName.UseCustomBackColor = true;
            this.lblUserName.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.metroLabel1.Location = new System.Drawing.Point(89, 38);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Hello!";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(64, 559);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseCustomForeColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMngSupplier
            // 
            this.btnMngSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMngSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngSupplier.ForeColor = System.Drawing.Color.White;
            this.btnMngSupplier.Location = new System.Drawing.Point(0, 473);
            this.btnMngSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMngSupplier.Name = "btnMngSupplier";
            this.btnMngSupplier.Size = new System.Drawing.Size(267, 60);
            this.btnMngSupplier.TabIndex = 6;
            this.btnMngSupplier.Text = "Manage Supplier";
            this.btnMngSupplier.UseCustomBackColor = true;
            this.btnMngSupplier.UseCustomForeColor = true;
            this.btnMngSupplier.UseSelectable = true;
            this.btnMngSupplier.Click += new System.EventHandler(this.btnMngSupplier_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnManageCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCategory.ForeColor = System.Drawing.Color.White;
            this.btnManageCategory.Location = new System.Drawing.Point(0, 388);
            this.btnManageCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(267, 60);
            this.btnManageCategory.TabIndex = 5;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.UseCustomBackColor = true;
            this.btnManageCategory.UseCustomForeColor = true;
            this.btnManageCategory.UseSelectable = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // btnMngUser
            // 
            this.btnMngUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMngUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngUser.ForeColor = System.Drawing.Color.White;
            this.btnMngUser.Location = new System.Drawing.Point(0, 303);
            this.btnMngUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMngUser.Name = "btnMngUser";
            this.btnMngUser.Size = new System.Drawing.Size(267, 60);
            this.btnMngUser.TabIndex = 4;
            this.btnMngUser.Text = "User Management";
            this.btnMngUser.UseCustomBackColor = true;
            this.btnMngUser.UseCustomForeColor = true;
            this.btnMngUser.UseSelectable = true;
            this.btnMngUser.Click += new System.EventHandler(this.btnMngUser_Click);
            // 
            // btnMngProduct
            // 
            this.btnMngProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMngProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMngProduct.ForeColor = System.Drawing.Color.White;
            this.btnMngProduct.Location = new System.Drawing.Point(0, 218);
            this.btnMngProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMngProduct.Name = "btnMngProduct";
            this.btnMngProduct.Size = new System.Drawing.Size(267, 60);
            this.btnMngProduct.TabIndex = 3;
            this.btnMngProduct.Text = "Product Management";
            this.btnMngProduct.UseCustomBackColor = true;
            this.btnMngProduct.UseCustomForeColor = true;
            this.btnMngProduct.UseSelectable = true;
            this.btnMngProduct.Click += new System.EventHandler(this.btnMngProduct_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(0, 133);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(267, 60);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Sales Report";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnSalesReport);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 12;
            this.panelMain.Location = new System.Drawing.Point(275, 30);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(921, 585);
            this.panelMain.TabIndex = 1;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 13;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnMngSupplier;
        private MetroFramework.Controls.MetroButton btnManageCategory;
        private MetroFramework.Controls.MetroButton btnMngUser;
        private MetroFramework.Controls.MetroButton btnMngProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}