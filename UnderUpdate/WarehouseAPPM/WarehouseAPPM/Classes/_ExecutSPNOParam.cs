using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAPPM.Classes
{
    public class _ExecutSPNOParam
    {

        /// <summary>
        /// Return data from database using sp one way(no params)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static DataTable _ExecutSP(string text)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = text;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dt = new DataSet())
                        {



                            da.Fill(dt); con.Close();

                            return dt.Tables[0];
                        }
                    }
                }
            }
            }
        }
    }

