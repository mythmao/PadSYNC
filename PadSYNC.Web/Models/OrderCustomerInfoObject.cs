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
    public class OrderCustomerInfoObject : ITableObject
    {
        public List<OrderCustomerInfo> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<OrderCustomerInfo>)obj;
            }
            string sqlStr = "select * from OrderCustomerInfo where SchoolID=@SchoolID and LastModified>@LastModified";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            //pms.Add(new SqlParameter("BranchID", table.BranchID));
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
            List<OrderCustomerInfo> list = OrderCustomerInfoBLL.Search(sqlStr,pms.ToArray());
            if (list.Count > 0)
            {
                CacheUtility.Insert(key, list);
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<OrderCustomerInfo> list = GetList(table);
            List<OrderCustomerInfo> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.OrderCustomerInfoID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<OrderCustomerInfo> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<OrderCustomerInfo> list = JsonConvert.DeserializeObject<List<OrderCustomerInfo>>(data);
            foreach (OrderCustomerInfo item in list)
            {
                OrderCustomerInfoBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudTrade.dbo.OrderCustomerInfo");
        }
    }
}