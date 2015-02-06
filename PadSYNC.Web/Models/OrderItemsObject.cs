using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PadSYNC.Web.Models
{
    public class OrderItemsObject : ITableObject
    {
        public List<OrderItems> GetList(TableObject table)
        {
            string CacheEnable = ConfigurationManager.AppSettings["CacheEnable"];
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<OrderItems>)obj;
            }
            string sqlStr = "select * from OrderItems where LastModified>@LastModified";
            List<DbParameter> paras = new List<DbParameter>();
            string providerName = ConfigurationManager.ConnectionStrings["CloudTrade"].ProviderName;
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
           
            List<OrderItems> list = OrderItemsBLL.Search(sqlStr,paras.ToArray());
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
            List<OrderItems> list = GetList(table);
            List<OrderItems> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.OrderItemId).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<OrderItems> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<OrderItems> list = JsonConvert.DeserializeObject<List<OrderItems>>(data);
            foreach (OrderItems item in list)
            {
                OrderItemsBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudTrade.dbo.OrderItems");
        }
    }
}