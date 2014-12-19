using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC
{
    public partial class OrderItems
    {
        #region 属性
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  OrderItemId {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  OrderID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  ProductID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  BuyCount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  BasicPrice {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  RealPrice {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  ProductCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  ProductName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  ProductType {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  Grade {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  Subject {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  CourseLevel {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  TimeIntervalType {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  ClassTime {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  ProductGranularity {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  Discount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  STCoupon {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  CouponCount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  CouponTotalMoney {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  STRegularCusDis {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  UseRegularCusDis {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  STDiscount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  ParticularDiscount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  PromotionalAllowance {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  OrderDuration {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  RealCourseCount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  PackageID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  PackageCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  PackageName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  GradeID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  GradeName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Byte[]  LastModified {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  StartDate {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  EndDate {get;set;}
        #endregion
        public OrderItems() { }
        public OrderItems(DataRow dr)
        {
            if (dr.Table.Columns.Contains("OrderItemId"))
            {
               if(dr["OrderItemId"]!=DBNull.Value)
               {
                   this.OrderItemId= (System.Int64)dr["OrderItemId"];
               } 
            }
            if (dr.Table.Columns.Contains("OrderID"))
            {
               if(dr["OrderID"]!=DBNull.Value)
               {
                   this.OrderID= (System.Int64)dr["OrderID"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductID"))
            {
               if(dr["ProductID"]!=DBNull.Value)
               {
                   this.ProductID= (System.Int64)dr["ProductID"];
               } 
            }
            if (dr.Table.Columns.Contains("BuyCount"))
            {
               if(dr["BuyCount"]!=DBNull.Value)
               {
                   this.BuyCount= (System.Decimal)dr["BuyCount"];
               } 
            }
            if (dr.Table.Columns.Contains("BasicPrice"))
            {
               if(dr["BasicPrice"]!=DBNull.Value)
               {
                   this.BasicPrice= (System.Decimal)dr["BasicPrice"];
               } 
            }
            if (dr.Table.Columns.Contains("RealPrice"))
            {
               if(dr["RealPrice"]!=DBNull.Value)
               {
                   this.RealPrice= (System.Decimal)dr["RealPrice"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductCode"))
            {
               if(dr["ProductCode"]!=DBNull.Value)
               {
                   this.ProductCode= (System.String)dr["ProductCode"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductName"))
            {
               if(dr["ProductName"]!=DBNull.Value)
               {
                   this.ProductName= (System.String)dr["ProductName"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductType"))
            {
               if(dr["ProductType"]!=DBNull.Value)
               {
                   this.ProductType= (System.Int32)dr["ProductType"];
               } 
            }
            if (dr.Table.Columns.Contains("Grade"))
            {
               if(dr["Grade"]!=DBNull.Value)
               {
                   this.Grade= (System.Int32)dr["Grade"];
               } 
            }
            if (dr.Table.Columns.Contains("Subject"))
            {
               if(dr["Subject"]!=DBNull.Value)
               {
                   this.Subject= (System.Int32)dr["Subject"];
               } 
            }
            if (dr.Table.Columns.Contains("CourseLevel"))
            {
               if(dr["CourseLevel"]!=DBNull.Value)
               {
                   this.CourseLevel= (System.Int32)dr["CourseLevel"];
               } 
            }
            if (dr.Table.Columns.Contains("TimeIntervalType"))
            {
               if(dr["TimeIntervalType"]!=DBNull.Value)
               {
                   this.TimeIntervalType= (System.Int32)dr["TimeIntervalType"];
               } 
            }
            if (dr.Table.Columns.Contains("ClassTime"))
            {
               if(dr["ClassTime"]!=DBNull.Value)
               {
                   this.ClassTime= (System.Int32)dr["ClassTime"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductGranularity"))
            {
               if(dr["ProductGranularity"]!=DBNull.Value)
               {
                   this.ProductGranularity= (System.Int32)dr["ProductGranularity"];
               } 
            }
            if (dr.Table.Columns.Contains("Discount"))
            {
               if(dr["Discount"]!=DBNull.Value)
               {
                   this.Discount= (System.Decimal)dr["Discount"];
               } 
            }
            if (dr.Table.Columns.Contains("STCoupon"))
            {
               if(dr["STCoupon"]!=DBNull.Value)
               {
                   this.STCoupon= (System.Int32)dr["STCoupon"];
               } 
            }
            if (dr.Table.Columns.Contains("CouponCount"))
            {
               if(dr["CouponCount"]!=DBNull.Value)
               {
                   this.CouponCount= (System.Int32)dr["CouponCount"];
               } 
            }
            if (dr.Table.Columns.Contains("CouponTotalMoney"))
            {
               if(dr["CouponTotalMoney"]!=DBNull.Value)
               {
                   this.CouponTotalMoney= (System.Decimal)dr["CouponTotalMoney"];
               } 
            }
            if (dr.Table.Columns.Contains("STRegularCusDis"))
            {
               if(dr["STRegularCusDis"]!=DBNull.Value)
               {
                   this.STRegularCusDis= (System.Decimal)dr["STRegularCusDis"];
               } 
            }
            if (dr.Table.Columns.Contains("UseRegularCusDis"))
            {
               if(dr["UseRegularCusDis"]!=DBNull.Value)
               {
                   this.UseRegularCusDis= (System.Int32)dr["UseRegularCusDis"];
               } 
            }
            if (dr.Table.Columns.Contains("STDiscount"))
            {
               if(dr["STDiscount"]!=DBNull.Value)
               {
                   this.STDiscount= (System.Int32)dr["STDiscount"];
               } 
            }
            if (dr.Table.Columns.Contains("ParticularDiscount"))
            {
               if(dr["ParticularDiscount"]!=DBNull.Value)
               {
                   this.ParticularDiscount= (System.Decimal)dr["ParticularDiscount"];
               } 
            }
            if (dr.Table.Columns.Contains("PromotionalAllowance"))
            {
               if(dr["PromotionalAllowance"]!=DBNull.Value)
               {
                   this.PromotionalAllowance= (System.Decimal)dr["PromotionalAllowance"];
               } 
            }
            if (dr.Table.Columns.Contains("OrderDuration"))
            {
               if(dr["OrderDuration"]!=DBNull.Value)
               {
                   this.OrderDuration= (System.DateTime)dr["OrderDuration"];
               } 
            }
            if (dr.Table.Columns.Contains("RealCourseCount"))
            {
               if(dr["RealCourseCount"]!=DBNull.Value)
               {
                   this.RealCourseCount= (System.Int32)dr["RealCourseCount"];
               } 
            }
            if (dr.Table.Columns.Contains("PackageID"))
            {
               if(dr["PackageID"]!=DBNull.Value)
               {
                   this.PackageID= (System.Int64)dr["PackageID"];
               } 
            }
            if (dr.Table.Columns.Contains("PackageCode"))
            {
               if(dr["PackageCode"]!=DBNull.Value)
               {
                   this.PackageCode= (System.String)dr["PackageCode"];
               } 
            }
            if (dr.Table.Columns.Contains("PackageName"))
            {
               if(dr["PackageName"]!=DBNull.Value)
               {
                   this.PackageName= (System.String)dr["PackageName"];
               } 
            }
            if (dr.Table.Columns.Contains("GradeID"))
            {
               if(dr["GradeID"]!=DBNull.Value)
               {
                   this.GradeID= (System.Int64)dr["GradeID"];
               } 
            }
            if (dr.Table.Columns.Contains("GradeName"))
            {
               if(dr["GradeName"]!=DBNull.Value)
               {
                   this.GradeName= (System.String)dr["GradeName"];
               } 
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
               if(dr["LastModified"]!=DBNull.Value)
               {
                   this.LastModified= (System.Byte[])dr["LastModified"];
               } 
            }
            if (dr.Table.Columns.Contains("StartDate"))
            {
               if(dr["StartDate"]!=DBNull.Value)
               {
                   this.StartDate= (System.DateTime)dr["StartDate"];
               } 
            }
            if (dr.Table.Columns.Contains("EndDate"))
            {
               if(dr["EndDate"]!=DBNull.Value)
               {
                   this.EndDate= (System.DateTime)dr["EndDate"];
               } 
            }
        }
    }
}