using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PadSYNC.Web.Models
{
    public class OrganizationObject : ITableObject
    {
        public List<Organization> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<Organization>)obj;
            }
            string sqlStr = "select * from Organization where BranchID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";

            List<MySqlParameter> pms = new List<MySqlParameter>();
            pms.Add(new MySqlParameter("BranchID", table.BranchID));
            pms.Add(new MySqlParameter("SchoolID", table.SchoolID));
            pms.Add(new MySqlParameter("LastModified", table.LastModifiedDate));
            //if (!string.IsNullOrEmpty(table.StartDate))
            //{
            //    sqlStr += " and OperateTime>@StartDate";
            //    pms.Add(new MySqlParameter("StartDate", table.StartDate));
            //}
            //if (!string.IsNullOrEmpty(table.EndDate))
            //{
            //    sqlStr += " and OperateTime<@EndDate";
            //    pms.Add(new MySqlParameter("EndDate", table.EndDate));
            //}
            List<Organization> list = OrganizationBLL.Search(sqlStr, pms.ToArray());
            if (list.Count > 0)
            {
                CacheUtility.Insert(key, list);
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<Organization> list = GetList(table);
            List<Organization> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.OrgID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<Organization> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<Organization> list = JsonConvert.DeserializeObject<List<Organization>>(data);
            foreach (Organization item in list)
            {
                OrganizationBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudOrganization.Organization");
        }
    }
}