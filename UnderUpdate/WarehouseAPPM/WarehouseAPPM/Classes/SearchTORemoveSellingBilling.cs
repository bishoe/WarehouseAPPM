using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;
//using MetroFramework.Controls.MetroRadioButton;
using MetroFramework.Controls;
namespace WarehouseAPPM.Classes
{
  public  class SearchTORemoveSellingBilling
    {
          DeleteSellingBilling deleteSellingBilling = new DeleteSellingBilling();
        public void SearchToRemoveSellinGprice(DataGridView dataGridView,string txtsearch,MetroRadioButton RBbILLnO, MetroRadioButton RBName,ComboBox comboBox)
        {
             

            DataTable dataTable = new DataTable();
            if (RBbILLnO.Checked == true)
            {
               


                 if (txtsearch == string.Empty)
                {
                    MessageBox.Show("يجب ادخال رقم الفاتورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    dataTable = _Executequerysearch.executequerysearch("_Warehouse_Selectbill_ByID_Selling", CommandType.StoredProcedure,
    new _Parameter("@BILLId", SqlDbType.Int, int.Parse(txtsearch)));

                    dataGridView.DataSource = dataTable;

                    deleteSellingBilling.IDBilldel = int.Parse(dataGridView.Rows[0].Cells[0].Value.ToString());

                    dataGridView.Visible = true;
                    //DBConnect.dt.Clear();
                    //DBConnect.dt.Dispose();

                }
            }
            else if (RBName.Checked == true)
            {
                if (comboBox.SelectedValue == null)
                {
                    return;
                }
                else
                {

                    //DataTable dt = new DataTable();
                    dataTable = _Executequerysearch.executequerysearch("_Warehouse_Selectbill_ByName_Selling", CommandType.StoredProcedure,
                         new _Parameter("@CustomerID", SqlDbType.Int, int.Parse(comboBox.SelectedValue.ToString())));
                    dataGridView.Visible = true;
                    //Int32.Parse(dt.Rows[0]["SQTTOML"].ToString());

                    dataGridView.DataSource = dataTable;

                    deleteSellingBilling.IDBilldel =
                 int.Parse(dataGridView.Rows[0].Cells[0].Value.ToString());
                    //DBConnect.dt.Clear();
                    //DBConnect.dt.Dispose();

                }
            }
            else
            {
                MessageBox.Show("يجب اختيار طريقة البحث اولا");
                dataGridView.Visible = false;

                return;
            }}
         
        
    }
}
