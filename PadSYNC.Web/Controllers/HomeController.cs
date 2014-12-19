using Newtonsoft.Json;
using PadSYNC.BLL;
using PadSYNC.Model;
using PadSYNC.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PadSYNC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //string data = "{\"LastModified\":\"AAAAAABVXOI=\"}";
            //TableObject tb = JsonConvert.DeserializeObject<TableObject>(data);
            
            //byte[] b = System.Text.Encoding.UTF8.GetBytes("AAAAAABVXOI=");
            //Dictionary<string, object> dict = new Dictionary<string, object>();
            //string filter = " and LastModified>@LastModified ";
            //dict.Add("LastModified", tb.LastModified);
            //DataTable dt = Common.GetTableData("CloudCustomer", "CustomerSearch", "CustomerUserName,XDSchoolName", filter,dict);
            //string json = JsonConvert.SerializeObject(dt);
            //return Content(json,"application/json");

            //SYNCObject obj = new SYNCObject();
            //obj.Database = "CloudCustomer";
            //obj.TableName = "CustomerSearch";
            //obj.Fields = new List<string>();
            //obj.Fields.Add("*");
            //obj.Fields.Add("XDSchoolName");
            //Dictionary<string, string> oper = new Dictionary<string, string>();
            //oper["LastModified"] = ">";
            //oper["BranchID"] = "=";
            //oper["XDSchoolID"] = "=";
            //obj.DictOperator = oper;

            //Dictionary<string, object> filter = new Dictionary<string, object>();
            //filter["LastModified"] = tb.LastModified;
            //filter["BranchID"] = 8;
            //filter["XDSchoolID"] = 18;
            //obj.DictFilter = filter;

            //string jsono = JsonConvert.SerializeObject(obj);
            
            //DataTable dt= Common.GetTableData(obj.Database, obj.TableName, obj.Fields, obj.DictOperator, obj.DictFilter);
            //string json = JsonConvert.SerializeObject(dt);
            //return Content(json,"application/json");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
