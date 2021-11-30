namespace WarehouseAPPM.Screen
{
    partial class FRM_SubUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SubUnits));
            this.LBLCurrentcat = new MetroFramework.Controls.MetroLabel();
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CMBMainUnits = new MetroFramework.Controls.MetroComboBox();
            this.BTNEDIT = new MetroFramework.Controls.MetroButton();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.CMBMainUnitsEdit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBSubUnits = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BTNDEL = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTNotes = new MetroFramework.Controls.MetroTextBox();
            this.TXTUNITCONVERT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLCurrentcat
            // 
            this.LBLCurrentcat.AutoSize = true;
            this.LBLCurrentcat.Location = new System.Drawing.Point(550, 20);
            this.LBLCurrentcat.Name = "LBLCurrentcat";
            this.LBLCurrentcat.Size = new System.Drawing.Size(83, 19);
            this.LBLCurrentcat.TabIndex = 60;
            this.LBLCurrentcat.Text = "metroLabel4";
            // 
            // TXTName
            // 
            // 
            // 
            // 
            this.TXTName.CustomButton.Image = null;
            this.TXTName.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.TXTName.CustomButton.Name = "";
            this.TXTName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.CustomButton.TabIndex = 1;
            this.TXTName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTName.CustomButton.UseSelectable = true;
            this.TXTName.CustomButton.Visible = false;
            this.TXTName.Lines = new string[0];
            this.TXTName.Location = new System.Drawing.Point(70, 53);
            this.TXTName.MaxLength = 32767;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.Size = new System.Drawing.Size(238, 23);
            this.TXTName.TabIndex = 59;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseSelectable = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(158, 32);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "الوحده الفرعيه";
            // 
            // CMBMainUnits
            // 
            this.CMBMainUnits.FormattingEnabled = true;
            this.CMBMainUnits.ItemHeight = 23;
            this.CMBMainUnits.Location = new System.Drawing.Point(605, 56);
            this.CMBMainUnits.Name = "CMBMainUnits";
            this.CMBMainUnits.Size = new System.Drawing.Size(290, 29);
            this.CMBMainUnits.TabIndex = 57;
            this.CMBMainUnits.UseSelectable = true;
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEDIT.BackgroundImage")));
            this.BTNEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEDIT.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEDIT.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEDIT.Location = new System.Drawing.Point(585, 137);
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(162, 64);
            this.BTNEDIT.TabIndex = 4;
            this.BTNEDIT.Text = "تعديل";
            this.BTNEDIT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEDIT.UseSelectable = true;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.Controls.Add(this.CMBMainUnitsEdit);
            this.PanelSub.Controls.Add(this.metroLabel7);
            this.PanelSub.Controls.Add(this.metroLabel6);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBSubUnits);
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
            this.PanelSub.Size = new System.Drawing.Size(929, 283);
            this.PanelSub.TabIndex = 56;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // CMBMainUnitsEdit
            // 
            this.CMBMainUnitsEdit.FormattingEnabled = true;
            this.CMBMainUnitsEdit.ItemHeight = 23;
            this.CMBMainUnitsEdit.Location = new System.Drawing.Point(585, 30);
            this.CMBMainUnitsEdit.Name = "CMBMainUnitsEdit";
            this.CMBMainUnitsEdit.Size = new System.Drawing.Size(290, 29);
            this.CMBMainUnitsEdit.TabIndex = 64;
            this.CMBMainUnitsEdit.UseSelectable = true;
            this.CMBMainUnitsEdit.Click += new System.EventHandler(this.CMBMainUnitsEdit_Click);
            this.CMBMainUnitsEdit.MouseLeave += new System.EventHandler(this.CMBMainUnitsEdit_MouseLeave);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(700, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.TabIndex = 63;
            this.metroLabel7.Text = "الوحدة الاساسية";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(365, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "اسم الوحدة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBSubUnits
            // 
            this.CMBSubUnits.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBSubUnits.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBSubUnits.FormattingEnabled = true;
            this.CMBSubUnits.ItemHeight = 29;
            this.CMBSubUnits.Location = new System.Drawing.Point(80, 14);
            this.CMBSubUnits.Name = "CMBSubUnits";
            this.CMBSubUnits.Size = new System.Drawing.Size(272, 35);
            this.CMBSubUnits.TabIndex = 6;
            this.CMBSubUnits.UseSelectable = true;
            this.CMBSubUnits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMBSubUnits_MouseClick);
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
            this.BTNDEL.Location = new System.Drawing.Point(275, 137);
            this.BTNDEL.Name = "BTNDEL";
            this.BTNDEL.Size = new System.Drawing.Size(162, 64);
            this.BTNDEL.TabIndex = 3;
            this.BTNDEL.Text = "حذف";
            this.BTNDEL.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNDEL.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(503, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 55;
            this.metroLabel5.Text = "ملاحظات";
            // 
            // DTP
            // 
            this.DTP.Enabled = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(324, 53);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(237, 20);
            this.DTP.TabIndex = 53;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(408, 34);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 52;
            this.metroLabel2.Text = "تاريخ الاضافة";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(71, 179);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(489, 64);
            this.BtnSave.TabIndex = 50;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(720, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 51;
            this.metroLabel1.Text = "الوحدة الاساسية";
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(605, 179);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(290, 64);
            this.BTNNew.TabIndex = 49;
            this.BTNNew.Text = "جديد";
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // TXTNotes
            // 
            // 
            // 
            // 
            this.TXTNotes.CustomButton.Image = null;
            this.TXTNotes.CustomButton.Location = new System.Drawing.Point(444, 2);
            this.TXTNotes.CustomButton.Name = "";
            this.TXTNotes.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.TXTNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNotes.CustomButton.TabIndex = 1;
            this.TXTNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNotes.CustomButton.UseSelectable = true;
            this.TXTNotes.CustomButton.Visible = false;
            this.TXTNotes.Lines = new string[0];
            this.TXTNotes.Location = new System.Drawing.Point(70, 113);
            this.TXTNotes.MaxLength = 32767;
            this.TXTNotes.Multiline = true;
            this.TXTNotes.Name = "TXTNotes";
            this.TXTNotes.PasswordChar = '\0';
            this.TXTNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNotes.SelectedText = "";
            this.TXTNotes.SelectionLength = 0;
            this.TXTNotes.SelectionStart = 0;
            this.TXTNotes.ShortcutsEnabled = true;
            this.TXTNotes.Size = new System.Drawing.Size(490, 48);
            this.TXTNotes.TabIndex = 54;
            this.TXTNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNotes.UseSelectable = true;
            this.TXTNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTUNITCONVERT
            // 
            // 
            // 
            // 
            this.TXTUNITCONVERT.CustomButton.Image = null;
            this.TXTUNITCONVERT.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTUNITCONVERT.CustomButton.Name = "";
            this.TXTUNITCONVERT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTUNITCONVERT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTUNITCONVERT.CustomButton.TabIndex = 1;
            this.TXTUNITCONVERT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTUNITCONVERT.CustomButton.UseSelectable = true;
            this.TXTUNITCONVERT.CustomButton.Visible = false;
            this.TXTUNITCONVERT.Lines = new string[0];
            this.TXTUNITCONVERT.Location = new System.Drawing.Point(605, 113);
            this.TXTUNITCONVERT.MaxLength = 32767;
            this.TXTUNITCONVERT.Name = "TXTUNITCONVERT";
            this.TXTUNITCONVERT.PasswordChar = '\0';
            this.TXTUNITCONVERT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTUNITCONVERT.SelectedText = "";
            this.TXTUNITCONVERT.SelectionLength = 0;
            this.TXTUNITCONVERT.SelectionStart = 0;
            this.TXTUNITCONVERT.ShortcutsEnabled = true;
            this.TXTUNITCONVERT.Size = new System.Drawing.Size(290, 23);
            this.TXTUNITCONVERT.TabIndex = 61;
            this.TXTUNITCONVERT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTUNITCONVERT.UseSelectable = true;
            this.TXTUNITCONVERT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTUNITCONVERT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(727, 91);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "معامل التحويل";
            // 
            // SubUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 575);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TXTUNITCONVERT);
            this.Controls.Add(this.LBLCurrentcat);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CMBMainUnits);
            this.Controls.Add(this.PanelSub);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BTNNew);
            this.Controls.Add(this.TXTNotes);
            this.Name = "SubUnits";
            this.Text = "SubUnits";
            this.Load += new System.EventHandler(this.SubUnits_Load);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LBLCurrentcat;
        private MetroFramework.Controls.MetroTextBox TXTName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CMBMainUnits;
        private MetroFramework.Controls.MetroButton BTNEDIT;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBSubUnits;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BTNDEL;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroTextBox TXTNotes;
        private MetroFramework.Controls.MetroTextBox TXTUNITCONVERT;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox CMBMainUnitsEdit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroPanel PanelSub;
    }
}