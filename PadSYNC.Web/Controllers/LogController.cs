using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PadSYNC.Web.Controllers
{
    public class LogController : Controller
    {
        //
        // GET: /Log/

        public ActionResult Index()
        {
            //查看当天日志
            string date = DateTime.Now.ToString("yyyy")+"/"+DateTime.Now.ToString("yyyyMM")+"/"+DateTime.Now.ToString("yyyyMMdd")+".txt";
            string path= Server.MapPath("/log/" + date);
            StringBuilder sb = new StringBuilder();
            string result="";
            using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
            {
                //byte[] buf=new byte[1024];
                //int len=0;
                
                //while((len=fs.Read(buf,0,buf.Length))!=-1)
                //{
                //    sb.Append(System.Text.Encoding.Default.GetString(buf, 0, len));
                //}
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                result = sr.ReadToEnd();
            }
            string fileContent = sb.ToString();
            //string fileContent = System.IO.File.ReadAllText(path,System.Text.Encoding.Default);
            return Content(result);
        }

    }
}
