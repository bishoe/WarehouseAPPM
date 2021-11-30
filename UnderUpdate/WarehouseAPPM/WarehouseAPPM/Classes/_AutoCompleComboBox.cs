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
    public class _AutoCompleComboBox : _ExecutSPNOParam
    {
        private void _AUtocomplete(ComboBox comboBox,string SP)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection combData = new AutoCompleteStringCollection();
            Executequery_(SP,combData);
            comboBox.AutoCompleteCustomSource = combData;
        }

  

        public  DataTable Executequery_(string SP, AutoCompleteStringCollection dataCollection)
        {

            using (SqlConnection con = new SqlConnection(DBConnect
                .FUllConnection))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Parameters.Clear();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SP;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {

                        using (DataSet ds = new DataSet())
                        {

                            da.Fill(ds);
                            foreach (DataRow row in ds.Tables[0].Rows)
                            {
                                dataCollection.Add(row[0].ToString());
                            }
                            return ds.Tables[0];

                        }


                    }
                }
            }

        } } }