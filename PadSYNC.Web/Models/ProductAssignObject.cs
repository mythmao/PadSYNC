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
        public string GetTableData(TableObject table)
        {
            string result = "";
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
            result = CustomJsonConvert.SerializeObject(list);
            return result;
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