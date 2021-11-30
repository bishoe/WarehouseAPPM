//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WarehouseAPPM.Classes;

//namespace WarehouseAPPM
//{
//    public partial class FRM_GetScreenName : Form
//    {
//        public FRM_GetScreenName()
//        {
//            InitializeComponent();
//        }

//        private void InitializeComponent()
//        {
//            throw new NotImplementedException();
//        }

//        private void FRM_GetScreenName_Load(object sender, EventArgs e)
//        {
//            List<String> FormNames = GetFormsNames();




//            //save name
//        }
//        public List<String> GetFormsNames()
//        {

//            List<String> formsName = new List<string>();
//            Assembly myProject = Assembly.Load("WarehouseAPPM");
//            foreach (Type t in myProject.GetTypes())
//            {
//                if (t.BaseType == typeof(MetroFramework.Forms.MetroForm))
//                {
//                    formsName.Add(t.Name);
//                    _ExecuteNonquery.executeNonquery("INSERTSCREEN",
//            new _Parameter("@SCREEN_NAME", SqlDbType.NVarChar, t.Name),
//            new _Parameter("@SCREEN_NameAr", SqlDbType.NVarChar, t.Name)

//            );
                     
//                }
//            }
            
//            return formsName;
//        }
         
 

 
//    }
//}
