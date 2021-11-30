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
    static class _AutoCompleTextBox
    {
        public static void  _AutoCompleTextBox_(  string SP, string ParamName, object ParamValue,MetroFramework.Controls.MetroTextBox textBox)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            getData(DataCollection, SP,ParamName, ParamValue);
            textBox.AutoCompleteCustomSource = DataCollection;
        }


        static void getData(AutoCompleteStringCollection dataCollection, string SP, string ParamName, object ParamValue )
        {
    
            using (SqlConnection connection = new SqlConnection(DBConnect.FUllConnection)
)
            {


                using (SqlCommand command = new SqlCommand())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = SP;
                    command.Parameters.AddWithValue(ParamName, ParamValue);
                    try
                    {
                        connection.Open();
                        command.Connection = connection;
                        //command = new SqlCommand(sql, connection);
                        adapter.SelectCommand = command;
                        adapter.Fill(ds);
                        adapter.Dispose();
                        command.Dispose();
                        connection.Close();
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            dataCollection.Add(row[0].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message+"Can not open connection ! ");
                    }
                }
            }
        }
    }
}