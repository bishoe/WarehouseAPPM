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
    public static class _Executequerysearch
    {
        public static object loopTo;
        public static DataTable executequerysearch(string text, CommandType com, params _Parameter[] paramarr)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandType = com;
                    cmd.CommandText = text;


                    foreach (_Parameter prm in paramarr)
                    {
                        cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;

                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataSet dt = new DataSet();
                    da.Fill(dt);
                      loopTo = dt.Tables[0].Rows.Count ;
                    con.Close();

                    return dt.Tables[0];

                }
            }
        }
    }
}
