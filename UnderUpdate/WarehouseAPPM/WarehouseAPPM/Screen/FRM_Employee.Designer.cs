namespace WarehouseAPPM.Screen
{
    partial class FRM_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Employee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMBEmployee = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BTNEdit = new MetroFramework.Controls.MetroButton();
            this.PanelSub = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.BtnDel = new MetroFramework.Controls.MetroButton();
            this.PaneMain = new MetroFramework.Controls.MetroPanel();
            this.LBLEmpID = new MetroFramework.Controls.MetroLabel();
            this.TXTSalary = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TXTNOTE = new MetroFramework.Controls.MetroTextBox();
            this.TXTPHONE = new MetroFramework.Controls.MetroTextBox();
            this.TXTADDress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BTNNew = new MetroFramework.Controls.MetroButton();
            this.TXTName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSub.SuspendLayout();
            this.PaneMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMBEmployee
            // 
            this.CMBEmployee.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.CMBEmployee.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.CMBEmployee.FormattingEnabled = true;
            this.CMBEmployee.ItemHeight = 29;
            this.CMBEmployee.Location = new System.Drawing.Point(80, 14);
            this.CMBEmployee.Name = "CMBEmployee";
            this.CMBEmployee.Size = new System.Drawing.Size(272, 35);
            this.CMBEmployee.TabIndex = 6;
            this.CMBEmployee.UseSelectable = true;
            this.CMBEmployee.Click += new System.EventHandler(this.CMBEmployee_Click);
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
            // 
            // BTNEdit
            // 
            this.BTNEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEdit.BackgroundImage")));
            this.BTNEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNEdit.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNEdit.Location = new System.Drawing.Point(585, 137);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(162, 64);
            this.BTNEdit.TabIndex = 4;
            this.BTNEdit.Text = "تعديل";
            this.BTNEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BTNEdit.UseSelectable = true;
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // PanelSub
            // 
            this.PanelSub.AutoScroll = true;
            this.PanelSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelSub.BackgroundImage")));
            this.PanelSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSub.Controls.Add(this.metroLabel6);
            this.PanelSub.Controls.Add(this.pictureBox1);
            this.PanelSub.Controls.Add(this.CMBEmployee);
            this.PanelSub.Controls.Add(this.metroButton4);
            this.PanelSub.Controls.Add(this.BtnDel);
            this.PanelSub.Controls.Add(this.BTNEdit);
            this.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSub.HorizontalScrollbar = true;
            this.PanelSub.HorizontalScrollbarBarColor = true;
            this.PanelSub.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSub.HorizontalScrollbarSize = 10;
            this.PanelSub.Location = new System.Drawing.Point(20, 314);
            this.PanelSub.Name = "PanelSub";
            this.PanelSub.Size = new System.Drawing.Size(760, 252);
            this.PanelSub.TabIndex = 31;
            this.PanelSub.VerticalScrollbar = true;
            this.PanelSub.VerticalScrollbarBarColor = true;
            this.PanelSub.VerticalScrollbarHighlightOnWheel = true;
            this.PanelSub.VerticalScrollbarSize = 10;
            this.PanelSub.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(365, 23);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "اسم الموظف";
            // 
            // BtnDel
            // 
            this.BtnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDel.BackgroundImage")));
            this.BtnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDel.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnDel.Location = new System.Drawing.Point(275, 137);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(162, 64);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnDel.UseSelectable = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // PaneMain
            // 
            this.PaneMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaneMain.Controls.Add(this.LBLEmpID);
            this.PaneMain.Controls.Add(this.TXTSalary);
            this.PaneMain.Controls.Add(this.metroLabel7);
            this.PaneMain.Controls.Add(this.TXTNOTE);
            this.PaneMain.Controls.Add(this.TXTPHONE);
            this.PaneMain.Controls.Add(this.TXTADDress);
            this.PaneMain.Controls.Add(this.metroLabel5);
            this.PaneMain.Controls.Add(this.metroLabel4);
            this.PaneMain.Controls.Add(this.metroLabel3);
            this.PaneMain.Controls.Add(this.DTP);
            this.PaneMain.Controls.Add(this.metroLabel2);
            this.PaneMain.Controls.Add(this.BtnSave);
            this.PaneMain.Controls.Add(this.metroLabel1);
            this.PaneMain.Controls.Add(this.BTNNew);
            this.PaneMain.Controls.Add(this.TXTName);
            this.PaneMain.HorizontalScrollbarBarColor = true;
            this.PaneMain.HorizontalScrollbarHighlightOnWheel = false;
            this.PaneMain.HorizontalScrollbarSize = 10;
            this.PaneMain.Location = new System.Drawing.Point(20, 25);
            this.PaneMain.Name = "PaneMain";
            this.PaneMain.Size = new System.Drawing.Size(760, 274);
            this.PaneMain.TabIndex = 32;
            this.PaneMain.VerticalScrollbarBarColor = true;
            this.PaneMain.VerticalScrollbarHighlightOnWheel = false;
            this.PaneMain.VerticalScrollbarSize = 10;
            // 
            // LBLEmpID
            // 
            this.LBLEmpID.AutoSize = true;
            this.LBLEmpID.Location = new System.Drawing.Point(282, 64);
            this.LBLEmpID.Name = "LBLEmpID";
            this.LBLEmpID.Size = new System.Drawing.Size(83, 19);
            this.LBLEmpID.TabIndex = 50;
            this.LBLEmpID.Text = "metroLabel8";
            this.LBLEmpID.Visible = false;
            // 
            // TXTSalary
            // 
            // 
            // 
            // 
            this.TXTSalary.CustomButton.Image = null;
            this.TXTSalary.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TXTSalary.CustomButton.Name = "";
            this.TXTSalary.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSalary.CustomButton.TabIndex = 1;
            this.TXTSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSalary.CustomButton.UseSelectable = true;
            this.TXTSalary.CustomButton.Visible = false;
            this.TXTSalary.Lines = new string[0];
            this.TXTSalary.Location = new System.Drawing.Point(15, 95);
            this.TXTSalary.MaxLength = 32767;
            this.TXTSalary.Name = "TXTSalary";
            this.TXTSalary.PasswordChar = '\0';
            this.TXTSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSalary.SelectedText = "";
            this.TXTSalary.SelectionLength = 0;
            this.TXTSalary.SelectionStart = 0;
            this.TXTSalary.ShortcutsEnabled = true;
            this.TXTSalary.Size = new System.Drawing.Size(207, 23);
            this.TXTSalary.TabIndex = 49;
            this.TXTSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSalary.UseSelectable = true;
            this.TXTSalary.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTSalary.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTSalary.TextChanged += new System.EventHandler(this.TXTSalary_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(232, 99);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(40, 19);
            this.metroLabel7.TabIndex = 48;
            this.metroLabel7.Text = "الراتب";
            // 
            // TXTNOTE
            // 
            // 
            // 
            // 
            this.TXTNOTE.CustomButton.Image = null;
            this.TXTNOTE.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.TXTNOTE.CustomButton.Name = "";
            this.TXTNOTE.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.TXTNOTE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTNOTE.CustomButton.TabIndex = 1;
            this.TXTNOTE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTNOTE.CustomButton.UseSelectable = true;
            this.TXTNOTE.CustomButton.Visible = false;
            this.TXTNOTE.Lines = new string[0];
            this.TXTNOTE.Location = new System.Drawing.Point(368, 142);
            this.TXTNOTE.MaxLength = 32767;
            this.TXTNOTE.Multiline = true;
            this.TXTNOTE.Name = "TXTNOTE";
            this.TXTNOTE.PasswordChar = '\0';
            this.TXTNOTE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTNOTE.SelectedText = "";
            this.TXTNOTE.SelectionLength = 0;
            this.TXTNOTE.SelectionStart = 0;
            this.TXTNOTE.ShortcutsEnabled = true;
            this.TXTNOTE.Size = new System.Drawing.Size(290, 100);
            this.TXTNOTE.TabIndex = 47;
            this.TXTNOTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTNOTE.UseSelectable = true;
            this.TXTNOTE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTNOTE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTPHONE
            // 
            // 
            // 
            // 
            this.TXTPHONE.CustomButton.Image = null;
            this.TXTPHONE.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TXTPHONE.CustomButton.Name = "";
            this.TXTPHONE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTPHONE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTPHONE.CustomButton.TabIndex = 1;
            this.TXTPHONE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTPHONE.CustomButton.UseSelectable = true;
            this.TXTPHONE.CustomButton.Visible = false;
            this.TXTPHONE.Lines = new string[0];
            this.TXTPHONE.Location = new System.Drawing.Point(15, 70);
            this.TXTPHONE.MaxLength = 32767;
            this.TXTPHONE.Name = "TXTPHONE";
            this.TXTPHONE.PasswordChar = '\0';
            this.TXTPHONE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTPHONE.SelectedText = "";
            this.TXTPHONE.SelectionLength = 0;
            this.TXTPHONE.SelectionStart = 0;
            this.TXTPHONE.ShortcutsEnabled = true;
            this.TXTPHONE.Size = new System.Drawing.Size(207, 23);
            this.TXTPHONE.TabIndex = 46;
            this.TXTPHONE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPHONE.UseSelectable = true;
            this.TXTPHONE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTPHONE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTPHONE.TextChanged += new System.EventHandler(this.TXTPHONE_TextChanged);
            // 
            // TXTADDress
            // 
            // 
            // 
            // 
            this.TXTADDress.CustomButton.Image = null;
            this.TXTADDress.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTADDress.CustomButton.Name = "";
            this.TXTADDress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTADDress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTADDress.CustomButton.TabIndex = 1;
            this.TXTADDress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTADDress.CustomButton.UseSelectable = true;
            this.TXTADDress.CustomButton.Visible = false;
            this.TXTADDress.Lines = new string[0];
            this.TXTADDress.Location = new System.Drawing.Point(368, 99);
            this.TXTADDress.MaxLength = 32767;
            this.TXTADDress.Name = "TXTADDress";
            this.TXTADDress.PasswordChar = '\0';
            this.TXTADDress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTADDress.SelectedText = "";
            this.TXTADDress.SelectionLength = 0;
            this.TXTADDress.SelectionStart = 0;
            this.TXTADDress.ShortcutsEnabled = true;
            this.TXTADDress.Size = new System.Drawing.Size(290, 23);
            this.TXTADDress.TabIndex = 45;
            this.TXTADDress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTADDress.UseSelectable = true;
            this.TXTADDress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTADDress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(664, 169);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "ملاحظات";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(233, 74);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 43;
            this.metroLabel4.Text = "الهاتف";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(683, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "العنوان";
            // 
            // DTP
            // 
            this.DTP.Enabled = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(15, 31);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 41;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(221, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "تاريخ الاضافة";
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSave.Enabled = false;
            this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BtnSave.Location = new System.Drawing.Point(12, 191);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(237, 64);
            this.BtnSave.TabIndex = 37;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(664, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "اسم الموظف";
            // 
            // BTNNew
            // 
            this.BTNNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNew.BackgroundImage")));
            this.BTNNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BTNNew.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTNNew.Location = new System.Drawing.Point(12, 121);
            this.BTNNew.Name = "BTNNew";
            this.BTNNew.Size = new System.Drawing.Size(237, 64);
            this.BTNNew.TabIndex = 36;
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
            this.TXTName.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.TXTName.CustomButton.Name = "";
            this.TXTName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTName.CustomButton.TabIndex = 1;
            this.TXTName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTName.CustomButton.UseSelectable = true;
            this.TXTName.CustomButton.Visible = false;
            this.TXTName.Lines = new string[0];
            this.TXTName.Location = new System.Drawing.Point(368, 38);
            this.TXTName.MaxLength = 32767;
            this.TXTName.Name = "TXTName";
            this.TXTName.PasswordChar = '\0';
            this.TXTName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTName.SelectedText = "";
            this.TXTName.SelectionLength = 0;
            this.TXTName.SelectionStart = 0;
            this.TXTName.ShortcutsEnabled = true;
            this.TXTName.Size = new System.Drawing.Size(290, 23);
            this.TXTName.TabIndex = 38;
            this.TXTName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTName.UseSelectable = true;
            this.TXTName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TXTName.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            this.TXTName.Leave += new System.EventHandler(this.TXTName_Leave);
            // 
            // FRM_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.PaneMain);
            this.Controls.Add(this.PanelSub);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Employee";
            this.Resizable = false;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSub.ResumeLayout(false);
            this.PanelSub.PerformLayout();
            this.PaneMain.ResumeLayout(false);
            this.PaneMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox CMBEmployee;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel PaneMain;
        private MetroFramework.Controls.MetroTextBox TXTNOTE;
        private MetroFramework.Controls.MetroTextBox TXTPHONE;
        private MetroFramework.Controls.MetroTextBox TXTADDress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker DTP;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BTNNew;
        private MetroFramework.Controls.MetroTextBox TXTName;
        private MetroFramework.Controls.MetroTextBox TXTSalary;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel LBLEmpID;
        public MetroFramework.Controls.MetroButton BTNEdit;
        public MetroFramework.Controls.MetroPanel PanelSub;
        public MetroFramework.Controls.MetroButton BtnDel;
        public MetroFramework.Controls.MetroButton BtnSave;
    }
}