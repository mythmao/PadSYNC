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
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = @"  select * from [CloudAsset].[dbo].[Period] a 
  join [dbo].[Asset] b on a.AssetID=b.AssetID where b.SubCompanyID=@BranchID and b.SchoolID=@SchoolID and a.LastModified>@LastModified";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("BranchID", table.BranchID));
            pms.Add(new SqlParameter("SchoolID", table.SchoolID));
            pms.Add(new SqlParameter("LastModified", table.LastModified));
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
            result = CustomJsonConvert.SerializeObject(list);
            return result;
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