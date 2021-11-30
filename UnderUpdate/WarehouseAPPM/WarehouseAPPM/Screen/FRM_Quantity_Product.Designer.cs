namespace WarehouseAPPM.Screen
{
    partial class FRM_Quantity_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Quantity_Product));
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CMBCat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBPRODUCT = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.PanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTName
            // 
            this.TXTName.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.TXTName.CustomButton.Image = null;
            this.TXTName.CustomButton.Location = new System.Drawing.Point(506, 2);
            this.TXTName.CustomButton.Name = "";
            this.TXTName.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.TXTName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.CustomButton.TabIndex = 1;
            this.TXTName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTName.CustomButton.UseSelectable = true;
            this.TXTName.CustomButton.Visible = false;
            this.TXTName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TXTName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTName.ForeColor = System.Drawing.Color.DarkBlue;
            this.TXTName.IconRight = true;
            this.TXTName.Lines = new string[0];
            this.TXTName.Location = new System.Drawing.Point(349, 96);
            this.TXTName.MaxLength = 32767;
            this.TXTName.Multiline = true;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ReadOnly = true;
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.ShowClearButton = true;
            this.TXTName.Size = new System.Drawing.Size(604, 100);
            this.TXTName.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.TabIndex = 51;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseCustomBackColor = true;
            this.TXTName.UseCustomForeColor = true;
            this.TXTName.UseSelectable = true;
            this.TXTName.UseStyleColors = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(972, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "اسم المنتج";
            // 
            // CMBCat
            // 
            this.CMBCat.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBCat.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBCat.FormattingEnabled = true;
            this.CMBCat.ItemHeight = 29;
            this.CMBCat.Location = new System.Drawing.Point(663, 36);
            this.CMBCat.Name = "CMBCat";
            this.CMBCat.Size = new System.Drawing.Size(290, 35);
            this.CMBCat.TabIndex = 49;
            this.CMBCat.UseSelectable = true;
            this.CMBCat.Click += new System.EventHandler(this.CMBCat_Click);
            this.CMBCat.Leave += new System.EventHandler(this.CMBCat_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(972, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "التصنيف";
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.Controls.Add(this.TXTName);
            this.PanelSub.Controls.Add(this.metroLabel3);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBCat);
            this.PanelSub.Controls.Add(this.metroLabel1);
            this.PanelSub.Controls.Add(this.CMBPRODUCT);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(20, 18);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(1120, 303);
            this.PanelSub.TabIndex = 52;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            this.PanelSub.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSub_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 222);
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
            this.CMBPRODUCT.Location = new System.Drawing.Point(349, 36);
            this.CMBPRODUCT.Name = "CMBPRODUCT";
            this.CMBPRODUCT.Size = new System.Drawing.Size(290, 35);
            this.CMBPRODUCT.TabIndex = 6;
            this.CMBPRODUCT.UseSelectable = true;
            this.CMBPRODUCT.Leave += new System.EventHandler(this.CMBPRODUCT_Leave);
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton4.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton4.Location = new System.Drawing.Point(59, 110);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(162, 64);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "خروج";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // FRM_Quantity_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 341);
            this.Controls.Add(this.PanelSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Quantity_Product";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "كمية المنتج";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Quantity_Product_Load);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CMBCat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox TXTName;
        private MetroFramework.Controls.MetroPanel PanelSub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBPRODUCT;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}