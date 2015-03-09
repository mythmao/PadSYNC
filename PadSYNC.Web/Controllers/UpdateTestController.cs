using Newtonsoft.Json;
using PadSYNC.BLL;
using PadSYNC.Model;
using PadSYNC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PadSYNC.Web.Controllers
{
    public class UpdateTestController : Controller
    {
        //
        // GET: /UpdateTest/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Upadate(long AssignID)
        {
            PadSYNC.Model.AssignCourse ac = PadSYNC.BLL.AssignCourseBLL.GetById(AssignID);
            try
            {
                ac.Gid = Guid.NewGuid();
                //新增必须为0，不为0会更改原纪录
                ac.AssignID = 0;
                //排课状态为排定
                ac.AsignStatus = 1;
                //5表示来源是Pad
                ac.CourseSourceType = 5;
                //异常类型
                ac.AbnormalReasonType = 0;
                string json = JsonConvert.SerializeObject(ac);
                SYNCOperation op = new SYNCOperation();
                op.Id = ac.AssignID;
                op.Gid = ac.Gid;
                op.Name = "AssignCourse";
                op.Status = 0;
                SYNCOperationBLL.Insert(op);
                Send.Push(json);
                string result = "Success";
                return Content(result, "application/json");
            }
            catch (Exception ex)
            {
                return Content(ex.Message, "application/json");
            }
            
            //return View();
        }
    }
}
