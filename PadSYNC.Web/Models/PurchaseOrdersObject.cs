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
    public class PurchaseOrdersObject : ITableObject
    {
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = "select * from PurchaseOrders where CompanyID=@BranchID and SchoolID= @SchoolID and LastModified>@LastModified";

            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            if (!string.IsNullOrEmpty(table.StartDate))
            {
                sqlStr += " and [LastModifiedDate]>@StartDate";
                pms.Add(new SqlParameter("StartDate", table.StartDate));
            }
            if (!string.IsNullOrEmpty(table.EndDate))
            {
                sqlStr += " and [LastModifiedDate]<@EndDate";
                pms.Add(new SqlParameter("EndDate", table.EndDate));
            }
            List<PurchaseOrders> list = PurchaseOrdersBLL.Search(sqlStr, pms.ToArray());
            result = CustomJsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<PurchaseOrders> list = JsonConvert.DeserializeObject<List<PurchaseOrders>>(data);
            foreach (PurchaseOrders item in list)
            {
                PurchaseOrdersBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudTrade.dbo.PurchaseOrders");
        }
    }
}