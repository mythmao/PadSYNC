﻿
using CommonTools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PadSYNC.Web.Filters
{
    public class LogsFilterAttribute : ActionFilterAttribute
    {
        private string logEnable = ConfigurationManager.AppSettings["logEnable"];
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (logEnable == "false")
                return;
            //base.OnActionExecuting(filterContext);
            string actionName = filterContext.ActionDescriptor.ActionName;
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            IDictionary<string, object> dict = filterContext.ActionParameters;
            StringBuilder sb = new StringBuilder();
            foreach (var k in dict)
            {
                sb.Append(k.Key + "=" + k.Value + "&");
            }
            string actionParameter = sb.ToString();
            LogHelper.WriteLog(this.GetType(),controllerName+"/"+actionName+"?"+ sb.ToString());
        }
    }
}