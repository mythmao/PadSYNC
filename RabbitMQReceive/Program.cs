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
            //test
            //Test();
            //return;
            
            //GetAC();
            //return;
            //test over
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
                            #region 处理消息
                            ac = JsonConvert.DeserializeObject<PadSYNC.Model.AssignCourse>(message);
                            //ac.Gid = new Guid("D67C7F51-29A1-4CA8-ACDF-08512FB3E8DF");
                            op = SYNCOperationBLL.GetById(ac.Gid);
                            //op.Id = ac.AssignID;


                            AssignCourseDataContract acdc = Translate.TranslateAssignCourseEntityToGuest(ac);
                            bool b = false;
                            string result = "";
                            AssignCourseServiceClient client = new AssignCourseServiceClient();
                            Console.WriteLine("处理消息*---*" + ea.DeliveryTag);
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
                            channel.BasicAck(ea.DeliveryTag, false); 
                            #endregion
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

        private static void GetAC()
        {
            PadSYNC.Model.AssignCourse ac= AssignCourseBLL.GetById(16961);
            string json = JsonConvert.SerializeObject(ac);

            ac.AssignID = 0;
            ac.AsignCourseID = 0;
            ac.StartTime = new DateTime(2015, 1, 30, 12, 0, 0);
            ac.EndTime = new DateTime(2015, 1, 30, 13, 0, 0);


            AssignCourseDataContract acdc = Translate.TranslateAssignCourseEntityToGuest(ac);
            bool b = false;
            string result = "";
            AssignCourseServiceClient client = new AssignCourseServiceClient();
            Console.WriteLine("处理消息*---*");
            if (ac.PadOperType == 0)
            {
                b = client.AddNewAssignCourseRetErrowString(out result, acdc);
            }
            else
            {
                List<CancelReasonConditionsDataContract> CancelReasonConditionsList = new List<CancelReasonConditionsDataContract>();
                CancelReasonConditionsDataContract cancelReasonConditions = new CancelReasonConditionsDataContract();
                cancelReasonConditions.AssignID = ac.AsignCourseID;
                cancelReasonConditions.Reason = "";
                CancelReasonConditionsList.Add(cancelReasonConditions);
                CancelReasonConditionsDataContract[] arr = CancelReasonConditionsList.ToArray();
                b = client.CancleAssignCourse(arr, 0, 0, 1);
                result = "取消失败";
            }
            Console.WriteLine("处理成功 {0}",  "*---*" + result);
        }

        private static void Test()
        {
            AssignCourseServiceClient client = new AssignCourseServiceClient();
            List<CancelReasonConditionsDataContract> CancelReasonConditionsList = new List<CancelReasonConditionsDataContract>();
            CancelReasonConditionsDataContract cancelReasonConditions = new CancelReasonConditionsDataContract();
            cancelReasonConditions.AssignID = 16995;
            cancelReasonConditions.Reason = "";
            CancelReasonConditionsList.Add(cancelReasonConditions);
            CancelReasonConditionsDataContract[] arr = CancelReasonConditionsList.ToArray();
            bool b = client.CancleAssignCourse(arr, 0, 0, 1);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
