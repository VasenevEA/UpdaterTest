using AutoUpdaterDotNET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdaterTest1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutoUpdater.Start("http://rbsoft.org/updates/AutoUpdaterTest.xml");
            AutoUpdater.CurrentCulture = CultureInfo.CreateSpecificCulture("ru");
            AutoUpdater.ReportErrors = true;
            AutoUpdater.ShowSkipButton = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
