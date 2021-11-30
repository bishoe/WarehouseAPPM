using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_BackupRestore : MetroFramework.Forms.MetroForm
    {
        public FRM_BackupRestore()
        {
            InitializeComponent();
        }
                    string GETFULLPATH;

        private void BTNRestore_Click(object sender, EventArgs e)
        {

          
        }

        private void Dbbackup_Complete(object sender, ServerMessageEventArgs e)
        {

            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });


            }
        }

        private void Dbbackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {


            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            label6.Invoke((MethodInvoker)delegate
            {
                label6.Text = $"{e.Percent}%";


            });
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
         
             
                }
            
        
        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            label6.Invoke((MethodInvoker)delegate
            {
                label6.Text = $"{e.Percent}%";


            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

           
        }
        private void GETDBNAME()
        {
            string connectionString = "Data Source=.; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            CMBDB.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable databases = con.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    String databaseName = database.Field<String>("database_name");
                    short dbID = database.Field<short>("dbid");
                    DateTime creationDate = database.Field<DateTime>("create_date");
                    //CMB.DisplayMember = databaseName;
                }
            }
        }
        private void BackupRestore_Load(object sender, EventArgs e)
        {
            GETDBNAME();
        }

        private void BTNCreateDB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {
                var fbd = new FolderBrowserDialog();

                DialogResult result = fbd.ShowDialog();
                GETFULLPATH = fbd.SelectedPath;

                Server dbserver = new Server(new ServerConnection(TXTSERVER.Text, TXTUserName.Text, TXTPassword.Text));

                Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = CMBDB.Text.ToString() };
                string GETPATHONLY = GETFULLPATH;
                GETFULLPATH += "\\" + CMBDB.Text + ".back";

                TXTPath.Text = GETFULLPATH;
                dbbackup.Devices.AddDevice(GETFULLPATH, DeviceType.File);


                dbbackup.Initialize = true;
                //>>>>>>>> +=  press Tab to create Dbbackup_PercentComplete event
                dbbackup.PercentComplete += Dbbackup_PercentComplete;
                dbbackup.Complete += Dbbackup_Complete;
                dbbackup.SqlBackupAsync(dbserver);
                Process.Start(GETPATHONLY);
                MessageBox.Show("Done");
                this.Hide();
                this.Dispose();

            }




            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog();

            fbd.Filter = "BACKUP Files(*.bak)|*.back";
            DialogResult result = fbd.ShowDialog();

            var onlyfilename = Path.GetDirectoryName(fbd.FileName);
            onlyfilename += Path.GetFileName(fbd.FileName);
            MessageBox.Show(onlyfilename);


            Server dbServer = new Server(new ServerConnection(TXTSERVER.Text, TXTUserName.Text, TXTPassword.Text));


            Restore dbRestore = new Restore() { Database = CMBDB.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
            dbRestore.Devices.AddDevice(onlyfilename, DeviceType.File);

            dbRestore.PercentComplete += DbRestore_PercentComplete;
            dbRestore.Complete += DbRestore_Complete;
            dbRestore.SqlRestoreAsync(dbServer);
        }
    }
}
