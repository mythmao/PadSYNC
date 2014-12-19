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
    public  partial class PeriodBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudAsset");
        
        
        public static List<Period> Search(string sqlStr,params SqlParameter[] parameters)
        {
            List<Period> list = new List<Period>();
            using(DbCommand cmd=db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if(ds!=null&&ds.Tables.Count>0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        Period model = new Period(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(Period model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            
            
                if(model.AssetID!=null)
                {
                    fileds.Add("[AssetID]");
                    pFileds.Add("@AssetID");
                    pms.Add(new SqlParameter("AssetID", model.AssetID));
                }
            
                if(model.AssortedProductID!=null)
                {
                    fileds.Add("[AssortedProductID]");
                    pFileds.Add("@AssortedProductID");
                    pms.Add(new SqlParameter("AssortedProductID", model.AssortedProductID));
                }
            
                if(model.BaseProductID!=null)
                {
                    fileds.Add("[BaseProductID]");
                    pFileds.Add("@BaseProductID");
                    pms.Add(new SqlParameter("BaseProductID", model.BaseProductID));
                }
            
                if(model.CounterID!=null)
                {
                    fileds.Add("[CounterID]");
                    pFileds.Add("@CounterID");
                    pms.Add(new SqlParameter("CounterID", model.CounterID));
                }
            
                if(model.PurchaseItemID!=null)
                {
                    fileds.Add("[PurchaseItemID]");
                    pFileds.Add("@PurchaseItemID");
                    pms.Add(new SqlParameter("PurchaseItemID", model.PurchaseItemID));
                }
            
                if(model.PurchaseItemDetailID!=null)
                {
                    fileds.Add("[PurchaseItemDetailID]");
                    pFileds.Add("@PurchaseItemDetailID");
                    pms.Add(new SqlParameter("PurchaseItemDetailID", model.PurchaseItemDetailID));
                }
            
                if(model.PurchasePrice!=null)
                {
                    fileds.Add("[PurchasePrice]");
                    pFileds.Add("@PurchasePrice");
                    pms.Add(new SqlParameter("PurchasePrice", model.PurchasePrice));
                }
            
                if(model.StartTimeType!=null)
                {
                    fileds.Add("[StartTimeType]");
                    pFileds.Add("@StartTimeType");
                    pms.Add(new SqlParameter("StartTimeType", model.StartTimeType));
                }
            
                if(model.StartDelayLength!=null)
                {
                    fileds.Add("[StartDelayLength]");
                    pFileds.Add("@StartDelayLength");
                    pms.Add(new SqlParameter("StartDelayLength", model.StartDelayLength));
                }
            
                if(model.EndTimeType!=null)
                {
                    fileds.Add("[EndTimeType]");
                    pFileds.Add("@EndTimeType");
                    pms.Add(new SqlParameter("EndTimeType", model.EndTimeType));
                }
            
                if(model.EndDelayLength!=null)
                {
                    fileds.Add("[EndDelayLength]");
                    pFileds.Add("@EndDelayLength");
                    pms.Add(new SqlParameter("EndDelayLength", model.EndDelayLength));
                }
            
                if(model.RealStartTime!=null&&model.RealStartTime!=new DateTime())
                {
                    fileds.Add("[RealStartTime]");
                    pFileds.Add("@RealStartTime");
                    pms.Add(new SqlParameter("RealStartTime", model.RealStartTime));
                }
            
                if(model.RealEndTime!=null&&model.RealEndTime!=new DateTime())
                {
                    fileds.Add("[RealEndTime]");
                    pFileds.Add("@RealEndTime");
                    pms.Add(new SqlParameter("RealEndTime", model.RealEndTime));
                }
            
                if(model.ReturnCount!=null)
                {
                    fileds.Add("[ReturnCount]");
                    pFileds.Add("@ReturnCount");
                    pms.Add(new SqlParameter("ReturnCount", model.ReturnCount));
                }
            
                if(model.ReturnMoney!=null)
                {
                    fileds.Add("[ReturnMoney]");
                    pFileds.Add("@ReturnMoney");
                    pms.Add(new SqlParameter("ReturnMoney", model.ReturnMoney));
                }
            
                if(model.ReturnTime!=null&&model.ReturnTime!=new DateTime())
                {
                    fileds.Add("[ReturnTime]");
                    pFileds.Add("@ReturnTime");
                    pms.Add(new SqlParameter("ReturnTime", model.ReturnTime));
                }
            
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Period (");
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
        
        public static bool Update(Period model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[AutoID]=@AutoID");
            pms.Add(new SqlParameter("AutoID", model.AutoID));
            
                if(model.AssetID!=null)
                {
                    fileds.Add("[AssetID]=@AssetID");
                    pms.Add(new SqlParameter("AssetID", model.AssetID));
                }
            
                if(model.AssortedProductID!=null)
                {
                    fileds.Add("[AssortedProductID]=@AssortedProductID");
                    pms.Add(new SqlParameter("AssortedProductID", model.AssortedProductID));
                }
            
                if(model.BaseProductID!=null)
                {
                    fileds.Add("[BaseProductID]=@BaseProductID");
                    pms.Add(new SqlParameter("BaseProductID", model.BaseProductID));
                }
            
                if(model.CounterID!=null)
                {
                    fileds.Add("[CounterID]=@CounterID");
                    pms.Add(new SqlParameter("CounterID", model.CounterID));
                }
            
                if(model.PurchaseItemID!=null)
                {
                    fileds.Add("[PurchaseItemID]=@PurchaseItemID");
                    pms.Add(new SqlParameter("PurchaseItemID", model.PurchaseItemID));
                }
            
                if(model.PurchaseItemDetailID!=null)
                {
                    fileds.Add("[PurchaseItemDetailID]=@PurchaseItemDetailID");
                    pms.Add(new SqlParameter("PurchaseItemDetailID", model.PurchaseItemDetailID));
                }
            
                if(model.PurchasePrice!=null)
                {
                    fileds.Add("[PurchasePrice]=@PurchasePrice");
                    pms.Add(new SqlParameter("PurchasePrice", model.PurchasePrice));
                }
            
                if(model.StartTimeType!=null)
                {
                    fileds.Add("[StartTimeType]=@StartTimeType");
                    pms.Add(new SqlParameter("StartTimeType", model.StartTimeType));
                }
            
                if(model.StartDelayLength!=null)
                {
                    fileds.Add("[StartDelayLength]=@StartDelayLength");
                    pms.Add(new SqlParameter("StartDelayLength", model.StartDelayLength));
                }
            
                if(model.EndTimeType!=null)
                {
                    fileds.Add("[EndTimeType]=@EndTimeType");
                    pms.Add(new SqlParameter("EndTimeType", model.EndTimeType));
                }
            
                if(model.EndDelayLength!=null)
                {
                    fileds.Add("[EndDelayLength]=@EndDelayLength");
                    pms.Add(new SqlParameter("EndDelayLength", model.EndDelayLength));
                }
            
                if(model.RealStartTime!=null&&model.RealStartTime!=new DateTime())
                {
                    fileds.Add("[RealStartTime]=@RealStartTime");
                }
            
                if(model.RealEndTime!=null&&model.RealEndTime!=new DateTime())
                {
                    fileds.Add("[RealEndTime]=@RealEndTime");
                }
            
                if(model.ReturnCount!=null)
                {
                    fileds.Add("[ReturnCount]=@ReturnCount");
                    pms.Add(new SqlParameter("ReturnCount", model.ReturnCount));
                }
            
                if(model.ReturnMoney!=null)
                {
                    fileds.Add("[ReturnMoney]=@ReturnMoney");
                    pms.Add(new SqlParameter("ReturnMoney", model.ReturnMoney));
                }
            
                if(model.ReturnTime!=null&&model.ReturnTime!=new DateTime())
                {
                    fileds.Add("[ReturnTime]=@ReturnTime");
                }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Period set ");
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
        
        public static bool Save(Period model)
        {
            string sqlStr="select count(1) from Period where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
                    sqlStr+=" and AutoID=@AutoID ";
                    pms.Add(new SqlParameter("AutoID", model.AutoID));
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i =(int)db.ExecuteScalar(cmd);
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