using System;
using System.Windows.Forms;


namespace QWS_Local
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
            // 20260701 start here so that I can update app.config before calling a form with datasets
            //Application.Run(new QWSLogin()); 
            // OOPs application shuts down when I clode QWSLogin !@#
            Application.Run(new QWS_MDIParent());
        }
    }
}
