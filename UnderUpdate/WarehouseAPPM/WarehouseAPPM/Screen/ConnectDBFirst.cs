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
    public partial class ConnectDBFirst : MetroFramework.Forms.MetroForm
    {
        public ConnectDBFirst()
        {
            InitializeComponent();
        }
        public static void Login(string User_Name_, string Password_)
        {

            //DBConnect.CloseConnection();

            using (SqlConnection con = new SqlConnection(DBConnectFirst.FUllConnection))
            {
                //int ResultQuery;//Get Result From ExecuteNonQuery   (return 0 or 1)

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    //cmd.CommandType = CommandType.StoredProcedure;


                    con.Open();
                    cmd.Parameters.Clear();

                    cmd.CommandText = "SELECT * FROM TBUSERS where USER_NAME=@USER_NAME";
                    SqlParameter[] p = new SqlParameter[2];

                    p[0] = new SqlParameter("@USER_NAME", User_Name_);
                    p[1] = new SqlParameter("@USER_PASSWORD", Password_);

                    cmd.Parameters.AddRange(p);
                    //DBConnect.OpenConnection();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.Read())
                    {

                    }
                    else
                    {
                        MessageBox.Show("تم تركيب قاعدة البانات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
            }
        }

                      
 

                   
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void ConnectDBFirst_Load(object sender, EventArgs e)
        {

        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            Login(metroTextBox1.Text, metroTextBox2.Text);
            this.Close();
        }
    }
}
