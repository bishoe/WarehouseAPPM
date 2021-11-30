namespace WarehouseAPPM.Screen
{
    partial class FRM_Expiredate
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
            this.dataGridViewWithPaging1 = new CPDataGridUserControl.DataGridViewWithPaging();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // dataGridViewWithPaging1
            // 
            this.dataGridViewWithPaging1.ControlHeight = 287;
            this.dataGridViewWithPaging1.ControlWidth = 749;
            this.dataGridViewWithPaging1.DataSource = null;
            this.dataGridViewWithPaging1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWithPaging1.FirstButtonText = "&الاول";
            this.dataGridViewWithPaging1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewWithPaging1.ForeColor = System.Drawing.Color.Crimson;
            this.dataGridViewWithPaging1.LastButtonText = "&الاخير";
            this.dataGridViewWithPaging1.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewWithPaging1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridViewWithPaging1.Name = "dataGridViewWithPaging1";
            this.dataGridViewWithPaging1.NextButtonText = "&التالى";
            this.dataGridViewWithPaging1.PageSize = 10;
            this.dataGridViewWithPaging1.PreviousButtonText = "&السابق";
            this.dataGridViewWithPaging1.Size = new System.Drawing.Size(1072, 356);
            this.dataGridViewWithPaging1.TabIndex = 0;
            this.dataGridViewWithPaging1.Load += new System.EventHandler(this.DataGridViewWithPaging1_Load);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(23, 367);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(219, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLink1.TabIndex = 1;
            this.metroLink1.Text = "تحديد فترة الانتهاء";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // FRM_Expiredate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 436);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.dataGridViewWithPaging1);
            this.Name = "FRM_Expiredate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "منتجات قاربت على انتهاء صلاحيتها";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FRM_Expiredate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CPDataGridUserControl.DataGridViewWithPaging dataGridViewWithPaging1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}