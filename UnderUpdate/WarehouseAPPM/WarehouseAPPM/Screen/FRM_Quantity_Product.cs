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
    public partial class FRM_Quantity_Product : MetroFramework.Forms.MetroForm
    {
        public FRM_Quantity_Product()
        {
            InitializeComponent();
        }

        private void Quantity_Product_Load(object sender, EventArgs e)
        {
         


        }

        private void CMBPRODUCT_Leave(object sender, EventArgs e)
        {


            //_AutoFillCMBWithPARAm.Bindcmb(cmbSupplyRep, "_WarehouseSelectALL_SupplyRepresentativeByID", "@SupplyRepID", Convert.ToInt32(cmbSuppliers.SelectedValue.ToString()), "SRName", "SupplyRepID"



        }

        private void CMBCat_Leave(object sender, EventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(CMBPRODUCT, "_Warehouse_SelectProducts",
              "@IdCategoryProduct", Convert.ToInt32(CMBCat.SelectedValue.ToString()), "Pname", "ProdouctsID");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBPRODUCT.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityProduct",
   CommandType.StoredProcedure
,new _Parameter("@IdCategoryProduct", SqlDbType.Int, CMBCat.SelectedValue.ToString()),
new _Parameter("@ProdouctsID", SqlDbType.Int, CMBPRODUCT.SelectedValue.ToString()));
                //lblIDCustomer.Text = dt.Rows[0]["CustomersID"].ToString();
                if (dt.Rows.Count > 0) { 
                TXTName.Text = dt.Rows[0]["QuantityProduct"].ToString();
                }
                else
                {
                    MessageBox.Show("عفوا لايوجد كميات لهذا المنتج","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PanelSub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMBCat_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBCat, "_WarehouseSelectAll_CategoryProduct", "CategoryName", "IdCategoryProduct");
        }
    }
}