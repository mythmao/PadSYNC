using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RabbitMQ.Client;
using System.Configuration;
using System.Text;

namespace PadSYNC.Web.Models
{
    public class Send
    {
        public static string hostName = ConfigurationManager.AppSettings["RabbitMQHostName"];
        public static string userName = ConfigurationManager.AppSettings["RabbitMQUserName"];
        public static string password = ConfigurationManager.AppSettings["RabbitMQPassword"];
        public static void Push(string message)
        {
            var factory = new ConnectionFactory() { HostName = hostName, UserName = userName, Password = password };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("AssignCourseSYNC", true, false, false, null);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("", "AssignCourseSYNC", null, body);
                }
            }
        }
    }
}