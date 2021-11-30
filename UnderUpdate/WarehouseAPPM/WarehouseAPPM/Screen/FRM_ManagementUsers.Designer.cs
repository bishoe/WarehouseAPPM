namespace WarehouseAPPM.Screen
{
    partial class FRM_ManagementUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ManagementUsers));
            this.PNLILOGin = new MetroFramework.Controls.MetroPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNLINSERTROLES = new MetroFramework.Controls.MetroPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PNLINSERTPer = new MetroFramework.Controls.MetroPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CMBUsername = new System.Windows.Forms.ComboBox();
            this.CMBRolesName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBFormsNAme = new System.Windows.Forms.ComboBox();
            this.BTNADDPerm = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CKSearch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CKDelete = new System.Windows.Forms.CheckBox();
            this.CKAdd = new System.Windows.Forms.CheckBox();
            this.CKEdit = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PNLINSERTUSER = new MetroFramework.Controls.MetroPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TXTADDUSERPAssword = new System.Windows.Forms.TextBox();
            this.TXTADDUSERName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNLUPDATEPassword = new MetroFramework.Controls.MetroPanel();
            this.txtChangepasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtChangepassword = new System.Windows.Forms.TextBox();
            this.CMBUPDATEPassword = new System.Windows.Forms.ComboBox();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PNLILOGin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNLINSERTROLES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.PNLINSERTPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PNLINSERTUSER.SuspendLayout();
            this.PNLUPDATEPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNLILOGin
            // 
            this.PNLILOGin.Controls.Add(this.textBox1);
            this.PNLILOGin.Controls.Add(this.button1);
            this.PNLILOGin.Controls.Add(this.textBox2);
            this.PNLILOGin.Controls.Add(this.pictureBox1);
            this.PNLILOGin.HorizontalScrollbarBarColor = true;
            this.PNLILOGin.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLILOGin.HorizontalScrollbarSize = 10;
            this.PNLILOGin.Location = new System.Drawing.Point(8, 12);
            this.PNLILOGin.Name = "PNLILOGin";
            this.PNLILOGin.Size = new System.Drawing.Size(348, 213);
            this.PNLILOGin.TabIndex = 41;
            this.PNLILOGin.VerticalScrollbarBarColor = true;
            this.PNLILOGin.VerticalScrollbarHighlightOnWheel = false;
            this.PNLILOGin.VerticalScrollbarSize = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(15, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "UserName";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(15, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox2.Location = new System.Drawing.Point(15, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(265, 40);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "123456";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // PNLINSERTROLES
            // 
            this.PNLINSERTROLES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLINSERTROLES.Controls.Add(this.button3);
            this.PNLINSERTROLES.Controls.Add(this.textBox5);
            this.PNLINSERTROLES.Controls.Add(this.pictureBox4);
            this.PNLINSERTROLES.Controls.Add(this.label2);
            this.PNLINSERTROLES.HorizontalScrollbarBarColor = true;
            this.PNLINSERTROLES.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLINSERTROLES.HorizontalScrollbarSize = 10;
            this.PNLINSERTROLES.Location = new System.Drawing.Point(697, 12);
            this.PNLINSERTROLES.Name = "PNLINSERTROLES";
            this.PNLINSERTROLES.Size = new System.Drawing.Size(282, 213);
            this.PNLINSERTROLES.TabIndex = 39;
            this.PNLINSERTROLES.VerticalScrollbarBarColor = true;
            this.PNLINSERTROLES.VerticalScrollbarHighlightOnWheel = false;
            this.PNLINSERTROLES.VerticalScrollbarSize = 10;
            this.PNLINSERTROLES.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox5.Location = new System.Drawing.Point(3, 54);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 97);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(94, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "AddRoles";
            // 
            // PNLINSERTPer
            // 
            this.PNLINSERTPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNLINSERTPer.Controls.Add(this.pictureBox5);
            this.PNLINSERTPer.Controls.Add(this.CMBUsername);
            this.PNLINSERTPer.Controls.Add(this.CMBRolesName);
            this.PNLINSERTPer.Controls.Add(this.label3);
            this.PNLINSERTPer.Controls.Add(this.CMBFormsNAme);
            this.PNLINSERTPer.Controls.Add(this.BTNADDPerm);
            this.PNLINSERTPer.Controls.Add(this.label5);
            this.PNLINSERTPer.Controls.Add(this.CKSearch);
            this.PNLINSERTPer.Controls.Add(this.label4);
            this.PNLINSERTPer.Controls.Add(this.CKDelete);
            this.PNLINSERTPer.Controls.Add(this.CKAdd);
            this.PNLINSERTPer.Controls.Add(this.CKEdit);
            this.PNLINSERTPer.HorizontalScrollbarBarColor = true;
            this.PNLINSERTPer.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLINSERTPer.HorizontalScrollbarSize = 10;
            this.PNLINSERTPer.Location = new System.Drawing.Point(8, 249);
            this.PNLINSERTPer.Name = "PNLINSERTPer";
            this.PNLINSERTPer.Size = new System.Drawing.Size(348, 206);
            this.PNLINSERTPer.TabIndex = 38;
            this.PNLINSERTPer.VerticalScrollbarBarColor = true;
            this.PNLINSERTPer.VerticalScrollbarHighlightOnWheel = false;
            this.PNLINSERTPer.VerticalScrollbarSize = 10;
            this.PNLINSERTPer.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(8, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // CMBUsername
            // 
            this.CMBUsername.FormattingEnabled = true;
            this.CMBUsername.Location = new System.Drawing.Point(77, 55);
            this.CMBUsername.Name = "CMBUsername";
            this.CMBUsername.Size = new System.Drawing.Size(100, 21);
            this.CMBUsername.TabIndex = 23;
            this.CMBUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMBUsername_MouseClick);
            // 
            // CMBRolesName
            // 
            this.CMBRolesName.FormattingEnabled = true;
            this.CMBRolesName.Location = new System.Drawing.Point(183, 54);
            this.CMBRolesName.Name = "CMBRolesName";
            this.CMBRolesName.Size = new System.Drawing.Size(142, 21);
            this.CMBRolesName.TabIndex = 11;
            this.CMBRolesName.Click += new System.EventHandler(this.CMBRolesName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "FormsName";
            this.label3.Visible = false;
            // 
            // CMBFormsNAme
            // 
            this.CMBFormsNAme.FormattingEnabled = true;
            this.CMBFormsNAme.Location = new System.Drawing.Point(388, 54);
            this.CMBFormsNAme.Name = "CMBFormsNAme";
            this.CMBFormsNAme.Size = new System.Drawing.Size(116, 21);
            this.CMBFormsNAme.TabIndex = 24;
            this.CMBFormsNAme.Visible = false;
            // 
            // BTNADDPerm
            // 
            this.BTNADDPerm.Location = new System.Drawing.Point(32, 129);
            this.BTNADDPerm.Name = "BTNADDPerm";
            this.BTNADDPerm.Size = new System.Drawing.Size(270, 51);
            this.BTNADDPerm.TabIndex = 22;
            this.BTNADDPerm.Text = "Add";
            this.BTNADDPerm.UseVisualStyleBackColor = true;
            this.BTNADDPerm.Click += new System.EventHandler(this.BTNADDPerm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(73, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "USERNAMe";
            // 
            // CKSearch
            // 
            this.CKSearch.AutoSize = true;
            this.CKSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKSearch.Location = new System.Drawing.Point(420, 94);
            this.CKSearch.Name = "CKSearch";
            this.CKSearch.Size = new System.Drawing.Size(122, 28);
            this.CKSearch.TabIndex = 15;
            this.CKSearch.Text = "CKSearch";
            this.CKSearch.UseVisualStyleBackColor = true;
            this.CKSearch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "RolesName";
            // 
            // CKDelete
            // 
            this.CKDelete.AutoSize = true;
            this.CKDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKDelete.Location = new System.Drawing.Point(214, 95);
            this.CKDelete.Name = "CKDelete";
            this.CKDelete.Size = new System.Drawing.Size(116, 28);
            this.CKDelete.TabIndex = 14;
            this.CKDelete.Text = "CKDelete";
            this.CKDelete.UseVisualStyleBackColor = true;
            this.CKDelete.Visible = false;
            // 
            // CKAdd
            // 
            this.CKAdd.AutoSize = true;
            this.CKAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKAdd.Location = new System.Drawing.Point(16, 95);
            this.CKAdd.Name = "CKAdd";
            this.CKAdd.Size = new System.Drawing.Size(94, 28);
            this.CKAdd.TabIndex = 12;
            this.CKAdd.Text = "CKAdd";
            this.CKAdd.UseVisualStyleBackColor = true;
            this.CKAdd.Visible = false;
            // 
            // CKEdit
            // 
            this.CKEdit.AutoSize = true;
            this.CKEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CKEdit.Location = new System.Drawing.Point(116, 95);
            this.CKEdit.Name = "CKEdit";
            this.CKEdit.Size = new System.Drawing.Size(92, 28);
            this.CKEdit.TabIndex = 13;
            this.CKEdit.Text = "CKEdit";
            this.CKEdit.UseVisualStyleBackColor = true;
            this.CKEdit.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // PNLINSERTUSER
            // 
            this.PNLINSERTUSER.Controls.Add(this.label6);
            this.PNLINSERTUSER.Controls.Add(this.button2);
            this.PNLINSERTUSER.Controls.Add(this.TXTADDUSERPAssword);
            this.PNLINSERTUSER.Controls.Add(this.TXTADDUSERName);
            this.PNLINSERTUSER.Controls.Add(this.pictureBox2);
            this.PNLINSERTUSER.HorizontalScrollbarBarColor = true;
            this.PNLINSERTUSER.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLINSERTUSER.HorizontalScrollbarSize = 10;
            this.PNLINSERTUSER.Location = new System.Drawing.Point(362, 12);
            this.PNLINSERTUSER.Name = "PNLINSERTUSER";
            this.PNLINSERTUSER.Size = new System.Drawing.Size(282, 210);
            this.PNLINSERTUSER.TabIndex = 40;
            this.PNLINSERTUSER.VerticalScrollbarBarColor = true;
            this.PNLINSERTUSER.VerticalScrollbarHighlightOnWheel = false;
            this.PNLINSERTUSER.VerticalScrollbarSize = 10;
            this.PNLINSERTUSER.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "AddUsers";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXTADDUSERPAssword
            // 
            this.TXTADDUSERPAssword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTADDUSERPAssword.Location = new System.Drawing.Point(12, 111);
            this.TXTADDUSERPAssword.Name = "TXTADDUSERPAssword";
            this.TXTADDUSERPAssword.PasswordChar = '*';
            this.TXTADDUSERPAssword.Size = new System.Drawing.Size(265, 40);
            this.TXTADDUSERPAssword.TabIndex = 3;
            this.TXTADDUSERPAssword.Text = "123456";
            this.TXTADDUSERPAssword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTADDUSERName
            // 
            this.TXTADDUSERName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTADDUSERName.Location = new System.Drawing.Point(12, 65);
            this.TXTADDUSERName.Name = "TXTADDUSERName";
            this.TXTADDUSERName.Size = new System.Drawing.Size(265, 40);
            this.TXTADDUSERName.TabIndex = 4;
            this.TXTADDUSERName.Text = "UserName";
            this.TXTADDUSERName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adduser";
            // 
            // PNLUPDATEPassword
            // 
            this.PNLUPDATEPassword.Controls.Add(this.txtChangepasswordConfirm);
            this.PNLUPDATEPassword.Controls.Add(this.txtChangepassword);
            this.PNLUPDATEPassword.Controls.Add(this.CMBUPDATEPassword);
            this.PNLUPDATEPassword.Controls.Add(this.BTNUpdate);
            this.PNLUPDATEPassword.Controls.Add(this.label7);
            this.PNLUPDATEPassword.HorizontalScrollbarBarColor = true;
            this.PNLUPDATEPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.PNLUPDATEPassword.HorizontalScrollbarSize = 10;
            this.PNLUPDATEPassword.Location = new System.Drawing.Point(362, 249);
            this.PNLUPDATEPassword.Name = "PNLUPDATEPassword";
            this.PNLUPDATEPassword.Size = new System.Drawing.Size(292, 210);
            this.PNLUPDATEPassword.TabIndex = 42;
            this.PNLUPDATEPassword.VerticalScrollbarBarColor = true;
            this.PNLUPDATEPassword.VerticalScrollbarHighlightOnWheel = false;
            this.PNLUPDATEPassword.VerticalScrollbarSize = 10;
            this.PNLUPDATEPassword.Visible = false;
            // 
            // txtChangepasswordConfirm
            // 
            this.txtChangepasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtChangepasswordConfirm.Location = new System.Drawing.Point(12, 109);
            this.txtChangepasswordConfirm.Name = "txtChangepasswordConfirm";
            this.txtChangepasswordConfirm.PasswordChar = '*';
            this.txtChangepasswordConfirm.Size = new System.Drawing.Size(265, 40);
            this.txtChangepasswordConfirm.TabIndex = 36;
            this.txtChangepasswordConfirm.Text = "123456";
            this.txtChangepasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChangepassword
            // 
            this.txtChangepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtChangepassword.Location = new System.Drawing.Point(13, 68);
            this.txtChangepassword.Name = "txtChangepassword";
            this.txtChangepassword.PasswordChar = '*';
            this.txtChangepassword.Size = new System.Drawing.Size(265, 40);
            this.txtChangepassword.TabIndex = 35;
            this.txtChangepassword.Text = "123456";
            this.txtChangepassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMBUPDATEPassword
            // 
            this.CMBUPDATEPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBUPDATEPassword.ForeColor = System.Drawing.Color.YellowGreen;
            this.CMBUPDATEPassword.FormattingEnabled = true;
            this.CMBUPDATEPassword.Location = new System.Drawing.Point(12, 31);
            this.CMBUPDATEPassword.Name = "CMBUPDATEPassword";
            this.CMBUPDATEPassword.Size = new System.Drawing.Size(266, 33);
            this.CMBUPDATEPassword.TabIndex = 33;
            this.CMBUPDATEPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CMBUPDATEPassword_MouseClick);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(12, 150);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(266, 51);
            this.BTNUpdate.TabIndex = 32;
            this.BTNUpdate.Text = "UPDATE";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "USERNAMe";
            // 
            // FRM_ManagementUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 482);
            this.Controls.Add(this.PNLUPDATEPassword);
            this.Controls.Add(this.PNLILOGin);
            this.Controls.Add(this.PNLINSERTROLES);
            this.Controls.Add(this.PNLINSERTPer);
            this.Controls.Add(this.PNLINSERTUSER);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ManagementUsers";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "ManagementUsers";
            this.Load += new System.EventHandler(this.ManagementUsers_Load);
            this.PNLILOGin.ResumeLayout(false);
            this.PNLILOGin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PNLINSERTROLES.ResumeLayout(false);
            this.PNLINSERTROLES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.PNLINSERTPer.ResumeLayout(false);
            this.PNLINSERTPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PNLINSERTUSER.ResumeLayout(false);
            this.PNLINSERTUSER.PerformLayout();
            this.PNLUPDATEPassword.ResumeLayout(false);
            this.PNLUPDATEPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ComboBox CMBUsername;
        private System.Windows.Forms.ComboBox CMBRolesName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBFormsNAme;
        private System.Windows.Forms.Button BTNADDPerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CKSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CKDelete;
        private System.Windows.Forms.CheckBox CKAdd;
        private System.Windows.Forms.CheckBox CKEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXTADDUSERPAssword;
        private System.Windows.Forms.TextBox TXTADDUSERName;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroPanel PNLILOGin;
        public MetroFramework.Controls.MetroPanel PNLINSERTROLES;
        public MetroFramework.Controls.MetroPanel PNLINSERTPer;
        public MetroFramework.Controls.MetroPanel PNLINSERTUSER;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroPanel PNLUPDATEPassword;
        private System.Windows.Forms.ComboBox CMBUPDATEPassword;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChangepasswordConfirm;
        private System.Windows.Forms.TextBox txtChangepassword;
    }
}