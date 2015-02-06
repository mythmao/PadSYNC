using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;

namespace ServiceOrApp
{
    public static class BasicServiceStarter
    {
        public static void Run<T>(string serviceName) where T : IService, new()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                if (EventLog.SourceExists(serviceName))
                {
                    EventLog.WriteEntry(serviceName,
                        "Fatal Exception : " + Environment.NewLine +
                        e.ExceptionObject, EventLogEntryType.Error);
                }
            };
            if (Environment.UserInteractive)
            {
                var cmd =
                    (Environment.GetCommandLineArgs().Skip(1).FirstOrDefault() ?? "")
                    .ToLower();
                switch (cmd)
                {
                    case "i":
                    case "install":
                        Console.WriteLine("Installing {0}", serviceName);
                        BasicServiceInstaller.Install(serviceName);
                        break;
                    case "u":
                    case "uninstall":
                        Console.WriteLine("Uninstalling {0}", serviceName);
                        BasicServiceInstaller.Uninstall(serviceName);
                        break;
                    default:
                        using (var service = new T())
                        {
                            service.Start();
                            Console.WriteLine(
                                "Running {0}, press any key to stop", serviceName);
                            Console.ReadKey();
                        }
                        break;
                }
            }
            else
            {
                ServiceBase.Run(new BasicService<T> { ServiceName = serviceName });
            }
        }
    }
    public class BasicService<T> : ServiceBase where T : IService, new()
    {
        private IService _service;

        protected override void OnStart(string[] args)
        {
            try
            {
                _service = new T();
                _service.Start();
            }
            catch
            {
                ExitCode = 1064;
                throw;
            }
        }

        protected override void OnStop()
        {
            _service.Dispose();
        }
    }
    static class BasicServiceInstaller
    {
        public static void Install(string serviceName)
        {
            CreateInstaller(serviceName).Install(new Hashtable());
        }

        public static void Uninstall(string serviceName)
        {
            CreateInstaller(serviceName).Uninstall(null);
        }

        private static Installer CreateInstaller(string serviceName)
        {
            var installer = new TransactedInstaller();
            installer.Installers.Add(new ServiceInstaller
            {
                ServiceName = serviceName,
                DisplayName = serviceName,
                StartType = ServiceStartMode.Manual
            });
            installer.Installers.Add(new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem
            });
            var installContext = new InstallContext(
                serviceName + ".install.log", null);
            installContext.Parameters["assemblypath"] =
                Assembly.GetEntryAssembly().Location;
            installer.Context = installContext;
            return installer;
        }
    }
}
