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
        public string GetTableData(TableObject table)
        {
            string result = "";
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
            result = JsonConvert.SerializeObject(list);
            return result;
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