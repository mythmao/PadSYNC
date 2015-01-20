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
    public class PeriodObject : ITableObject
    {
        public List<Period> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<Period>)obj;
            }
            string sqlStr = "";
            byte[] TimeStamp = new byte[8];
            if (CacheUtility.GetCollectionKey(table.LastModified) == CacheUtility.GetCollectionKey(TimeStamp))
            {
                sqlStr = @"select * from [CloudAsset].[dbo].[Period]  where LastModified>@LastModified and AssetID in
(
select AssetID from [CloudAsset].[dbo].[Asset] where [OwnerID]
in(
select CustomerID  FROM [CLOUDCUSTOMER].[CloudCustomer].[dbo].[CustomerSearch] ss where ss.XDSchoolID=@SchoolID

  ))";
                //  AND (SS.TotalCourseAmount>0 OR SS.CommonCourseAmount>0 OR SS.SpecialCourseAmount>0)
            }
            else
            {
                sqlStr = @"  select a.* from [CloudAsset].[dbo].[Period] a 
                  join [dbo].[Asset] b on a.AssetID=b.AssetID where b.SubCompanyID=@BranchID and b.SchoolID=@SchoolID and a.LastModified>@LastModified";
            }

             
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified",table.LastModified));
            if (!string.IsNullOrEmpty(table.StartDate))
            {
                sqlStr += " and AssetCreateDate>@StartDate";
                pms.Add(new SqlParameter("StartDate", table.StartDate));
            }
            if (!string.IsNullOrEmpty(table.EndDate))
            {
                sqlStr += " and AssetCreateDate<@EndDate";
                pms.Add(new SqlParameter("EndDate", table.EndDate));
            }
            List<Period> list = PeriodBLL.Search(sqlStr,pms.ToArray());
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
            List<Period> list = GetList(table);
            List<Period> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.AutoID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<Period> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<Period> list = JsonConvert.DeserializeObject<List<Period>>(data);
            foreach (Period item in list)
            {
                PeriodBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudAsset.dbo.Period");
        }
    }
}