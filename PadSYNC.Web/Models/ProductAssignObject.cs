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
    public class ProductAssignObject : ITableObject
    {
        public List<ProductAssign> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<ProductAssign>)obj;
            }
            string sqlStr = "select * from ProductAssign where LastModified>@LastModified";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            //pms.Add(new SqlParameter("BranchID", table.BranchID));
            //pms.Add(new SqlParameter("SchoolID", table.SchoolID));
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
            List<ProductAssign> list = ProductAssignBLL.Search(sqlStr,pms.ToArray());
            if (list.Count > 0)
            {
                CacheUtility.Insert(key, list);
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<ProductAssign> list = GetList(table);
            List<ProductAssign> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.ProductAssignID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<ProductAssign> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<ProductAssign> list = JsonConvert.DeserializeObject<List<ProductAssign>>(data);
            foreach (ProductAssign item in list)
            {
                ProductAssignBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudAsset.dbo.ProductAssign");
        }
    }
}