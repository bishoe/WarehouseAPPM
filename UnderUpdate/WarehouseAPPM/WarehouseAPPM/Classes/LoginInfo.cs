using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM
{

    static class LoginInfo
    {
        ////////////public static int Userid = 1;
        //public static MainFrm MainFrm = new MainFrm();               
        public static bool CkLogin=false;//check Login If true GrbLogin.Visible=false;

        //public static object IDUserLOGIN = 0;
        #region LoginasAdmin
        public static void Login(string User_Name_, string Password_    )
        {

        //DBConnect.CloseConnection();

            //using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                //int ResultQuery;//Get Result From ExecuteNonQuery   (return 0 or 1)
              SqlConnection con = new SqlConnection(DBConnect.FUllConnection) ;

                using (SqlCommand cmd = new SqlCommand())
                {
                    bool IsExist = false;
                    string Password = "";
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    con.Open();
            cmd.Parameters.Clear();
             cmd.CommandText = "SELECT * FROM TBUSERS where USER_NAME=@USER_NAME";
            SqlParameter[] p = new SqlParameter[2];
            p[0] = new SqlParameter("@USER_NAME", User_Name_);
            p[1] = new SqlParameter("@USER_PASSWORD", Password_);
             cmd.Parameters.AddRange(p);
             SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Password = reader.GetString(2);  //get the user password from db if the user name is exist in that.  
Login_.Userid =Convert.ToInt32( reader.GetValue(0));//GET ID
     IsExist = true;
            }
            if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
            {
                if (Cryptography.Decrypt(Password).Equals(Password_))
                {
                           

                                 cmd.Dispose();
                    DBConnect.CloseConnection();
                     
                }
                else
                {
                    MessageBox.Show("الرقم السرى غير صحيح او الاسم", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.Dispose();
                            Application.ExitThread();
                            //Application.Exit();
                    DBConnect.CloseConnection();
                    //CkLogin = 2;

                    return;
                }
                    }
               
       
            else
            {
                 //Error err = new Error();
                //err.Show();
                //CloseConnection();
                return;
            }
        } }

            }
        #endregion LoginasAdmin
        

      
     



    }
}