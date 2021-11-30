namespace WarehouseAPPM.Screen
{
    partial class FRM_SearchAll_InvoiceStore
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
            this.dataGridViewPaging1 = new In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging();
            this.SuspendLayout();
            // 
            // dataGridViewPaging1
            // 
            this.dataGridViewPaging1.AutoHideNavigator = false;
            this.dataGridViewPaging1.AutoScroll = true;
            this.dataGridViewPaging1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataGridViewPaging1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridViewPaging1.DataSource = null;
            this.dataGridViewPaging1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaging1.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewPaging1.MaxRecords = 100;
            this.dataGridViewPaging1.Name = "dataGridViewPaging1";
            this.dataGridViewPaging1.Size = new System.Drawing.Size(1025, 329);
            this.dataGridViewPaging1.TabIndex = 0;
            // 
            // FRM_SearchAll_InvoiceStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 409);
            this.Controls.Add(this.dataGridViewPaging1);
            this.Name = "FRM_SearchAll_InvoiceStore";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "فواتير الشراء";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_SearchAll_InvoiceStore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private In.Sontx.SimpleDataGridViewPaging.DataGridViewPaging dataGridViewPaging1;
    }
}