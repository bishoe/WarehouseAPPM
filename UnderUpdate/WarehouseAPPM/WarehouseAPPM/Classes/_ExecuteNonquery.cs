using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using WarehouseAPPM.Classes;
namespace WarehouseAPPM.Classes
{
    class _ExecuteNonquery
    {
        public static void executeNonquery(string text, params _Parameter[] paramarr)
        {

            try
            {




                using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
                {
                    int ResultQuery=0;//Get Result From ExecuteNonQuery   (return 0 or 1)

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = text;
   if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        foreach (_Parameter prm in paramarr)
                        {
                            cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;

                        }


                        ResultQuery  =1+
                            cmd.ExecuteNonQuery();

                    }
                    if (ResultQuery > 0)
                    {
                        MessageBox.Show("العملية تمت بنجاح", "نجاح العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GC.Collect();
                    }

                    else
                    {
                        MessageBox.Show("لم تتم عمليه الحفظ");

                        con.Close();
                        GC.Collect();

                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());



            }
        }
    }
}
        
    
