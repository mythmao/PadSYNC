using Newtonsoft.Json;
using PadSYNC.BLL;
using PadSYNC.Model;
using PadSYNC.Model.AssignCourseServiceReference;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQReceive
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = ConfigurationManager.AppSettings["RabbitMQHostName"];
            string userName = ConfigurationManager.AppSettings["RabbitMQUserName"];
            string password = ConfigurationManager.AppSettings["RabbitMQPassword"];
            var factory = new ConnectionFactory() { HostName = hostName, UserName = userName, Password = password };
            factory.AutomaticRecoveryEnabled = true;
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("AssignCourseSYNC", true, false, false, null);
                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("AssignCourseSYNC", false, consumer);

                    Console.WriteLine(" [*] Waiting for messages." +
                                             "To exit press CTRL+C");
                    while (true)
                    {

                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                        Console.WriteLine("获得消息*---*" + ea.DeliveryTag);
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        PadSYNC.Model.AssignCourse ac = null;
                        SYNCOperation op = null;
                        //清除消息队列用
                        //channel.BasicAck(ea.DeliveryTag, false);
                        //continue;
                        try
                        {
                            ac = JsonConvert.DeserializeObject<PadSYNC.Model.AssignCourse>(message);
                            op = SYNCOperationBLL.GetById(ac.Gid);
                            AssignCourseDataContract acdc = Translate.TranslateAssignCourseEntityToGuest(ac);
                            bool b = false;
                            string result = "";
                            AssignCourseServiceClient client = new AssignCourseServiceClient();
                            Console.WriteLine("处理消息*---*" + ea.DeliveryTag);
                            b = client.AddNewAssignCourseRetErrowString(out result,acdc);
                            if (b)
                            {
                                result = "Success";
                                op.Status = 1;
                            }
                            else
                            {
                                op.Status = 2;
                                op.Content = result;
                            }
                            Console.WriteLine("处理成功 {0}", op.Gid + "*---*" + result);
                            channel.BasicAck(ea.DeliveryTag, false);
                        }
                        catch (Exception ex)
                        {
                            if (op != null)
                            {
                                op.Status = 2;
                                op.Content = ex.Message;
                            }
                            Console.WriteLine("处理失败 {0}", "*---*" + ex.Message);
                        }
                        if (op != null)
                        {
                            SYNCOperationBLL.Save(op);
                        }

                        //Thread.Sleep(3000);
                    }
                }
            }
        }
    }
}
