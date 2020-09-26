using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            var log = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Debug from log4net");
            log.Info("Info from log4net");
            log.Warn("Warn from log4net");
            log.Error("Error from log4net");
            log.Fatal("Fatal from log4net");

            Console.ReadLine();

        }
    }
}
