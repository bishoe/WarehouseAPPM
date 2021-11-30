using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;
//using WarehouseAPPM.Classes;
using WarehouseAPPM.Screen;
using System.Net;
using System.Net.Mail;

namespace WarehouseAPPM
{
    public partial class FRM_login : MetroFramework.Forms.MetroForm
    {
        public FRM_login()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

  
       
    private void login_Load(object sender, EventArgs e)
        {
       

        }

        public static DataTable _ExecuteQuery(string text, CommandType com)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = com;
                cmd.CommandText = text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet dt = new DataSet();
                dt.Clear();
                da.Fill(dt);
                da.Dispose();
                DBConnect.conn.Dispose();

                return dt.Tables[0];

            }

            }
        }

      
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            //this.Dispose();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            //FRM_DB_CON fRM_DB_CON = new FRM_DB_CON();
            //fRM_DB_CON.ShowDialog();
            //public static string FUllConnection = @"Data Source=.;AttachDbFileName=|DataDirectory|\DBWarehouse\Warehouse.mdf;Initial Catalog=Warehouse;Integrated Security=True;";
            ConnectDBFirst connectDBFirst = new ConnectDBFirst();
            connectDBFirst.ShowDialog();

        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            LoginInfo.Login(txtUsername.Text, txtPassword.Text);
            WarehouseAPPM.Properties.Settings.Default.Reload();
            WarehouseAPPM.Properties. Settings.Default.USERNameLOGIN = txtUsername.Text;

            Properties.Settings.Default.Save();
            //WarehouseAPPM.Properties.Settings.Default.Reload();
            WarehouseAPPM.Properties.Settings.Default.Upgrade();

            DataTable dataTable = new DataTable();


            dataTable = _Executequerysearch.executequerysearch("GETRolebaseUSerID",

       CommandType.StoredProcedure, new _Parameter("@User_ID", SqlDbType.Int, Login_.Userid));//GET IDUSER 0 why ???

            if (dataTable.Rows.Count >0)
            {
VarS.RoleId = Convert.ToInt32(dataTable.Rows[0]["ROLES_ID"].ToString());
            Login_.StartWork =Convert.ToDateTime( DateTime.Now.ToLongTimeString().ToString());
            FRM_MAin main = new FRM_MAin();
            this.Hide();
 
            main.Show();
            }
            else
            {
                MessageBox.Show("ليس لديك صلاحيه ","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
             
        }
      
        private void textBox2_Enter(object sender, EventArgs e)
        {
            //BTNLOGIN.Focus();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BTNLOGIN_Click(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtPassword.Focus();
        }

        private void FRM_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void FRM_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            this.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = WarehouseAPPM.Properties.Settings.Default.USERNameLOGIN;
            lblProductID.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblProductID.Text);
            LicenseInfo lic = new LicenseInfo();

            int value = km.LoadSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            //Check valid
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                //Decrypt license key
                if (km.DisassembleKey(productKey, ref kv))
                {
                    //lblProductName.Text = "FoxLearn";
                    //lblProductKey.Text = productKey;
                    lblLicenseType.Text = "Full";
                    //this.Hide();

                    //FRMLogin fRMLogin = new FRMLogin();
                    //fRMLogin.Show();
                    if (kv.Type == LicenseType.TRIAL)
                        lblLicenseType.Text = string.Format("{0} days", (kv.Expiration - DateTime.Now.Date).Days);
                    if (lblLicenseType.Text.Contains("-")){
                        MessageBox.Show("عفوا انتهاء صلاحيه الرخصه","ترخيص",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        FrmRegistration frmRegistration = new FrmRegistration();

                        frmRegistration.ShowDialog();
                        this.Close();
                    }
                    else
                        this.Hide();

                    //fRMLogin.ShowDialog();

                    //lblLicenseType.Text = "Full";

                }
            }
            else
            {
                FrmRegistration frmRegistration = new FrmRegistration();

                frmRegistration.ShowDialog();
            }
            //if (WarehouseAPPM.Properties .Settings.Default.userName != string.Empty)
            //{
            //    //txtUsername.Text = Properties.Settings.Default.userName;

            //    WarehouseAPPM.Properties.Settings.Default.userName = txtUsername.Text;


            //}
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BTNLOGIN_Click(sender, e);

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BTNLOGIN_Click(this, new EventArgs());
            }
        }
    }
}
