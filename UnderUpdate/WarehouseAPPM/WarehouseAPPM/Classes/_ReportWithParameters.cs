using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.ds;
//using WarehouseAPPM.dataSet;
//using WarehouseAPPM.ds;

namespace WarehouseAPPM.Classes
{
    class _ReportWithParameters
    {
        public static DataSet1 FunReport(string SpName, string ParamName, ComboBox comboBox, string DataTableName)
        {
            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = SpName;

                    using (SqlDataAdapter DataAdapter = new SqlDataAdapter()  )
                    {

                   
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(ParamName, int.Parse(comboBox.SelectedValue.ToString()));

                    DataAdapter.SelectCommand = cmd;
                    using (DataSet1 DataSet1 = new DataSet1())
                    {
                        //nameDATATABLE in dataset
                        DataAdapter.Fill(DataSet1, DataTableName);
                        return DataSet1;
                    }
                }
                }
            }
        }
    }
}