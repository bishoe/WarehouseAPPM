using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_DB_CON : MetroFramework.Forms.MetroForm
    {
        //Properties.Settings.Default.Server
        public FRM_DB_CON()
        {
            InitializeComponent();
            txtServer.Text = WarehouseAPPM.Properties.Settings.Default.Server;
            label7.Text = WarehouseAPPM.Properties.Settings.Default.Database;
            if (WarehouseAPPM.Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
                txtID.Text = WarehouseAPPM.Properties.Settings.Default.ID;
                txtPWD.Text = WarehouseAPPM.Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtID.Clear();
                txtPWD.Clear();
                txtID.ReadOnly = true;
                txtPWD.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WarehouseAPPM.Properties.Settings.Default.Server = txtServer.Text;
            WarehouseAPPM.Properties.Settings.Default.Database = CMB.Text;
            WarehouseAPPM.Properties.Settings.Default.Mode = rbSQL.Checked == true ? "SQL" : "Windows";
            WarehouseAPPM.Properties.Settings.Default.ID = txtID.Text;
            WarehouseAPPM.Properties.Settings.Default.Password = txtPWD.Text;
            WarehouseAPPM.Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح");
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
                            CMB.Items.Add(dr[0].ToString());
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
        private void FRM_DB_CON_Load(object sender, EventArgs e)
        {
            GETDBNAME();
        }
    }
}
