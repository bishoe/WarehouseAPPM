namespace WarehouseAPPM.Reports
{
    partial class FRPAllCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRPAllCustomer));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBSearch = new MetroFramework.Controls.MetroComboBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 328);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(977, 305);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBSearch
            // 
            this.CMBSearch.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBSearch.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBSearch.FormattingEnabled = true;
            this.CMBSearch.ItemHeight = 29;
            this.CMBSearch.Location = new System.Drawing.Point(672, 45);
            this.CMBSearch.Name = "CMBSearch";
            this.CMBSearch.Size = new System.Drawing.Size(272, 35);
            this.CMBSearch.TabIndex = 8;
            this.CMBSearch.UseSelectable = true;
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(672, 95);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(272, 53);
            this.BtnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "عرض الجميع";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.UseStyleColors = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FRPAllCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 633);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CMBSearch);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FRPAllCustomer";
            this.Text = "العملاء";
            this.Load += new System.EventHandler(this.FRPAllCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBSearch;
        private MetroFramework.Controls.MetroButton BtnSave;
    }
}