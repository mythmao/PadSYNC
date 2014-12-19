using PadSYNC.BLL;
using PadSYNC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace PadSYNC.Web.Models
{
    public class OrganizationObject : ITableObject
    {
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = "select * from Organization where BranchID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";

            List<MySqlParameter> pms = new List<MySqlParameter>();
            pms.Add(new MySqlParameter("BranchID", table.BranchID));
            pms.Add(new MySqlParameter("SchoolID", table.SchoolID));
            pms.Add(new MySqlParameter("LastModified", table.LastModifiedDate));
            //if (!string.IsNullOrEmpty(table.StartDate))
            //{
            //    sqlStr += " and OperateTime>@StartDate";
            //    pms.Add(new MySqlParameter("StartDate", table.StartDate));
            //}
            //if (!string.IsNullOrEmpty(table.EndDate))
            //{
            //    sqlStr += " and OperateTime<@EndDate";
            //    pms.Add(new MySqlParameter("EndDate", table.EndDate));
            //}
            List<Organization> list = OrganizationBLL.Search(sqlStr, pms.ToArray());
            result = CustomJsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<Organization> list = JsonConvert.DeserializeObject<List<Organization>>(data);
            foreach (Organization item in list)
            {
                OrganizationBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudOrganization.Organization");
        }
    }
}