using PadSYNC.BLL;
using PadSYNC.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Configuration;

namespace PadSYNC.Web.Models
{
    public class JobSearchObject : ITableObject
    {
        public List<JobSearch> GetList(TableObject table)
        {
            string CacheEnable = ConfigurationManager.AppSettings["CacheEnable"];
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<JobSearch>)obj;
            }
            string sqlStr = "select * from JobSearch where BranchID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";
            List<DbParameter> paras = new List<DbParameter>();
            string providerName = ConfigurationManager.ConnectionStrings["CloudOrganization"].ProviderName;
            switch(providerName)
            {
                case "MySql.Data.MySqlClient":
                    paras.Add(new MySqlParameter("BranchID", table.BranchID));
                    paras.Add(new MySqlParameter("SchoolID", table.SchoolID));
                    paras.Add(new MySqlParameter("LastModified", table.LastModifiedDate));
                    break;
                default:
                    paras.Add(new SqlParameter("BranchID", table.BranchID));
                    paras.Add(new SqlParameter("SchoolID", table.SchoolID));
                    paras.Add(new SqlParameter("LastModified", table.LastModified));
                    break;
            }
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
            List<JobSearch> list = JobSearchBLL.Search(sqlStr, paras.ToArray());
            if (list.Count > 0)
            {
                byte[] b = new byte[8];
                if (CacheUtility.GetCollectionKey(table.LastModified) == CacheUtility.GetCollectionKey(b))
                {
                    CacheUtility.Insert(key, list);
                }
                else
                {
                    if (CacheEnable == "true")
                    {
                        CacheUtility.Insert(key, list);
                    }
                }
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<JobSearch> list = GetList(table);
            List<JobSearch> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.ID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<JobSearch> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<JobSearch> list = JsonConvert.DeserializeObject<List<JobSearch>>(data);
            foreach (JobSearch item in list)
            {
                JobSearchBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudOrganization.JobSearch");
        }
    }
}