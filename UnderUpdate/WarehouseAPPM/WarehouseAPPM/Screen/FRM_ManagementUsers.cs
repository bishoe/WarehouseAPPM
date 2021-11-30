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
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_ManagementUsers : MetroFramework.Forms.MetroForm
    {
        public FRM_ManagementUsers()
        {
            InitializeComponent();
        }

        private void ManagementUsers_Load(object sender, EventArgs e)
        {
          
            Bindcmb(CMBFormsNAme, "SelectScreen", "SCREEN_NAME", "SCREEN_ID");
        }
        public static void Bindcmb(ComboBox comboBox, String sp, String displayMember, String valueMember)
        {
            comboBox.DataSource = null;
            comboBox.ResetText(); comboBox.Text = "";
            //"_SelectAll_Customers"
            comboBox.DataSource = _ExecuteQuery(sp, CommandType.StoredProcedure);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            //comboBox.Text = comboBox.SelectedValue.ToString();
           
            comboBox.Refresh();
            //cmbcity.SelectedIndex = -1;


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
                    con.Dispose();

                    return dt.Tables[0];

                }

            }
        }

        private void CMBUsername_MouseClick(object sender, MouseEventArgs e)
        {
            Bindcmb(CMBUsername, "spGetBUSERSAll", "USER_NAME", "User_ID");

        }

        private void BTNADDPerm_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery("spInsertBCONTROLS",
          new _Parameter("@User_ID", SqlDbType.Int, CMBUsername.SelectedValue),
            new _Parameter("@ROLES_ID", SqlDbType.Int, CMBRolesName.SelectedValue)


          );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == string.Empty  ) return;

            _ExecuteNonquery.executeNonquery("InsertRoles",
              new _Parameter("@ROLES_NAME", SqlDbType.NVarChar, textBox5.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TXTADDUSERName.Text == string.Empty || TXTADDUSERPAssword.Text == string.Empty) return;

            string Password = Cryptography.Encrypt(TXTADDUSERPAssword.Text);
            _ExecuteNonquery.executeNonquery("InsertUSers",
              new _Parameter("@USER_NAME", SqlDbType.NVarChar, TXTADDUSERName.Text)
            ,
              new _Parameter("@USER_PASSWORD", SqlDbType.NVarChar, Password));
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginInfo.Login(textBox1.Text, textBox2.Text);
            DataTable dataTable = new DataTable();


            dataTable = _Executequerysearch.executequerysearch("GETRolebaseUSerID",

       CommandType.StoredProcedure, new _Parameter("@User_ID", SqlDbType.Int, Login_.Userid));//GET IDUSER 0 why ???

            VarS.RoleId = Convert.ToInt32(dataTable.Rows[0]["ROLES_ID"].ToString());
            if (VarS.RoleId == 1)
            {
                PNLINSERTUSER.Visible = true;
                PNLINSERTROLES.Visible = true;
                PNLINSERTPer.Visible = true;
                PNLUPDATEPassword.Visible = true;
            }
           
            //MAin main = new MAin();
            //this.Hide();

            //main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //UpdateUSersPassword

            if (TXTADDUSERName.Text == string.Empty || TXTADDUSERPAssword.Text == string.Empty) return;
            if(txtChangepassword.Text == txtChangepasswordConfirm.Text)
            {
                string Password = Cryptography.Encrypt(txtChangepasswordConfirm.Text.ToString());
                _ExecuteNonquery.executeNonquery("UpdateUSersPassword",
                  new _Parameter("@User_ID", SqlDbType.Int, Convert.ToInt32(CMBUPDATEPassword.SelectedValue.ToString()))
                ,
                  new _Parameter("@USER_PASSWORD", SqlDbType.NVarChar, Password));
            }
          

        }

        private void CMBRolesName_Click(object sender, EventArgs e)
        {
            Bindcmb(CMBRolesName, "spGetBROLESAll", "ROLES_NAME", "ROLES_ID");
        }

        private void CMBUPDATEPassword_MouseClick(object sender, MouseEventArgs e)
        {
            Bindcmb(CMBUPDATEPassword, "spGetBUSERSAll", "USER_NAME", "User_ID");

        }
    }
}
