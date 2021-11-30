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
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Barcode : MetroFramework.Forms.MetroForm
    {
        public FRM_Barcode()
        {
            InitializeComponent();
        }

        private void Barcode_Load(object sender, EventArgs e)
        {
            _AutoCompleTextBox._AutoCompleTextBox_("_Warehosue_Select_ProductBYBarcodePrint", "@Pname", TXTBarCode.Text, TXTBarCode);
            _FillComboboxNoParam.FillComboboxNoParams(CMBCATEGORY, "_WarehouseSelectAll_CategoryProduct", "CategoryName", "IdCategoryProduct");

        }

        private void CMBCATEGORY_Leave(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(CMBPRODUCT, "_Warehouse_SelectProducts", "@IdCategoryProduct", Convert.ToInt32(CMBCATEGORY.SelectedValue.ToString()), "Pname", "ProdouctsID");

        }
        
        private void metroButton7_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery("Watehouse_Insert_BarCode",

 new _Parameter("@BarcodeCategory_Product", SqlDbType.Int, Convert.ToUInt32(CMBCATEGORY.SelectedValue.ToString())),
 new _Parameter("@BarCodeProduct", SqlDbType.Int, Convert.ToUInt32(CMBPRODUCT.SelectedValue.ToString())),
        

          new _Parameter("@BarCodeDate", SqlDbType.Date, DTP.Value)
          ,
                      new _Parameter("@BarCodeText", SqlDbType.Int, TXTBarCode.Text)   );
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery("Watehouse_Update_BarCode",
       new _Parameter("@BarCodeID", SqlDbType.Int, int.Parse(CMBBarcode.SelectedValue.ToString())),

 new _Parameter("@BarcodeCategory_Product", SqlDbType.Int, Convert.ToUInt32(CMBCATEGORY.SelectedValue.ToString())),
 new _Parameter("@BarCodeProduct", SqlDbType.Int, Convert.ToUInt32(CMBPRODUCT.SelectedValue.ToString())),
     new _Parameter("@BarCodeDate", SqlDbType.Date, DTP.Value) ,
 new _Parameter("@BarCodeText", SqlDbType.Int, TXTBarCode.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBBarcode.Text != "")
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("Watehouse_Select_ALL_BYID_BarCode", CommandType.StoredProcedure, new _Parameter("@BarCodeID", SqlDbType.Int, Convert.ToInt32(CMBBarcode.SelectedValue.ToString())));
                //Suppliers suppliers = new Suppliers();

                CMBCATEGORY.Text = dt.Rows[0]["BarcodeCategory_Product"].ToString();
                CMBPRODUCT.Text = dt.Rows[0]["BarCodeProduct"].ToString();
                TXTBarCode.Text = dt.Rows[0]["BarCodeText"].ToString();
                DTP.Value = Convert.ToDateTime(dt.Rows[0]["BarCodeDate"].ToString());
                CMBBarcode.SelectedItem = null;

            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CMBBarcode_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBBarcode, "Watehouse_Select_ALL_BarCode", "BarCodeText", "BarCodeID");

        }
    }
}
