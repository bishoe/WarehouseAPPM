namespace WarehouseAPPM.Screen
{
    partial class FRM_Qutaly_Units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Qutaly_Units));
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTQ = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CMBUnits = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.PanelSub.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.BtnSave);
            this.PanelSub.Controls.Add(this.BTNNew);
            this.PanelSub.Controls.Add(this.TXTQ);
            this.PanelSub.Controls.Add(this.metroLabel1);
            this.PanelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(17, 63);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(772, 117);
            this.PanelSub.TabIndex = 54;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Enabled = false;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(166, 39);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(163, 64);
            this.BtnSave.TabIndex = 56;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(344, 39);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(189, 64);
            this.BTNNew.TabIndex = 55;
            this.BTNNew.Text = "جديد";
            this.BTNNew.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNNew.UseSelectable = true;
            this.BTNNew.Click += new System.EventHandler(this.BTNNew_Click);
            // 
            // TXTQ
            // 
            // 
            // 
            // 
            this.TXTQ.CustomButton.Image = null;
            this.TXTQ.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.TXTQ.CustomButton.Name = "";
            this.TXTQ.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.TXTQ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTQ.CustomButton.TabIndex = 1;
            this.TXTQ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTQ.CustomButton.UseSelectable = true;
            this.TXTQ.CustomButton.Visible = false;
            this.TXTQ.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TXTQ.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTQ.Lines = new string[0];
            this.TXTQ.Location = new System.Drawing.Point(558, 39);
            this.TXTQ.MaxLength = 32767;
            this.TXTQ.Multiline = true;
            this.TXTQ.Name = "TXTQ";
            this.TXTQ.PasswordChar = '\0';
            this.TXTQ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTQ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTQ.SelectedText = "";
            this.TXTQ.SelectionLength = 0;
            this.TXTQ.SelectionStart = 0;
            this.TXTQ.ShortcutsEnabled = true;
            this.TXTQ.Size = new System.Drawing.Size(189, 64);
            this.TXTQ.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTQ.TabIndex = 54;
            this.TXTQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTQ.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTQ.UseCustomBackColor = true;
            this.TXTQ.UseCustomForeColor = true;
            this.TXTQ.UseSelectable = true;
            this.TXTQ.UseStyleColors = true;
            this.TXTQ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTQ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTQ.TextChanged += new System.EventHandler(this.TXTQ_TextChanged);
            this.TXTQ.Leave += new System.EventHandler(this.TXTQ_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(594, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 25);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "اسم المصروف";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMBUnits
            // 
            this.CMBUnits.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBUnits.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBUnits.FormattingEnabled = true;
            this.CMBUnits.ItemHeight = 29;
            this.CMBUnits.Location = new System.Drawing.Point(275, 3);
            this.CMBUnits.Name = "CMBUnits";
            this.CMBUnits.Size = new System.Drawing.Size(272, 35);
            this.CMBUnits.TabIndex = 6;
            this.CMBUnits.UseSelectable = true;
            this.CMBUnits.Click += new System.EventHandler(this.CMBUnits_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.CMBUnits);
            this.metroPanel1.Controls.Add(this.metroButton6);
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 255);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(772, 231);
            this.metroPanel1.TabIndex = 55;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = true;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(585, 13);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 25);
            this.metroLabel2.TabIndex = 55;
            this.metroLabel2.Text = "اسم المصروف";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton1.Location = new System.Drawing.Point(12, 144);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(162, 64);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "خروج";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton5.BackgroundImage")));
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton5.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton5.Location = new System.Drawing.Point(275, 137);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(272, 64);
            this.metroButton5.TabIndex = 3;
            this.metroButton5.Text = "حذف";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton6.BackgroundImage")));
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton6.ForeColor = System.Drawing.Color.Cornsilk;
            this.metroButton6.Location = new System.Drawing.Point(585, 137);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(162, 64);
            this.metroButton6.TabIndex = 4;
            this.metroButton6.Text = "تعديل";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // FRM_Qutaly_Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.PanelSub);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Qutaly_Units";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادخال مصروف";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Qutaly_Units_Load);
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelSub;
        private MetroFramework.Controls.MetroTextBox TXTQ;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CMBUnits;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BTNNew;
    }
}