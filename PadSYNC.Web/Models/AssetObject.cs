using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace PadSYNC.Web.Models
{
    public class AssetObject : ITableObject
    {
        public List<Asset> GetList(TableObject table)
        {
            string CustomerLink = ConfigurationManager.AppSettings["CustomerLink"];
            string CacheEnable = ConfigurationManager.AppSettings["CacheEnable"];
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<Asset>)obj;
            }
            string sqlStr = "";
            byte[] TimeStamp = new byte[8];
            if (CacheUtility.GetCollectionKey(table.LastModified) == CacheUtility.GetCollectionKey(TimeStamp))
            {
                sqlStr = @"select * from Asset where SubCompanyID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified 
and [OwnerID]
in(
select CustomerID  FROM " + CustomerLink + @"[CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=@SchoolID
  
  )";
                //AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)
            }
            else
            {
                sqlStr = @"select * from Asset where SubCompanyID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";
            }
            //[CLOUDCUSTOMER]为链接服务器
//            string sqlStr = @"select * from Asset where SubCompanyID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified 
//and [OwnerID]
//in(
//select CustomerID  FROM [CLOUDCUSTOMER].[CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=@SchoolID
//  AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)
//  )";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            //if (!string.IsNullOrEmpty(table.StartDate))
            //{
            //    sqlStr += " and OperateTime>@StartDate";
            //    pms.Add(new SqlParameter("StartDate", table.StartDate));
            //}
            //if (!string.IsNullOrEmpty(table.EndDate))
            //{
            //    sqlStr += " and OperateTime<@EndDate";
            //    pms.Add(new SqlParameter("EndDate", table.EndDate));
            //}
            List<Asset> list = AssetBLL.Search(sqlStr,pms.ToArray());
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
            List<Asset> list = GetList(table);
            List<Asset> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.AssetID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<Asset> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<Asset> list = JsonConvert.DeserializeObject<List<Asset>>(data);
            foreach (Asset item in list)
            {
                AssetBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudAsset.dbo.Asset");
        }
    }
}