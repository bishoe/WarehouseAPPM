 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseAPPM.Classes;
using In.Sontx.SimpleDataGridViewPaging;

namespace WarehouseAPPM.Classes
{
    public class _SearchAll_Invoice
    {
    public  static  void GETALLInVoice_( DataGridViewPaging dataGridViewPaging,string text, System.Data.CommandType com, params _Parameter[] paramarr) {

            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

                con.Close();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = com;
                    cmd.CommandText = text;
                    con.Open();
                    foreach (_Parameter prm in paramarr)
                    {
                        cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;

                    }
                    //= command.ExecuteReader();
                    //reader.Close();
                    
                   
                    SqlDataReader reader;
                    
                     
                     reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dataGridViewPaging.DataSource = reader;
                        reader.Close();
                        DBConnect.CloseConnection();
                    //con.Close();
                }
                }
            }
    }
    }
}
