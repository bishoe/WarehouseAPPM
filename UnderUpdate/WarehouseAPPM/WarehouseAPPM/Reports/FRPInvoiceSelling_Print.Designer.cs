namespace WarehouseAPPM.Reports
{
    partial class FRPInvoiceSelling_Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRPInvoiceSelling_Print));
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TXTInvoiceID = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(566, 118);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(272, 53);
            this.BtnSave.Style = MetroFramework.MetroColorStyle.Green;
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "عرض  ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.UseStyleColors = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(20, 60);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(818, 477);
            this.crystalReportViewer1.TabIndex = 11;
            // 
            // TXTInvoiceID
            // 
            // 
            // 
            // 
            this.TXTInvoiceID.CustomButton.Image = null;
            this.TXTInvoiceID.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.TXTInvoiceID.CustomButton.Name = "";
            this.TXTInvoiceID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTInvoiceID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTInvoiceID.CustomButton.TabIndex = 1;
            this.TXTInvoiceID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTInvoiceID.CustomButton.UseSelectable = true;
            this.TXTInvoiceID.CustomButton.Visible = false;
            this.TXTInvoiceID.Lines = new string[0];
            this.TXTInvoiceID.Location = new System.Drawing.Point(566, 89);
            this.TXTInvoiceID.MaxLength = 32767;
            this.TXTInvoiceID.Name = "TXTInvoiceID";
            this.TXTInvoiceID.PasswordChar = '\0';
            this.TXTInvoiceID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTInvoiceID.SelectedText = "";
            this.TXTInvoiceID.SelectionLength = 0;
            this.TXTInvoiceID.SelectionStart = 0;
            this.TXTInvoiceID.ShortcutsEnabled = true;
            this.TXTInvoiceID.Size = new System.Drawing.Size(272, 23);
            this.TXTInvoiceID.TabIndex = 15;
            this.TXTInvoiceID.UseSelectable = true;
            this.TXTInvoiceID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTInvoiceID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTInvoiceID.TextChanged += new System.EventHandler(this.TXTInvoiceID_TextChanged);
            // 
            // FRPInvoiceSelling_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 557);
            this.Controls.Add(this.TXTInvoiceID);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FRPInvoiceSelling_Print";
            this.Text = "فاتورة بيع";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRPInvoiceSelling_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox TXTInvoiceID;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}