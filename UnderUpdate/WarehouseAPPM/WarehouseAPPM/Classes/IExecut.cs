using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseAPPM.Classes;
namespace WarehouseAPPM.Classes
{
    public class IExecut
    {
         public static SqlConnection con = new SqlConnection(DBConnect.FUllConnection);

        public virtual  DataTable Executequery(string text, CommandType com)
        {

            using ( SqlCommand cmd = new SqlCommand())
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
}
