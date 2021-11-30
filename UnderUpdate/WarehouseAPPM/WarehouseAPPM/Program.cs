using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAPPM;
using WarehouseAPPM.Classes;
using WarehouseAPPM.Reports;
using WarehouseAPPM.Screen;
 
namespace WarehouseAPPMM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);

            // Force all WinForms errors to go through handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // This handler is for catching non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            Application.Run(new FRM_Splash());
        }
        private static void CurrentDomain_UnhandledException(Object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                MessageBox.Show("Unhadled domain exception:\n\n" + ex.Message);

                //WriteErrorLogFile.WriteLog("WarehouseLog", ex.Message.ToString(), string.Format("{0}", "", DateTime.Now));

                WriteErrorLogFile.WriteLog("WarehouseLog",
                    string.Format("{0} => {1} ", ex.Message.ToString(), DateTime.Now), "");

                return;


            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal exception happend inside UnhadledExceptionHandler: \n\n"
                        + exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    WriteErrorLogFile.WriteLog("WarehouseLog",
          string.Format("{0} => {1} ", exc.Message.ToString(), DateTime.Now), "");

                    return;

                }
                finally
                {
                    Application.Exit();
                }
            }

            // It should terminate our main thread so Application.Exit() is unnecessary here
        }


        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {

            try
            {

                MessageBox.Show(t.Exception.Message.ToString());

                WriteErrorLogFile.WriteLog("WarehouseLog",


 string.Format("{0} => {1} ", t.Exception.Message.ToString(), DateTime.Now), "");

                return;

            }
            catch (Exception exception)
            {
                try
                {
                    //WriteErrorLogFile.WriteLog("ConsoleLog",exception.Message.ToString(), string.Format("{0}", "33", DateTime.Now));
                    
                    WriteErrorLogFile.WriteLog("WarehouseLog",
                        string.Format("{0} => {1} ", t.Exception.Message.ToString(), DateTime.Now), "");

                    return;

                }
                finally
                {
                    Application.Exit();
                }
            }

            // Here we can decide if we want to end our application or do something else
            //Application.Exit();
        }
    }
}
