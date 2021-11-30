namespace WarehouseAPPM.Screen
{
    partial class FRM_Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Barcode));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.CMBPRODUCT = new MetroFramework.Controls.MetroComboBox();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.CMBCATEGORY = new MetroFramework.Controls.MetroComboBox();
            this.TXTBarCode = new MetroFramework.Controls.MetroTextBox();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.CMBBarcode = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BTNDEL = new MetroFramework.Controls.MetroButton();
            this.BTNEDIT = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroPanel1.SuspendLayout();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(848, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "المنتج";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(983, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "التصنيف";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.DTP);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroButton7);
            this.metroPanel1.Controls.Add(this.CMBPRODUCT);
            this.metroPanel1.Controls.Add(this.BTNNew);
            this.metroPanel1.Controls.Add(this.CMBCATEGORY);
            this.metroPanel1.Controls.Add(this.TXTBarCode);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(130, 27);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1106, 193);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DTP
            // 
            this.DTP.Enabled = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(161, 26);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(237, 20);
            this.DTP.TabIndex = 68;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(245, 7);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 67;
            this.metroLabel4.Text = "تاريخ الاضافة";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(549, 4);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "الباركود";
            // 
            // metroButton7
            // 
            this.metroButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton7.BackgroundImage")));
            this.metroButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton7.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton7.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton7.Location = new System.Drawing.Point(453, 101);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(299, 64);
            this.metroButton7.TabIndex = 66;
            this.metroButton7.Text = "حفظ";
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // CMBPRODUCT
            // 
            this.CMBPRODUCT.FormattingEnabled = true;
            this.CMBPRODUCT.ItemHeight = 23;
            this.CMBPRODUCT.Location = new System.Drawing.Point(771, 26);
            this.CMBPRODUCT.Name = "CMBPRODUCT";
            this.CMBPRODUCT.Size = new System.Drawing.Size(157, 29);
            this.CMBPRODUCT.TabIndex = 5;
            this.CMBPRODUCT.UseSelectable = true;
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(771, 95);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(299, 64);
            this.BTNNew.TabIndex = 57;
            this.BTNNew.Text = "جديد";
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            // 
            // CMBCATEGORY
            // 
            this.CMBCATEGORY.FormattingEnabled = true;
            this.CMBCATEGORY.ItemHeight = 23;
            this.CMBCATEGORY.Location = new System.Drawing.Point(949, 26);
            this.CMBCATEGORY.Name = "CMBCATEGORY";
            this.CMBCATEGORY.Size = new System.Drawing.Size(121, 29);
            this.CMBCATEGORY.TabIndex = 4;
            this.CMBCATEGORY.UseSelectable = true;
            this.CMBCATEGORY.Leave += new System.EventHandler(this.CMBCATEGORY_Leave);
            // 
            // TXTBarCode
            // 
            // 
            // 
            // 
            this.TXTBarCode.CustomButton.Image = null;
            this.TXTBarCode.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.TXTBarCode.CustomButton.Name = "";
            this.TXTBarCode.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.TXTBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTBarCode.CustomButton.TabIndex = 1;
            this.TXTBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBarCode.CustomButton.UseSelectable = true;
            this.TXTBarCode.CustomButton.Visible = false;
            this.TXTBarCode.DisplayIcon = true;
            this.TXTBarCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TXTBarCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTBarCode.Lines = new string[0];
            this.TXTBarCode.Location = new System.Drawing.Point(453, 26);
            this.TXTBarCode.MaxLength = 32767;
            this.TXTBarCode.Name = "TXTBarCode";
            this.TXTBarCode.PasswordChar = '\0';
            this.TXTBarCode.PromptText = "BareCode";
            this.TXTBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTBarCode.SelectedText = "";
            this.TXTBarCode.SelectionLength = 0;
            this.TXTBarCode.SelectionStart = 0;
            this.TXTBarCode.ShortcutsEnabled = true;
            this.TXTBarCode.ShowClearButton = true;
            this.TXTBarCode.Size = new System.Drawing.Size(299, 69);
            this.TXTBarCode.Style = MetroFramework.MetroColorStyle.Green;
            this.TXTBarCode.TabIndex = 2;
            this.TXTBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTBarCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBarCode.UseSelectable = true;
            this.TXTBarCode.WaterMark = "BareCode";
            this.TXTBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTBarCode.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.Controls.Add(this.CMBBarcode);
            this.PanelSub.Controls.Add(this.metroLabel7);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BTNDEL);
            this.PanelSub.Controls.Add(this.BTNEDIT);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(20, 322);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(1275, 153);
            this.PanelSub.TabIndex = 59;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // CMBBarcode
            // 
            this.CMBBarcode.FormattingEnabled = true;
            this.CMBBarcode.ItemHeight = 23;
            this.CMBBarcode.Location = new System.Drawing.Point(947, 30);
            this.CMBBarcode.Name = "CMBBarcode";
            this.CMBBarcode.Size = new System.Drawing.Size(290, 29);
            this.CMBBarcode.TabIndex = 64;
            this.CMBBarcode.UseSelectable = true;
            this.CMBBarcode.Click += new System.EventHandler(this.CMBBarcode_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(1062, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(45, 19);
            this.metroLabel7.TabIndex = 63;
            this.metroLabel7.Text = "الباركود";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(877, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton4.Location = new System.Drawing.Point(227, 16);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(162, 64);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "خروج";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            // 
            // BTNDEL
            // 
            this.BTNDEL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDEL.BackgroundImage")));
            this.BTNDEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNDEL.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNDEL.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNDEL.Location = new System.Drawing.Point(470, 16);
            this.BTNDEL.Name = "BTNDEL";
            this.BTNDEL.Size = new System.Drawing.Size(162, 64);
            this.BTNDEL.TabIndex = 3;
            this.BTNDEL.Text = "حذف";
            this.BTNDEL.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNDEL.UseSelectable = true;
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEDIT.BackgroundImage")));
            this.BTNEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEDIT.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEDIT.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEDIT.Location = new System.Drawing.Point(659, 16);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(162, 64);
            this.BTNEDIT.TabIndex = 4;
            this.BTNEDIT.Text = "تعديل";
            this.BTNEDIT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEDIT.UseSelectable = true;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 20);
            this.textBox1.TabIndex = 60;
            // 
            // FRM_Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 495);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PanelSub);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FRM_Barcode";
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CMBPRODUCT;
        private MetroFramework.Controls.MetroComboBox CMBCATEGORY;
        private MetroFramework.Controls.MetroTextBox TXTBarCode;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroPanel PanelSub;
        private MetroFramework.Controls.MetroComboBox CMBBarcode;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BTNDEL;
        private MetroFramework.Controls.MetroButton BTNEDIT;
        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox textBox1;
    }
}