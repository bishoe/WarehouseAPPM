namespace WarehouseAPPM.Screen
{
    partial class FRM_Prodoucts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Prodoucts));
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBPRODUCT = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BTNDEL = new MetroFramework.Controls.MetroButton();
            this.BTNEDIT = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TXTNotes = new MetroFramework.Controls.MetroTextBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.CMBCat = new MetroFramework.Controls.MetroComboBox();
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.LBLCurrentcat = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TXTBarCode = new MetroFramework.Controls.MetroTextBox();
            this.PanelMain = new MetroFramework.Controls.MetroPanel();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.metroLabel6);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBPRODUCT);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BTNDEL);
            this.PanelSub.Controls.Add(this.BTNEDIT);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(20, 272);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(961, 283);
            this.PanelSub.TabIndex = 44;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(773, 14);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(104, 35);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "اسم المنتج";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBPRODUCT
            // 
            this.CMBPRODUCT.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBPRODUCT.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBPRODUCT.FormattingEnabled = true;
            this.CMBPRODUCT.ItemHeight = 29;
            this.CMBPRODUCT.Location = new System.Drawing.Point(131, 14);
            this.CMBPRODUCT.Name = "CMBPRODUCT";
            this.CMBPRODUCT.Size = new System.Drawing.Size(636, 35);
            this.CMBPRODUCT.TabIndex = 6;
            this.CMBPRODUCT.UseSelectable = true;
            this.CMBPRODUCT.TextChanged += new System.EventHandler(this.CMBPRODUCT_TextChanged);
            this.CMBPRODUCT.Click += new System.EventHandler(this.CMBPRODUCT_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton4.Location = new System.Drawing.Point(131, 173);
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
            this.BTNDEL.Location = new System.Drawing.Point(368, 173);
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
            this.BTNEDIT.Location = new System.Drawing.Point(605, 173);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(162, 64);
            this.BTNEDIT.TabIndex = 4;
            this.BTNEDIT.Text = "تعديل";
            this.BTNEDIT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEDIT.UseSelectable = true;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(885, 108);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "ملاحظات";
            // 
            // TXTNotes
            // 
            // 
            // 
            // 
            this.TXTNotes.CustomButton.Image = null;
            this.TXTNotes.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.TXTNotes.CustomButton.Name = "";
            this.TXTNotes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TXTNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNotes.CustomButton.TabIndex = 1;
            this.TXTNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNotes.CustomButton.UseSelectable = true;
            this.TXTNotes.CustomButton.Visible = false;
            this.TXTNotes.Lines = new string[0];
            this.TXTNotes.Location = new System.Drawing.Point(566, 101);
            this.TXTNotes.MaxLength = 32767;
            this.TXTNotes.Multiline = true;
            this.TXTNotes.Name = "TXTNotes";
            this.TXTNotes.PasswordChar = '\0';
            this.TXTNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNotes.SelectedText = "";
            this.TXTNotes.SelectionLength = 0;
            this.TXTNotes.SelectionStart = 0;
            this.TXTNotes.ShortcutsEnabled = true;
            this.TXTNotes.Size = new System.Drawing.Size(290, 32);
            this.TXTNotes.TabIndex = 42;
            this.TXTNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNotes.UseSelectable = true;
            this.TXTNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DTP
            // 
            this.DTP.Enabled = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(90, 26);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(237, 20);
            this.DTP.TabIndex = 37;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(350, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "تاريخ الاضافة";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Enabled = false;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(90, 152);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(237, 64);
            this.BtnSave.TabIndex = 33;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(892, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "التصنيف";
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(566, 152);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(290, 64);
            this.BTNNew.TabIndex = 32;
            this.BTNNew.Text = "جديد";
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // CMBCat
            // 
            this.CMBCat.FormattingEnabled = true;
            this.CMBCat.ItemHeight = 23;
            this.CMBCat.Location = new System.Drawing.Point(566, 30);
            this.CMBCat.Name = "CMBCat";
            this.CMBCat.Size = new System.Drawing.Size(290, 29);
            this.CMBCat.Style = MetroFramework.MetroColorStyle.Blue;
            this.CMBCat.TabIndex = 45;
            this.CMBCat.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CMBCat.UseCustomBackColor = true;
            this.CMBCat.UseCustomForeColor = true;
            this.CMBCat.UseSelectable = true;
            this.CMBCat.UseStyleColors = true;
            this.CMBCat.Click += new System.EventHandler(this.CMBCat_Click);
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
            this.TXTName.Location = new System.Drawing.Point(566, 72);
            this.TXTName.MaxLength = 30;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.Size = new System.Drawing.Size(290, 23);
            this.TXTName.TabIndex = 47;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseSelectable = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTName.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            this.TXTName.Leave += new System.EventHandler(this.TXTName_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(881, 72);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "اسم المنتج";
            // 
            // LBLCurrentcat
            // 
            this.LBLCurrentcat.AutoSize = true;
            this.LBLCurrentcat.Location = new System.Drawing.Point(389, 152);
            this.LBLCurrentcat.Name = "LBLCurrentcat";
            this.LBLCurrentcat.Size = new System.Drawing.Size(83, 19);
            this.LBLCurrentcat.TabIndex = 48;
            this.LBLCurrentcat.Text = "metroLabel4";
            this.LBLCurrentcat.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(369, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 50;
            this.metroLabel4.Text = "الباركود";
            // 
            // TXTBarCode
            // 
            // 
            // 
            // 
            this.TXTBarCode.CustomButton.Image = null;
            this.TXTBarCode.CustomButton.Location = new System.Drawing.Point(169, 1);
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
            this.TXTBarCode.Location = new System.Drawing.Point(90, 72);
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
            this.TXTBarCode.Size = new System.Drawing.Size(237, 69);
            this.TXTBarCode.Style = MetroFramework.MetroColorStyle.Green;
            this.TXTBarCode.TabIndex = 49;
            this.TXTBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTBarCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBarCode.UseSelectable = true;
            this.TXTBarCode.WaterMark = "BareCode";
            this.TXTBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTBarCode.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBarCode.TextChanged += new System.EventHandler(this.TXTBarCode_TextChanged);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.TXTBarCode);
            this.PanelMain.Controls.Add(this.LBLCurrentcat);
            this.PanelMain.Controls.Add(this.BtnSave);
            this.PanelMain.Controls.Add(this.metroLabel4);
            this.PanelMain.Controls.Add(this.BTNNew);
            this.PanelMain.Controls.Add(this.CMBCat);
            this.PanelMain.Controls.Add(this.metroLabel1);
            this.PanelMain.Controls.Add(this.TXTName);
            this.PanelMain.Controls.Add(this.metroLabel2);
            this.PanelMain.Controls.Add(this.DTP);
            this.PanelMain.Controls.Add(this.metroLabel3);
            this.PanelMain.Controls.Add(this.TXTNotes);
            this.PanelMain.Controls.Add(this.metroLabel5);
            this.PanelMain.HorizontalScrollbarBarColor = true;
            this.PanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelMain.HorizontalScrollbarSize = 10;
            this.PanelMain.Location = new System.Drawing.Point(20, 47);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(961, 219);
            this.PanelMain.TabIndex = 51;
            this.PanelMain.VerticalScrollbarBarColor = true;
            this.PanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.PanelMain.VerticalScrollbarSize = 10;
            // 
            // FRM_Prodoucts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 575);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Prodoucts";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "المنتجات";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Prodoucts_Load);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBPRODUCT;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BTNDEL;
        private MetroFramework.Controls.MetroButton BTNEDIT;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TXTNotes;
        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroComboBox CMBCat;
        private MetroFramework.Controls.MetroTextBox TXTName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel LBLCurrentcat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TXTBarCode;
        public MetroFramework.Controls.MetroPanel PanelSub;
        private MetroFramework.Controls.MetroPanel PanelMain;
    }
}