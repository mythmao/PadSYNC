using PadSYNC.BLL;
using PadSYNC.Model;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Configuration;

namespace PadSYNC.Web.Models
{
    public class JobSearchObject : ITableObject
    {
        public string GetTableData(TableObject table)
        {
            string result = "";
            string sqlStr = "select * from JobSearch where BranchID=@BranchID and SchoolID=@SchoolID and LastModified>@LastModified";
            List<DbParameter> paras = new List<DbParameter>();
            string providerName = ConfigurationManager.ConnectionStrings["CloudOrganization"].ProviderName;
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
            List<JobSearch> list = JobSearchBLL.Search(sqlStr, paras.ToArray());
            result = CustomJsonConvert.SerializeObject(list);
            return result;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<JobSearch> list = JsonConvert.DeserializeObject<List<JobSearch>>(data);
            foreach (JobSearch item in list)
            {
                JobSearchBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudOrganization.JobSearch");
        }
    }
}