using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseAPPM.ds;

namespace WarehouseAPPM.Classes
{
   static class GETREportWithMultipleParam
    {
        public static DataSet1 GetDataWithMultiParam( string SP,string TableAdpater,params _Parameter[] paramarr)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {
             

                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.CommandText = SP;

                    
                    foreach (_Parameter prm in paramarr)
                    {
                        cmd.Parameters.Add(prm.pname, prm.pdtype).Value = prm.pvalue;

                    }
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {

                        sda.SelectCommand = cmd;

                        DataSet1 dsCustomers = new DataSet1();
                        sda.Fill(dsCustomers, TableAdpater);

                    
                        return dsCustomers;
                    }

                }
            }
        }
    }
}
