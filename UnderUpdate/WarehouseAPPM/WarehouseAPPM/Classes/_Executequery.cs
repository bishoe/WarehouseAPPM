using System;
using System.Collections.Generic;
using System.Data;
//using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseAPPM.Classes;
namespace WarehouseAPPM.Classes
{
    public class _Executequery
    {
        /// <summary>
        ///
        /// public static SqlConnection con = new SqlConnection
        /// GET Connection from dbconnect(DBConnect.FUllConnection);
        /// _ExecuteQuery
        /// ExecuteQuery and return result 
        /// USe in search 
        /// </summary>
        //public static SqlConnection con = new SqlConnection(DBConnect.FUllConnection);

        public static  DataTable _ExecuteQuery(string text, CommandType com)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
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
                    GC.Collect();
                    con.Close();

                    return dt.Tables[0];

                }
            }   

        }


    }
}
