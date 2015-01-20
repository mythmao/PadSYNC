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
    public class SYNCOperationObject : ITableObject
    {
        public List<SYNCOperation> GetList(TableObject table)
        {
            string key = CacheUtility.GetKey(table);
            object obj = CacheUtility.Get(key);
            if (obj != null)
            {
                return (List<SYNCOperation>)obj;
            }
            string sqlStr = "select * from SYNCOperation where LastModified>@LastModified";
            
            List<SqlParameter> pms = new List<SqlParameter>();
            pms.Add(new SqlParameter("LastModified", table.LastModified));
            List<SYNCOperation> list = SYNCOperationBLL.Search(sqlStr,pms.ToArray());
            if (list.Count > 0)
            {
                byte[] b = new byte[8];
                if (CacheUtility.GetCollectionKey(table.LastModified) == CacheUtility.GetCollectionKey(b))
                {
                    CacheUtility.Insert(key, list);
                }
            }
            return list;
        }
        public string GetTableData(TableObject table)
        {
            string result = "";
            List<SYNCOperation> list = GetList(table);
            List<SYNCOperation> resultList = null;
            if (table.CurPage > 0 && table.PageSize > 0)
            {
                resultList = list.OrderByDescending(p => p.Gid).Skip((table.CurPage - 1) * table.PageSize).Take(table.PageSize).ToList();
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
            List<SYNCOperation> list = GetList(table);
            count = list.Count;
            return count;
        }
        public void UpdateTable(string tableName, string data)
        {
            List<SYNCOperation> list = JsonConvert.DeserializeObject<List<SYNCOperation>>(data);
            foreach (SYNCOperation item in list)
            {
                SYNCOperationBLL.Save(item);
            };
            //Common.UpdateTableVersion("CloudCourse.dbo.SYNCOperation");
        }
    }
}