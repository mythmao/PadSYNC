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
    public class OrderStatisticsObject : ITableObject
    {
        public List<OrderStatistics> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<OrderStatistics>)obj;
            }
            string sqlStr = "select * from OrderStatistics where LastModified>@LastModified";

            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            
            List<OrderStatistics> list = OrderStatisticsBLL.Search(sqlStr, pms.ToArray());
            if (list.Count > 0)
            {
                CacheUtility.Insert(key, list);
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<OrderStatistics> list = GetList(table);
            List<OrderStatistics> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.OrderID).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<OrderStatistics> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<OrderStatistics> list = JsonConvert.DeserializeObject<List<OrderStatistics>>(data);
            foreach (OrderStatistics item in list)
            {
                OrderStatisticsBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudTrade.dbo.OrderStatistics");
        }
    }
}