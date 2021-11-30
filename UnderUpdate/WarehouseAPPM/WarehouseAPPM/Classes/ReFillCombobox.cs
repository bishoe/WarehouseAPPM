using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Classes
{
    class ReFillCombobox
    {
        public  static void REfillCMBSearch(ComboBox cmb,string SPName,string ParamName,string fieldName) {
            var list = new List<string>();
            using (SqlConnection con= new SqlConnection(DBConnect.FUllConnection))
            {

                con.Open();
                
                using (SqlCommand cmd = new SqlCommand(SPName, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.CommandText = SPName;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Convert.ToString(reader[fieldName]));
                        }
                    }
                }
                con.Close();
            }
            cmb.DataSource = new BindingSource(list, null);


        }
    }
}
