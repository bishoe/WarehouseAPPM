namespace WarehouseAPPM.Screen
{
    partial class FRM_ReturnProductOutWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ReturnProductOutWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNSearch = new MetroFramework.Controls.MetroButton();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TxtQtreturn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtQuntitProduct = new MetroFramework.Controls.MetroTextBox();
            this.lblQuntitProduct = new MetroFramework.Controls.MetroLabel();
            this.txtwarehouse = new MetroFramework.Controls.MetroTextBox();
            this.lblwarehouse = new MetroFramework.Controls.MetroLabel();
            this.LBLBillno = new MetroFramework.Controls.MetroLabel();
            this.Lblproductid = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.White;
            this.BTNDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDelete.BackgroundImage")));
            this.BTNDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNDelete.Enabled = false;
            this.BTNDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNDelete.ForeColor = System.Drawing.Color.Black;
            this.BTNDelete.Location = new System.Drawing.Point(3, 43);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(226, 61);
            this.BTNDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.BTNDelete.TabIndex = 141;
            this.BTNDelete.Text = "ارجاع";
            this.BTNDelete.UseCustomBackColor = true;
            this.BTNDelete.UseCustomForeColor = true;
            this.BTNDelete.UseSelectable = true;
            this.BTNDelete.UseStyleColors = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.BTNSearch);
            this.metroPanel2.Controls.Add(this.txtsearch);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(770, 34);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(366, 114);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel2.TabIndex = 140;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(254, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 27);
            this.metroLabel1.TabIndex = 131;
            this.metroLabel1.Text = "رقم الفاتورة";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSearch.BackgroundImage")));
            this.BTNSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNSearch.Location = new System.Drawing.Point(12, 63);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(338, 48);
            this.BTNSearch.TabIndex = 130;
            this.BTNSearch.Text = "البحث";
            this.BTNSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNSearch.UseSelectable = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtsearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtsearch.Lines = new string[] {
        "0"};
            this.txtsearch.Location = new System.Drawing.Point(12, 18);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(236, 28);
            this.txtsearch.TabIndex = 130;
            this.txtsearch.Text = "0";
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.TxtQtreturn);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.BTNDelete);
            this.metroPanel1.Controls.Add(this.txtQuntitProduct);
            this.metroPanel1.Controls.Add(this.lblQuntitProduct);
            this.metroPanel1.Controls.Add(this.txtwarehouse);
            this.metroPanel1.Controls.Add(this.lblwarehouse);
            this.metroPanel1.Controls.Add(this.LBLBillno);
            this.metroPanel1.Controls.Add(this.Lblproductid);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(181, 34);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(572, 114);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 139;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TxtQtreturn
            // 
            // 
            // 
            // 
            this.TxtQtreturn.CustomButton.Image = null;
            this.TxtQtreturn.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.TxtQtreturn.CustomButton.Name = "";
            this.TxtQtreturn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtQtreturn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtQtreturn.CustomButton.TabIndex = 1;
            this.TxtQtreturn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtQtreturn.CustomButton.UseSelectable = true;
            this.TxtQtreturn.CustomButton.Visible = false;
            this.TxtQtreturn.Lines = new string[0];
            this.TxtQtreturn.Location = new System.Drawing.Point(247, 81);
            this.TxtQtreturn.MaxLength = 32767;
            this.TxtQtreturn.Name = "TxtQtreturn";
            this.TxtQtreturn.PasswordChar = '\0';
            this.TxtQtreturn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtQtreturn.SelectedText = "";
            this.TxtQtreturn.SelectionLength = 0;
            this.TxtQtreturn.SelectionStart = 0;
            this.TxtQtreturn.ShortcutsEnabled = true;
            this.TxtQtreturn.Size = new System.Drawing.Size(141, 23);
            this.TxtQtreturn.Style = MetroFramework.MetroColorStyle.Green;
            this.TxtQtreturn.TabIndex = 143;
            this.TxtQtreturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQtreturn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtQtreturn.UseCustomForeColor = true;
            this.TxtQtreturn.UseSelectable = true;
            this.TxtQtreturn.UseStyleColors = true;
            this.TxtQtreturn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtQtreturn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQtreturn.TextChanged += new System.EventHandler(this.TxtQtreturn_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(394, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 142;
            this.metroLabel2.Text = "الكمية ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuntitProduct
            // 
            // 
            // 
            // 
            this.txtQuntitProduct.CustomButton.Image = null;
            this.txtQuntitProduct.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtQuntitProduct.CustomButton.Name = "";
            this.txtQuntitProduct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuntitProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuntitProduct.CustomButton.TabIndex = 1;
            this.txtQuntitProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuntitProduct.CustomButton.UseSelectable = true;
            this.txtQuntitProduct.CustomButton.Visible = false;
            this.txtQuntitProduct.Lines = new string[0];
            this.txtQuntitProduct.Location = new System.Drawing.Point(247, 46);
            this.txtQuntitProduct.MaxLength = 32767;
            this.txtQuntitProduct.Name = "txtQuntitProduct";
            this.txtQuntitProduct.PasswordChar = '\0';
            this.txtQuntitProduct.ReadOnly = true;
            this.txtQuntitProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuntitProduct.SelectedText = "";
            this.txtQuntitProduct.SelectionLength = 0;
            this.txtQuntitProduct.SelectionStart = 0;
            this.txtQuntitProduct.ShortcutsEnabled = true;
            this.txtQuntitProduct.Size = new System.Drawing.Size(141, 23);
            this.txtQuntitProduct.Style = MetroFramework.MetroColorStyle.Green;
            this.txtQuntitProduct.TabIndex = 74;
            this.txtQuntitProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuntitProduct.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuntitProduct.UseCustomForeColor = true;
            this.txtQuntitProduct.UseSelectable = true;
            this.txtQuntitProduct.UseStyleColors = true;
            this.txtQuntitProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuntitProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblQuntitProduct
            // 
            this.lblQuntitProduct.AutoSize = true;
            this.lblQuntitProduct.Location = new System.Drawing.Point(394, 50);
            this.lblQuntitProduct.Name = "lblQuntitProduct";
            this.lblQuntitProduct.Size = new System.Drawing.Size(85, 19);
            this.lblQuntitProduct.TabIndex = 73;
            this.lblQuntitProduct.Text = "الكمية بالمخزن";
            this.lblQuntitProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtwarehouse
            // 
            // 
            // 
            // 
            this.txtwarehouse.CustomButton.Image = null;
            this.txtwarehouse.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtwarehouse.CustomButton.Name = "";
            this.txtwarehouse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtwarehouse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwarehouse.CustomButton.TabIndex = 1;
            this.txtwarehouse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwarehouse.CustomButton.UseSelectable = true;
            this.txtwarehouse.CustomButton.Visible = false;
            this.txtwarehouse.Lines = new string[0];
            this.txtwarehouse.Location = new System.Drawing.Point(247, 17);
            this.txtwarehouse.MaxLength = 32767;
            this.txtwarehouse.Name = "txtwarehouse";
            this.txtwarehouse.PasswordChar = '\0';
            this.txtwarehouse.ReadOnly = true;
            this.txtwarehouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtwarehouse.SelectedText = "";
            this.txtwarehouse.SelectionLength = 0;
            this.txtwarehouse.SelectionStart = 0;
            this.txtwarehouse.ShortcutsEnabled = true;
            this.txtwarehouse.Size = new System.Drawing.Size(141, 23);
            this.txtwarehouse.Style = MetroFramework.MetroColorStyle.Green;
            this.txtwarehouse.TabIndex = 72;
            this.txtwarehouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtwarehouse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwarehouse.UseCustomForeColor = true;
            this.txtwarehouse.UseSelectable = true;
            this.txtwarehouse.UseStyleColors = true;
            this.txtwarehouse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtwarehouse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtwarehouse.TextChanged += new System.EventHandler(this.txtwarehouse_TextChanged);
            // 
            // lblwarehouse
            // 
            this.lblwarehouse.AutoSize = true;
            this.lblwarehouse.Location = new System.Drawing.Point(394, 17);
            this.lblwarehouse.Name = "lblwarehouse";
            this.lblwarehouse.Size = new System.Drawing.Size(90, 19);
            this.lblwarehouse.TabIndex = 71;
            this.lblwarehouse.Text = "الكمية المشتراه";
            this.lblwarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLBillno
            // 
            this.LBLBillno.AutoSize = true;
            this.LBLBillno.Location = new System.Drawing.Point(44, 21);
            this.LBLBillno.Name = "LBLBillno";
            this.LBLBillno.Size = new System.Drawing.Size(61, 19);
            this.LBLBillno.TabIndex = 69;
            this.LBLBillno.Text = "LBLBillno";
            this.LBLBillno.Visible = false;
            // 
            // Lblproductid
            // 
            this.Lblproductid.AutoSize = true;
            this.Lblproductid.Location = new System.Drawing.Point(111, 21);
            this.Lblproductid.Name = "Lblproductid";
            this.Lblproductid.Size = new System.Drawing.Size(83, 19);
            this.Lblproductid.TabIndex = 68;
            this.Lblproductid.Text = "Lblproductid";
            this.Lblproductid.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle13;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DGV.Location = new System.Drawing.Point(11, 184);
            this.DGV.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DGV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1136, 573);
            this.DGV.StandardTab = true;
            this.DGV.Style = MetroFramework.MetroColorStyle.Teal;
            this.DGV.TabIndex = 142;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSelling_CellClick);
            this.DGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVSelling_CellMouseClick);
            // 
            // FRM_ReturnProductOutWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1159, 772);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FRM_ReturnProductOutWarehouse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "ارجاع منتج للتاجر";
            this.TransparencyKey = System.Drawing.Color.Orchid;
            this.Load += new System.EventHandler(this.FRM_ReturnProductOutWarehouse_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BTNDelete;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BTNSearch;
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel LBLBillno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid DGV;
        private MetroFramework.Controls.MetroTextBox txtQuntitProduct;
        private MetroFramework.Controls.MetroLabel lblQuntitProduct;
        private MetroFramework.Controls.MetroTextBox txtwarehouse;
        private MetroFramework.Controls.MetroLabel lblwarehouse;
        private MetroFramework.Controls.MetroLabel Lblproductid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtQtreturn;
    }
}