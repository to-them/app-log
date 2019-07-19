using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-TEST LOG=-=-=-=");
            string msg = "Write something...";
            Log.WriteLog(msg);
            Console.WriteLine("Logged: {0}", msg);
            Console.Write("PRESS ANY KEY TO EXIT: ");
            Console.ReadKey();
        }
    }
}
