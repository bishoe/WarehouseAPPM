namespace WarehouseAPPM
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNExit = new MetroFramework.Controls.MetroButton();
            this.BTNSAVE = new MetroFramework.Controls.MetroButton();
            this.TXTMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNSENDMAIL = new MetroFramework.Controls.MetroButton();
            this.PNL = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // lblProductKey
            // 
            this.lblProductKey.AutoSize = true;
            this.lblProductKey.Location = new System.Drawing.Point(4, 36);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(65, 13);
            this.lblProductKey.TabIndex = 1;
            this.lblProductKey.Text = "Product Key";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(70, 10);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(238, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(71, 36);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(237, 20);
            this.txtProductKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "bishoyrizkdev@gmail.com";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(19, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tel / 01025012313";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(16, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "©2015 Bishoy Nabil All Rights Reserved";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BTNExit
            // 
            this.BTNExit.Location = new System.Drawing.Point(233, 62);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 13;
            this.BTNExit.Text = "Exit";
            this.BTNExit.UseSelectable = true;
            this.BTNExit.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Location = new System.Drawing.Point(71, 62);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(75, 23);
            this.BTNSAVE.TabIndex = 14;
            this.BTNSAVE.Text = "Save";
            this.BTNSAVE.UseSelectable = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // TXTMail
            // 
            this.TXTMail.Location = new System.Drawing.Point(89, 63);
            this.TXTMail.Name = "TXTMail";
            this.TXTMail.Size = new System.Drawing.Size(250, 20);
            this.TXTMail.TabIndex = 16;
            this.TXTMail.Leave += new System.EventHandler(this.TXTMail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // BTNSENDMAIL
            // 
            this.BTNSENDMAIL.Location = new System.Drawing.Point(90, 87);
            this.BTNSENDMAIL.Name = "BTNSENDMAIL";
            this.BTNSENDMAIL.Size = new System.Drawing.Size(81, 23);
            this.BTNSENDMAIL.TabIndex = 17;
            this.BTNSENDMAIL.Text = "Save";
            this.BTNSENDMAIL.UseSelectable = true;
            this.BTNSENDMAIL.Click += new System.EventHandler(this.BTNSENDMAIL_Click);
            // 
            // PNL
            // 
            this.PNL.Controls.Add(this.BTNSAVE);
            this.PNL.Controls.Add(this.label1);
            this.PNL.Controls.Add(this.lblProductKey);
            this.PNL.Controls.Add(this.BTNExit);
            this.PNL.Controls.Add(this.txtProductID);
            this.PNL.Controls.Add(this.txtProductKey);
            this.PNL.HorizontalScrollbarBarColor = true;
            this.PNL.HorizontalScrollbarHighlightOnWheel = false;
            this.PNL.HorizontalScrollbarSize = 10;
            this.PNL.Location = new System.Drawing.Point(49, 116);
            this.PNL.Name = "PNL";
            this.PNL.Size = new System.Drawing.Size(330, 100);
            this.PNL.TabIndex = 18;
            this.PNL.VerticalScrollbarBarColor = true;
            this.PNL.VerticalScrollbarHighlightOnWheel = false;
            this.PNL.VerticalScrollbarSize = 10;
            this.PNL.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(264, 89);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 275);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 358);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PNL);
            this.Controls.Add(this.BTNSENDMAIL);
            this.Controls.Add(this.TXTMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.MinimizeBox = false;
            this.Name = "FrmRegistration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistration_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PNL.ResumeLayout(false);
            this.PNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BTNExit;
        private MetroFramework.Controls.MetroButton BTNSAVE;
        private System.Windows.Forms.TextBox TXTMail;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton BTNSENDMAIL;
        private MetroFramework.Controls.MetroPanel PNL;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}