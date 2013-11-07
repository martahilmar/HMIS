using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HMIS.PresentationLayer;
using HMIS.Controller;

namespace HMIS.AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainController mainController = new MainController();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainWindow(mainController));
        }
    }
}
