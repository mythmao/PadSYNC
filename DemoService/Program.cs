using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoService
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicServiceStarter.Run<MyService>("DemoService");
        }
    }
    class MyService : IDisposable
    {
        public MyService()
        {
            Console.WriteLine("服务启动...");
            LogHelper.WriteLog(this.GetType(), "服务启动");
        }
        public void Start()
        {
            //Console.WriteLine("服务启动...");
        }

        public void Dispose()
        {
            Console.WriteLine("服务停止...");
            LogHelper.WriteLog(this.GetType(), "服务停止");
        }
    }
}
