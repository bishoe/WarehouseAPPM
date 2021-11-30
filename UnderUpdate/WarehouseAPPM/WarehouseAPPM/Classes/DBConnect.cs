using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace WarehouseAPPM.Classes
{
    public class DBConnect
    {
        private DBConnect() { }
        private static readonly object LockDBConnect = new object();  
        private static DBConnect dBConnect=null ;
        private static string server = WarehouseAPPM.Properties.Settings.Default.Server;
        private static string db = WarehouseAPPM.Properties.Settings.Default.Database;
        private static string user = WarehouseAPPM.Properties.Settings.Default.ID;
        private static string pass = WarehouseAPPM.Properties.Settings.Default.Password;
        public static string FUllConnection = "Data Source ='" + server + "'; Initial Catalog = '" + db + "'; Integrated Security=True;";
        //public static string FUllConnection = @"Data Source=.;AttachDbFileName=|DataDirectory|\DBWarehouse\Warehouse.mdf;Initial Catalog=Warehouse;Integrated Security=True;";

        public static DBConnect GetdbConnect()
        {
            lock (LockDBConnect)
            {
                if (dBConnect == null) { dBConnect = new DBConnect(); }

                return dBConnect;
            }
        }

        //public static String connection =  FUllConnection;

        //public static String FUllConnection = ConfigurationManager.ConnectionStrings["WarehouseAPPM.Properties.Settings.WarehouseConnectionString"].ConnectionString.ToString();

        public static SqlConnection conn = new SqlConnection(FUllConnection);

     
         static DBConnect()
        {
            OpenConnection();
        }
        public static void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
             conn.Open();
            
             }

        public static void CloseConnection() {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }



    }
}
