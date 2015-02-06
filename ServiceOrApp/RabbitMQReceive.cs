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

namespace ServiceOrApp
{
    public class RabbitMQReceive
    {
        public static void DoReceive()
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
                    LogHelper.WriteLog(typeof(RabbitMQReceive), " [*] Waiting for messages." +
                                             "To exit press CTRL+C");
                    while (true)
                    {
                        var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                        Console.WriteLine("获得消息*---*" + ea.DeliveryTag);
                        LogHelper.WriteLog(typeof(RabbitMQReceive), "获得消息*---*" + ea.DeliveryTag);
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        PadSYNC.Model.AssignCourse ac = null;
                        SYNCOperation op = null;
                       
                        try
                        {
                            ac = JsonConvert.DeserializeObject<PadSYNC.Model.AssignCourse>(message);
                          
                            op = SYNCOperationBLL.GetById(ac.Gid);

                            AssignCourseDataContract acdc = Translate.TranslateAssignCourseEntityToGuest(ac);
                            bool b = false;
                            string result = "";
                            AssignCourseServiceClient client = new AssignCourseServiceClient();
                            Console.WriteLine("处理消息*---*" + ea.DeliveryTag);
                            LogHelper.WriteLog(typeof(RabbitMQReceive), "处理消息*---*" + ea.DeliveryTag);
                            if (ac.PadOperType == 0)
                            {
                                b = client.AddNewAssignCourseRetErrowString(out result, acdc);
                            }
                            else
                            {
                                List<CancelReasonConditionsDataContract> CancelReasonConditionsList = new List<CancelReasonConditionsDataContract>();
                                CancelReasonConditionsDataContract cancelReasonConditions = new CancelReasonConditionsDataContract();
                                cancelReasonConditions.AssignID = ac.AssignID;
                                cancelReasonConditions.Reason = "";
                                CancelReasonConditionsList.Add(cancelReasonConditions);
                                CancelReasonConditionsDataContract[] arr = CancelReasonConditionsList.ToArray();
                                b = client.CancleAssignCourse(arr, 0, 0, 1);
                                result = "取消失败";
                            }

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
                            LogHelper.WriteLog(typeof(RabbitMQReceive), "处理成功 "+op.Gid + "*---*" + result);
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
                            LogHelper.WriteLog(typeof(RabbitMQReceive), "处理失败 "+ "*---*" + ex.Message);
                            LogHelper.WriteLog(typeof(RabbitMQReceive), ex);
                        }
                        if (op != null)
                        {
                            SYNCOperationBLL.Save(op);
                        }

                    }
                }
            }
        }
    }
}
