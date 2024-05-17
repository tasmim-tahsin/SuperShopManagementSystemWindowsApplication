namespace SuperShopManagementSystemWindowsApplication.Controls
{
    partial class UserControlSupplier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchBySupName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.gridSupplier = new MetroFramework.Controls.MetroGrid();
            this.SupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtSupId = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSupContactNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSupEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtSupName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(921, 585);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.Controls.Add(this.txtSearchBySupName);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 12;
            this.metroPanel5.Location = new System.Drawing.Point(4, 314);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(917, 39);
            this.metroPanel5.TabIndex = 21;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.UseStyleColors = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 13;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel7.Location = new System.Drawing.Point(15, 10);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(153, 17);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Search by Supplier name";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtSearchBySupName
            // 
            // 
            // 
            // 
            this.txtSearchBySupName.CustomButton.Image = null;
            this.txtSearchBySupName.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.txtSearchBySupName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBySupName.CustomButton.Name = "";
            this.txtSearchBySupName.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSearchBySupName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchBySupName.CustomButton.TabIndex = 1;
            this.txtSearchBySupName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchBySupName.CustomButton.UseSelectable = true;
            this.txtSearchBySupName.CustomButton.Visible = false;
            this.txtSearchBySupName.Lines = new string[0];
            this.txtSearchBySupName.Location = new System.Drawing.Point(216, 5);
            this.txtSearchBySupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBySupName.MaxLength = 32767;
            this.txtSearchBySupName.Name = "txtSearchBySupName";
            this.txtSearchBySupName.PasswordChar = '\0';
            this.txtSearchBySupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchBySupName.SelectedText = "";
            this.txtSearchBySupName.SelectionLength = 0;
            this.txtSearchBySupName.SelectionStart = 0;
            this.txtSearchBySupName.ShortcutsEnabled = true;
            this.txtSearchBySupName.Size = new System.Drawing.Size(235, 28);
            this.txtSearchBySupName.TabIndex = 18;
            this.txtSearchBySupName.UseSelectable = true;
            this.txtSearchBySupName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchBySupName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchBySupName.TextChanged += new System.EventHandler(this.txtSearchBySupName_TextChanged);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.gridSupplier);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(4, 358);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(913, 223);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // gridSupplier
            // 
            this.gridSupplier.AllowUserToAddRows = false;
            this.gridSupplier.AllowUserToDeleteRows = false;
            this.gridSupplier.AllowUserToResizeRows = false;
            this.gridSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupId,
            this.SupName,
            this.SupEmail,
            this.SupContactNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSupplier.EnableHeadersVisualStyles = false;
            this.gridSupplier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSupplier.Location = new System.Drawing.Point(0, 0);
            this.gridSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridSupplier.Name = "gridSupplier";
            this.gridSupplier.ReadOnly = true;
            this.gridSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSupplier.RowHeadersWidth = 51;
            this.gridSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplier.Size = new System.Drawing.Size(913, 226);
            this.gridSupplier.Style = MetroFramework.MetroColorStyle.Orange;
            this.gridSupplier.TabIndex = 2;
            this.gridSupplier.DoubleClick += new System.EventHandler(this.gridSupplier_DoubleClick);
            // 
            // SupId
            // 
            this.SupId.DataPropertyName = "SupId";
            this.SupId.HeaderText = "ID";
            this.SupId.MinimumWidth = 6;
            this.SupId.Name = "SupId";
            this.SupId.ReadOnly = true;
            this.SupId.Width = 125;
            // 
            // SupName
            // 
            this.SupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "Supplier Name";
            this.SupName.MinimumWidth = 6;
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // SupEmail
            // 
            this.SupEmail.DataPropertyName = "SupEmail";
            this.SupEmail.HeaderText = "Email";
            this.SupEmail.MinimumWidth = 6;
            this.SupEmail.Name = "SupEmail";
            this.SupEmail.ReadOnly = true;
            this.SupEmail.Width = 125;
            // 
            // SupContactNo
            // 
            this.SupContactNo.DataPropertyName = "SupContactNo";
            this.SupContactNo.HeaderText = "ContactNo";
            this.SupContactNo.MinimumWidth = 6;
            this.SupContactNo.Name = "SupContactNo";
            this.SupContactNo.ReadOnly = true;
            this.SupContactNo.Width = 125;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.Controls.Add(this.txtSupId);
            this.metroPanel2.Controls.Add(this.metroPanel4);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.txtSupContactNo);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.txtSupEmail);
            this.metroPanel2.Controls.Add(this.btnClear);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.txtSupName);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(4, 71);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(913, 238);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(16, 11);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 20);
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Supplier Id";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // txtSupId
            // 
            // 
            // 
            // 
            this.txtSupId.CustomButton.Image = null;
            this.txtSupId.CustomButton.Location = new System.Drawing.Point(429, 2);
            this.txtSupId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupId.CustomButton.Name = "";
            this.txtSupId.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSupId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupId.CustomButton.TabIndex = 1;
            this.txtSupId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupId.CustomButton.UseSelectable = true;
            this.txtSupId.CustomButton.Visible = false;
            this.txtSupId.Lines = new string[0];
            this.txtSupId.Location = new System.Drawing.Point(155, 11);
            this.txtSupId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupId.MaxLength = 32767;
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.PasswordChar = '\0';
            this.txtSupId.PromptText = "Enter supplier id";
            this.txtSupId.ReadOnly = true;
            this.txtSupId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupId.SelectedText = "";
            this.txtSupId.SelectionLength = 0;
            this.txtSupId.SelectionStart = 0;
            this.txtSupId.ShortcutsEnabled = true;
            this.txtSupId.Size = new System.Drawing.Size(348, 28);
            this.txtSupId.TabIndex = 26;
            this.txtSupId.UseSelectable = true;
            this.txtSupId.WaterMark = "Enter supplier id";
            this.txtSupId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.LightYellow;
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroLabel12);
            this.metroPanel4.Controls.Add(this.metroLabel11);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(527, 4);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(387, 229);
            this.metroPanel4.TabIndex = 25;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            this.metroPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel4_Paint);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.Red;
            this.metroLabel6.Location = new System.Drawing.Point(24, 130);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(165, 17);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "then click the delete button";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(21, 177);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(189, 17);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Contact No for save operation.";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.ForeColor = System.Drawing.Color.Red;
            this.metroLabel12.Location = new System.Drawing.Point(4, 159);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(251, 17);
            this.metroLabel12.TabIndex = 5;
            this.metroLabel12.Text = "3. All field must be filled except Email and";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.ForeColor = System.Drawing.Color.Red;
            this.metroLabel11.Location = new System.Drawing.Point(4, 112);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(245, 17);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "2. Select the row first you want to delete.";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.ForeColor = System.Drawing.Color.Red;
            this.metroLabel10.Location = new System.Drawing.Point(4, 79);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(304, 17);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "1. Double click any row for update the information.";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.Red;
            this.metroLabel9.Location = new System.Drawing.Point(148, 12);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(100, 20);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "*Instruction*";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(16, 129);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 20);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "ContactNo";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // txtSupContactNo
            // 
            // 
            // 
            // 
            this.txtSupContactNo.CustomButton.Image = null;
            this.txtSupContactNo.CustomButton.Location = new System.Drawing.Point(429, 2);
            this.txtSupContactNo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupContactNo.CustomButton.Name = "";
            this.txtSupContactNo.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSupContactNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupContactNo.CustomButton.TabIndex = 1;
            this.txtSupContactNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupContactNo.CustomButton.UseSelectable = true;
            this.txtSupContactNo.CustomButton.Visible = false;
            this.txtSupContactNo.Lines = new string[0];
            this.txtSupContactNo.Location = new System.Drawing.Point(155, 129);
            this.txtSupContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupContactNo.MaxLength = 32767;
            this.txtSupContactNo.Name = "txtSupContactNo";
            this.txtSupContactNo.PasswordChar = '\0';
            this.txtSupContactNo.PromptText = "Enter contact no";
            this.txtSupContactNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupContactNo.SelectedText = "";
            this.txtSupContactNo.SelectionLength = 0;
            this.txtSupContactNo.SelectionStart = 0;
            this.txtSupContactNo.ShortcutsEnabled = true;
            this.txtSupContactNo.Size = new System.Drawing.Size(348, 28);
            this.txtSupContactNo.TabIndex = 23;
            this.txtSupContactNo.UseSelectable = true;
            this.txtSupContactNo.WaterMark = "Enter contact no";
            this.txtSupContactNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupContactNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(16, 90);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 20);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Email";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtSupEmail
            // 
            // 
            // 
            // 
            this.txtSupEmail.CustomButton.Image = null;
            this.txtSupEmail.CustomButton.Location = new System.Drawing.Point(429, 2);
            this.txtSupEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupEmail.CustomButton.Name = "";
            this.txtSupEmail.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSupEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupEmail.CustomButton.TabIndex = 1;
            this.txtSupEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupEmail.CustomButton.UseSelectable = true;
            this.txtSupEmail.CustomButton.Visible = false;
            this.txtSupEmail.Lines = new string[0];
            this.txtSupEmail.Location = new System.Drawing.Point(155, 90);
            this.txtSupEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupEmail.MaxLength = 32767;
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.PasswordChar = '\0';
            this.txtSupEmail.PromptText = "Enter email";
            this.txtSupEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupEmail.SelectedText = "";
            this.txtSupEmail.SelectionLength = 0;
            this.txtSupEmail.SelectionStart = 0;
            this.txtSupEmail.ShortcutsEnabled = true;
            this.txtSupEmail.Size = new System.Drawing.Size(348, 28);
            this.txtSupEmail.TabIndex = 21;
            this.txtSupEmail.UseSelectable = true;
            this.txtSupEmail.WaterMark = "Enter email";
            this.txtSupEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(349, 181);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 34);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 181);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 181);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 34);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(16, 50);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Supplier Name";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // txtSupName
            // 
            // 
            // 
            // 
            this.txtSupName.CustomButton.Image = null;
            this.txtSupName.CustomButton.Location = new System.Drawing.Point(429, 2);
            this.txtSupName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupName.CustomButton.Name = "";
            this.txtSupName.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtSupName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupName.CustomButton.TabIndex = 1;
            this.txtSupName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupName.CustomButton.UseSelectable = true;
            this.txtSupName.CustomButton.Visible = false;
            this.txtSupName.Lines = new string[0];
            this.txtSupName.Location = new System.Drawing.Point(155, 50);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSupName.MaxLength = 32767;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.PasswordChar = '\0';
            this.txtSupName.PromptText = "Enter supplier name";
            this.txtSupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupName.SelectedText = "";
            this.txtSupName.SelectionLength = 0;
            this.txtSupName.SelectionStart = 0;
            this.txtSupName.ShortcutsEnabled = true;
            this.txtSupName.Size = new System.Drawing.Size(348, 28);
            this.txtSupName.TabIndex = 6;
            this.txtSupName.UseSelectable = true;
            this.txtSupName.WaterMark = "Enter supplier name";
            this.txtSupName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.metroLabel1.Location = new System.Drawing.Point(343, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Manage Supplier";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // UserControlSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlSupplier";
            this.Size = new System.Drawing.Size(921, 585);
            this.Load += new System.EventHandler(this.UserControlSupplier_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroGrid gridSupplier;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtSupName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSupEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupContactNo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSupContactNo;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtSearchBySupName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtSupId;
    }
}
