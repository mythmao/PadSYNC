using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisClient client = new RedisClient("127.0.0.1", 6379);
            client.Set<string>("name", "sasha");
            string s = client.Get<string>("name");
            Console.WriteLine(s);

            client.EnqueueItemOnList("name1", "grey");
            client.EnqueueItemOnList("name1", "haha");

            string s2= client.DequeueItemFromList("name1");
            Console.WriteLine(s2);

            
            Console.ReadKey();
        }
    }
}
