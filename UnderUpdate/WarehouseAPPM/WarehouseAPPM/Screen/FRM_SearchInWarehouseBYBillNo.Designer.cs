namespace WarehouseAPPM.Screen
{
    partial class FRM_SearchInWarehouseBYBillNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SearchInWarehouseBYBillNo));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTBillNO = new MetroFramework.Controls.MetroTextBox();
            this.PanelMain = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1129, 356);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TXTBillNO
            // 
            // 
            // 
            // 
            this.TXTBillNO.CustomButton.Image = null;
            this.TXTBillNO.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.TXTBillNO.CustomButton.Name = "";
            this.TXTBillNO.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTBillNO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTBillNO.CustomButton.TabIndex = 1;
            this.TXTBillNO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBillNO.CustomButton.UseSelectable = true;
            this.TXTBillNO.CustomButton.Visible = false;
            this.TXTBillNO.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTBillNO.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTBillNO.Lines = new string[] {
        "0"};
            this.TXTBillNO.Location = new System.Drawing.Point(69, 13);
            this.TXTBillNO.MaxLength = 32767;
            this.TXTBillNO.Name = "TXTBillNO";
            this.TXTBillNO.PasswordChar = '\0';
            this.TXTBillNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTBillNO.SelectedText = "";
            this.TXTBillNO.SelectionLength = 0;
            this.TXTBillNO.SelectionStart = 0;
            this.TXTBillNO.ShortcutsEnabled = true;
            this.TXTBillNO.Size = new System.Drawing.Size(248, 23);
            this.TXTBillNO.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTBillNO.TabIndex = 16;
            this.TXTBillNO.Text = "0";
            this.TXTBillNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTBillNO.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBillNO.UseSelectable = true;
            this.TXTBillNO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTBillNO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.metroLabel1);
            this.PanelMain.Controls.Add(this.TXTBillNO);
            this.PanelMain.Controls.Add(this.pictureBox1);
            this.PanelMain.HorizontalScrollbarBarColor = true;
            this.PanelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelMain.HorizontalScrollbarSize = 10;
            this.PanelMain.Location = new System.Drawing.Point(741, 6);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(408, 55);
            this.PanelMain.TabIndex = 17;
            this.PanelMain.VerticalScrollbarBarColor = true;
            this.PanelMain.VerticalScrollbarHighlightOnWheel = false;
            this.PanelMain.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(323, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "رقم الفاتورة";
            // 
            // FRM_SearchInWarehouseBYBillNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 436);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FRM_SearchInWarehouseBYBillNo";
            this.Text = "تقرير بفاتورة شراء";
            this.Load += new System.EventHandler(this.SearchInWarehouseBYBillNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox TXTBillNO;
        private MetroFramework.Controls.MetroPanel PanelMain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}