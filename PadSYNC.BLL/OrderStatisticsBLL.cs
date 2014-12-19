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
    public partial class OrderStatisticsBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudTrade");


        public static List<OrderStatistics> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<OrderStatistics> list = new List<OrderStatistics>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        OrderStatistics model = new OrderStatistics(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(OrderStatistics model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段

            if (model.OrderID != null)
            {
                fileds.Add("[OrderID]");
                pFileds.Add("@OrderID");
                pms.Add(new SqlParameter("OrderID", model.OrderID));
            }

            if (model.OrderCode != null)
            {
                fileds.Add("[OrderCode]");
                pFileds.Add("@OrderCode");
                pms.Add(new SqlParameter("OrderCode", model.OrderCode));
            }

            if (model.UnitPrice != null)
            {
                fileds.Add("[UnitPrice]");
                pFileds.Add("@UnitPrice");
                pms.Add(new SqlParameter("UnitPrice", model.UnitPrice));
            }

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]");
                pFileds.Add("@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.Amount != null)
            {
                fileds.Add("[Amount]");
                pFileds.Add("@Amount");
                pms.Add(new SqlParameter("Amount", model.Amount));
            }

            if (model.Used != null)
            {
                fileds.Add("[Used]");
                pFileds.Add("@Used");
                pms.Add(new SqlParameter("Used", model.Used));
            }

            if (model.Scheduling != null)
            {
                fileds.Add("[Scheduling]");
                pFileds.Add("@Scheduling");
                pms.Add(new SqlParameter("Scheduling", model.Scheduling));
            }

            if (model.Unsubscribe != null)
            {
                fileds.Add("[Unsubscribe]");
                pFileds.Add("@Unsubscribe");
                pms.Add(new SqlParameter("Unsubscribe", model.Unsubscribe));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO OrderStatistics (");
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

        public static bool Update(OrderStatistics model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[OrderID]=@OrderID");
            pms.Add(new SqlParameter("OrderID", model.OrderID));

            if (model.OrderCode != null)
            {
                fileds.Add("[OrderCode]=@OrderCode");
                pms.Add(new SqlParameter("OrderCode", model.OrderCode));
            }

            if (model.UnitPrice != null)
            {
                fileds.Add("[UnitPrice]=@UnitPrice");
                pms.Add(new SqlParameter("UnitPrice", model.UnitPrice));
            }

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]=@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.Amount != null)
            {
                fileds.Add("[Amount]=@Amount");
                pms.Add(new SqlParameter("Amount", model.Amount));
            }

            if (model.Used != null)
            {
                fileds.Add("[Used]=@Used");
                pms.Add(new SqlParameter("Used", model.Used));
            }

            if (model.Scheduling != null)
            {
                fileds.Add("[Scheduling]=@Scheduling");
                pms.Add(new SqlParameter("Scheduling", model.Scheduling));
            }

            if (model.Unsubscribe != null)
            {
                fileds.Add("[Unsubscribe]=@Unsubscribe");
                pms.Add(new SqlParameter("Unsubscribe", model.Unsubscribe));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update OrderStatistics set ");
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

        public static bool Save(OrderStatistics model)
        {
            string sqlStr = "select count(1) from OrderStatistics where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
            sqlStr += " and OrderID=@OrderID ";
            pms.Add(new SqlParameter("OrderID", model.OrderID));
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