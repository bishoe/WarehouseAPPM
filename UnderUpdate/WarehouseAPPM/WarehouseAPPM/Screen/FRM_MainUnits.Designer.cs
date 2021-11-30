namespace WarehouseAPPM.Screen
{
    partial class FRM_MainUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MainUnits));
            this.MainPnl = new MetroFramework.Controls.MetroPanel();
            this.TXTUnitConvert = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTNameUnit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBMainUnits = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.BTNEdit = new MetroFramework.Controls.MetroButton();
            this.MainPnl.SuspendLayout();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPnl
            // 
            this.MainPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPnl.Controls.Add(this.TXTUnitConvert);
            this.MainPnl.Controls.Add(this.metroLabel1);
            this.MainPnl.Controls.Add(this.BtnSave);
            this.MainPnl.Controls.Add(this.BTNNew);
            this.MainPnl.Controls.Add(this.TXTNameUnit);
            this.MainPnl.Controls.Add(this.metroLabel19);
            this.MainPnl.Controls.Add(this.DTP);
            this.MainPnl.Controls.Add(this.metroLabel15);
            this.MainPnl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainPnl.HorizontalScrollbarBarColor = true;
            this.MainPnl.HorizontalScrollbarHighlightOnWheel = true;
            this.MainPnl.HorizontalScrollbarSize = 10;
            this.MainPnl.Location = new System.Drawing.Point(8, 11);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainPnl.Size = new System.Drawing.Size(1269, 118);
            this.MainPnl.Style = MetroFramework.MetroColorStyle.Black;
            this.MainPnl.TabIndex = 0;
            this.MainPnl.UseStyleColors = true;
            this.MainPnl.VerticalScrollbar = true;
            this.MainPnl.VerticalScrollbarBarColor = true;
            this.MainPnl.VerticalScrollbarHighlightOnWheel = true;
            this.MainPnl.VerticalScrollbarSize = 10;
            this.MainPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPnl_Paint);
            // 
            // TXTUnitConvert
            // 
            this.TXTUnitConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXTUnitConvert.CustomButton.Image = null;
            this.TXTUnitConvert.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.TXTUnitConvert.CustomButton.Name = "";
            this.TXTUnitConvert.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.TXTUnitConvert.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTUnitConvert.CustomButton.TabIndex = 1;
            this.TXTUnitConvert.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTUnitConvert.CustomButton.UseSelectable = true;
            this.TXTUnitConvert.CustomButton.Visible = false;
            this.TXTUnitConvert.Lines = new string[0];
            this.TXTUnitConvert.Location = new System.Drawing.Point(679, 51);
            this.TXTUnitConvert.MaxLength = 5;
            this.TXTUnitConvert.Multiline = true;
            this.TXTUnitConvert.Name = "TXTUnitConvert";
            this.TXTUnitConvert.PasswordChar = '\0';
            this.TXTUnitConvert.PromptText = "طن = 1000كيلو";
            this.TXTUnitConvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTUnitConvert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTUnitConvert.SelectedText = "";
            this.TXTUnitConvert.SelectionLength = 0;
            this.TXTUnitConvert.SelectionStart = 0;
            this.TXTUnitConvert.ShortcutsEnabled = true;
            this.TXTUnitConvert.ShowClearButton = true;
            this.TXTUnitConvert.Size = new System.Drawing.Size(243, 40);
            this.TXTUnitConvert.Style = MetroFramework.MetroColorStyle.Teal;
            this.TXTUnitConvert.TabIndex = 1;
            this.TXTUnitConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTUnitConvert.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTUnitConvert.UseSelectable = true;
            this.TXTUnitConvert.WaterMark = "طن = 1000كيلو";
            this.TXTUnitConvert.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TXTUnitConvert.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTUnitConvert.WithError = true;
            this.TXTUnitConvert.TextChanged += new System.EventHandler(this.TXTUnitConvert_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(750, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 104;
            this.metroLabel1.Text = "معامل التحويل";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Enabled = false;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(41, 51);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(179, 44);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(237, 51);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(177, 44);
            this.BTNNew.TabIndex = 2;
            this.BTNNew.Text = "جديد";
            this.BTNNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // TXTNameUnit
            // 
            this.TXTNameUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TXTNameUnit.CustomButton.Image = null;
            this.TXTNameUnit.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.TXTNameUnit.CustomButton.Name = "";
            this.TXTNameUnit.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.TXTNameUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNameUnit.CustomButton.TabIndex = 1;
            this.TXTNameUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNameUnit.CustomButton.UseSelectable = true;
            this.TXTNameUnit.CustomButton.Visible = false;
            this.TXTNameUnit.Lines = new string[0];
            this.TXTNameUnit.Location = new System.Drawing.Point(969, 47);
            this.TXTNameUnit.MaxLength = 32767;
            this.TXTNameUnit.Multiline = true;
            this.TXTNameUnit.Name = "TXTNameUnit";
            this.TXTNameUnit.PasswordChar = '\0';
            this.TXTNameUnit.PromptText = "كرتونه ..طن";
            this.TXTNameUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTNameUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNameUnit.SelectedText = "";
            this.TXTNameUnit.SelectionLength = 0;
            this.TXTNameUnit.SelectionStart = 0;
            this.TXTNameUnit.ShortcutsEnabled = true;
            this.TXTNameUnit.ShowClearButton = true;
            this.TXTNameUnit.Size = new System.Drawing.Size(243, 40);
            this.TXTNameUnit.Style = MetroFramework.MetroColorStyle.Teal;
            this.TXTNameUnit.TabIndex = 0;
            this.TXTNameUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNameUnit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNameUnit.UseSelectable = true;
            this.TXTNameUnit.WaterMark = "كرتونه ..طن";
            this.TXTNameUnit.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TXTNameUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTNameUnit.WithError = true;
            this.TXTNameUnit.Leave += new System.EventHandler(this.TXTNameUnit_Leave);
            // 
            // metroLabel19
            // 
            this.metroLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(1064, 25);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(70, 19);
            this.metroLabel19.TabIndex = 100;
            this.metroLabel19.Text = "اسم الوحدة";
            // 
            // DTP
            // 
            this.DTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.DTP.Enabled = false;
            this.DTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(420, 51);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(232, 44);
            this.DTP.TabIndex = 99;
            // 
            // metroLabel15
            // 
            this.metroLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(493, 29);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(77, 19);
            this.metroLabel15.TabIndex = 98;
            this.metroLabel15.Text = "تاريخ الاضافة";
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.metroLabel6);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBMainUnits);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BtnDel);
            this.PanelSub.Controls.Add(this.BTNEdit);
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(8, 156);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(1272, 113);
            this.PanelSub.TabIndex = 0;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(1181, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(70, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "اسم الوحدة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(833, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBMainUnits
            // 
            this.CMBMainUnits.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBMainUnits.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBMainUnits.FormattingEnabled = true;
            this.CMBMainUnits.ItemHeight = 29;
            this.CMBMainUnits.Location = new System.Drawing.Point(903, 27);
            this.CMBMainUnits.Name = "CMBMainUnits";
            this.CMBMainUnits.Size = new System.Drawing.Size(272, 35);
            this.CMBMainUnits.TabIndex = 0;
            this.CMBMainUnits.UseSelectable = true;
            this.CMBMainUnits.Click += new System.EventHandler(this.CMBMainUnits_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton4.Location = new System.Drawing.Point(280, 16);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(162, 64);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "خروج";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDel.BackgroundImage")));
            this.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDel.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnDel.Location = new System.Drawing.Point(487, 16);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(165, 64);
            this.BtnDel.TabIndex = 2;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BTNEdit
            // 
            this.BTNEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEdit.BackgroundImage")));
            this.BTNEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEdit.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEdit.Location = new System.Drawing.Point(665, 16);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(162, 64);
            this.BTNEdit.TabIndex = 1;
            this.BTNEdit.Text = "تعديل";
            this.BTNEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEdit.UseSelectable = true;
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // FRM_MainUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 274);
            this.Controls.Add(this.PanelSub);
            this.Controls.Add(this.MainPnl);
            this.Name = "FRM_MainUnits";
            this.Text = "الوحدات الاساسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainUnits_Load);
            this.MainPnl.ResumeLayout(false);
            this.MainPnl.PerformLayout();
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel MainPnl;
        private MetroFramework.Controls.MetroTextBox TXTNameUnit;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBMainUnits;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BtnDel;
        private MetroFramework.Controls.MetroButton BTNEdit;
        private MetroFramework.Controls.MetroTextBox TXTUnitConvert;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroPanel PanelSub;
    }
}