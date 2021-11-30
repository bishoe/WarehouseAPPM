namespace WarehouseAPPM.Screen
{
    partial class FRMWarehouse_invoice_Store_Status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMWarehouse_invoice_Store_Status));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNxtPage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFirstPAge = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtRemainingAMOUNT = new MetroFramework.Controls.MetroTextBox();
            this.txtPAIDAMOUNT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtbillno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMstoreID = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 369);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(50, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevPage.Location = new System.Drawing.Point(326, 8);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevPage.TabIndex = 13;
            this.btnPrevPage.Text = "السابقه";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLastPage.Location = new System.Drawing.Point(222, 8);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 14;
            this.btnLastPage.Text = "الاخيره";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNxtPage
            // 
            this.btnNxtPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNxtPage.Location = new System.Drawing.Point(438, 8);
            this.btnNxtPage.Name = "btnNxtPage";
            this.btnNxtPage.Size = new System.Drawing.Size(75, 23);
            this.btnNxtPage.TabIndex = 11;
            this.btnNxtPage.Text = "التالى";
            this.btnNxtPage.UseVisualStyleBackColor = false;
            this.btnNxtPage.Click += new System.EventHandler(this.btnNxtPage_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPrevPage);
            this.panel1.Controls.Add(this.btnLastPage);
            this.panel1.Controls.Add(this.btnNxtPage);
            this.panel1.Controls.Add(this.btnFirstPAge);
            this.panel1.Location = new System.Drawing.Point(12, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 47);
            this.panel1.TabIndex = 20;
            // 
            // btnFirstPAge
            // 
            this.btnFirstPAge.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFirstPAge.Location = new System.Drawing.Point(576, 8);
            this.btnFirstPAge.Name = "btnFirstPAge";
            this.btnFirstPAge.Size = new System.Drawing.Size(95, 23);
            this.btnFirstPAge.TabIndex = 12;
            this.btnFirstPAge.Text = "الاولى";
            this.btnFirstPAge.UseVisualStyleBackColor = false;
            this.btnFirstPAge.Click += new System.EventHandler(this.btnFirstPAge_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtMstoreID);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtbillno);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtRemainingAMOUNT);
            this.metroPanel1.Controls.Add(this.txtPAIDAMOUNT);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(718, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(272, 444);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.Crimson;
            this.metroButton1.Location = new System.Drawing.Point(22, 385);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(223, 58);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "حفظ";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(22, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(223, 35);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "المبلغ المتبقى";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(22, 300);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(223, 35);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "المبلغ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtRemainingAMOUNT
            // 
            this.txtRemainingAMOUNT.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.txtRemainingAMOUNT.CustomButton.Image = null;
            this.txtRemainingAMOUNT.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtRemainingAMOUNT.CustomButton.Name = "";
            this.txtRemainingAMOUNT.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtRemainingAMOUNT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemainingAMOUNT.CustomButton.TabIndex = 1;
            this.txtRemainingAMOUNT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemainingAMOUNT.CustomButton.UseSelectable = true;
            this.txtRemainingAMOUNT.CustomButton.Visible = false;
            this.txtRemainingAMOUNT.Enabled = false;
            this.txtRemainingAMOUNT.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRemainingAMOUNT.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtRemainingAMOUNT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtRemainingAMOUNT.Lines = new string[] {
        "0"};
            this.txtRemainingAMOUNT.Location = new System.Drawing.Point(22, 242);
            this.txtRemainingAMOUNT.MaxLength = 32767;
            this.txtRemainingAMOUNT.Multiline = true;
            this.txtRemainingAMOUNT.Name = "txtRemainingAMOUNT";
            this.txtRemainingAMOUNT.PasswordChar = '\0';
            this.txtRemainingAMOUNT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemainingAMOUNT.SelectedText = "";
            this.txtRemainingAMOUNT.SelectionLength = 0;
            this.txtRemainingAMOUNT.SelectionStart = 0;
            this.txtRemainingAMOUNT.ShortcutsEnabled = true;
            this.txtRemainingAMOUNT.Size = new System.Drawing.Size(223, 30);
            this.txtRemainingAMOUNT.Style = MetroFramework.MetroColorStyle.Green;
            this.txtRemainingAMOUNT.TabIndex = 3;
            this.txtRemainingAMOUNT.Text = "0";
            this.txtRemainingAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRemainingAMOUNT.UseCustomBackColor = true;
            this.txtRemainingAMOUNT.UseCustomForeColor = true;
            this.txtRemainingAMOUNT.UseSelectable = true;
            this.txtRemainingAMOUNT.UseStyleColors = true;
            this.txtRemainingAMOUNT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemainingAMOUNT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPAIDAMOUNT
            // 
            this.txtPAIDAMOUNT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            // 
            // 
            // 
            this.txtPAIDAMOUNT.CustomButton.Image = null;
            this.txtPAIDAMOUNT.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtPAIDAMOUNT.CustomButton.Name = "";
            this.txtPAIDAMOUNT.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPAIDAMOUNT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPAIDAMOUNT.CustomButton.TabIndex = 1;
            this.txtPAIDAMOUNT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPAIDAMOUNT.CustomButton.UseSelectable = true;
            this.txtPAIDAMOUNT.CustomButton.Visible = false;
            this.txtPAIDAMOUNT.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPAIDAMOUNT.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtPAIDAMOUNT.ForeColor = System.Drawing.Color.Crimson;
            this.txtPAIDAMOUNT.Lines = new string[] {
        "000"};
            this.txtPAIDAMOUNT.Location = new System.Drawing.Point(22, 338);
            this.txtPAIDAMOUNT.MaxLength = 32767;
            this.txtPAIDAMOUNT.Multiline = true;
            this.txtPAIDAMOUNT.Name = "txtPAIDAMOUNT";
            this.txtPAIDAMOUNT.PasswordChar = '\0';
            this.txtPAIDAMOUNT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPAIDAMOUNT.SelectedText = "";
            this.txtPAIDAMOUNT.SelectionLength = 0;
            this.txtPAIDAMOUNT.SelectionStart = 0;
            this.txtPAIDAMOUNT.ShortcutsEnabled = true;
            this.txtPAIDAMOUNT.Size = new System.Drawing.Size(223, 30);
            this.txtPAIDAMOUNT.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPAIDAMOUNT.TabIndex = 2;
            this.txtPAIDAMOUNT.Text = "000";
            this.txtPAIDAMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPAIDAMOUNT.UseCustomBackColor = true;
            this.txtPAIDAMOUNT.UseCustomForeColor = true;
            this.txtPAIDAMOUNT.UseSelectable = true;
            this.txtPAIDAMOUNT.UseStyleColors = true;
            this.txtPAIDAMOUNT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPAIDAMOUNT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPAIDAMOUNT.TabIndexChanged += new System.EventHandler(this.txtPAIDAMOUNT_TabIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(22, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(223, 35);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "فاتورة التاجر";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtbillno
            // 
            this.txtbillno.BackColor = System.Drawing.Color.RoyalBlue;
            // 
            // 
            // 
            this.txtbillno.CustomButton.Image = null;
            this.txtbillno.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtbillno.CustomButton.Name = "";
            this.txtbillno.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtbillno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbillno.CustomButton.TabIndex = 1;
            this.txtbillno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbillno.CustomButton.UseSelectable = true;
            this.txtbillno.CustomButton.Visible = false;
            this.txtbillno.Enabled = false;
            this.txtbillno.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbillno.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtbillno.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtbillno.Lines = new string[] {
        "0"};
            this.txtbillno.Location = new System.Drawing.Point(22, 78);
            this.txtbillno.MaxLength = 32767;
            this.txtbillno.Multiline = true;
            this.txtbillno.Name = "txtbillno";
            this.txtbillno.PasswordChar = '\0';
            this.txtbillno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbillno.SelectedText = "";
            this.txtbillno.SelectionLength = 0;
            this.txtbillno.SelectionStart = 0;
            this.txtbillno.ShortcutsEnabled = true;
            this.txtbillno.Size = new System.Drawing.Size(223, 30);
            this.txtbillno.Style = MetroFramework.MetroColorStyle.Green;
            this.txtbillno.TabIndex = 8;
            this.txtbillno.Text = "0";
            this.txtbillno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbillno.UseCustomBackColor = true;
            this.txtbillno.UseCustomForeColor = true;
            this.txtbillno.UseSelectable = true;
            this.txtbillno.UseStyleColors = true;
            this.txtbillno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbillno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(22, 126);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(223, 35);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "رقم الفاتوره";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // txtMstoreID
            // 
            this.txtMstoreID.BackColor = System.Drawing.Color.DodgerBlue;
            // 
            // 
            // 
            this.txtMstoreID.CustomButton.Image = null;
            this.txtMstoreID.CustomButton.Location = new System.Drawing.Point(195, 2);
            this.txtMstoreID.CustomButton.Name = "";
            this.txtMstoreID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMstoreID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMstoreID.CustomButton.TabIndex = 1;
            this.txtMstoreID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMstoreID.CustomButton.UseSelectable = true;
            this.txtMstoreID.CustomButton.Visible = false;
            this.txtMstoreID.Enabled = false;
            this.txtMstoreID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMstoreID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMstoreID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtMstoreID.Lines = new string[] {
        "0"};
            this.txtMstoreID.Location = new System.Drawing.Point(22, 164);
            this.txtMstoreID.MaxLength = 32767;
            this.txtMstoreID.Multiline = true;
            this.txtMstoreID.Name = "txtMstoreID";
            this.txtMstoreID.PasswordChar = '\0';
            this.txtMstoreID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMstoreID.SelectedText = "";
            this.txtMstoreID.SelectionLength = 0;
            this.txtMstoreID.SelectionStart = 0;
            this.txtMstoreID.ShortcutsEnabled = true;
            this.txtMstoreID.Size = new System.Drawing.Size(223, 30);
            this.txtMstoreID.Style = MetroFramework.MetroColorStyle.Green;
            this.txtMstoreID.TabIndex = 10;
            this.txtMstoreID.Text = "0";
            this.txtMstoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMstoreID.UseCustomBackColor = true;
            this.txtMstoreID.UseCustomForeColor = true;
            this.txtMstoreID.UseSelectable = true;
            this.txtMstoreID.UseStyleColors = true;
            this.txtMstoreID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMstoreID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRMWarehouse_invoice_Store_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 515);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FRMWarehouse_invoice_Store_Status";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الفواتير الغير مكتمله السداد";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this._Warehouse_invoice_Store_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNxtPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFirstPAge;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtPAIDAMOUNT;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtRemainingAMOUNT;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMstoreID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtbillno;
    }
}