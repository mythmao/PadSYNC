using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PadSYNC.BLL
{
    public class Common
    {
        public static List<string> Opertors = new List<string>() { ">","<",">=","<=","="};
        public static DataTable GetTableData(string database,string tableName,List<string> fields,Dictionary<string,string> dictOperator,Dictionary<string,object> dictFilter)
        {
            DataTable dt = null;
            //过滤字段
            foreach(string f in fields)
            {
                if (f.Trim().Contains(" ")||f.Trim().Contains(";"))
                {
                    return null;
                }
            }
            
            foreach(string key in dictOperator.Keys)
            {
                if(key.Trim().Contains(" ")||key.Trim().Contains(";"))
                {
                    return null;
                }
                if(!Opertors.Contains( dictOperator[key]))
                {
                    return null;
                }
            }
            string sqlStr = "select "+string.Join(",",fields)+" from "+tableName+" where 1=1 ";
            StringBuilder sb = new StringBuilder();
            foreach(var key in dictOperator.Keys)
            {
                sb.Append(" and " + key + dictOperator[key] +"@"+ key);
            }
            sqlStr += sb.ToString();
            List<DbParameter> paras = new List<DbParameter>();
            switch (ConfigurationManager.ConnectionStrings[database].ProviderName)
            {
                case "System.Data.SqlClient":
                    foreach(var key in dictFilter.Keys)
                    {
                        DbParameter para = new SqlParameter(key, dictFilter[key]);
                        paras.Add(para);
                    }
                    break;
                case "MySql.Data.MySqlClient":
                    foreach (var key in dictFilter.Keys)
                    {
                        DbParameter para = new MySqlParameter(key, dictFilter[key]);
                        paras.Add(para);
                    }
                    break;
                default:
                    foreach (var key in dictFilter.Keys)
                    {
                        DbParameter para = new SqlParameter(key, dictFilter[key]);
                        paras.Add(para);
                    }
                    break;
            }
            
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create(database);
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(paras.ToArray());
                DataSet ds = db.ExecuteDataSet(cmd);
                if(ds!=null&&ds.Tables.Count>0)
                {
                    dt = ds.Tables[0];
                }
            }
            return dt;
        }
    }
}
