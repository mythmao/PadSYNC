using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Configuration;

namespace PadSYNC.Web.Models
{
    public class CustomerSearchObject : ITableObject
    {
        
        public List<CustomerSearch> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            string CacheEnable = ConfigurationManager.AppSettings["CacheEnable"];
            object obj = CacheUtility.Get(key);
            //string key1 = "000_000_000_000_000_074_014_085";
            //byte[] b = CacheUtility.GetByteFromString(key1);
            
            if (obj != null)
            {
                return (List<CustomerSearch>)obj;
            }
            string sqlAdd = "";
            if(table.IsValid==1)
            {
                sqlAdd = " AND (TotalCourseAmount>0 OR CommonCourseAmount>0 OR SpecialCourseAmount>0) ";
            }
            string sqlStr = @"select * from CustomerSearch where BranchID=@BranchID and XDSchoolID=@SchoolID and LastModified>@LastModified "+sqlAdd+" order by LastModified desc";
            //AND (TotalCourseAmount>0 OR CommonCourseAmount>0 OR SpecialCourseAmount>0)
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified",table.LastModified));
            if (!string.IsNullOrEmpty(table.StartDate))
            {
                sqlStr += " and OperateTime>@StartDate";
                pms.Add(new SqlParameter("StartDate", table.StartDate));
            }
            if (!string.IsNullOrEmpty(table.EndDate))
            {
                sqlStr += " and OperateTime<@EndDate";
                pms.Add(new SqlParameter("EndDate", table.EndDate));
            }
            List<CustomerSearch> list = CustomerSearchBLL.Search(sqlStr, pms.ToArray());
            if(list.Count>0)
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
            List<CustomerSearch> list = GetList(table);
            List<CustomerSearch> resultList = null;
            if(table.CurPage>0&&table.PageSize>0)
            {
                resultList = list.OrderByDescending(p => p.ID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
            }
            else
            {
                resultList = list.OrderByDescending(p => p.ID).ToList();
            }
            result = CustomJsonConvert.SerializeObject(resultList);
            return result;
        }
        public int GetTotalCount(TableObject table)
        {
            int count = 0;
            List<CustomerSearch> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            throw new NotImplementedException();
        }
    }
}