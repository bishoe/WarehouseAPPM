using System;
using System.Data;
using System.Windows.Forms;
using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Qutaly_Units : MetroFramework.Forms.MetroForm
    {
        public FRM_Qutaly_Units()
        {
            InitializeComponent();
        }

        private void Qutaly_Units_Load(object sender, EventArgs e)
        {

        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            _CheckTxt.CheckTxt(this, PanelSub);
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
                    _ExecuteNonquery.executeNonquery("_Warehouse_OutLayUnites",
            new _Parameter("@QName", SqlDbType.NVarChar, TXTQ.Text)
        
             );
                }
            }
            _TxtClear.TxtClear(this, PanelSub);
            BtnSave.Enabled = false;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery("_Warehouse_UpdateOutLayUnites",

 new _Parameter("@OutLayUnID", SqlDbType.Int, int.Parse(CMBUnits.SelectedValue.ToString())),

            new _Parameter("@QName", SqlDbType.NVarChar, TXTQ.Text));
        }

        private void CMBUnits_Click(object sender, EventArgs e)
        {
            

        _FillComboboxNoParam.FillComboboxNoParams(CMBUnits, "_Warehouse_Select_AllOutLayUnites", "QName", "OutLayID");
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelSub);



            BtnSave.Enabled = true;

        }

        private void TXTQ_TextChanged(object sender, EventArgs e)
        {
            //_Textaccept_alphabetic._Textaccept(TXTQ);
        }

        private void TXTQ_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("Warehouse_OutLayUnites", "QName", "@QName", TXTQ.Text);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TXTQ.Text = string.Empty;
            if (CMBUnits.Text != "")
            {
                DataTable dt = new DataTable();
                CMBUnits.Text = "";

                dt = _Executequerysearch.executequerysearch("_Warehouse_Select_AllOutLayUnitesBYID", CommandType.StoredProcedure, new _Parameter("@OutLayID", SqlDbType.Int, CMBUnits.SelectedValue.ToString()));


                 if (dt.Rows.Count > 0)
                {
                TXTQ.Text = dt.Rows[0]["QName"].ToString();

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                    return;
                }


            }
        }
        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (TXTQ.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery
("_Warehouse_delOutLayUnites",
              new _Parameter("@OutLayUnID", SqlDbType.Int, int.Parse(CMBUnits.SelectedValue.ToString()))

              );

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
