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
    public partial class FRM_SubUnits : MetroFramework.Forms.MetroForm
    {
        public FRM_SubUnits()
        {
            InitializeComponent();
        }

        private void SubUnits_Load(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBMainUnits, "_Warehouse_Select_MainUnites", "UName", "UnitesNId");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            

                   _ExecuteNonquery.executeNonquery("_Warehouse_Insert_SubUnits",
           
   new _Parameter("@UnitesNId", SqlDbType.Int, Convert.ToUInt32(CMBMainUnits.SelectedValue.ToString())),
                       new _Parameter("@UnitsSubName", SqlDbType.NVarChar, TXTName.Text)
          ,
                     
            new _Parameter("@WDate", SqlDbType.Date, DTP.Value)
            ,
                        new _Parameter("@UnitConvert", SqlDbType.Int, TXTUNITCONVERT.Text),


            new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)
            );

        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {

            if (CMBMainUnits.Text != "")
            {
                MessageBox.Show("يوجد خانه فارغه", "Err", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                _ExecuteNonquery.executeNonquery("_Warehouse_UPdate_SubUnits",

new _Parameter("@UnitesId", SqlDbType.Int, Convert.ToUInt32(CMBSubUnits.SelectedValue.ToString())),

new _Parameter("@UnitesNId", SqlDbType.Int, Convert.ToUInt32(CMBMainUnitsEdit.SelectedValue.ToString())),
                new _Parameter("@UnitsSubName", SqlDbType.Int, Convert.ToUInt32(TXTName.Text))
   ,

     new _Parameter("@WDate", SqlDbType.Date, DTP.Value)
     ,
                 new _Parameter("@UnitConvert", SqlDbType.Int, TXTUNITCONVERT.Text),


     new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)
     );

            }
        }

        private void CMBMainUnitsEdit_MouseLeave(object sender, EventArgs e)
        {


           

        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            //SubUnits_Load(sender, e); // call a button click event from another method

            

        }

        private void CMBMainUnitsEdit_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBMainUnitsEdit, "_Warehouse_Select_MainUnites", "UName", "UnitesNId");

        }

        private void CMBSubUnits_MouseClick(object sender, MouseEventArgs e)
        {
            _AutoFillCMBWithPARAm.Bindcmb(CMBSubUnits, "_Warehouse_Select_SubUnis_BYIDMainUnit", "@UnitesNId", Convert.ToInt32(CMBMainUnitsEdit.SelectedValue.ToString()),
               "UnitsSubName", "UnitesId");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBSubUnits.Text != "")
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_Warehouse_Select_SubUnis_BYID", CommandType.StoredProcedure, new _Parameter("@UnitesId", SqlDbType.Int, Convert.ToInt32(CMBSubUnits.SelectedValue.ToString())));
                //Suppliers suppliers = new Suppliers();

                TXTName.Text = dt.Rows[0]["UnitsSubName"].ToString();
                //DTP.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
                TXTUNITCONVERT.Text = dt.Rows[0]["UnitConvert"].ToString();
                //SubUnits_Load(sender, e);
                CMBMainUnits.Text = "";
                CMBMainUnits.SelectedItem = null;
               
  //////////CMBMainUnits.ResetText();
            }

        }
    }
}
