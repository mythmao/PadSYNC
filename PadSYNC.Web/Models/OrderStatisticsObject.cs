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
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = "select * from OrderStatistics where LastModified>@LastModified";

            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            
            List<OrderStatistics> list = OrderStatisticsBLL.Search(sqlStr, pms.ToArray());
            result = CustomJsonConvert.SerializeObject(list);
            return result;
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