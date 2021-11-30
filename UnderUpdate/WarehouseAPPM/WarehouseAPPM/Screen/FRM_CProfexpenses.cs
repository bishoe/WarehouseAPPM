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
    public partial class CProfexpenses : MetroFramework.Forms.MetroForm
    {
        public CProfexpenses()
        {
            InitializeComponent();
        }
        int VQutaly;
        int VEmployee;
        int VStore;
        int VSelling;
        int VARTotalSUM;
        int VarTotalCalc;
        private void CProfexpenses_Load(object sender, EventArgs e)
        {

        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("Warehouse_CalcGainlossQutaly", CommandType.StoredProcedure, new _Parameter("@StartDate", SqlDbType.Date, dteStart.Value),
           new _Parameter("@EndDate", SqlDbType.Date, dteEnd.Value)
            );
            if (dataTable.Rows.Count >0)
            {
            TxtQutaly.Text = dataTable.Rows[0]["TotalQutaly"].ToString();
            VQutaly = Convert.ToInt32(dataTable.Rows[0]["TotalQutaly"]);

            }
            else
            {
                MessageBox.Show("عفوا لايوجد نتيجه");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("Warehouse_CalcGainlossEmployee", CommandType.StoredProcedure, new _Parameter("@StartDate", SqlDbType.Date, dteStart.Value),
           new _Parameter("@EndDate", SqlDbType.Date, dteEnd.Value)
            );
            if (dataTable.Rows.Count > 0)
            {
            TxtEmployee.Text = dataTable.Rows[0]["TotalSalary"].ToString();

            VEmployee = Convert.ToInt32(dataTable.Rows[0]["TotalSalary"]);

            }
            else
            {
                MessageBox.Show("عفوا لايوجد نتيجه");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            using (DataSet dataSet = new DataSet())
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("Warehouse_CalcGainlossStore", CommandType.StoredProcedure, new _Parameter("@StartDate", SqlDbType.Date, dteStart.Value),
                  new _Parameter("@EndDate", SqlDbType.Date, dteEnd.Value)
                   );


                if (dt.Rows.Count > 0)
                {
                TxtStore.Text = dt.Rows[0]["TotalStore"].ToString();

                VStore = Convert.ToInt32(dt.Rows[0]["TotalStore"]);

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            using (DataSet dataSet = new DataSet())
            {
                DataTable dt = new DataTable();
                dt = _Executequerysearch.executequerysearch("Warehouse_CalcGainloss", CommandType.StoredProcedure, new _Parameter("@StartDate", SqlDbType.Date, dteStart.Value),
         new _Parameter("@EndDate", SqlDbType.Date, dteEnd.Value)
          );
                if (dt.Rows.Count > 0)
                {
                TxtSelling.Text = dt.Rows[0]["TotalPriceBill"].ToString();
                VSelling = Convert.ToInt32(dt.Rows[0]["TotalPriceBill"]);
                dt.Clear();
                dt.Dispose();

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                }

                //VSelling = int.Parse(TxtSelling.Text);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            VARTotalSUM = VQutaly + VEmployee + VStore;
            VarTotalCalc = VSelling - VARTotalSUM;
            textBox4.Text = Convert.ToString(VarTotalCalc);
        }
    }
}