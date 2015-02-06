using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using PadSYNC.Model;

namespace PadSYNC.BLL
{
    public partial class SYNCOperationBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudCourse");

        public static SYNCOperation GetById(Guid Gid)
        {
            string sqlStr = "select * from SYNCOperation where Gid=@Gid";
            List<SYNCOperation> list = Search(sqlStr, new SqlParameter("Gid", Gid));
            if (list.Count >= 1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }


        public static List<SYNCOperation> Search(string sqlStr, params DbParameter[] parameters)
        {
            List<SYNCOperation> list = new List<SYNCOperation>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        SYNCOperation model = new SYNCOperation(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(SYNCOperation model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            if (model.Gid != null)
            {
                fileds.Add("[Gid]");
                pFileds.Add("@Gid");
                pms.Add(new SqlParameter("Gid", model.Gid));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            if (model.Content != null)
            {
                fileds.Add("[Content]");
                pFileds.Add("@Content");
                pms.Add(new SqlParameter("Content", model.Content));
            }

            if (model.Name != null)
            {
                fileds.Add("[Name]");
                pFileds.Add("@Name");
                pms.Add(new SqlParameter("Name", model.Name));
            }


            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]");
                pFileds.Add("@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }

            if (model.Id != null)
            {
                fileds.Add("[Id]");
                pFileds.Add("@Id");
                pms.Add(new SqlParameter("Id", model.Id));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO SYNCOperation (");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(") values (");
            sb.Append(string.Join(",", pFileds.ToArray()));
            sb.Append(")");
            sqlStr = sb.ToString();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = db.ExecuteNonQuery(cmd);
                return i > 0;
            }
        }

        public static bool Update(SYNCOperation model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[Gid]=@Gid");
            pms.Add(new SqlParameter("Gid", model.Gid));

            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new SqlParameter("Status", model.Status));
            }

            if (model.Content != null)
            {
                fileds.Add("[Content]=@Content");
                pms.Add(new SqlParameter("Content", model.Content));
            }

            if (model.Name != null)
            {
                fileds.Add("[Name]=@Name");
                pms.Add(new SqlParameter("Name", model.Name));
            }

            if (model.InsertDate != null && model.InsertDate != new DateTime())
            {
                fileds.Add("[InsertDate]=@InsertDate");
                pms.Add(new SqlParameter("InsertDate", model.InsertDate));
            }

            if (model.Id != null)
            {
                fileds.Add("[Id]=@Id");
                pms.Add(new SqlParameter("Id", model.Id));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update SYNCOperation set ");
            sb.Append(string.Join(",", fileds.ToArray()));
            sb.Append(" where ");
            sb.Append(string.Join(" and ", pFileds.ToArray()));
            sqlStr = sb.ToString();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = db.ExecuteNonQuery(cmd);
                return i > 0;
            }
        }

        public static bool Save(SYNCOperation model)
        {
            string sqlStr = "select count(1) from SYNCOperation where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
            sqlStr += " and Gid=@Gid ";
            pms.Add(new SqlParameter("Gid", model.Gid));
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = (int)db.ExecuteScalar(cmd);
                if (i > 0)
                {
                    return Update(model);
                }
                else
                {
                    return Insert(model);
                }
            }
        }
    }
}