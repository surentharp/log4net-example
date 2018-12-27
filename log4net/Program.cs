using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace log4net
{
    // add [assembly: log4net.Config.XmlConfigurator(Watch=true)] in the AssemblyInfo.cs file under the Properties folder
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            //If you use the below commented line, it will output in the console window
            //log4net.Config.BasicConfigurator.Configure();
            //log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Info("test");
            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
