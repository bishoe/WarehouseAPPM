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
    public partial class FRM_Qutaly : MetroFramework.Forms.MetroForm
    {
        public FRM_Qutaly()
        {
            InitializeComponent();
        }

        private void Qutaly_Load(object sender, EventArgs e)
        {
            CMBUnits.Items.Clear();
            //CMBUnits.DataSource = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            _CheckTxt.CheckTxt(this, PanelMain);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {




                _ExecuteNonquery.executeNonquery("_Warehouse_Qutaly", new _Parameter("@OutLayUnID", SqlDbType.Int, int.Parse(CMBUnits.SelectedValue.ToString()))
            ,
            new _Parameter("@Amount", SqlDbType.Decimal, Convert.ToDecimal(TXTAMount.Text))
            ,

            new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
            new _Parameter("@Notes", SqlDbType.NVarChar, TXTNotes.Text),
           new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
            }
            _TxtClear.TxtClear(this, PanelMain);
            BtnSave.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBSearch.Text != "")
            {
                DataTable dt = new DataTable();
                dt = _Executequerysearch.executequerysearch("_Warehouse_Qutaly_Selectbyid", CommandType.StoredProcedure, new _Parameter("@QutalyID", SqlDbType.Int, Convert.ToInt32(CMBSearch.SelectedValue.ToString())));

                if (dt.Rows.Count > 0)
                {
                    TXTAMount.Text = dt.Rows[0]["Amount"].ToString();
                    TXTNotes.Text = dt.Rows[0]["Notes"].ToString();

                }
                else
                {
                    MessageBox.Show("عفوا لايوجد نتيجه");
                    return;
                }
            }
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);



            BtnSave.Enabled = true;
        }

        private void TXTAMount_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTAMount);
                }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMBUnits_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBUnits, "_Warehouse_Select_AllOutLayUnites", "QName", "OutLayID");

        }
        
        private void metroButton3_Click(object sender, EventArgs e)
        {

            if (CMBUnits.Text == string.Empty)
            {

                return;
            }
            else
            {

                _ExecuteNonquery.executeNonquery
                ("_Warehouse_QutalyUpdate",
                new _Parameter("@QutalyID", SqlDbType.Int, int.Parse(CMBSearch.SelectedValue.ToString())),
                
                   new _Parameter("@OutLayUnID", SqlDbType.Int, Convert.ToInt32(CMBUnits.SelectedValue.ToString()))
               , new _Parameter("@Amount", SqlDbType.Decimal, Convert.ToDecimal(TXTAMount.Text))
               ,
               new _Parameter("@Notes", SqlDbType.NVarChar, TXTNotes.Text)
 );
                //new _Parameter("@Userid", SqlDbType.Int, LoginInfo.Userid));
            }
        }

        private void CMBSearch_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBSearch, "_WarehouseSelectAllQutaly", "QName", "QutalyID");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
