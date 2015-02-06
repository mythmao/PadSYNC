using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceOrApp
{
    class Program
    {
        public const string Name = "PPTSHD更新服务";
        static void Main(string[] args)
        {
            BasicServiceStarter.Run<MyService>(Name);

            #region MyRegion
            //if (args.Length > 0 && args[0] == "s")
            //{
            //    ServiceBase[] ServicesToRun;
            //    ServicesToRun = new ServiceBase[] 
            //    { 
            //        new MainService(),
            //    };
            //    ServiceBase.Run(ServicesToRun);
            //}
            //else
            //{
            //    Console.WriteLine("这是Windows应用程序");
            //    Console.WriteLine("请选择，[1]安装服务 [2]卸载服务 [3]退出");
            //    LogHelper.WriteLog(typeof(Program), "应用程序启动...");
            //    var rs = int.Parse(Console.ReadLine());
            //    switch (rs)
            //    {
            //        case 1:
            //            //取当前可执行文件路径，加上"s"参数，证明是从windows服务启动该程序
            //            var path = Process.GetCurrentProcess().MainModule.FileName + " s";
            //            //ManagedInstallerClass.InstallHelper()
            //            Process.Start("sc", "create myserver binpath= \"" + path + "\" displayName= 我的服务 start= auto");
            //            Console.WriteLine("安装成功");
            //            Console.Read();
            //            break;
            //        case 2:
            //            Process.Start("sc", "delete myserver");
            //            Console.WriteLine("卸载成功");
            //            Console.Read();
            //            break;
            //        case 3:
            //            LogHelper.WriteLog(typeof(Program), "应用程序退出...");
            //            break;
            //    }
            //} 
            #endregion
        }
    }

    public interface IService:IDisposable
    {
        void Start();
    }
    public class BasicService:ServiceBase
    {
        private readonly IService _service;

        public BasicService(IService service, string name)
        {
            _service = service;
            ServiceName = name;
        }

        protected override void OnStart(string[] args)
        {
            _service.Start();
        }

        protected override void OnStop()
        {
            _service.Dispose();
        }
    }

    class MyService:IService
    {
        private bool _stopped;
        public MyService()
        {
            //Thread.Sleep(TimeSpan.FromMinutes(1));
        }
        public void Start()
        {
            LogHelper.WriteLog(this.GetType(), "服务开启");
            ThreadStart ts = new ThreadStart(RabbitMQReceive.DoReceive);
            Thread t = new Thread(ts);
            t.Start();
        }

        

        public void Dispose()
        {
            _stopped = true;
            LogHelper.WriteLog(this.GetType(), "服务停止");
        }
    }
    [RunInstaller(true)]
    public class MyInstaller : Installer
    {
        public MyInstaller()
        {
            Installers.Add(new ServiceProcessInstaller { 
                Account=ServiceAccount.LocalSystem
            });
            Installers.Add(new ServiceInstaller {
                ServiceName = Program.Name,
                DisplayName = Program.Name,
                Description = "This is a demo service"
            });
        }
    }
}
