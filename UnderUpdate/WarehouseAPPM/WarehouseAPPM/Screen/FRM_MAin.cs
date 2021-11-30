using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM.Classes;
using WarehouseAPPM.Reports;
//using WarehouseAPPM.Classes;

namespace WarehouseAPPM.Screen
{
    public partial class FRM_MAin : MetroFramework.Forms.MetroForm
    {
        #region FRM
        static FRM_Customers customers = new FRM_Customers();
        static FRM_Employee employee = new FRM_Employee();
        static CategoryProducts categoryproducts = new CategoryProducts();
        static FRM_Prodoucts prodoucts = new FRM_Prodoucts();
        static FRM_Qutaly qutaly = new FRM_Qutaly();
        static FRM_Qutaly_Units qutaly_units = new FRM_Qutaly_Units();
        static FRM_Warehouse warehouse = new FRM_Warehouse();
        static FRM_MainUnits mainunits = new FRM_MainUnits();
        static FRM_SubUnits subunits = new FRM_SubUnits();
        static FRM_Selling Selling = new FRM_Selling();
        static FRM_Quantity_Product Quantity_Product = new FRM_Quantity_Product();
        static FRM_ManagementUsers managementUsers = new FRM_ManagementUsers();
        FRPAllCustomer fRPAllCustomer = new FRPAllCustomer();
        FRPALLEmployees fRPALLEmployees = new FRPALLEmployees();
        FRPALLPRODUCTS fRPALLPRODUCTS = new FRPALLPRODUCTS();
        FRM_SearchInWarehouseBYBillNo fRM_SearchInWarehouseBYBillNo = new FRM_SearchInWarehouseBYBillNo();
        FRM_ERROR fRM_ERROR = new FRM_ERROR();
        FRM_BackupRestore fRM_BackupRestore = new FRM_BackupRestore();
        FRM_ReturnProductOutWarehouse fRM_ReturnProductOutWarehouse = new FRM_ReturnProductOutWarehouse();
        FRM_ReturnSellingBill fRM_ReturnSellingBill = new FRM_ReturnSellingBill();
        FRPInvoiceSelling_Print fRPInvoiceSelling_Print = new FRPInvoiceSelling_Print();
        FRMWarehouse_invoice_Store_Status fRMWarehouse_invoice_Store_Status = new FRMWarehouse_invoice_Store_Status();
        FRM_Expiredate FRM_Expiredate = new FRM_Expiredate();
        FRM_ExpiredateDays FRM_ExpiredateDays = new FRM_ExpiredateDays();
        FRM_Expiredproducts FRM_Expiredproducts = new FRM_Expiredproducts();
        FRPAllQutaly FRPAllQutaly = new FRPAllQutaly();
        FRPALLUSers fRPALLUSers = new FRPALLUSers();
        FRM_Suppliers fRM_Suppliers = new FRM_Suppliers();
        FRM_SupplyRepresentative fRM_SupplyRepresentative = new FRM_SupplyRepresentative();
        FRM_Qutaly_Units fRM_Qutaly_Units = new FRM_Qutaly_Units();

        #endregion
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Set  KeyPreview properties =True
            if (keyData == (Keys.F9))
            {

                CProfexpenses cProfexpenses = new CProfexpenses();
                cProfexpenses.MdiParent  = this;
                cProfexpenses.Show();
                return true;
            }
          


            return base.ProcessCmdKey(ref msg, keyData);
        }

        public FRM_MAin()
        {
            InitializeComponent();
        }

        private void اضافةقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Customers customers = new FRM_Customers();
            customers.Show();

        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void المخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Warehouse warehouse = new FRM_Warehouse();

            warehouse.Show();
        }

        private void البيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FRM_Selling selling = new FRM_Selling();
            //selling.MdiParent = this;

            //selling.Show();
        }


        private void MAin_Load(object sender, EventArgs e)
        {
            //CheckPerm();
        }




        private void TXTScreen1_Click(object sender, EventArgs e)
        {


            //لاظم نسوف حل للمشكلة دى انه مش بيشوف الفورم الرئيسى لو فى ميثود بيشوفه لو فى اى كنترول داخل الفورم الرئيسى فقط
        }

        public static void CheckFORMCustomers()
        {

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

            //_CheckFORMCustomers.CheckFORMCustomers();

        }

        private void اضافةموظفينجددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check Admin OR EMPLOYEE AND SHOW  OR HIDE GROUP PANEL FOR UPDATE
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (employee.IsDisposed == true)
                {
                    FRM_Employee employee = new FRM_Employee();

                    employee.MdiParent = this;
                    employee.PanelSub.Visible = true;
                    employee.Show();

                }
                else
                {
                    employee.MdiParent = this;
                    employee.PanelSub.Visible = true;
                    employee.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (employee.IsDisposed == true)
                {
                    FRM_Employee employee = new FRM_Employee();


                    employee.MdiParent = this;
                    employee.PanelSub.Visible = false;

                    employee.Height = 350;
                    employee.PanelSub.Visible = false;
                    employee.StartPosition = FormStartPosition.CenterScreen;

                    employee.Show();
                }

                else
                {

                    employee.MdiParent = this;
                    employee.Height = 350;
                    employee.PanelSub.Visible = false;
                    employee.StartPosition = FormStartPosition.CenterScreen;
                    employee.Show();
                }
            }

            #endregion


        }

        private void الوحداتالرئيسةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الوحداتالرئيسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void الوحداتالفرعيهToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void المخزنToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();

                    warehouse.MdiParent = this;
                    warehouse.Show();

                }
                else
                {
                    warehouse.MdiParent = this;
                    warehouse.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();


                    warehouse.MdiParent = this;

                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;

                    warehouse.Show();
                }

                else
                {

                    warehouse.MdiParent = this;
                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;
                    warehouse.Show();
                }
            }

            #endregion
        }

        private void بيعمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtSellingName.Text = dt.Rows[0]["SellingName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (Selling.IsDisposed == true)
                {
                    FRM_Selling Selling = new FRM_Selling();
                    Selling.MdiParent = this;
                    Selling.WindowState = FormWindowState.Maximized;
                    //Selling.PanelSub.Visible = true;
                    Selling.Show();

                }
                else
                {
                    Selling.MdiParent = this;
                    //Selling.PanelSub.Visible = true;
                    Selling.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (Selling.IsDisposed == true)
                {
                    FRM_Selling Selling = new FRM_Selling();


                    Selling.MdiParent = this;
                    //Selling.PanelSub.Visible = false;
                    Selling.Show();
                }

                else
                {

                    Selling.MdiParent = this;
                    //Selling.Height = 350;
                    //Selling.PanelSub.Visible = false;
                    Selling.StartPosition = FormStartPosition.CenterScreen;
                    Selling.Show();
                }
            }

            #endregion
        }

        private void ادارةالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtqutalyName.Text = dt.Rows[0]["qutalyName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (qutaly.IsDisposed == true)
                {
                    FRM_Qutaly qutaly = new FRM_Qutaly();
                    qutaly.MdiParent = this;
                    qutaly.PanelSub.Visible = true;
                    qutaly.Show();

                }
                else
                {
                    qutaly.MdiParent = this;
                    qutaly.PanelSub.Visible = true;
                    qutaly.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (qutaly.IsDisposed == true)
                {
                    FRM_Qutaly qutaly = new FRM_Qutaly();
                    qutaly.MdiParent = this;
                    qutaly.PanelSub.Visible = false;
                    qutaly.Show();
                }

                else
                {

                    qutaly.MdiParent = this;
                    qutaly.Height = 350;
                    qutaly.PanelSub.Visible = false;
                    qutaly.StartPosition = FormStartPosition.CenterScreen;
                    qutaly.Show();
                }
            }

            #endregion
        }

        private void الوحداتالفرعيهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtsubunitsName.Text = dt.Rows[0]["subunitsName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (subunits.IsDisposed == true)
                {
                    FRM_SubUnits subunits = new FRM_SubUnits();
                    subunits.MdiParent = this;
                    subunits.PanelSub.Visible = true;
                    subunits.Show();

                }
                else
                {
                    subunits.MdiParent = this;
                    subunits.PanelSub.Visible = true;
                    subunits.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (subunits.IsDisposed == true)
                {
                    FRM_SubUnits subunits = new FRM_SubUnits();


                    subunits.MdiParent = this;
                    subunits.PanelSub.Visible = false;
                    subunits.Show();
                }

                else
                {

                    subunits.MdiParent = this;
                    subunits.Height = 350;
                    subunits.PanelSub.Visible = false;
                    subunits.StartPosition = FormStartPosition.CenterScreen;
                    subunits.Show();
                }
            }

            #endregion
        }

        private void كميهمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtmanagementUsersName.Text = dt.Rows[0]["managementUsersName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (managementUsers.IsDisposed == true)
                {
                    FRM_ManagementUsers managementUsers = new FRM_ManagementUsers(); managementUsers.MdiParent = this;
                    managementUsers.Show();

                }
                else
                {
                    managementUsers.MdiParent = this;
                    managementUsers.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (managementUsers.IsDisposed == true)
                {
                    FRM_ManagementUsers managementUsers = new FRM_ManagementUsers();

                    managementUsers.MdiParent = this;
                    managementUsers.PNLILOGin.Visible = false;
                    managementUsers.PNLINSERTUSER.Visible = false;
                    managementUsers.PNLINSERTROLES.Visible = false;
                    managementUsers.PNLINSERTPer.Visible = false;
                    managementUsers.Show();
                }

                else
                {

                    managementUsers.MdiParent = this;
                    managementUsers.PNLILOGin.Visible = false;
                    managementUsers.PNLINSERTUSER.Visible = false;
                    managementUsers.PNLINSERTROLES.Visible = false;
                    managementUsers.PNLINSERTPer.Visible = false;

                    managementUsers.StartPosition = FormStartPosition.CenterScreen;
                    managementUsers.Show();
                }
            }

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void ادارةالنظامToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_DB_CON fRM_DB_CON = new FRM_DB_CON();
            fRM_DB_CON.MdiParent = this;
            fRM_DB_CON.Show();

        }

        private void المخزنToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void المخزنToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();

                    warehouse.MdiParent = this;
                    warehouse.Show();

                }
                else
                {
                    warehouse.MdiParent = this;
                    warehouse.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();


                    warehouse.MdiParent = this;

                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;

                    warehouse.Show();
                }

                else
                {

                    warehouse.MdiParent = this;
                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;
                    warehouse.Show();
                }
            }

            #endregion
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();

                    warehouse.MdiParent = this;
                    warehouse.Show();

                }
                else
                {
                    warehouse.MdiParent = this;
                    warehouse.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (warehouse.IsDisposed == true)
                {
                    FRM_Warehouse warehouse = new FRM_Warehouse();


                    warehouse.MdiParent = this;

                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;

                    warehouse.Show();
                }

                else
                {

                    warehouse.MdiParent = this;
                    warehouse.Height = 350;
                    warehouse.StartPosition = FormStartPosition.CenterScreen;
                    warehouse.Show();
                }
            }

            #endregion
        }

        private void تقريرالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRPAllCustomer.IsDisposed == true)
                {
                    FRPAllCustomer fRPAllCustomer = new FRPAllCustomer();

                    fRPAllCustomer.MdiParent = this;
                    fRPAllCustomer.Show();

                }
                else
                {
                    fRPAllCustomer.MdiParent = this;
                    fRPAllCustomer.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRPAllCustomer.IsDisposed == true)
                {
                    FRPAllCustomer fRPAllCustomer = new FRPAllCustomer();


                    fRPAllCustomer.MdiParent = this;

                    fRPAllCustomer.Height = 350;
                    fRPAllCustomer.StartPosition = FormStartPosition.CenterScreen;

                    fRPAllCustomer.Show();
                }

                else
                {

                    fRPAllCustomer.MdiParent = this;
                    fRPAllCustomer.Height = 350;
                    fRPAllCustomer.StartPosition = FormStartPosition.CenterScreen;
                    fRPAllCustomer.Show();
                }
            }

            #endregion

        }

        private void تقريرالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRPALLEmployees.IsDisposed == true)
                {
                    FRPALLEmployees fRPALLEmployees = new FRPALLEmployees();

                    fRPALLEmployees.MdiParent = this;
                    fRPALLEmployees.Show();

                }
                else
                {
                    fRPALLEmployees.MdiParent = this;
                    fRPALLEmployees.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRPALLEmployees.IsDisposed == true)
                {
                    FRPALLEmployees fRPALLEmployees = new FRPALLEmployees();


                    fRPALLEmployees.MdiParent = this;

                    //fRPALLEmployees.Height = 350;
                    fRPALLEmployees.StartPosition = FormStartPosition.CenterScreen;

                    fRPALLEmployees.Show();
                }

                else
                {

                    fRPALLEmployees.MdiParent = this;
                    //fRPALLEmployees.Height = 350;
                    fRPALLEmployees.StartPosition = FormStartPosition.CenterScreen;
                    fRPALLEmployees.Show();
                }
            }

            #endregion
        }



        private void تقريرالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRPALLPRODUCTS.IsDisposed == true)
                {
                    FRPALLPRODUCTS fRPALLPRODUCTS = new FRPALLPRODUCTS();


                    fRPALLPRODUCTS.MdiParent = this;
                    fRPALLPRODUCTS.Show();

                }
                else
                {
                    fRPALLPRODUCTS.MdiParent = this;
                    fRPALLPRODUCTS.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRPALLPRODUCTS.IsDisposed == true)
                {
                    FRPALLPRODUCTS fRPALLPRODUCTS = new FRPALLPRODUCTS();



                    fRPALLPRODUCTS.MdiParent = this;

                    fRPALLPRODUCTS.StartPosition = FormStartPosition.CenterScreen;

                    fRPALLPRODUCTS.Show();
                }

                else
                {

                    fRPALLPRODUCTS.MdiParent = this;
                    fRPALLPRODUCTS.StartPosition = FormStartPosition.CenterScreen;
                    fRPALLPRODUCTS.Show();
                }
            }

            #endregion
        }

        private void تقريرالوحداتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        FRM_SearchAll_InvoiceStore fRM_SearchAll_InvoiceStore = new FRM_SearchAll_InvoiceStore();

        public FRPInvoiceSelling_Print FRPInvoiceSelling_Print { get; private set; }

        private void تقريرالمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تقريربجميعالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_SearchAll_InvoiceStore.IsDisposed == true)
                {
                    FRM_SearchAll_InvoiceStore fRM_SearchAll_InvoiceStore = new FRM_SearchAll_InvoiceStore();

                    fRM_SearchAll_InvoiceStore.MdiParent = this;
                    fRM_SearchAll_InvoiceStore.Show();

                }
                else
                {
                    fRM_SearchAll_InvoiceStore.MdiParent = this;
                    fRM_SearchAll_InvoiceStore.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_ERROR.IsDisposed == true)
                {
                    FRM_ERROR fRM_ERROR = new FRM_ERROR();
                    fRM_ERROR.MdiParent = this;
                    fRM_ERROR.Show();

                }

                else
                {

                    FRM_ERROR fRM_ERROR = new FRM_ERROR();
                    fRM_ERROR.MdiParent = this;
                    fRM_ERROR.Show();

                }
            }


        }

        #endregion

        private void تقريربرقمفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //#region GET->ROLES_NAME
            //DataTable dataTable = new DataTable();
            //dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            //CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            ////txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            //}
            //#endregion
            //#region MyRegion
            //if (VarS.ROLES_NAME == "Admin")
            //{

            //    if (fRM_SearchInWarehouseBYBillNo.IsDisposed == true)
            //    {
            //        FRM_SearchInWarehouseBYBillNo fRM_SearchInWarehouseBYBillNo = new FRM_SearchInWarehouseBYBillNo();

            //        fRM_SearchInWarehouseBYBillNo.MdiParent = this;
            //        fRM_SearchInWarehouseBYBillNo.Show();

            //    }
            //    else
            //    {
            //        fRM_SearchInWarehouseBYBillNo.MdiParent = this;
            //        fRM_SearchInWarehouseBYBillNo.Show();
            //    }
            //}
            //else if (VarS.ROLES_NAME == "Employee")
            //{
            //    if (fRM_ERROR.IsDisposed == true)
            //    {
            //        FRM_ERROR fRM_ERROR = new FRM_ERROR();
            //        fRM_ERROR.MdiParent = this;
            //        fRM_ERROR.Show();

            //    }

            //    else
            //    {

            //        FRM_ERROR fRM_ERROR = new FRM_ERROR();
            //        fRM_ERROR.MdiParent = this;
            //        fRM_ERROR.Show();

            //    }
            //}

            //#endregion

            if (fRPInvoiceSelling_Print.IsDisposed == true)
            {
                FRPInvoiceSelling_Print fRPInvoiceSelling_Print = new FRPInvoiceSelling_Print();
                fRPInvoiceSelling_Print.MdiParent = this;
                fRPInvoiceSelling_Print.Show();

            }

            else
            {

                FRPInvoiceSelling_Print fRPInvoiceSelling_Print = new FRPInvoiceSelling_Print();
                fRPInvoiceSelling_Print.MdiParent = this;
                fRPInvoiceSelling_Print.Show();
            }
        }

        private void النسخالاحتياطىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtwarehouseName.Text = dt.Rows[0]["warehouseName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_BackupRestore.IsDisposed == true)
                {
                    FRM_BackupRestore fRM_BackupRestore = new FRM_BackupRestore();
                    fRM_BackupRestore.MdiParent = this;
                    fRM_BackupRestore.Show();

                }
                else
                {
                    //fRM_BackupRestore.MdiParent = this;
                    fRM_BackupRestore.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_ERROR.IsDisposed == true)
                {
                    FRM_ERROR fRM_ERROR = new FRM_ERROR();
                    //fRM_ERROR.MdiParent = this;
                    fRM_ERROR.Show();

                }

                else
                {

                    FRM_ERROR fRM_ERROR = new FRM_ERROR();
                    //fRM_ERROR.MdiParent = this;
                    fRM_ERROR.Show();

                }
            }
            #endregion

        }

        private void تقريربرقمفاتورهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SearchInWarehouseBYBillNo fRM_SearchInWarehouseBYBillNo = new FRM_SearchInWarehouseBYBillNo();
            fRM_SearchInWarehouseBYBillNo.MdiParent = this;

            fRM_SearchInWarehouseBYBillNo.Show();

            //Name proc
            //_Warehosue_Select_ALL_invoiceSToreBY_ID
            //CRP_Warehosue_invoiceSTore_ID.rpt
        }

        private void اضافةعملاءجددToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //Check Admin OR EMPLOYEE AND SHOW  OR HIDE GROUP PANEL FOR UPDATE
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (customers.IsDisposed == true)
                {
                    FRM_Customers customers = new FRM_Customers();

                    customers.MdiParent = this;
                    customers.PanelSub.Visible = true;
                    customers.Show();

                }
                else
                {
                    customers.MdiParent = this;
                    customers.PanelSub.Visible = true;
                    customers.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (customers.IsDisposed == true)
                {
                    FRM_Customers customers = new FRM_Customers();


                    customers.MdiParent = this;
                    customers.PanelSub.Visible = false;

                    //customers.Height = 350;
                    customers.PanelSub.Visible = false;
                    //customers.StartPosition = FormStartPosition.CenterScreen;

                    customers.Show();
                }

                else
                {

                    customers.MdiParent = this;
                    //customers.Height = 350;
                    customers.PanelSub.Visible = false;
                    //customers.StartPosition = FormStartPosition.CenterScreen;
                    customers.Show();
                }
            }

            #endregion
        }
        //FRM_ReturnProductOutWarehouse
        private void ارجاعمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_ReturnProductOutWarehouse.IsDisposed == true)
                {
                    FRM_ReturnProductOutWarehouse fRM_ReturnProductOutWarehouse = new FRM_ReturnProductOutWarehouse();

                    fRM_ReturnProductOutWarehouse.MdiParent = this;
                    //fRM_ReturnProductOutWarehouse.PanelSub.Visible = true;
                    fRM_ReturnProductOutWarehouse.Show();

                }
                else
                {
                    fRM_ReturnProductOutWarehouse.MdiParent = this;
                    //fRM_ReturnProductOutWarehouse.PanelSub.Visible = true;
                    fRM_ReturnProductOutWarehouse.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_ReturnProductOutWarehouse.IsDisposed == true)
                {
                    FRM_ReturnProductOutWarehouse fRM_ReturnProductOutWarehouse = new FRM_ReturnProductOutWarehouse();


                    fRM_ReturnProductOutWarehouse.MdiParent = this;
                    // fRM_ReturnProductOutWarehouse.PanelSub.Visible = false;

                    //fRM_ReturnProductOutWarehouse.Height = 350;
                    // fRM_ReturnProductOutWarehouse.PanelSub.Visible = false;
                    //fRM_ReturnProductOutWarehouse.StartPosition = FormStartPosition.CenterScreen;

                    fRM_ReturnProductOutWarehouse.Show();
                }

                else
                {

                    fRM_ReturnProductOutWarehouse.MdiParent = this;
                    //fRM_ReturnProductOutWarehouse.Height = 350;
                    //fRM_ReturnProductOutWarehouse.PanelSub.Visible = false;
                    //fRM_ReturnProductOutWarehouse.StartPosition = FormStartPosition.CenterScreen;
                    fRM_ReturnProductOutWarehouse.Show();
                }
            }

            #endregion
        }

        private void ارجاعمنتجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_ReturnSellingBill.IsDisposed == true)
                {
                    FRM_ReturnSellingBill fRM_ReturnSellingBill = new FRM_ReturnSellingBill();

                    fRM_ReturnSellingBill.MdiParent = this;
                    fRM_ReturnSellingBill.Show();

                }
                else
                {
                    fRM_ReturnSellingBill.MdiParent = this;
                    fRM_ReturnSellingBill.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_ReturnSellingBill.IsDisposed == true)
                {
                    FRM_ReturnSellingBill fRM_ReturnSellingBill = new FRM_ReturnSellingBill();


                    fRM_ReturnSellingBill.MdiParent = this;

                    //fRM_ReturnSellingBill.Height = 350;
                    //fRM_ReturnSellingBill.StartPosition = FormStartPosition.CenterScreen;

                    fRM_ReturnSellingBill.Show();
                }

                else
                {

                    fRM_ReturnSellingBill.MdiParent = this;
                    //fRM_ReturnSellingBill.Height = 350;
                    //fRM_ReturnSellingBill.StartPosition = FormStartPosition.CenterScreen;
                    fRM_ReturnSellingBill.Show();
                }
            }

            #endregion
        }

        private void تقريربجميعالفواتيرToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAin_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtLoginStartWork.Text = Convert.ToString(Login_.StartWork);
            _ExecuteNonquery.executeNonquery("_Warehouse_Track_employee_progress_INSERT", new _Parameter("@USERID", SqlDbType.Int, Login_.Userid)
               ,
               new _Parameter("@StartWork", SqlDbType.DateTime, Convert.ToDateTime(txtLoginStartWork.Text)),
                new _Parameter("@EndWork", SqlDbType.DateTime, Convert.ToDateTime(DateTime.Now.ToLongTimeString().ToString())));

            //_Warehouse_Track_employee_progress_INSERT

            this.Dispose();
            Application.ExitThread();

            //Application.Exit();
        }

        private void الباركودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMPRINTBARCODE fRMPRINTBARCODE = new FRMPRINTBARCODE();
            fRMPRINTBARCODE.MdiParent = this;
            fRMPRINTBARCODE.Show();

        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtfRM_SuppliersName.Text = dt.Rows[0]["fRM_SuppliersName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_Suppliers.IsDisposed == true)
                {
                    FRM_Suppliers fRM_Suppliers = new FRM_Suppliers();
                    fRM_Suppliers.MdiParent = this;
                    fRM_Suppliers.PanelSub.Visible = true;
                    fRM_Suppliers.Show();

                }
                else
                {
                    fRM_Suppliers.MdiParent = this;
                    fRM_Suppliers.PanelSub.Visible = true;
                    fRM_Suppliers.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_Suppliers.IsDisposed == true)
                {
                    FRM_Suppliers fRM_Suppliers = new FRM_Suppliers();


                    fRM_Suppliers.MdiParent = this;
                    fRM_Suppliers.PanelSub.Visible = false;
                    fRM_Suppliers.Show();
                }

                else
                {

                    fRM_Suppliers.MdiParent = this;
                    fRM_Suppliers.Height = 350;
                    fRM_Suppliers.PanelSub.Visible = false;
                    fRM_Suppliers.StartPosition = FormStartPosition.CenterScreen;
                    fRM_Suppliers.Show();
                }
            }
        }


        #endregion

    
    private void دفعالفواتيرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRMWarehouse_invoice_Store_Status.IsDisposed == true)
                {
                    FRMWarehouse_invoice_Store_Status fRMWarehouse_invoice_Store_Status = new FRMWarehouse_invoice_Store_Status();

                    fRMWarehouse_invoice_Store_Status.MdiParent = this;
                    fRMWarehouse_invoice_Store_Status.Show();

                }
                else
                {
                    fRMWarehouse_invoice_Store_Status.MdiParent = this;
                    fRMWarehouse_invoice_Store_Status.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRMWarehouse_invoice_Store_Status.IsDisposed == true)
                {
                    FRMWarehouse_invoice_Store_Status fRMWarehouse_invoice_Store_Status = new FRMWarehouse_invoice_Store_Status();


                    fRMWarehouse_invoice_Store_Status.MdiParent = this;

                    //fRMWarehouse_invoice_Store_Status.Height = 350;
                    //fRMWarehouse_invoice_Store_Status.StartPosition = FormStartPosition.CenterScreen;

                    fRMWarehouse_invoice_Store_Status.Show();
                }

                else
                {

                    fRMWarehouse_invoice_Store_Status.MdiParent = this;
                    //fRMWarehouse_invoice_Store_Status.Height = 350;
                    //fRMWarehouse_invoice_Store_Status.StartPosition = FormStartPosition.CenterScreen;
                    fRMWarehouse_invoice_Store_Status.Show();
                }
            }

            #endregion
        }

        private void صلاحيهالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (FRM_Expiredate.IsDisposed == true)
                {
                    FRM_Expiredate FRM_Expiredate = new FRM_Expiredate();

                    FRM_Expiredate.MdiParent = this;
                    FRM_Expiredate.Show();

                }
                else
                {
                    FRM_Expiredate.MdiParent = this;
                    FRM_Expiredate.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (FRM_Expiredate.IsDisposed == true)
                {
                    FRM_Expiredate FRM_Expiredate = new FRM_Expiredate();


                    FRM_Expiredate.MdiParent = this;

                    //FRM_Expiredate.Height = 350;
                    //FRM_Expiredate.StartPosition = FormStartPosition.CenterScreen;

                    FRM_Expiredate.Show();
                }

                else
                {

                    FRM_Expiredate.MdiParent = this;
                    //FRM_Expiredate.Height = 350;
                    //FRM_Expiredate.StartPosition = FormStartPosition.CenterScreen;
                    FRM_Expiredate.Show();
                }
            }

            #endregion
        }

        private void صلاحيهالمنتجاتبتاريخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (FRM_ExpiredateDays.IsDisposed == true)
                {
                    FRM_ExpiredateDays FRM_ExpiredateDays = new FRM_ExpiredateDays();

                    FRM_ExpiredateDays.MdiParent = this;
                    FRM_ExpiredateDays.Show();

                }
                else
                {
                    FRM_ExpiredateDays.MdiParent = this;
                    FRM_ExpiredateDays.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (FRM_ExpiredateDays.IsDisposed == true)
                {
                    FRM_ExpiredateDays FRM_ExpiredateDays = new FRM_ExpiredateDays();


                    FRM_ExpiredateDays.MdiParent = this;

                    //FRM_ExpiredateDays.Height = 350;
                    //FRM_ExpiredateDays.StartPosition = FormStartPosition.CenterScreen;

                    FRM_ExpiredateDays.Show();
                }

                else
                {

                    FRM_ExpiredateDays.MdiParent = this;
                    //FRM_ExpiredateDays.Height = 350;
                    //FRM_ExpiredateDays.StartPosition = FormStartPosition.CenterScreen;
                    FRM_ExpiredateDays.Show();
                }
            }

            #endregion
        }

        private void منتجاتمنتهيهالصلاحيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (FRM_Expiredproducts.IsDisposed == true)
                {
                    FRM_Expiredproducts FRM_Expiredproducts = new FRM_Expiredproducts();


                    FRM_Expiredproducts.MdiParent = this;
                    FRM_Expiredproducts.Show();

                }
                else
                {
                    FRM_Expiredproducts.MdiParent = this;
                    FRM_Expiredproducts.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (FRM_Expiredproducts.IsDisposed == true)
                {
                    FRM_Expiredproducts FRM_Expiredproducts = new FRM_Expiredproducts();


                    FRM_Expiredproducts.MdiParent = this;

                    //FRM_Expiredproducts.Height = 350;
                    //FRM_Expiredproducts.StartPosition = FormStartPosition.CenterScreen;

                    FRM_Expiredproducts.Show();
                }

                else
                {

                    FRM_Expiredproducts.MdiParent = this;
                    //FRM_Expiredproducts.Height = 350;
                    //FRM_Expiredproducts.StartPosition = FormStartPosition.CenterScreen;
                    FRM_Expiredproducts.Show();
                }
            }

            #endregion
        }

        private void تقريرالمصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (FRPAllQutaly.IsDisposed == true)
                {
                    FRPAllQutaly FRPAllQutaly = new FRPAllQutaly();
                    FRPAllQutaly.MdiParent = this;
                    FRPAllQutaly.Show();

                }
                else
                {
                    FRPAllQutaly.MdiParent = this;
                    FRPAllQutaly.Show();
                }
            }
            else if (VarS.ROLES_NAME == "FRPAllQutaly")
            {
                if (FRPAllQutaly.IsDisposed == true)
                {
                    FRPAllQutaly FRPAllQutaly = new FRPAllQutaly();

                    FRPAllQutaly.MdiParent = this;

                    FRPAllQutaly.Height = 350;
                    FRPAllQutaly.StartPosition = FormStartPosition.CenterScreen;

                    FRPAllQutaly.Show();
                }

                else
                {

                    FRPAllQutaly.MdiParent = this;
                    FRPAllQutaly.Height = 350;
                    FRPAllQutaly.StartPosition = FormStartPosition.CenterScreen;
                    FRPAllQutaly.Show();
                }
            }

            #endregion
        }

        private void تقريرمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion


            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRPALLUSers.IsDisposed == true)
                {
                    FRPALLUSers fRPALLUSers = new FRPALLUSers();

                    fRPALLUSers.MdiParent = this;
                    fRPALLUSers.Show();

                }
                else
                {
                    fRPALLUSers.MdiParent = this;
                    fRPALLUSers.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRPALLUSers.IsDisposed == true)
                {
                    FRPALLUSers fRPALLUSers = new FRPALLUSers();


                    fRPALLUSers.MdiParent = this;
                    fRPALLUSers.crystalReportViewer1.Visible = false;
                    //fRPALLUSers.Height = 350;
                    //fRPALLUSers.StartPosition = FormStartPosition.CenterScreen;

                    fRPALLUSers.Show();
                }

                else
                {

                    fRPALLUSers.MdiParent = this;
                    fRPALLUSers.crystalReportViewer1.Visible = false;

                    //fRPALLUSers.Height = 350;
                    //fRPALLUSers.StartPosition = FormStartPosition.CenterScreen;
                    fRPALLUSers.Show();
                }
            }

            #endregion
        }

        private void اضافةقسمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (categoryproducts.IsDisposed == true)
                {
                    CategoryProducts category = new CategoryProducts();
                    category.MdiParent = this;
                    category.PanelSub.Visible = true;
                    category.Show();

                }
                else
                {
                    categoryproducts.MdiParent = this;
                    categoryproducts.PanelSub.Visible = true;
                    categoryproducts.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (categoryproducts.IsDisposed == true)
                {
                    CategoryProducts category = new CategoryProducts();


                    category.MdiParent = this;
                    category.PanelSub.Visible = false;
                    category.Show();
                }

                else
                {

                    categoryproducts.MdiParent = this;
                    categoryproducts.Height = 350;
                    categoryproducts.PanelSub.Visible = false;
                    categoryproducts.StartPosition = FormStartPosition.CenterScreen;
                    categoryproducts.Show();
                }
            }
        }


        #endregion

        private void المندوبينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtfRM_SupplyRepresentativeName.Text = dt.Rows[0]["fRM_SupplyRepresentativeName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_SupplyRepresentative.IsDisposed == true)
                {
                    FRM_SupplyRepresentative fRM_SupplyRepresentative = new FRM_SupplyRepresentative();
                    fRM_SupplyRepresentative.MdiParent = this;
                    fRM_SupplyRepresentative.PanelSub.Visible = true;
                    fRM_SupplyRepresentative.Show();

                }
                else
                {
                    fRM_SupplyRepresentative.MdiParent = this;
                    fRM_SupplyRepresentative.PanelSub.Visible = true;
                    fRM_SupplyRepresentative.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_SupplyRepresentative.IsDisposed == true)
                {
                    FRM_SupplyRepresentative fRM_SupplyRepresentative = new FRM_SupplyRepresentative();


                    fRM_SupplyRepresentative.MdiParent = this;
                    fRM_SupplyRepresentative.PanelSub.Visible = false;
                    fRM_SupplyRepresentative.Show();
                }

                else
                {

                    fRM_SupplyRepresentative.MdiParent = this;
                    fRM_SupplyRepresentative.PanelSub.Visible = false;
                    fRM_SupplyRepresentative.StartPosition = FormStartPosition.CenterScreen;
                    fRM_SupplyRepresentative.Show();
                }
            }
        }


        #endregion

        private void ادخالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (prodoucts.IsDisposed == true)
                {
                    FRM_Prodoucts prodoucts = new FRM_Prodoucts();
                    prodoucts.MdiParent = this;
                    prodoucts.PanelSub.Visible = true;
                    prodoucts.Show();

                }
                else
                {
                    prodoucts.MdiParent = this;
                    prodoucts.PanelSub.Visible = true;
                    prodoucts.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (prodoucts.IsDisposed == true)
                {
                    FRM_Prodoucts prodoucts = new FRM_Prodoucts();


                    prodoucts.MdiParent = this;
                    prodoucts.PanelSub.Visible = false;
                    prodoucts.Show();
                }

                else
                {

                    prodoucts.MdiParent = this;
                    prodoucts.Height = 350;
                    prodoucts.PanelSub.Visible = false;
                    prodoucts.StartPosition = FormStartPosition.CenterScreen;
                    prodoucts.Show();
                }
            }

            #endregion
        }

        private void اضافةمصروفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (fRM_Qutaly_Units.IsDisposed == true)
                {
                    FRM_Qutaly_Units fRM_Qutaly_Units = new FRM_Qutaly_Units(); fRM_Qutaly_Units.MdiParent = this;

                    fRM_Qutaly_Units.Show();

                }
                else
                {
                    fRM_Qutaly_Units.MdiParent = this;

                    fRM_Qutaly_Units.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (fRM_Qutaly_Units.IsDisposed == true)
                {
                    FRM_Qutaly_Units fRM_Qutaly_Units = new FRM_Qutaly_Units();

                    fRM_Qutaly_Units.MdiParent = this;

                    fRM_Qutaly_Units.Show();
                }

                else
                {

                    fRM_Qutaly_Units.MdiParent = this;
                    fRM_Qutaly_Units.Height = 350;

                    fRM_Qutaly_Units.StartPosition = FormStartPosition.CenterScreen;
                    fRM_Qutaly_Units.Show();
                }
            }

            #endregion
        }

        private void وحداتالبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtmainunitsName.Text = dt.Rows[0]["mainunitsName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (mainunits.IsDisposed == true)
                {
                    FRM_MainUnits mainunits = new FRM_MainUnits();
                    mainunits.MdiParent = this;
                    mainunits.PanelSub.Visible = true;
                    mainunits.Show();

                }
                else
                {
                    mainunits.MdiParent = this;
                    mainunits.PanelSub.Visible = true;
                    mainunits.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (mainunits.IsDisposed == true)
                {
                    FRM_MainUnits mainunits = new FRM_MainUnits();


                    mainunits.MdiParent = this;
                    mainunits.PanelSub.Visible = false;
                    mainunits.Show();
                }

                else
                {

                    mainunits.MdiParent = this;
                    mainunits.Height = 350;
                    mainunits.PanelSub.Visible = false;
                    mainunits.StartPosition = FormStartPosition.CenterScreen;
                    mainunits.Show();
                }
            }

            #endregion
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void كميهمنتجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region GET->ROLES_NAME
            DataTable dataTable = new DataTable();
            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",
            CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtQuantity_ProductName.Text = dt.Rows[0]["Quantity_ProductName"].ToString();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
            }
            #endregion
            #region MyRegion
            if (VarS.ROLES_NAME == "Admin")
            {

                if (Quantity_Product.IsDisposed == true)
                {
                    FRM_Quantity_Product Quantity_Product = new FRM_Quantity_Product();
                    Quantity_Product.MdiParent = this;
                    //Quantity_Product.PanelSub.Visible = true;
                    Quantity_Product.Show();

                }
                else
                {
                    Quantity_Product.MdiParent = this;
                    //Quantity_Product.PanelSub.Visible = true;
                    Quantity_Product.Show();
                }
            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                if (Quantity_Product.IsDisposed == true)
                {
                    FRM_Quantity_Product Quantity_Product = new FRM_Quantity_Product();
                    Quantity_Product.MdiParent = this;
                    //Quantity_Product.PanelSub.Visible = false;
                    Quantity_Product.Show();
                }

                else
                {

                    Quantity_Product.MdiParent = this;
                    //Quantity_Product.Height = 350;
                    //Quantity_Product.PanelSub.Visible = false;
                    Quantity_Product.StartPosition = FormStartPosition.CenterScreen;
                    Quantity_Product.Show();
                }
            }

            #endregion
        }

        private void الباركودToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FRMPRINTBARCODE fRMPRINTBARCODE = new FRMPRINTBARCODE();
                fRMPRINTBARCODE.MdiParent = this;
                fRMPRINTBARCODE.Show();
            
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تعليماتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.MdiParent = this;
            frmAbout.Show();
        }

        private void المرتجعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReturnProducts frmReturnProducts = new FrmReturnProducts();
            frmReturnProducts.MdiParent = this;
            frmReturnProducts.Show();
         }
    }

}