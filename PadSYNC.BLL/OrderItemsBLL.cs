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
    public  partial class OrderItemsBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudTrade");
        
        public static OrderItems GetById(Int64 OrderItemId)
        {
            string sqlStr = "select * from OrderItems where OrderItemId=@OrderItemId";
            List<OrderItems> list = Search(sqlStr, new SqlParameter("OrderItemId", OrderItemId));
            if(list.Count>=1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        
        
        public static List<OrderItems> Search(string sqlStr,params DbParameter[] parameters)
        {
            List<OrderItems> list = new List<OrderItems>();
            using(DbCommand cmd=db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if(ds!=null&&ds.Tables.Count>0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        OrderItems model = new OrderItems(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(OrderItems model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            
            
                if(model.OrderID!=null)
                {
                    fileds.Add("[OrderID]");
                    pFileds.Add("@OrderID");
                    pms.Add(new SqlParameter("OrderID", model.OrderID));
                }
            
                if(model.ProductID!=null)
                {
                    fileds.Add("[ProductID]");
                    pFileds.Add("@ProductID");
                    pms.Add(new SqlParameter("ProductID", model.ProductID));
                }
            
                if(model.BuyCount!=null)
                {
                    fileds.Add("[BuyCount]");
                    pFileds.Add("@BuyCount");
                    pms.Add(new SqlParameter("BuyCount", model.BuyCount));
                }
            
                if(model.BasicPrice!=null)
                {
                    fileds.Add("[BasicPrice]");
                    pFileds.Add("@BasicPrice");
                    pms.Add(new SqlParameter("BasicPrice", model.BasicPrice));
                }
            
                if(model.RealPrice!=null)
                {
                    fileds.Add("[RealPrice]");
                    pFileds.Add("@RealPrice");
                    pms.Add(new SqlParameter("RealPrice", model.RealPrice));
                }
            
                if(model.ProductCode!=null)
                {
                    fileds.Add("[ProductCode]");
                    pFileds.Add("@ProductCode");
                    pms.Add(new SqlParameter("ProductCode", model.ProductCode));
                }
            
                if(model.ProductName!=null)
                {
                    fileds.Add("[ProductName]");
                    pFileds.Add("@ProductName");
                    pms.Add(new SqlParameter("ProductName", model.ProductName));
                }
            
                if(model.ProductType!=null)
                {
                    fileds.Add("[ProductType]");
                    pFileds.Add("@ProductType");
                    pms.Add(new SqlParameter("ProductType", model.ProductType));
                }
            
                if(model.Grade!=null)
                {
                    fileds.Add("[Grade]");
                    pFileds.Add("@Grade");
                    pms.Add(new SqlParameter("Grade", model.Grade));
                }
            
                if(model.Subject!=null)
                {
                    fileds.Add("[Subject]");
                    pFileds.Add("@Subject");
                    pms.Add(new SqlParameter("Subject", model.Subject));
                }
            
                if(model.CourseLevel!=null)
                {
                    fileds.Add("[CourseLevel]");
                    pFileds.Add("@CourseLevel");
                    pms.Add(new SqlParameter("CourseLevel", model.CourseLevel));
                }
            
                if(model.TimeIntervalType!=null)
                {
                    fileds.Add("[TimeIntervalType]");
                    pFileds.Add("@TimeIntervalType");
                    pms.Add(new SqlParameter("TimeIntervalType", model.TimeIntervalType));
                }
            
                if(model.ClassTime!=null)
                {
                    fileds.Add("[ClassTime]");
                    pFileds.Add("@ClassTime");
                    pms.Add(new SqlParameter("ClassTime", model.ClassTime));
                }
            
                if(model.ProductGranularity!=null)
                {
                    fileds.Add("[ProductGranularity]");
                    pFileds.Add("@ProductGranularity");
                    pms.Add(new SqlParameter("ProductGranularity", model.ProductGranularity));
                }
            
                if(model.Discount!=null)
                {
                    fileds.Add("[Discount]");
                    pFileds.Add("@Discount");
                    pms.Add(new SqlParameter("Discount", model.Discount));
                }
            
                if(model.STCoupon!=null)
                {
                    fileds.Add("[STCoupon]");
                    pFileds.Add("@STCoupon");
                    pms.Add(new SqlParameter("STCoupon", model.STCoupon));
                }
            
                if(model.CouponCount!=null)
                {
                    fileds.Add("[CouponCount]");
                    pFileds.Add("@CouponCount");
                    pms.Add(new SqlParameter("CouponCount", model.CouponCount));
                }
            
                if(model.CouponTotalMoney!=null)
                {
                    fileds.Add("[CouponTotalMoney]");
                    pFileds.Add("@CouponTotalMoney");
                    pms.Add(new SqlParameter("CouponTotalMoney", model.CouponTotalMoney));
                }
            
                if(model.STRegularCusDis!=null)
                {
                    fileds.Add("[STRegularCusDis]");
                    pFileds.Add("@STRegularCusDis");
                    pms.Add(new SqlParameter("STRegularCusDis", model.STRegularCusDis));
                }
            
                if(model.UseRegularCusDis!=null)
                {
                    fileds.Add("[UseRegularCusDis]");
                    pFileds.Add("@UseRegularCusDis");
                    pms.Add(new SqlParameter("UseRegularCusDis", model.UseRegularCusDis));
                }
            
                if(model.STDiscount!=null)
                {
                    fileds.Add("[STDiscount]");
                    pFileds.Add("@STDiscount");
                    pms.Add(new SqlParameter("STDiscount", model.STDiscount));
                }
            
                if(model.ParticularDiscount!=null)
                {
                    fileds.Add("[ParticularDiscount]");
                    pFileds.Add("@ParticularDiscount");
                    pms.Add(new SqlParameter("ParticularDiscount", model.ParticularDiscount));
                }
            
                if(model.PromotionalAllowance!=null)
                {
                    fileds.Add("[PromotionalAllowance]");
                    pFileds.Add("@PromotionalAllowance");
                    pms.Add(new SqlParameter("PromotionalAllowance", model.PromotionalAllowance));
                }
            
                if(model.OrderDuration!=null&&model.OrderDuration!=new DateTime())
                {
                    fileds.Add("[OrderDuration]");
                    pFileds.Add("@OrderDuration");
                    pms.Add(new SqlParameter("OrderDuration", model.OrderDuration));
                }
            
                if(model.RealCourseCount!=null)
                {
                    fileds.Add("[RealCourseCount]");
                    pFileds.Add("@RealCourseCount");
                    pms.Add(new SqlParameter("RealCourseCount", model.RealCourseCount));
                }
            
                if(model.PackageID!=null)
                {
                    fileds.Add("[PackageID]");
                    pFileds.Add("@PackageID");
                    pms.Add(new SqlParameter("PackageID", model.PackageID));
                }
            
                if(model.PackageCode!=null)
                {
                    fileds.Add("[PackageCode]");
                    pFileds.Add("@PackageCode");
                    pms.Add(new SqlParameter("PackageCode", model.PackageCode));
                }
            
                if(model.PackageName!=null)
                {
                    fileds.Add("[PackageName]");
                    pFileds.Add("@PackageName");
                    pms.Add(new SqlParameter("PackageName", model.PackageName));
                }
            
                if(model.GradeID!=null)
                {
                    fileds.Add("[GradeID]");
                    pFileds.Add("@GradeID");
                    pms.Add(new SqlParameter("GradeID", model.GradeID));
                }
            
                if(model.GradeName!=null)
                {
                    fileds.Add("[GradeName]");
                    pFileds.Add("@GradeName");
                    pms.Add(new SqlParameter("GradeName", model.GradeName));
                }
            
            
                if(model.StartDate!=null&&model.StartDate!=new DateTime())
                {
                    fileds.Add("[StartDate]");
                    pFileds.Add("@StartDate");
                    pms.Add(new SqlParameter("StartDate", model.StartDate));
                }
            
                if(model.EndDate!=null&&model.EndDate!=new DateTime())
                {
                    fileds.Add("[EndDate]");
                    pFileds.Add("@EndDate");
                    pms.Add(new SqlParameter("EndDate", model.EndDate));
                }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO OrderItems (");
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
        
        public static bool Update(OrderItems model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[OrderItemId]=@OrderItemId");
            pms.Add(new SqlParameter("OrderItemId", model.OrderItemId));
            
                if(model.OrderID!=null)
                {
                    fileds.Add("[OrderID]=@OrderID");
                    pms.Add(new SqlParameter("OrderID", model.OrderID));
                }
            
                if(model.ProductID!=null)
                {
                    fileds.Add("[ProductID]=@ProductID");
                    pms.Add(new SqlParameter("ProductID", model.ProductID));
                }
            
                if(model.BuyCount!=null)
                {
                    fileds.Add("[BuyCount]=@BuyCount");
                    pms.Add(new SqlParameter("BuyCount", model.BuyCount));
                }
            
                if(model.BasicPrice!=null)
                {
                    fileds.Add("[BasicPrice]=@BasicPrice");
                    pms.Add(new SqlParameter("BasicPrice", model.BasicPrice));
                }
            
                if(model.RealPrice!=null)
                {
                    fileds.Add("[RealPrice]=@RealPrice");
                    pms.Add(new SqlParameter("RealPrice", model.RealPrice));
                }
            
                if(model.ProductCode!=null)
                {
                    fileds.Add("[ProductCode]=@ProductCode");
                    pms.Add(new SqlParameter("ProductCode", model.ProductCode));
                }
            
                if(model.ProductName!=null)
                {
                    fileds.Add("[ProductName]=@ProductName");
                    pms.Add(new SqlParameter("ProductName", model.ProductName));
                }
            
                if(model.ProductType!=null)
                {
                    fileds.Add("[ProductType]=@ProductType");
                    pms.Add(new SqlParameter("ProductType", model.ProductType));
                }
            
                if(model.Grade!=null)
                {
                    fileds.Add("[Grade]=@Grade");
                    pms.Add(new SqlParameter("Grade", model.Grade));
                }
            
                if(model.Subject!=null)
                {
                    fileds.Add("[Subject]=@Subject");
                    pms.Add(new SqlParameter("Subject", model.Subject));
                }
            
                if(model.CourseLevel!=null)
                {
                    fileds.Add("[CourseLevel]=@CourseLevel");
                    pms.Add(new SqlParameter("CourseLevel", model.CourseLevel));
                }
            
                if(model.TimeIntervalType!=null)
                {
                    fileds.Add("[TimeIntervalType]=@TimeIntervalType");
                    pms.Add(new SqlParameter("TimeIntervalType", model.TimeIntervalType));
                }
            
                if(model.ClassTime!=null)
                {
                    fileds.Add("[ClassTime]=@ClassTime");
                    pms.Add(new SqlParameter("ClassTime", model.ClassTime));
                }
            
                if(model.ProductGranularity!=null)
                {
                    fileds.Add("[ProductGranularity]=@ProductGranularity");
                    pms.Add(new SqlParameter("ProductGranularity", model.ProductGranularity));
                }
            
                if(model.Discount!=null)
                {
                    fileds.Add("[Discount]=@Discount");
                    pms.Add(new SqlParameter("Discount", model.Discount));
                }
            
                if(model.STCoupon!=null)
                {
                    fileds.Add("[STCoupon]=@STCoupon");
                    pms.Add(new SqlParameter("STCoupon", model.STCoupon));
                }
            
                if(model.CouponCount!=null)
                {
                    fileds.Add("[CouponCount]=@CouponCount");
                    pms.Add(new SqlParameter("CouponCount", model.CouponCount));
                }
            
                if(model.CouponTotalMoney!=null)
                {
                    fileds.Add("[CouponTotalMoney]=@CouponTotalMoney");
                    pms.Add(new SqlParameter("CouponTotalMoney", model.CouponTotalMoney));
                }
            
                if(model.STRegularCusDis!=null)
                {
                    fileds.Add("[STRegularCusDis]=@STRegularCusDis");
                    pms.Add(new SqlParameter("STRegularCusDis", model.STRegularCusDis));
                }
            
                if(model.UseRegularCusDis!=null)
                {
                    fileds.Add("[UseRegularCusDis]=@UseRegularCusDis");
                    pms.Add(new SqlParameter("UseRegularCusDis", model.UseRegularCusDis));
                }
            
                if(model.STDiscount!=null)
                {
                    fileds.Add("[STDiscount]=@STDiscount");
                    pms.Add(new SqlParameter("STDiscount", model.STDiscount));
                }
            
                if(model.ParticularDiscount!=null)
                {
                    fileds.Add("[ParticularDiscount]=@ParticularDiscount");
                    pms.Add(new SqlParameter("ParticularDiscount", model.ParticularDiscount));
                }
            
                if(model.PromotionalAllowance!=null)
                {
                    fileds.Add("[PromotionalAllowance]=@PromotionalAllowance");
                    pms.Add(new SqlParameter("PromotionalAllowance", model.PromotionalAllowance));
                }
            
                if(model.OrderDuration!=null&&model.OrderDuration!=new DateTime())
                {
                    fileds.Add("[OrderDuration]=@OrderDuration");
                }
            
                if(model.RealCourseCount!=null)
                {
                    fileds.Add("[RealCourseCount]=@RealCourseCount");
                    pms.Add(new SqlParameter("RealCourseCount", model.RealCourseCount));
                }
            
                if(model.PackageID!=null)
                {
                    fileds.Add("[PackageID]=@PackageID");
                    pms.Add(new SqlParameter("PackageID", model.PackageID));
                }
            
                if(model.PackageCode!=null)
                {
                    fileds.Add("[PackageCode]=@PackageCode");
                    pms.Add(new SqlParameter("PackageCode", model.PackageCode));
                }
            
                if(model.PackageName!=null)
                {
                    fileds.Add("[PackageName]=@PackageName");
                    pms.Add(new SqlParameter("PackageName", model.PackageName));
                }
            
                if(model.GradeID!=null)
                {
                    fileds.Add("[GradeID]=@GradeID");
                    pms.Add(new SqlParameter("GradeID", model.GradeID));
                }
            
                if(model.GradeName!=null)
                {
                    fileds.Add("[GradeName]=@GradeName");
                    pms.Add(new SqlParameter("GradeName", model.GradeName));
                }
            
                if(model.StartDate!=null&&model.StartDate!=new DateTime())
                {
                    fileds.Add("[StartDate]=@StartDate");
                }
            
                if(model.EndDate!=null&&model.EndDate!=new DateTime())
                {
                    fileds.Add("[EndDate]=@EndDate");
                }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update OrderItems set ");
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
        
        public static bool Save(OrderItems model)
        {
            string sqlStr="select count(1) from OrderItems where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
                    sqlStr+=" and OrderItemId=@OrderItemId ";
                    pms.Add(new SqlParameter("OrderItemId", model.OrderItemId));
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