using WarehouseAPPM.Reports;

namespace WarehouseAPPM.Screen
{
    partial class FRMPRINTBARCODE
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBarCode = new MetroFramework.Controls.MetroTextBox();
            this.TXTPRODUCTNAME = new MetroFramework.Controls.MetroTextBox();
            this.barcode1 = new WarehouseAPPM.Reports.barcode();
            this.BTNPrint = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 155);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(831, 371);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "show all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(438, 95);
            this.txtQT.MaxLength = 2;
            this.txtQT.Name = "txtQT";
            this.txtQT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQT.Size = new System.Drawing.Size(171, 20);
            this.txtQT.TabIndex = 4;
            this.txtQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المنتج";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "الكميه";
            // 
            // TXTBarCode
            // 
            // 
            // 
            // 
            this.TXTBarCode.CustomButton.Image = null;
            this.TXTBarCode.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.TXTBarCode.CustomButton.Name = "";
            this.TXTBarCode.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.TXTBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTBarCode.CustomButton.TabIndex = 1;
            this.TXTBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBarCode.CustomButton.UseSelectable = true;
            this.TXTBarCode.CustomButton.Visible = false;
            this.TXTBarCode.DisplayIcon = true;
            this.TXTBarCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TXTBarCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTBarCode.Lines = new string[0];
            this.TXTBarCode.Location = new System.Drawing.Point(277, 33);
            this.TXTBarCode.MaxLength = 32767;
            this.TXTBarCode.Multiline = true;
            this.TXTBarCode.Name = "TXTBarCode";
            this.TXTBarCode.PasswordChar = '\0';
            //this.TXTBarCode.PromptText = "BareCode";
            this.TXTBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTBarCode.SelectedText = "";
            this.TXTBarCode.SelectionLength = 0;
            this.TXTBarCode.SelectionStart = 0;
            this.TXTBarCode.ShortcutsEnabled = true;
            this.TXTBarCode.ShowClearButton = true;
            this.TXTBarCode.Size = new System.Drawing.Size(155, 69);
            this.TXTBarCode.Style = MetroFramework.MetroColorStyle.Green;
            this.TXTBarCode.TabIndex = 8;
            this.TXTBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTBarCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTBarCode.UseSelectable = true;
            this.TXTBarCode.WaterMark = "BareCode";
            this.TXTBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTBarCode.WaterMarkFont = new System.Drawing.Font("IDAutomationHC39M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // TXTPRODUCTNAME
            // 
            // 
            // 
            // 
            this.TXTPRODUCTNAME.CustomButton.Image = null;
            this.TXTPRODUCTNAME.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.TXTPRODUCTNAME.CustomButton.Name = "";
            this.TXTPRODUCTNAME.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.TXTPRODUCTNAME.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTPRODUCTNAME.CustomButton.TabIndex = 1;
            this.TXTPRODUCTNAME.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTPRODUCTNAME.CustomButton.UseSelectable = true;
            this.TXTPRODUCTNAME.CustomButton.Visible = false;
            this.TXTPRODUCTNAME.Lines = new string[0];
            this.TXTPRODUCTNAME.Location = new System.Drawing.Point(438, 36);
            this.TXTPRODUCTNAME.MaxLength = 40;
            this.TXTPRODUCTNAME.Name = "TXTPRODUCTNAME";
            this.TXTPRODUCTNAME.PasswordChar = '\0';
            this.TXTPRODUCTNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTPRODUCTNAME.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTPRODUCTNAME.SelectedText = "";
            this.TXTPRODUCTNAME.SelectionLength = 0;
            this.TXTPRODUCTNAME.SelectionStart = 0;
            this.TXTPRODUCTNAME.ShortcutsEnabled = true;
            this.TXTPRODUCTNAME.Size = new System.Drawing.Size(171, 24);
            this.TXTPRODUCTNAME.TabIndex = 9;
            this.TXTPRODUCTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPRODUCTNAME.UseSelectable = true;
            this.TXTPRODUCTNAME.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTPRODUCTNAME.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTPRODUCTNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPRODUCTNAME_KeyDown);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(277, 108);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(155, 41);
            this.BTNPrint.TabIndex = 10;
            this.BTNPrint.Text = "طباعه";
            this.BTNPrint.UseSelectable = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // FRMPRINTBARCODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 526);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.TXTPRODUCTNAME);
            this.Controls.Add(this.TXTBarCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FRMPRINTBARCODE";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "طباعه الباركود";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private barcode barcode1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TXTBarCode;
        private MetroFramework.Controls.MetroTextBox TXTPRODUCTNAME;
        private MetroFramework.Controls.MetroButton BTNPrint;
    }
}