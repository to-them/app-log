using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=TEST LOG 4 NET=-=-=-=");
            string msg = "Hello logging INFO world!...";
            log.Info(msg);
            log.Error(msg + " Error...");
            Console.Write("\n Hit enter: ");
            Console.ReadKey();
        }
    }
}
