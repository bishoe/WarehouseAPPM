using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAPPM.Classes
{
    static class WriteErrorLogFile
    {
        public static bool WriteLog(string strFileName, string strMessage,string dateTime)
        {
            try
            {
                string path = Application.StartupPath;

                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", path, strFileName),
     FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage,dateTime);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
 
