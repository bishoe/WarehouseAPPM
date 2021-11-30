using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class comboboxtest : Form
    {
        public comboboxtest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString =
                    "Data Source=.;Initial Catalog=Warehouse;Integrated Security=True";
                conn.Open();
                using (var cmd = new SqlCommand("SELECT CName FROM WarehouseCustomers", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Convert.ToString(reader["cName"]));
                        }
                    }
                }
            }
            ListU.DataSource = new BindingSource(list, null);
         }

        private void sss_Load(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(ListU, "_WarehouseSelectAll_Customers", "CName", "CustomersID");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection())
            {
                conn.ConnectionString =
                    "Data Source=.;Initial Catalog=Warehouse;Integrated Security=True";
                conn.Open();
                using (var cmd = new SqlCommand("SELECT * FROM WarehouseCustomers", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           ListU.SelectedText= Convert.ToString((reader["cName"]));
                            ListU.SelectedValue = Convert.ToInt32((reader["CustomersID"]));
                        
                    }
                }           }
                }           
        }

        private void ListU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListU_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(ListU.SelectedValue.ToString());

        }
    }
}

