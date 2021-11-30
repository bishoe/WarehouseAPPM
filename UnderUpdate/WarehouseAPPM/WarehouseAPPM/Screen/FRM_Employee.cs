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
    public partial class FRM_Employee : MetroFramework.Forms.MetroForm
    {
        public FRM_Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            dt = _ExecutSPNOParam._ExecutSP("_Warehouse_SElectMAXEMPID");
            LBLEmpID.Text = Convert.ToString(dt.Rows[0]["EmployeeId"].ToString());
            if (LBLEmpID.Text == "")
            {
                
                _ExecuteNonquery.executeNonquery
("_WarehouseAddrowEmp");
                return;
            }
          
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            _CheckTxt.CheckTxt(this, PaneMain);
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
                    _ExecuteNonquery.executeNonquery
    ("_Warehouse_Employee",
                new _Parameter("@EName", SqlDbType.NVarChar, TXTName.Text)
              , new _Parameter("@Phone", SqlDbType.NVarChar, TXTPHONE.Text)
              , new _Parameter("@Salary", SqlDbType.Decimal, Convert.ToDecimal(TXTSalary.Text))
              ,
              new _Parameter("@Address", SqlDbType.NVarChar, TXTADDress.Text),
              new _Parameter("@WDate", SqlDbType.DateTime, DateTime.Now.ToString()),
              new _Parameter("SalaryDate", SqlDbType.DateTime, DTP.Value)
              ,
              new _Parameter("@Notes", SqlDbType.NVarChar, TXTNOTE.Text),
                new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
                } }
                _TxtClear.TxtClear(this, PaneMain);
                BtnSave.Enabled = false;
           
        }
        //}

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery
("_Warehouse_UpdateEmployee"
                ,
 new _Parameter("@EmployeeId", SqlDbType.Int, Convert.ToInt32(CMBEmployee.SelectedValue.ToString())),

             new _Parameter("@EName", SqlDbType.NVarChar, TXTName.Text)
              , new _Parameter("@Phone", SqlDbType.NVarChar, TXTPHONE.Text)
              , new _Parameter("@Salary", SqlDbType.Decimal, Convert.ToDecimal(TXTSalary.Text))
              ,
              new _Parameter("@Address", SqlDbType.NVarChar, TXTADDress.Text),
              new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value),
              new _Parameter("@Notes", SqlDbType.NVarChar, TXTNOTE.Text));
              
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            _ExecuteNonquery.executeNonquery
("_Warehouse_delEmployee",
              new _Parameter("@EmployeeId", SqlDbType.Int, int.Parse(CMBEmployee.SelectedValue.ToString()))

              );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CMBEmployee.Text != "")
            {
                DataTable dt = new DataTable();
                CMBEmployee.Text = "";
                dt = _Executequerysearch.executequerysearch("_WarehouseSelectAll_EmployeeById", CommandType.StoredProcedure, new _Parameter("@EmployeeId", SqlDbType.Int, Convert.ToInt32(CMBEmployee.SelectedValue.ToString())));

                TXTName.Text = dt.Rows[0]["EName"].ToString();
                TXTADDress.Text = dt.Rows[0]["Address"].ToString();
                TXTPHONE.Text = dt.Rows[0]["Phone"].ToString();
                TXTSalary.Text = dt.Rows[0]["Salary"].ToString();
                DTP.Value = Convert.ToDateTime(dt.Rows[0]["WDate"].ToString());

                TXTNOTE.Text = dt.Rows[0]["Notes"].ToString();

            }
        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PaneMain);
            BtnSave.Enabled = true;

        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {
            //_Textaccept_alphabetic._Textaccept(TXTName);
        }

        private void TXTPHONE_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTNOTE);
        }

        private void TXTSalary_TextChanged(object sender, EventArgs e)
        {
            _DecimalForTEXTbox.AcceptingDecimal(TXTSalary);

        }

        private void TXTName_Leave(object sender, EventArgs e)
        {
            _CheckExIsts.Check_exists("Warehouse_Employee", "EName", "@EName", TXTName.Text);

        }

        private void CMBEmployee_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBEmployee, "_WarehouseSelectAll_Employee", "EName", "EmployeeId");
        }
    }
}
