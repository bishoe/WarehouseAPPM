using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseAPPM.Classes
{
   public class _Parameter
    {
        public string pname;
        public SqlDbType pdtype;
        public object pvalue;
        /// <summary>
        /// Paramter using in any SP
        /// </summary>
        /// <param name="pname"></param>
        /// <param name="pdtype"></param>
        /// <param name="pvalue"></param>
        public _Parameter(string pname, SqlDbType pdtype, object pvalue)
        {
            this.pname = pname;
            this.pdtype = pdtype;
            this.pvalue = pvalue;

        }
    }
}
