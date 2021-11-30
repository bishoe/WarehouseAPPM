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
using WarehouseAPPM.Classes;

namespace WarehouseAPPM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();


            dataTable = _Executequerysearch.executequerysearch("SelectRolesIDForMenustrip",

       CommandType.StoredProcedure, new _Parameter("@ROLES_ID", SqlDbType.Int, VarS.RoleId));
            //txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                VarS.ROLES_NAME = dataTable.Rows[0]["ROLES_NAME"].ToString();
             }
            if (VarS.ROLES_NAME == "ADmin")
            {
                AddEmployee addEmployee = new AddEmployee();
                //addEmployee.Parent = this;
                addEmployee.btnsave.Enabled = true;
                addEmployee.btndelete.Enabled = true;
                addEmployee.Show();

            }
            else if (VarS.ROLES_NAME == "Employee")
            {
                AddEmployee addEmployee = new AddEmployee();
                //addEmployee.Parent = this;
                addEmployee.btnsave.Enabled = false;
                addEmployee.btndelete.Enabled = false;
                addEmployee.Show();
            }



            //AddEmployee addEmployee_ = new AddEmployee();
            //    addEmployee_.Parent = this;

            //    addEmployee_.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();


            dataTable = _Executequerysearch.executequerysearch("SelectScreenMainForm",

       CommandType.StoredProcedure, new _Parameter("@User_ID", SqlDbType.Int, Login_.Userid));
            //txtCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
            if (dataTable.Rows.Count > 0)
            {


                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    TXTScreen1.Text = dataTable.Rows[0]["SCREEN_NAME"].ToString();
                    TXTScreen2.Text = dataTable.Rows[1]["SCREEN_NAME"].ToString();
                    //TXTScreen3.Text = dataTable.Rows[2]["SCREEN_NAME"].ToString();
                    //TXTScreen4.Text = dataTable.Rows[3]["SCREEN_NAME"].ToString();
                    //TXTScreen5.Text = dataTable.Rows[4]["SCREEN_NAME"].ToString();
                    //TXTScreen6.Text = dataTable.Rows[5]["SCREEN_NAME"].ToString();
                    //TXTScreen7.Text = dataTable.Rows[6]["SCREEN_NAME"].ToString();
                    //TXTScreen8.Text = dataTable.Rows[7]["SCREEN_NAME"].ToString();
                    //TXTScreen9.Text = dataTable.Rows[8]["SCREEN_NAME"].ToString();
                }
            }
            if (TXTScreen1.Text == "AddEmployee" || TXTScreen2.Text == "AddEmployee")
            {
                empToolStripMenuItem.Enabled = true;

            }
            else
            {
                empToolStripMenuItem.Enabled = false;
            }
        }
    }
}
