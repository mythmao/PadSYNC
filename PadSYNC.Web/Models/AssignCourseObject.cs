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
        public List<AssignCourse> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<AssignCourse>)obj;
            }
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
            if (list.Count > 0)
            {
                byte[] b = new byte[8];
                if (CacheUtility.GetCollectionKey(table.LastModified) == CacheUtility.GetCollectionKey(b))
                {
                    CacheUtility.Insert(key, list);
                }
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<AssignCourse> list = GetList(table);
            List<AssignCourse> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.AssignID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
            }
            else
            {
                resultList = list;
            }
            result = CustomJsonConvert.SerializeObject(resultList);
            return result;
        }
        public int GetTotalCount(TableObject table)
        {
            int count = 0;
            List<AssignCourse> list = GetList(table);
            count = list.Count;
            return count;
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