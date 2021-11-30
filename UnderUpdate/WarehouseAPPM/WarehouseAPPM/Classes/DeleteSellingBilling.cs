using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Classes
{

     class DeleteSellingBilling
    {
        public int IDBilldel;
    private int GetCurrentQuntity_Product;//Get All QT   from StoreTables
    int TotalQuntity_ProductRemove;
        public void DelSelling_Bill(DataGridView dataGridView,int ccOunt)
        {

            for (int i = 0; i < ccOunt - 1; i++)
            {
                DataTable dt = new DataTable();

                GetCurrentQuntity_Product = 0;  //Get All QT Ml from StoreTables

                TotalQuntity_ProductRemove = 0;

                dt = _Executequerysearch.executequerysearch("_Warehouse_Store_Select_Quntity_Product", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, Int32.Parse(dataGridView.Rows[i].Cells[9].Value.ToString())));

                GetCurrentQuntity_Product = Int32.Parse(dt.Rows[0]["Quntity_Product"].ToString());

                if (GetCurrentQuntity_Product != 0)
                {
                    TotalQuntity_ProductRemove = GetCurrentQuntity_Product + int.Parse(dataGridView.Rows[i].Cells[4].Value.ToString());

                }
                //Selling_MasterID
                _ExecuteNonquery.executeNonquery("_WarehosueDel_SellingBill",
             new _Parameter("@Selling_MasterID", SqlDbType.Int, IDBilldel),
             new _Parameter("@CurrentQuntity_Product", SqlDbType.Int, TotalQuntity_ProductRemove),


new _Parameter("@ProdouctsID", SqlDbType.Int, Int32.Parse(dataGridView.Rows[i].Cells[9].Value.ToString())),
//Wait  bill no  row from search grid
new _Parameter("@Billno", SqlDbType.Int, Int32.Parse(dataGridView.Rows[i].Cells[7].Value.ToString()))

                          );
                  dt.Clear();
                dt.Dispose();

                GetCurrentQuntity_Product=0;  //Get All QT Ml from StoreTables

                TotalQuntity_ProductRemove = 0;

            }

         

        }
    }
}
