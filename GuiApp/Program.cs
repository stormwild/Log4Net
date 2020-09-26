using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator]
namespace GuiApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var log = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
            log.Error("Error");
            log.Fatal("Fatal");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
