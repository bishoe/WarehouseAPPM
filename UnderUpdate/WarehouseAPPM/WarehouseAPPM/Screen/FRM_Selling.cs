using CrystalDecisions.CrystalReports.Engine;
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
using WarehouseAPPM.ds;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_Selling : MetroFramework.Forms.MetroForm
    {
        public FRM_Selling()
        {
            InitializeComponent();
        }
        #region Vars
        public object AddColINGrid;//add data from textbox to  datagrid ;
        public int SUM;
        public int TotalFStore;//Get all Qt from store 
        //public int AQT;
        //  TotalSendToDB.Text //Quantity after discount
        public int ccOunt;//count row gridview
        //public int CHKPrdouct;
        //public int ConvertQTToMl; //size * qt = 1000Ml
        public int Counterdgv = 1; //counter in grid start from 1 next press ++1


        //TotalBDiscount = Convert.ToInt32(txtTotalBDiscount.Text);
        //    Discount = Convert.ToInt32(TXTDiscount.Text);

        //    AMountDicount = TotalBDiscount* Discount;
        //AMoDicotDivid = AMountDicount / 100;
        //AmountDiscount = 1pound 10pound etc....
        private decimal TotalBDiscount; //txtTotalBDiscount.Text TotalAmount Before Discount
        private decimal Discount;//Discount
        private decimal AMountDicount;//AMountAfterDicount
        private decimal AMoDicotDivid;//AMount eg => AMoDicotDivid = TotalBDiscount * Discount /100 
        private decimal ToAmAfDi; //Total Amount after Discount
        private decimal GetSellingPrice;//Add value from txt selling price to variable
        private decimal GetSellingQt;
        private decimal TotalAmountRow;
        //
        private decimal GetQuntity_Product;//=GetQuntity_Product 
        private decimal GetQuntityTextBox;//GetQuntityFromTextBox
        private decimal CalcQuntity;
        //
        private decimal GetUnitConvert_;//GetUnitConvert from db
        private decimal GETQTFROMTXTQT;//GET QT 
        private decimal CalcQT;// CalcQT = UnitConvert_  * GETQTFROMTXTQT=>get QT save in db.productquntity
        DeleteSellingBilling deleteSellingBilling = new DeleteSellingBilling();
        SearchTORemoveSellingBilling searchTORemoveSellingBilling = new SearchTORemoveSellingBilling();
        private int GETPrroductid;//GETPrroductid
        private string _SellingPrice;//GetSelling price from db
        DataTable dataTable_Getprice = new DataTable();
        bool checkQT=false;//check condition if checkqt = 0 or 1
        private void _GenerateReport()
        {
            ReportDocument crystalReport = new ReportDocument();
            string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\Reports\CRPInvoiceSelling_Print.rpt";
            crystalReport.Load(filename);

            DataSet1 dsMembe_IN = GETREportWithMultipleParam.GetDataWithMultiParam("_Warehouse_InvoiceSelling_Print", "_Warehouse_InvoiceSelling_Print", new _Parameter("@Selling_MasterID", SqlDbType.Int, int.Parse(Selling_MasterID.Text)));
            crystalReport.SetDataSource(dsMembe_IN);
            //FRPInvoiceSelling_Print fRPInvoiceSelling_Print = new FRPInvoiceSelling_Print();
            //fRPInvoiceSelling_Print.crystalReportViewer1.ReportSource = crystalReport;
            crystalReport.PrintToPrinter(1, false, 0, 0);
            //crystalReportViewer1.ReportSource = crystalReport;
            //////////////////////////_TxtClear.TxtClear(this, PanelMain);
            BTNSAVE.Enabled = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Set  KeyPreview properties =True
            if (keyData == (Keys.F1))
            {

                BtnNewSelling();
                return true;
            }
            else if (keyData == (Keys.F2))
            {
                BTNADDSelling();
                return true;
            }
            else if (keyData == (Keys.F3))
            {
                BTNSaveSelling();
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        private void BtnNewSelling()
        {
            DataTable dt = new DataTable();
            dt = _Executequery._ExecuteQuery("_Warehouse_Select_MAX_ID_Selling_Master", CommandType.StoredProcedure);
            Selling_MasterID.Text = Convert.ToString(dt.Rows[0]["Selling_MasterID"].ToString());
            if (Selling_MasterID.Text == "")
            {
                _ExecuteNonquery.executeNonquery("_WarehouseAddrow_Selling_Master");
                return;
            }
            CMBCUSTOMER.Enabled = true;
            CMBEMPLOYEE.Enabled = true;
            TXTBarCode.Enabled = true;
            TXTPRODUCT.Enabled = true;
            DGVSelling.Rows.Clear();
        }
        private void BTNADDSelling()
        {

            #region ADDTOGrid
            try
            {
                AddColINGrid = DGVSelling.Rows.Add(Counterdgv++,
                CMBEMPLOYEE.Text,
                int.Parse(CMBEMPLOYEE.SelectedValue.ToString()),
                GETPrroductid,
                TXTPRODUCT.Text,

                1,
                Convert.ToDecimal(_SellingPrice),
                Convert.ToDecimal(0));

                #endregion
                #region MyRegion
                var loopTo = DGVSelling.Rows.Count - 1;
                for (var i = 0; i <= loopTo; i++)
                {
                    DataGridViewRow rw = DGVSelling.Rows[i];
                    rw.Height = 32;
                    ccOunt = DGVSelling.Rows.Count;
                    #endregion
                    #region MyRegion
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            #endregion
        }
        private void BTNSaveSelling()
        {
            if (TXTDiscount.Text == "")
            {
                MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                //////////////////CalcQuntity
                #region save

                for (int i = 0; i < ccOunt; i++)
                {
                    _ExecuteNonquery.executeNonquery("_Warehouse_Insert_Selling",
new _Parameter("@Selling_MasterID", SqlDbType.Int, int.Parse(Selling_MasterID.Text)),

new _Parameter("@EmpId", SqlDbType.Int, Convert.ToInt32(DGVSelling.Rows[i].Cells[2].Value.ToString())),
new _Parameter("@ProdouctsID", SqlDbType.Int, int.Parse(DGVSelling.Rows[i].Cells[3].Value.ToString())),
new _Parameter("@UnitesNId", SqlDbType.Int, int.Parse(DGVSelling.Rows[i].Cells[9].Value.ToString())),
new _Parameter("@Quntity_Product", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[5].Value.ToString())),
new _Parameter("@SellingPrice", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[6].Value.ToString())),
new _Parameter("@Discount", SqlDbType.Int, int.Parse(TXTDiscount.Text)),
new _Parameter("@TotalPrice", SqlDbType.Decimal, Convert.ToDecimal(TxtTotalPrice.Text)),
new _Parameter("@TotalBDiscount", SqlDbType.Decimal, txtTotalBDiscount.Text),
new _Parameter("@AMountDicount", SqlDbType.Decimal,
txtAMountDicount.Text),
new _Parameter("@TotalAmountRow", SqlDbType.Decimal, Convert.ToDecimal(DGVSelling.Rows[i].Cells[7].Value.ToString())),
new _Parameter("@_Quantity_Product", SqlDbType.Decimal, CalcQuntity),
new _Parameter("@UsersID", SqlDbType.Int, Login_.Userid));
                }
                _ExecuteNonquery.executeNonquery("_Warehouse_Insert_Selling_Master",
               new _Parameter("@CustomerID", SqlDbType.Int, int.Parse(CMBCUSTOMER.SelectedValue.ToString())),
              new _Parameter("@WDate", SqlDbType.DateTime, DTP.Value));
                #endregion

                #region   _GenerateReport
                _GenerateReport();

                #endregion
                CMBCUSTOMER.Enabled = false;
                CMBEMPLOYEE.Enabled = false;
                TXTBarCode.Enabled = false;
                TXTPRODUCT.Enabled = false;
                DGVSelling.Rows.Clear();
            }
        }

        private void TXTBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                #region MyRegion
                DataTable dataTable = new DataTable();

                dataTable = _Executequerysearch.executequerysearch("_Warehouse_Select_BarCodeByProductid", CommandType.StoredProcedure,
                    new
                  _Parameter("@BarCode", SqlDbType.Int, Convert.ToInt32(TXTBarCode.Text))

                     );
                if (dataTable.Rows.Count > 0)
                {
                    TXTPRODUCT.Text = dataTable.Rows[0]["Pname"].ToString();

                    GETPrroductid = int.Parse(dataTable.Rows[0]["ProdouctsID"].ToString());
                    dataTable.Rows.Clear();
                    dataTable.Dispose();
                    #endregion
                    using (dataTable_Getprice = _Executequerysearch.executequerysearch("_Warehouse_GetPriceSelling", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text)))
                    {
                        if (dataTable_Getprice.Rows.Count > 0)
                        {
                            _SellingPrice = dataTable_Getprice.Rows[0]["SellingPrice"].ToString();
                            dataTable_Getprice.Rows.Clear();
                            dataTable_Getprice.Dispose();
                            #region GETQT
                            DataTable dataTable_ = new DataTable();

                            dataTable_ = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityByProductid", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, GETPrroductid));
                            if (dataTable_.Rows.Count == 0)
                            {
                                MessageBox.Show("عفوا لايوجد نتيجه");
                                return;
                            }
                            else
                            {
                                GetQuntity_Product = Convert.ToDecimal(dataTable_.Rows[0]["QuantityProduct"].ToString());
                            }

                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("عفوا باركود خطأ  او غير مسجل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                            BTNADDSelling();


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //using (WarehouseEntities db = new WarehouseEntities())
            //{
            //    warehouseMainUnitesBindingSource.DataSource = db.Warehouse_MainUnites.ToList();

            //}
            //this.ActiveControl = CMBEMPLOYEE;
      
            CMBCUSTOMER.Enabled = false;
            CMBEMPLOYEE.Enabled = false;
            TXTBarCode.Enabled = false;
            TXTPRODUCT.Enabled = false;
            DGVSelling.Rows.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            BTNADDSelling();

        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            _CheckTxt.CheckTxt(this, PanelMain);
            if (_CheckTxt._ResultValidate == 1)
            {

                return;
            }
            else
            {
                if (TXTDiscount.Text == null)
                {
                    MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXTDiscount.Focus();
                    return;
                }
                else
                {
                    TotalBDiscount = Convert.ToDecimal(txtTotalBDiscount.Text);
                    Discount = Convert.ToDecimal(TXTDiscount.Text);

                    AMountDicount = TotalBDiscount * Discount;
                    AMoDicotDivid = AMountDicount / 100;
                    txtAMountDicount.Text = Convert.ToString(AMoDicotDivid);
                    ToAmAfDi = TotalBDiscount - AMoDicotDivid;
                    TxtTotalPrice.Text = Convert.ToString(ToAmAfDi);
                }
                BTNSaveSelling();

            }

        }

        private void DGVSelling_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DGVSelling.EndEdit();

            if (DGVSelling.CurrentCell.Value != null)
            {
                for (int i = 0; i < DGVSelling.Rows.Count; i++)
                {

                    //get selected value
                    DGVSelling.Rows[i].Cells[9].Value = DGVSelling.CurrentCell.Value.ToString();
                    //metroTextBox2.Text = DGVSelling.CurrentCell.FormattedValue.ToString();

                    //GetUnitConvert_ = Convert.ToDecimal(DGVSelling.Rows[i].Cells[8].Value.ToString());

                    GETQTFROMTXTQT = Convert.ToDecimal(DGVSelling.Rows[i].Cells[5].Value.ToString());
                    CalcQT = GetUnitConvert_ * GETQTFROMTXTQT;
                    GetSellingPrice = Convert.ToDecimal(Convert.ToDecimal(DGVSelling.Rows[i].Cells[6].Value.ToString()));

                    GetSellingQt = Convert.ToDecimal(DGVSelling.Rows[i].Cells[5].Value.ToString());


                    TotalAmountRow = GetSellingQt * GetSellingPrice;
                    Convert.ToDecimal(DGVSelling.Rows[i].Cells[7].Value = Convert.ToString(TotalAmountRow));



                 }
            }

            DGVSelling.BeginEdit(false);
        }

        private void CMBEMPLOYEE_Click(object sender, EventArgs e)

        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBEMPLOYEE, "_WarehouseSelectAll_Employee", "EName", "EmployeeId");
        }

        private void CMBCUSTOMER_Click(object sender, EventArgs e)
        {
            _FillComboboxNoParam.FillComboboxNoParams(CMBCUSTOMER, "_WarehouseSelectAll_Customers", "CName", "CustomersID");

        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNNew_Click(object sender, EventArgs e)
        {
            _TxtClear.TxtClear(this, PanelMain);
            DGVSelling.Rows.Clear();
            CMBCUSTOMER.Enabled = true;
            CMBEMPLOYEE.Enabled = true;
            TXTBarCode.Enabled = true;
            TXTPRODUCT.Enabled = true;
            BTNSAVE.Enabled = true;
            BtnNewSelling();
            _AutoCompleTextBox._AutoCompleTextBox_("_Warehosue_Select_ProductBYBarcodePrint", "@Pname", TXTPRODUCT.Text, TXTPRODUCT);
        }

        //Calc qt selling check qt and calc discount
        private void CalcQtMore()
        {
            try
            {
                for (int i = 0; i < DGVSelling.Rows.Count; i++)
                {

                    DataTable dataTableUnitConvert = new DataTable();
                    using (dataTableUnitConvert = _ExecutSPNOParam._ExecutSP("SELECT UnitesNId, UName , UnitConvert FROM Warehouse_MainUnites"))
                    {
                        GetUnitConvert_ = Convert.ToDecimal(dataTableUnitConvert.Rows[i]["UnitConvert"].ToString());

                    }
                    GetSellingPrice = Convert.ToDecimal(_SellingPrice);

                    GetSellingQt = Convert.ToDecimal(DGVSelling.Rows[i].Cells[5].Value.ToString());


                    TotalAmountRow = GetSellingQt * GetSellingPrice;
                    DGVSelling.Rows[i].Cells[7].Value = Convert.ToString(TotalAmountRow);
                    if (DGVSelling.Rows[i].Cells[6].Value.ToString() != string.Empty)
                    {

                        GetQuntityTextBox = Convert.ToDecimal(DGVSelling.Rows[i].Cells[5].Value.ToString());
                        GetQuntityTextBox = GetQuntityTextBox * GetUnitConvert_;
                        CalcQuntity = GetQuntity_Product - GetQuntityTextBox;

                        if (GetQuntityTextBox > GetQuntity_Product)
                        {
                            MessageBox.Show("الكمية اكبر من الموجود بالمخزن", "الكمية كبيرة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            foreach (DataGridViewRow item in this.DGVSelling.Rows)
                            {
                                DGVSelling.Rows.RemoveAt(item.Index);
                            }
                             checkQT = false;
                            return;
                        }
                        else
                        {
                            checkQT = true;
                            decimal TotalBDiscount = DGVSelling.Rows.Cast<DataGridViewRow>()
                                        .Sum(t => Convert.ToDecimal(t.Cells[7].Value));
                            txtTotalBDiscount.Text = Convert.ToString(TotalBDiscount);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }
        private void DGVSelling_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //loopTo;
            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)DGVSelling.Rows[ccOunt].Cells[8];
            cbCell.DataSource = _ExecutSPNOParam._ExecutSP("SELECT UnitesNId, UName , UnitConvert FROM Warehouse_MainUnites");
            cbCell.DisplayMember = "UName";
            cbCell.ValueMember = "UnitesNId";
            //if (checkQT == true)
            //{
                CalcQtMore();

            ////}
            //else
            //{
            //    MessageBox.Show("00");
            //    foreach (DataGridViewRow row in DGVSelling.Rows)
            //    {
            //        DGVSelling.Rows.RemoveAt(row.Index);
            //    }
            //    return;
            //}
        }



        private void DGVSelling_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                //MessageBox.Show( ccOunt.ToString());
                //   DGVSelling.Rows[ccOunt].ToString() ;
                //MessageBox.Show(DGVSelling.Rows[200].Cells[5].Value.ToString());
                if (checkQT == true)
                {
                    CalcQtMore();

                }
                else
                {
                    return;
                }

            }

        }

        private void TXTDiscount_Leave(object sender, EventArgs e)
        {
            if (TXTDiscount.Text == null)
            {
                MessageBox.Show("عفوا خانة الخصم لايجب ان تكون فارغه", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTDiscount.Focus();
                return;
            }
            else
            {
                TotalBDiscount = Convert.ToDecimal(txtTotalBDiscount.Text);
                Discount = Convert.ToInt32(TXTDiscount.Text);

                AMountDicount = TotalBDiscount * Discount;
                AMoDicotDivid = AMountDicount / 100;
                txtAMountDicount.Text = Convert.ToString(AMoDicotDivid);
                ToAmAfDi = TotalBDiscount - AMoDicotDivid;
                TxtTotalPrice.Text = Convert.ToString(ToAmAfDi);
            }
        }

        private void TXTBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TXTBarCode_Leave(object sender, EventArgs e)
        {

        }

        private void TXTPRODUCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dataTable = new DataTable();
                DataTable dataTable_Getprice = new DataTable();
                using (dataTable = _Executequerysearch.executequerysearch("_Warehosue_Select_ProductBarcodeBYNamePrint", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text)))

                {
                    using (dataTable_Getprice = _Executequerysearch.executequerysearch("_Warehouse_GetPriceSelling", CommandType.StoredProcedure, new _Parameter("@Pname", SqlDbType.NVarChar, TXTPRODUCT.Text)))
                    {

                        if (dataTable.Rows.Count > 0 && dataTable_Getprice.Rows.Count > 0)
                        {
                            TXTBarCode.Text = dataTable.Rows[0]["BarCodeText"].ToString();
                            _SellingPrice = dataTable_Getprice.Rows[0]["SellingPrice"].ToString();
                            GETPrroductid = Convert.ToInt32(dataTable.Rows[0]["ProdouctsID"].ToString());
                            //_Warehouse_GetPriceSelling
                            #region GETQT
                            DataTable dataTable_ = new DataTable();

                            dataTable_ = _Executequerysearch.executequerysearch("_Warehouse_Select_QuantityByProductid", CommandType.StoredProcedure, new _Parameter("@ProdouctsID", SqlDbType.Int, GETPrroductid));
                            if (dataTable_.Rows.Count == 0)
                            {
                                MessageBox.Show("عفوا لايوجد نتيجه");
                                return;
                            }
                            else
                            {
                                GetQuntity_Product = Convert.ToDecimal(dataTable_.Rows[0]["QuantityProduct"].ToString());
                            }
                            #endregion
                        }
                        else
                        {
                            MessageBox.Show("عفوا باركود خطأ  او غير مسجل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                BTNADDSelling();



            }
        }

    }
}
 
