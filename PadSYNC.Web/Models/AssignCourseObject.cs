using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PadSYNC.Web.Models
{
    public class AssignCourseObject : ITableObject
    {
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = "select * from AssignCourse where CompanyID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            if (!string.IsNullOrEmpty(table.StartDate))
            {
                sqlStr += " and StartTime>@StartDate";
                pms.Add(new SqlParameter("StartDate", table.StartDate));
            }
            if (!string.IsNullOrEmpty(table.EndDate))
            {
                sqlStr += " and StartTime<@EndDate";
                pms.Add(new SqlParameter("EndDate", table.EndDate));
            }
            List<AssignCourse> list = AssignCourseBLL.Search(sqlStr,pms.ToArray());
            result = CustomJsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<AssignCourse> list = JsonConvert.DeserializeObject<List<AssignCourse>>(data);
            foreach (AssignCourse item in list)
            {
                AssignCourseBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudCourse.dbo.AssignCourse");
        }
    }
}