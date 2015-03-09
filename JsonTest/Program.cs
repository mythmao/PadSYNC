using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using PadSYNC.Model;
using DataSYNC.Web.Models;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string  jsonStr = File.ReadAllText(@"C:\Users\0\Downloads\GetDataInOne.json");
            Console.WriteLine("字符串长度：" +jsonStr.Length);
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<UpdateObject> list = new List<UpdateObject>();
            list = JsonConvert.DeserializeObject<List<UpdateObject>>(jsonStr);

            List<CustomerSearch> cslist = new List<CustomerSearch>();
            cslist = JsonConvert.DeserializeObject<List<CustomerSearch>>(list[0].Data);
            sw.Stop();
            Console.WriteLine("解析用时："+sw.ElapsedMilliseconds+" 毫秒");
            Console.WriteLine("共 "+cslist.Count+" 条数据");
            Console.ReadKey();

            
        }
    }
}
