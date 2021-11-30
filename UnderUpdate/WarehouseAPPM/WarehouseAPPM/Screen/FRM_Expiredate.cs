using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Expiredate : MetroFramework.Forms.MetroForm
    {
        public FRM_Expiredate()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
    }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void DataGridViewWithPaging1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("يرجى الضغط على اى زر للبدء بعرض البيانات","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
              DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("_warehouse_ProductExpireDate", CommandType.StoredProcedure, new _Parameter("@Wdate", SqlDbType.DateTime,Convert.ToDateTime(  DateTime.Now.ToString()) ));


            dataGridViewWithPaging1.DataSource = dataTable;
            dataGridViewWithPaging1.Refresh();
        }

        private void BtnGO_Click(object sender, EventArgs e)
        {
     
         
        }

        private void FRM_Expiredate_Load(object sender, EventArgs e)
        {

        }

        private void txtDayes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDayes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            FRM_ExpiredateDays fRM_ExpiredateDays = new FRM_ExpiredateDays();
            fRM_ExpiredateDays.ShowDialog();

        }
    }
}
