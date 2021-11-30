namespace WarehouseAPPM
{
    partial class CategoryProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryProducts));
            this.PanelMain = new MetroFramework.Controls.MetroPanel();
            this.daWDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            this.BTNDELETE = new MetroFramework.Controls.MetroButton();
            this.BTNEDit = new MetroFramework.Controls.MetroButton();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBSearch = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.AutoScroll = true;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.daWDate);
            this.PanelMain.Controls.Add(this.metroLabel2);
            this.PanelMain.Controls.Add(this.BtnSave);
            this.PanelMain.Controls.Add(this.metroLabel1);
            this.PanelMain.Controls.Add(this.BTNNew);
            this.PanelMain.Controls.Add(this.TXTName);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMain.HorizontalScrollbar = true;
            this.PanelMain.HorizontalScrollbarBarColor = true;
            this.PanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelMain.HorizontalScrollbarSize = 10;
            this.PanelMain.Location = new System.Drawing.Point(20, 60);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(760, 178);
            this.PanelMain.Style = MetroFramework.MetroColorStyle.Green;
            this.PanelMain.TabIndex = 0;
            this.PanelMain.VerticalScrollbar = true;
            this.PanelMain.VerticalScrollbarBarColor = true;
            this.PanelMain.VerticalScrollbarHighlightOnWheel = true;
            this.PanelMain.VerticalScrollbarSize = 10;
            // 
            // daWDate
            // 
            this.daWDate.Enabled = false;
            this.daWDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.daWDate.Location = new System.Drawing.Point(51, 29);
            this.daWDate.Name = "daWDate";
            this.daWDate.Size = new System.Drawing.Size(200, 20);
            this.daWDate.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(257, 30);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "تاريخ الاضافة";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Enabled = false;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(24, 89);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(237, 64);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(661, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "اسم القسم";
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(467, 89);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(188, 64);
            this.BTNNew.TabIndex = 1;
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
            this.TXTName.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.TXTName.CustomButton.Name = "";
            this.TXTName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.CustomButton.TabIndex = 1;
            this.TXTName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTName.CustomButton.UseSelectable = true;
            this.TXTName.CustomButton.Visible = false;
            this.TXTName.Lines = new string[0];
            this.TXTName.Location = new System.Drawing.Point(467, 30);
            this.TXTName.MaxLength = 20;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.Size = new System.Drawing.Size(188, 23);
            this.TXTName.TabIndex = 2;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseSelectable = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTName.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            this.TXTName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTName_KeyPress);
            this.TXTName.Leave += new System.EventHandler(this.TXTName_Leave);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNDELETE.BackgroundImage")));
            this.BTNDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNDELETE.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNDELETE.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNDELETE.Location = new System.Drawing.Point(315, 137);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(162, 64);
            this.BTNDELETE.TabIndex = 3;
            this.BTNDELETE.Text = "حذف";
            this.BTNDELETE.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNDELETE.UseSelectable = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNEDit
            // 
            this.BTNEDit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEDit.BackgroundImage")));
            this.BTNEDit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEDit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEDit.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEDit.Location = new System.Drawing.Point(585, 137);
            this.BTNEDit.Name = "BTNEDit";
            this.BTNEDit.Size = new System.Drawing.Size(162, 64);
            this.BTNEDit.TabIndex = 4;
            this.BTNEDit.Text = "تعديل";
            this.BTNEDit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEDit.UseSelectable = true;
            this.BTNEDit.Click += new System.EventHandler(this.BTNEDit_Click);
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBSearch);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BTNDELETE);
            this.PanelSub.Controls.Add(this.BTNEDit);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(20, 269);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(760, 211);
            this.PanelSub.TabIndex = 6;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBSearch
            // 
            this.CMBSearch.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBSearch.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBSearch.FormattingEnabled = true;
            this.CMBSearch.ItemHeight = 29;
            this.CMBSearch.Location = new System.Drawing.Point(299, 3);
            this.CMBSearch.Name = "CMBSearch";
            this.CMBSearch.Size = new System.Drawing.Size(272, 35);
            this.CMBSearch.TabIndex = 6;
            this.CMBSearch.UseSelectable = true;
            this.CMBSearch.SelectedIndexChanged += new System.EventHandler(this.CMBSearch_SelectedIndexChanged);
            this.CMBSearch.Click += new System.EventHandler(this.CMBSearch_Click);
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
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 2);
            this.label1.TabIndex = 9;
            // 
            // CategoryProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelSub);
            this.Controls.Add(this.PanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryProducts";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اضافة قسم";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CategoryProducts_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelMain;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TXTName;
        private System.Windows.Forms.DateTimePicker daWDate;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BTNDELETE;
        private MetroFramework.Controls.MetroButton BTNEDit;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox CMBSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroPanel PanelSub;
    }
}

