namespace WarehouseAPPM.Screen
{
    partial class FRM_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Customers));
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BTNSAVE = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TXTADDress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TXTPHONE = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TXTNOTE = new MetroFramework.Controls.MetroTextBox();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBCustomers = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BTNDEL = new MetroFramework.Controls.MetroButton();
            this.BTNEDIT = new MetroFramework.Controls.MetroButton();
            this.PaneMain = new MetroFramework.Controls.MetroPanel();
            this.lblCustomersID = new MetroFramework.Controls.MetroLabel();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PaneMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.Enabled = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(25, 81);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(287, 20);
            this.DTP.TabIndex = 11;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(96, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "تاريخ الاضافة";
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSAVE.BackgroundImage")));
            this.BTNSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNSAVE.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNSAVE.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNSAVE.Location = new System.Drawing.Point(25, 177);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(287, 64);
            this.BTNSAVE.TabIndex = 7;
            this.BTNSAVE.Text = "حفظ";
            this.BTNSAVE.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNSAVE.UseSelectable = true;
            this.BTNSAVE.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(555, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "اسم العميل";
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(25, 107);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(287, 64);
            this.BTNNew.TabIndex = 6;
            this.BTNNew.Text = "جديد";
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // TXTName
            // 
            // 
            // 
            // 
            this.TXTName.CustomButton.Image = null;
            this.TXTName.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTName.CustomButton.Name = "";
            this.TXTName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.CustomButton.TabIndex = 1;
            this.TXTName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTName.CustomButton.UseSelectable = true;
            this.TXTName.CustomButton.Visible = false;
            this.TXTName.Lines = new string[0];
            this.TXTName.Location = new System.Drawing.Point(441, 25);
            this.TXTName.MaxLength = 30;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.Size = new System.Drawing.Size(290, 23);
            this.TXTName.TabIndex = 8;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseSelectable = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTName.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            this.TXTName.Click += new System.EventHandler(this.TXTName_Click);
            this.TXTName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTName_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(581, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "العنوان";
            // 
            // TXTADDress
            // 
            // 
            // 
            // 
            this.TXTADDress.CustomButton.Image = null;
            this.TXTADDress.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTADDress.CustomButton.Name = "";
            this.TXTADDress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTADDress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTADDress.CustomButton.TabIndex = 1;
            this.TXTADDress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTADDress.CustomButton.UseSelectable = true;
            this.TXTADDress.CustomButton.Visible = false;
            this.TXTADDress.Lines = new string[0];
            this.TXTADDress.Location = new System.Drawing.Point(441, 78);
            this.TXTADDress.MaxLength = 100;
            this.TXTADDress.Name = "TXTADDress";
            this.TXTADDress.PasswordChar = '\0';
            this.TXTADDress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTADDress.SelectedText = "";
            this.TXTADDress.SelectionLength = 0;
            this.TXTADDress.SelectionStart = 0;
            this.TXTADDress.ShortcutsEnabled = true;
            this.TXTADDress.Size = new System.Drawing.Size(290, 23);
            this.TXTADDress.TabIndex = 12;
            this.TXTADDress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTADDress.UseSelectable = true;
            this.TXTADDress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTADDress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(130, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "الهاتف";
            // 
            // TXTPHONE
            // 
            // 
            // 
            // 
            this.TXTPHONE.CustomButton.Image = null;
            this.TXTPHONE.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTPHONE.CustomButton.Name = "";
            this.TXTPHONE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTPHONE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTPHONE.CustomButton.TabIndex = 1;
            this.TXTPHONE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTPHONE.CustomButton.UseSelectable = true;
            this.TXTPHONE.CustomButton.Visible = false;
            this.TXTPHONE.Lines = new string[0];
            this.TXTPHONE.Location = new System.Drawing.Point(22, 25);
            this.TXTPHONE.MaxLength = 13;
            this.TXTPHONE.Name = "TXTPHONE";
            this.TXTPHONE.PasswordChar = '\0';
            this.TXTPHONE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTPHONE.SelectedText = "";
            this.TXTPHONE.SelectionLength = 0;
            this.TXTPHONE.SelectionStart = 0;
            this.TXTPHONE.ShortcutsEnabled = true;
            this.TXTPHONE.Size = new System.Drawing.Size(290, 23);
            this.TXTPHONE.TabIndex = 14;
            this.TXTPHONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPHONE.UseSelectable = true;
            this.TXTPHONE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTPHONE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTPHONE.TextChanged += new System.EventHandler(this.TXTPHONE_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(573, 114);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "ملاحظات";
            // 
            // TXTNOTE
            // 
            // 
            // 
            // 
            this.TXTNOTE.CustomButton.Image = null;
            this.TXTNOTE.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.TXTNOTE.CustomButton.Name = "";
            this.TXTNOTE.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.TXTNOTE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNOTE.CustomButton.TabIndex = 1;
            this.TXTNOTE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNOTE.CustomButton.UseSelectable = true;
            this.TXTNOTE.CustomButton.Visible = false;
            this.TXTNOTE.Lines = new string[0];
            this.TXTNOTE.Location = new System.Drawing.Point(441, 136);
            this.TXTNOTE.MaxLength = 150;
            this.TXTNOTE.Multiline = true;
            this.TXTNOTE.Name = "TXTNOTE";
            this.TXTNOTE.PasswordChar = '\0';
            this.TXTNOTE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNOTE.SelectedText = "";
            this.TXTNOTE.SelectionLength = 0;
            this.TXTNOTE.SelectionStart = 0;
            this.TXTNOTE.ShortcutsEnabled = true;
            this.TXTNOTE.Size = new System.Drawing.Size(290, 100);
            this.TXTNOTE.TabIndex = 16;
            this.TXTNOTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNOTE.UseSelectable = true;
            this.TXTNOTE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNOTE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBCustomers);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BTNDEL);
            this.PanelSub.Controls.Add(this.BTNEDIT);
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(7, 306);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(773, 226);
            this.PanelSub.TabIndex = 18;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            this.PanelSub.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBCustomers
            // 
            this.CMBCustomers.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBCustomers.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBCustomers.FormattingEnabled = true;
            this.CMBCustomers.ItemHeight = 29;
            this.CMBCustomers.Location = new System.Drawing.Point(237, 27);
            this.CMBCustomers.Name = "CMBCustomers";
            this.CMBCustomers.Size = new System.Drawing.Size(272, 35);
            this.CMBCustomers.TabIndex = 6;
            this.CMBCustomers.UseSelectable = true;
            this.CMBCustomers.SelectedIndexChanged += new System.EventHandler(this.CMBCustomers_SelectedIndexChanged);
            this.CMBCustomers.Click += new System.EventHandler(this.CMBCustomers_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton4.Location = new System.Drawing.Point(12, 144);
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
            this.BTNDEL.Location = new System.Drawing.Point(289, 144);
            this.BTNDEL.Name = "BTNDEL";
            this.BTNDEL.Size = new System.Drawing.Size(162, 64);
            this.BTNDEL.TabIndex = 3;
            this.BTNDEL.Text = "حذف";
            this.BTNDEL.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNDEL.UseSelectable = true;
            this.BTNDEL.Click += new System.EventHandler(this.BTNDEL_Click);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEDIT.BackgroundImage")));
            this.BTNEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEDIT.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEDIT.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEDIT.Location = new System.Drawing.Point(585, 144);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(162, 64);
            this.BTNEDIT.TabIndex = 4;
            this.BTNEDIT.Text = "تعديل";
            this.BTNEDIT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEDIT.UseSelectable = true;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // PaneMain
            // 
            this.PaneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneMain.Controls.Add(this.lblCustomersID);
            this.PaneMain.Controls.Add(this.metroLabel5);
            this.PaneMain.Controls.Add(this.TXTADDress);
            this.PaneMain.Controls.Add(this.metroLabel3);
            this.PaneMain.Controls.Add(this.metroLabel1);
            this.PaneMain.Controls.Add(this.BTNSAVE);
            this.PaneMain.Controls.Add(this.DTP);
            this.PaneMain.Controls.Add(this.BTNNew);
            this.PaneMain.Controls.Add(this.metroLabel2);
            this.PaneMain.Controls.Add(this.TXTNOTE);
            this.PaneMain.Controls.Add(this.TXTPHONE);
            this.PaneMain.Controls.Add(this.TXTName);
            this.PaneMain.Controls.Add(this.metroLabel4);
            this.PaneMain.HorizontalScrollbarBarColor = true;
            this.PaneMain.HorizontalScrollbarHighlightOnWheel = false;
            this.PaneMain.HorizontalScrollbarSize = 10;
            this.PaneMain.Location = new System.Drawing.Point(7, 51);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(773, 249);
            this.PaneMain.TabIndex = 19;
            this.PaneMain.VerticalScrollbarBarColor = true;
            this.PaneMain.VerticalScrollbarHighlightOnWheel = false;
            this.PaneMain.VerticalScrollbarSize = 10;
            // 
            // lblCustomersID
            // 
            this.lblCustomersID.AutoSize = true;
            this.lblCustomersID.Location = new System.Drawing.Point(330, 114);
            this.lblCustomersID.Name = "lblCustomersID";
            this.lblCustomersID.Size = new System.Drawing.Size(83, 19);
            this.lblCustomersID.TabIndex = 18;
            this.lblCustomersID.Text = "metroLabel6";
            this.lblCustomersID.Visible = false;
            // 
            // FRM_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 534);
            this.Controls.Add(this.PaneMain);
            this.Controls.Add(this.PanelSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "FRM_Customers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.Click += new System.EventHandler(this.Customers_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Customers_MouseDoubleClick);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PaneMain.ResumeLayout(false);
            this.PaneMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroTextBox TXTName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TXTADDress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TXTPHONE;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TXTNOTE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBCustomers;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroPanel PaneMain;
        private MetroFramework.Controls.MetroLabel lblCustomersID;
        public MetroFramework.Controls.MetroButton BTNSAVE;
        public MetroFramework.Controls.MetroButton BTNDEL;
        public MetroFramework.Controls.MetroButton BTNEDIT;
        public MetroFramework.Controls.MetroPanel PanelSub;
    }
}