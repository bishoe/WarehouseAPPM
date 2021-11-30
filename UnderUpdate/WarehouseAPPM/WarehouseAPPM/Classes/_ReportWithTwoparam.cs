using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WarehouseAPPM.ds;
//using WarehouseAPPM.dataSet;

namespace WarehouseAPPM.Classes
{
    class _ReportWithTwoparam
    {
        public static DataSet1 FunReportWithtwoparam(string SpName, string ParamName, DateTimePicker dateTimePicker, string ParamNamese, ComboBox comboBox, string DataTableName)
        {

            using (SqlConnection con = new SqlConnection(DBConnect.FUllConnection))
            {

                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.CommandText = SpName;

                    using (SqlDataAdapter DataAdapter = new SqlDataAdapter())
                    {

                        cmd.Parameters.Clear();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue(ParamName, Convert.ToDateTime(dateTimePicker.Value.ToString()));
                        cmd.Parameters.AddWithValue(ParamNamese, Convert.ToInt32(comboBox.SelectedValue.ToString()));



                        DataAdapter.SelectCommand = cmd;
                        using (DataSet1 DataSet = new DataSet1())
                        {
                            //nameDATATABLE in dataset
                            DataAdapter.Fill(DataSet, DataTableName);
                            return DataSet;
                        }
                    }
                }
            }
        }
    }
}