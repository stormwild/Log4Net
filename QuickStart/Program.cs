using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator]
namespace QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // log4net.Config.BasicConfigurator.Configure(); 
            // log4net.Config.XmlConfigurator.Configure(); 

            // ConfigureLog4Net();

            var log = LogManager.GetLogger(typeof(Program));

            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
            log.Error("Error");
            log.Fatal("Fatal");

            Console.ReadLine();

        }

        private static void ConfigureLog4Net()
        {
            // Shows code based configuration initialization for log4net
            SimpleLayout layout = new SimpleLayout();
            layout.ActivateOptions();

            ConsoleAppender appender = new ConsoleAppender();
            appender.Layout = layout;
            appender.ActivateOptions();

            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
            Logger root = hierarchy.Root;

            root.Level = log4net.Core.Level.All;

            BasicConfigurator.Configure(appender);

            ILog log = LogManager.GetLogger(typeof(Program));

            log.Debug("Debug");
            log.Info("Info");
            log.Warn("Warn");
            log.Error("Error");
            log.Fatal("Fatal");
        }
    }
}
