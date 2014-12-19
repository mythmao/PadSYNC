using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LogHelper.WriteLog(typeof(Program), "testaaa");
            }
            catch (Exception ex)
            {
                
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
