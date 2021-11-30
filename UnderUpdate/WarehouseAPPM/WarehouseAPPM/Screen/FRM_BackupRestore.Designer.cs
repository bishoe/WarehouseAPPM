namespace WarehouseAPPM.Screen
{
    partial class FRM_BackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_BackupRestore));
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.LBLDatabase = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBDB = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSERVER = new MetroFramework.Controls.MetroTextBox();
            this.TXTUserName = new MetroFramework.Controls.MetroTextBox();
            this.TXTPassword = new MetroFramework.Controls.MetroTextBox();
            this.TXTPath = new MetroFramework.Controls.MetroTextBox();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNCreateDB = new MetroFramework.Controls.MetroButton();
            this.TXTCREATEDB = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "0 %";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(19, 281);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 201);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(5, 172);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 16);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "UserName";
            // 
            // LBLDatabase
            // 
            this.LBLDatabase.AutoSize = true;
            this.LBLDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDatabase.Location = new System.Drawing.Point(8, 138);
            this.LBLDatabase.Name = "LBLDatabase";
            this.LBLDatabase.Size = new System.Drawing.Size(76, 16);
            this.LBLDatabase.TabIndex = 15;
            this.LBLDatabase.Text = "Database";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.Location = new System.Drawing.Point(19, 110);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(54, 16);
            this.lblServer.TabIndex = 14;
            this.lblServer.Text = "Server";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Path";
            // 
            // CMBDB
            // 
            this.CMBDB.FormattingEnabled = true;
            this.CMBDB.ItemHeight = 23;
            this.CMBDB.Location = new System.Drawing.Point(102, 135);
            this.CMBDB.Name = "CMBDB";
            this.CMBDB.Size = new System.Drawing.Size(444, 29);
            this.CMBDB.TabIndex = 2;
            this.CMBDB.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Db Name :";
            // 
            // TXTSERVER
            // 
            // 
            // 
            // 
            this.TXTSERVER.CustomButton.Image = null;
            this.TXTSERVER.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.TXTSERVER.CustomButton.Name = "";
            this.TXTSERVER.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTSERVER.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTSERVER.CustomButton.TabIndex = 1;
            this.TXTSERVER.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTSERVER.CustomButton.UseSelectable = true;
            this.TXTSERVER.CustomButton.Visible = false;
            this.TXTSERVER.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTSERVER.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTSERVER.Lines = new string[] {
        "."};
            this.TXTSERVER.Location = new System.Drawing.Point(102, 106);
            this.TXTSERVER.MaxLength = 32767;
            this.TXTSERVER.Name = "TXTSERVER";
            this.TXTSERVER.PasswordChar = '\0';
            this.TXTSERVER.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTSERVER.SelectedText = "";
            this.TXTSERVER.SelectionLength = 0;
            this.TXTSERVER.SelectionStart = 0;
            this.TXTSERVER.ShortcutsEnabled = true;
            this.TXTSERVER.Size = new System.Drawing.Size(444, 23);
            this.TXTSERVER.TabIndex = 1;
            this.TXTSERVER.Text = ".";
            this.TXTSERVER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTSERVER.UseSelectable = true;
            this.TXTSERVER.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTSERVER.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTUserName
            // 
            // 
            // 
            // 
            this.TXTUserName.CustomButton.Image = null;
            this.TXTUserName.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.TXTUserName.CustomButton.Name = "";
            this.TXTUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTUserName.CustomButton.TabIndex = 1;
            this.TXTUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTUserName.CustomButton.UseSelectable = true;
            this.TXTUserName.CustomButton.Visible = false;
            this.TXTUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTUserName.Lines = new string[] {
        "sa"};
            this.TXTUserName.Location = new System.Drawing.Point(102, 169);
            this.TXTUserName.MaxLength = 32767;
            this.TXTUserName.Name = "TXTUserName";
            this.TXTUserName.PasswordChar = '\0';
            this.TXTUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTUserName.SelectedText = "";
            this.TXTUserName.SelectionLength = 0;
            this.TXTUserName.SelectionStart = 0;
            this.TXTUserName.ShortcutsEnabled = true;
            this.TXTUserName.Size = new System.Drawing.Size(444, 23);
            this.TXTUserName.TabIndex = 3;
            this.TXTUserName.Text = "sa";
            this.TXTUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTUserName.UseSelectable = true;
            this.TXTUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTPassword
            // 
            // 
            // 
            // 
            this.TXTPassword.CustomButton.Image = null;
            this.TXTPassword.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.TXTPassword.CustomButton.Name = "";
            this.TXTPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTPassword.CustomButton.TabIndex = 1;
            this.TXTPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTPassword.CustomButton.UseSelectable = true;
            this.TXTPassword.CustomButton.Visible = false;
            this.TXTPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTPassword.Lines = new string[] {
        "123456"};
            this.TXTPassword.Location = new System.Drawing.Point(103, 194);
            this.TXTPassword.MaxLength = 32767;
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '●';
            this.TXTPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTPassword.SelectedText = "";
            this.TXTPassword.SelectionLength = 0;
            this.TXTPassword.SelectionStart = 0;
            this.TXTPassword.ShortcutsEnabled = true;
            this.TXTPassword.Size = new System.Drawing.Size(444, 23);
            this.TXTPassword.TabIndex = 4;
            this.TXTPassword.Text = "123456";
            this.TXTPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPassword.UseSelectable = true;
            this.TXTPassword.UseSystemPasswordChar = true;
            this.TXTPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TXTPath
            // 
            // 
            // 
            // 
            this.TXTPath.CustomButton.Image = null;
            this.TXTPath.CustomButton.Location = new System.Drawing.Point(422, 1);
            this.TXTPath.CustomButton.Name = "";
            this.TXTPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTPath.CustomButton.TabIndex = 1;
            this.TXTPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTPath.CustomButton.UseSelectable = true;
            this.TXTPath.CustomButton.Visible = false;
            this.TXTPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTPath.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTPath.Lines = new string[] {
        "."};
            this.TXTPath.Location = new System.Drawing.Point(103, 222);
            this.TXTPath.MaxLength = 32767;
            this.TXTPath.Name = "TXTPath";
            this.TXTPath.PasswordChar = '\0';
            this.TXTPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTPath.SelectedText = "";
            this.TXTPath.SelectionLength = 0;
            this.TXTPath.SelectionStart = 0;
            this.TXTPath.ShortcutsEnabled = true;
            this.TXTPath.Size = new System.Drawing.Size(444, 23);
            this.TXTPath.TabIndex = 5;
            this.TXTPath.Text = ".";
            this.TXTPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTPath.UseSelectable = true;
            this.TXTPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 255);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBar1.Size = new System.Drawing.Size(535, 23);
            this.progressBar1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Restore";
            // 
            // BTNCreateDB
            // 
            this.BTNCreateDB.Location = new System.Drawing.Point(338, 72);
            this.BTNCreateDB.Name = "BTNCreateDB";
            this.BTNCreateDB.Size = new System.Drawing.Size(209, 23);
            this.BTNCreateDB.Style = MetroFramework.MetroColorStyle.Brown;
            this.BTNCreateDB.TabIndex = 39;
            this.BTNCreateDB.Text = "Create";
            this.BTNCreateDB.UseSelectable = true;
            this.BTNCreateDB.UseStyleColors = true;
            this.BTNCreateDB.Click += new System.EventHandler(this.BTNCreateDB_Click);
            // 
            // TXTCREATEDB
            // 
            // 
            // 
            // 
            this.TXTCREATEDB.CustomButton.Image = null;
            this.TXTCREATEDB.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.TXTCREATEDB.CustomButton.Name = "";
            this.TXTCREATEDB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TXTCREATEDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TXTCREATEDB.CustomButton.TabIndex = 1;
            this.TXTCREATEDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TXTCREATEDB.CustomButton.UseSelectable = true;
            this.TXTCREATEDB.CustomButton.Visible = false;
            this.TXTCREATEDB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TXTCREATEDB.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TXTCREATEDB.Lines = new string[] {
        "."};
            this.TXTCREATEDB.Location = new System.Drawing.Point(102, 72);
            this.TXTCREATEDB.MaxLength = 32767;
            this.TXTCREATEDB.Name = "TXTCREATEDB";
            this.TXTCREATEDB.PasswordChar = '\0';
            this.TXTCREATEDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTCREATEDB.SelectedText = "";
            this.TXTCREATEDB.SelectionLength = 0;
            this.TXTCREATEDB.SelectionStart = 0;
            this.TXTCREATEDB.ShortcutsEnabled = true;
            this.TXTCREATEDB.Size = new System.Drawing.Size(230, 23);
            this.TXTCREATEDB.TabIndex = 0;
            this.TXTCREATEDB.Text = ".";
            this.TXTCREATEDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTCREATEDB.UseSelectable = true;
            this.TXTCREATEDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TXTCREATEDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FRM_BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTCREATEDB);
            this.Controls.Add(this.BTNCreateDB);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTPath);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTUserName);
            this.Controls.Add(this.TXTSERVER);
            this.Controls.Add(this.CMBDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.LBLDatabase);
            this.Controls.Add(this.lblServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BackupRestore";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Backup&Restore";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label LBLDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox CMBDB;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox TXTSERVER;
        private MetroFramework.Controls.MetroTextBox TXTUserName;
        private MetroFramework.Controls.MetroTextBox TXTPassword;
        private MetroFramework.Controls.MetroTextBox TXTPath;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton BTNCreateDB;
        private MetroFramework.Controls.MetroTextBox TXTCREATEDB;
    }
}