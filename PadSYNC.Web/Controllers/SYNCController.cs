using DataSYNC.Web.Models;
using Newtonsoft.Json;
using PadSYNC.BLL;
using PadSYNC.Model;
using PadSYNC.Model.AssignCourseServiceReference;
using PadSYNC.Web.Filters;
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
    public class SYNCController : Controller
    {
        //
        // GET: /SYNC/
        public List<string> tableList
        {
            get
            {
                string DataTables = ConfigurationManager.AppSettings["DataTables"];
                return DataTables.Split(',').ToList();
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetDataWithField(string data)
        {
            SYNCObject obj = JsonConvert.DeserializeObject<SYNCObject>(data);
            obj.DictOperator.Add("LastModified", ">");
            obj.DictFilter.Add("LastModified", obj.LastModified);
            DataTable dt = Common.GetTableData(obj.Database, obj.TableName, obj.Fields, obj.DictOperator, obj.DictFilter);
            string json = JsonConvert.SerializeObject(dt);
            return Content(json, "application/json");
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            if (tableList.Contains(table.TableName))
            {
                string className = "PadSYNC.Web.Models." + table.TableName + "Object";
                Type t = Type.GetType(className);
                ITableObject ito = Activator.CreateInstance(t) as ITableObject;
                result = ito.GetTableData(table);
            }
            return result;
        }
        public  int GetTotalCount(TableObject table)
        {
            int  result = 0;
            if (tableList.Contains(table.TableName))
            {
                string className = "PadSYNC.Web.Models." + table.TableName + "Object";
                Type t = Type.GetType(className);
                ITableObject ito = Activator.CreateInstance(t) as ITableObject;
                result = ito.GetTotalCount(table);
            }
            return result;
        }
        [LogsFilterAttribute]
        public ActionResult GetDataInOne(string tables)
        {
            List<UpdateObject> list = new List<UpdateObject>();

            List<TableObject> tb = JsonConvert.DeserializeObject<List<TableObject>>(tables);
            foreach (TableObject t in tb)
            {
                string data = GetTableData(t);
                int count = GetTotalCount(t);
                UpdateObject uo = new UpdateObject();
                uo.TableName = t.TableName;
                uo.Data = data;
                uo.Count = count;
                list.Add(uo);
            }
            string result = JsonConvert.SerializeObject(list);
            return Content(result, "application/json");
        }
        public ActionResult UpdateCourseInOne(string data)
        {
            string result = "Failed";
            try
            {
                List<PadSYNC.Model.AssignCourse> list = JsonConvert.DeserializeObject<List<PadSYNC.Model.AssignCourse>>(data);
                //测试消息队列用
//                List<PadSYNC.Model.AssignCourse> list = AssignCourseBLL.Search(@"select top 5 starttime,endtime,* from [CloudCourse].[dbo].[AssignCourse]
//                where SchoolID=18 and studentuserid=1303839
//                 order by assignid desc");

                if (list != null)
                {
                    foreach (PadSYNC.Model.AssignCourse ac in list)
                    {
                        //ac.Gid = Guid.NewGuid();
                        //新增必须为0，不为0会更改原纪录
                        //ac.AssignID = 0;
                        //排课状态为排定
                        //ac.AsignStatus = 1;
                        //5表示来源是Pad
                        //ac.CourseSourceType = 5;
                        //异常类型
                        //ac.AbnormalReasonType = 0;
                        string json = JsonConvert.SerializeObject(ac);
                        SYNCOperation op = new SYNCOperation();
                        op.Id = ac.AssignID;
                        op.Gid = ac.Gid;
                        op.Name = "AssignCourse";
                        op.Status = 0;
                        SYNCOperationBLL.Insert(op);
                        Send.Push(json);
                        result = "Success";
                    }
                }

            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Content(result);
        }
        public ActionResult UpdateCourse(string data)
        {
            Random r = new Random();
            int x = r.Next(100);
            Send.Push(x.ToString());
            return Content(x.ToString());
            //AssignCourse ac = AssignCourseBLL.GetById(19249005);
            PadSYNC.Model.AssignCourse ac = JsonConvert.DeserializeObject<PadSYNC.Model.AssignCourse>(data);
            ac.AssignID = 0;
            //ac.AsignCourseID = 0;
            ac.AsignStatus = 1;
            ac.CourseSourceType = 5;
            ac.AbnormalReasonType = 0;
            //ac.StartTime = new DateTime(2014, 12, 11, 8, 0, 0);
            //ac.EndTime = new DateTime(2014, 12, 11, 10, 0, 0);
            //ac.AssignCount = 2;
            AssignCourseDataContract acdc = AssignCourseTranslateEntityAndDataContract.TranslateAssignCourseEntityToGuest(ac);
            bool b = false;
            string result = "Failed";
            try
            {
                AssignCourseServiceClient client = new AssignCourseServiceClient();
                //b = client.AddNewAssignCourseRetErrowString(acdc, out result);
                if (b)
                {
                    result = "Success";
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return Content(result, "application/json");
        }

    }
}
