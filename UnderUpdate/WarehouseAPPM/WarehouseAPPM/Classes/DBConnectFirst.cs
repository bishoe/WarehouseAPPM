 
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
    public class DBConnectFirst
    {
        private DBConnectFirst() { }
        private static readonly object LockDBConnect = new object();
        private static DBConnectFirst dBConnect = null;
        private static string server = WarehouseAPPM.Properties.Settings.Default.Server;
        private static string db = WarehouseAPPM.Properties.Settings.Default.Database;
        private static string user = WarehouseAPPM.Properties.Settings.Default.ID;
        private static string pass = WarehouseAPPM.Properties.Settings.Default.Password;
        //public static string FUllConnection = "Data Source ='" + server + "'; Initial Catalog = '" + db + "'; User id='" + user + "'; Password='" + pass + "'";
        public static string FUllConnection = @"Data Source=.;AttachDbFileName=|DataDirectory|\DBWarehouse\Warehouse.mdf;Initial Catalog=Warehouse;Integrated Security=True;";

        public static DBConnectFirst GetdbConnect()
        {
            lock (LockDBConnect)
            {
                if (dBConnect == null) { dBConnect = new DBConnectFirst(); }

                return dBConnect;
            }
        }

        //public static String connection =  FUllConnection;

        //public  static String connection = ConfigurationManager.ConnectionStrings["WarehouseAPPM.Properties.Settings.WarehouseConnectionString"].ConnectionString.ToString();

        public static SqlConnection conn = new SqlConnection(FUllConnection);


        static DBConnectFirst()
        {
            OpenConnection();
        }
        public static void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

        }

        public static void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }



    }
}
