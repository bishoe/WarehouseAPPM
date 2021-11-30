using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
  static  class _CheckExIsts
    {
      public  static bool Returnresult;
 public  static void Check_exists(
     string spname,
    string rowName ,
     string paramname,
     string paramvalue)
        {
            #region MyRegion
             using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
                Returnresult = false;
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM "+ spname+" WHERE ("+ rowName + " = "  +paramname+")", con);
                con.Open();
                check_User_Name.Parameters.AddWithValue(paramname, paramvalue);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    MessageBox.Show("عفوا هذا السجل مسجل مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Returnresult = true;
                    return;
                }
                //else
                //{
                //    MessageBox.Show("qqqqqqqqq", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //}
                     
 }
 #endregion
 }
 }
 }
 