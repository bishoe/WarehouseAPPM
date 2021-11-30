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
    public partial class FRM_MainUnits : MetroFramework.Forms.MetroForm
    {
        public FRM_MainUnits()
        {
            InitializeComponent();
        }
        
        private void MainUnits_Load(object sender, EventArgs e)
        {
           

        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery("_Warehouse_Update_MainUnites",
               new _Parameter("@UnitesNId", SqlDbType.Int, int.Parse(CMBMainUnits.SelectedValue.ToString())),
     new _Parameter("@UName ", SqlDbType.NVarChar, TXTNameUnit.Text)
  , new _Parameter("@WDate", SqlDbType.NVarChar, DTP.Value),
       new _Parameter("@UnitConvert ", SqlDbType.Int, TXTUnitConvert.Text)


  );


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBMainUnits.Text != "")
            {
                DataTable dt = new DataTable();

                dt = _Executequerysearch.executequerysearch("_Warehouse_SelectAll_UnitesNameById", CommandType.StoredProcedure, new _Parameter("@UnitesNId", SqlDbType.Int, Convert.ToInt32(CMBMainUnits.SelectedValue.ToString())));
                //Suppliers suppliers = new Suppliers();
                if (dt.Rows.Count > 0)
                {
                TXTNameUnit.Text = dt.Rows[0]["UName"].ToString();
                DTP.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());
TXTUnitConvert.Text = dt.Rows[0]["UnitConvert"].ToString();

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                    return;
                }

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            _CheckTxt.CheckTxt(this, MainPnl);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {
                if (_CheckExIsts.Returnresult == true)
                {
                    MessageBox.Show("عفوا هذا السجل مسجل مسبقا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {


                    _ExecuteNonquery.executeNonquery("_Warehouse_Insert_MainUnites",
            new _Parameter("@UName", SqlDbType.NVarChar, TXTNameUnit.Text)
          ,
            new _Parameter("@WDate", SqlDbType.Date, DTP.Value)
            ,
                        new _Parameter("@UnitConvert", SqlDbType.Int, TXTUnitConvert.Text),


            new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid)
            );
                }
            }
            _TxtClear.TxtClear(this, MainPnl);
            BtnSave.Enabled = false;

        }

        private void MainPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMBMainUnits_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBMainUnits, "_Warehouse_Select_MainUnites", "UName", "UnitesNId");
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, MainPnl);



            BtnSave.Enabled = true;
        }

        private void TXTUnitConvert_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTUnitConvert);
        }

        private void TXTNameUnit_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("Warehouse_MainUnites", "UName", "@UName", TXTNameUnit.Text);

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            
                  if (TXTNameUnit.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery
("_Warehouse_MainUnitesDelete",
              new _Parameter("@UnitesNId", SqlDbType.Int, int.Parse(CMBMainUnits.SelectedValue.ToString()))

              );

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
