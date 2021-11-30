using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAPPM.Screen
{
    class MyGenTable
    {
        private DataTable TBA = new DataTable();

        private DataTable TBB = new DataTable();

        public DataTable get_TBA()

        {

            return TBA;

        }

        public DataTable get_TBB()

        {

            return TBB;

        }

        public MyGenTable()

        {

            TBA.Columns.Add("ID", typeof(int));

            TBA.Columns.Add("Name_TBA", typeof(string));

            for (int i = 0; i <= 5; i++)

            {

                DataRow row = TBA.NewRow();

                row["ID"] = i;

                row["Name_TBA"] = "Name_TBA" + i.ToString();

                TBA.Rows.Add(row);

            }

            TBB.Columns.Add("ID", typeof(int));

            TBB.Columns.Add("Name_TBB", typeof(string));

            for (int i = 0; i <= 5; i++)

            {

                DataRow row = TBB.NewRow();

                row["ID"] = i;

                row["Name_TBB"] = "Name_TBB" + i.ToString();

                TBB.Rows.Add(row);

            }

        }

    }

}


 