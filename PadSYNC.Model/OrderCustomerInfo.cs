using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class OrderCustomerInfo
    {
        #region 属性
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  OrderCustomerInfoID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  OrderID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  SignUserID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SignUserName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  SchoolID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SchoolName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SchoolPhone {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SchoolAddress {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  LeagleOwner {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  CustomerID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerIDCard {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerCellPhone {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerPhone {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerAddress {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  Province {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  City {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  County {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  AddressDetail {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerPostCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CustomerEmail {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Boolean  IsPrimary {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  StudentID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  StudentCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  StudentName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  StudentSex {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  StudentBirthday {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  StudentSchoolName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  StudentGrade {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  ParentRole {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  StudentRole {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  LastModifiedDate {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  OrderCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  DepID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  DepName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Byte  CustomerIDCardType {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SignUserStaffCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  StudentIDCard {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  ClassPermitCode {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Boolean  CustomerAddressFinished {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  CompanyName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int32  StudentType {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  TeachingPlaceName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  InquiryPlaceName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.String  SignUserJobName {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Byte[]  LastModified {get;set;}
        #endregion
        public OrderCustomerInfo() { }
        public OrderCustomerInfo(DataRow dr)
        {
            if (dr.Table.Columns.Contains("OrderCustomerInfoID"))
            {
               if(dr["OrderCustomerInfoID"]!=DBNull.Value)
               {
                   this.OrderCustomerInfoID= (System.Int64)dr["OrderCustomerInfoID"];
               } 
            }
            if (dr.Table.Columns.Contains("OrderID"))
            {
               if(dr["OrderID"]!=DBNull.Value)
               {
                   this.OrderID= (System.Int64)dr["OrderID"];
               } 
            }
            if (dr.Table.Columns.Contains("SignUserID"))
            {
               if(dr["SignUserID"]!=DBNull.Value)
               {
                   this.SignUserID= (System.Int64)dr["SignUserID"];
               } 
            }
            if (dr.Table.Columns.Contains("SignUserName"))
            {
               if(dr["SignUserName"]!=DBNull.Value)
               {
                   this.SignUserName= (System.String)dr["SignUserName"];
               } 
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
               if(dr["SchoolID"]!=DBNull.Value)
               {
                   this.SchoolID= (System.Int32)dr["SchoolID"];
               } 
            }
            if (dr.Table.Columns.Contains("SchoolName"))
            {
               if(dr["SchoolName"]!=DBNull.Value)
               {
                   this.SchoolName= (System.String)dr["SchoolName"];
               } 
            }
            if (dr.Table.Columns.Contains("SchoolPhone"))
            {
               if(dr["SchoolPhone"]!=DBNull.Value)
               {
                   this.SchoolPhone= (System.String)dr["SchoolPhone"];
               } 
            }
            if (dr.Table.Columns.Contains("SchoolAddress"))
            {
               if(dr["SchoolAddress"]!=DBNull.Value)
               {
                   this.SchoolAddress= (System.String)dr["SchoolAddress"];
               } 
            }
            if (dr.Table.Columns.Contains("LeagleOwner"))
            {
               if(dr["LeagleOwner"]!=DBNull.Value)
               {
                   this.LeagleOwner= (System.String)dr["LeagleOwner"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerID"))
            {
               if(dr["CustomerID"]!=DBNull.Value)
               {
                   this.CustomerID= (System.Int64)dr["CustomerID"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerName"))
            {
               if(dr["CustomerName"]!=DBNull.Value)
               {
                   this.CustomerName= (System.String)dr["CustomerName"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerCode"))
            {
               if(dr["CustomerCode"]!=DBNull.Value)
               {
                   this.CustomerCode= (System.String)dr["CustomerCode"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerIDCard"))
            {
               if(dr["CustomerIDCard"]!=DBNull.Value)
               {
                   this.CustomerIDCard= (System.String)dr["CustomerIDCard"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerCellPhone"))
            {
               if(dr["CustomerCellPhone"]!=DBNull.Value)
               {
                   this.CustomerCellPhone= (System.String)dr["CustomerCellPhone"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerPhone"))
            {
               if(dr["CustomerPhone"]!=DBNull.Value)
               {
                   this.CustomerPhone= (System.String)dr["CustomerPhone"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerAddress"))
            {
               if(dr["CustomerAddress"]!=DBNull.Value)
               {
                   this.CustomerAddress= (System.String)dr["CustomerAddress"];
               } 
            }
            if (dr.Table.Columns.Contains("Province"))
            {
               if(dr["Province"]!=DBNull.Value)
               {
                   this.Province= (System.Int32)dr["Province"];
               } 
            }
            if (dr.Table.Columns.Contains("City"))
            {
               if(dr["City"]!=DBNull.Value)
               {
                   this.City= (System.Int32)dr["City"];
               } 
            }
            if (dr.Table.Columns.Contains("County"))
            {
               if(dr["County"]!=DBNull.Value)
               {
                   this.County= (System.Int32)dr["County"];
               } 
            }
            if (dr.Table.Columns.Contains("AddressDetail"))
            {
               if(dr["AddressDetail"]!=DBNull.Value)
               {
                   this.AddressDetail= (System.String)dr["AddressDetail"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerPostCode"))
            {
               if(dr["CustomerPostCode"]!=DBNull.Value)
               {
                   this.CustomerPostCode= (System.String)dr["CustomerPostCode"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerEmail"))
            {
               if(dr["CustomerEmail"]!=DBNull.Value)
               {
                   this.CustomerEmail= (System.String)dr["CustomerEmail"];
               } 
            }
            if (dr.Table.Columns.Contains("IsPrimary"))
            {
               if(dr["IsPrimary"]!=DBNull.Value)
               {
                   this.IsPrimary= (System.Boolean)dr["IsPrimary"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentID"))
            {
               if(dr["StudentID"]!=DBNull.Value)
               {
                   this.StudentID= (System.Int64)dr["StudentID"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentCode"))
            {
               if(dr["StudentCode"]!=DBNull.Value)
               {
                   this.StudentCode= (System.String)dr["StudentCode"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentName"))
            {
               if(dr["StudentName"]!=DBNull.Value)
               {
                   this.StudentName= (System.String)dr["StudentName"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentSex"))
            {
               if(dr["StudentSex"]!=DBNull.Value)
               {
                   this.StudentSex= (System.Int32)dr["StudentSex"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentBirthday"))
            {
               if(dr["StudentBirthday"]!=DBNull.Value)
               {
                   this.StudentBirthday= (System.DateTime)dr["StudentBirthday"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentSchoolName"))
            {
               if(dr["StudentSchoolName"]!=DBNull.Value)
               {
                   this.StudentSchoolName= (System.String)dr["StudentSchoolName"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentGrade"))
            {
               if(dr["StudentGrade"]!=DBNull.Value)
               {
                   this.StudentGrade= (System.Int32)dr["StudentGrade"];
               } 
            }
            if (dr.Table.Columns.Contains("ParentRole"))
            {
               if(dr["ParentRole"]!=DBNull.Value)
               {
                   this.ParentRole= (System.Int64)dr["ParentRole"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentRole"))
            {
               if(dr["StudentRole"]!=DBNull.Value)
               {
                   this.StudentRole= (System.Int64)dr["StudentRole"];
               } 
            }
            if (dr.Table.Columns.Contains("LastModifiedDate"))
            {
               if(dr["LastModifiedDate"]!=DBNull.Value)
               {
                   this.LastModifiedDate= (System.DateTime)dr["LastModifiedDate"];
               } 
            }
            if (dr.Table.Columns.Contains("OrderCode"))
            {
               if(dr["OrderCode"]!=DBNull.Value)
               {
                   this.OrderCode= (System.String)dr["OrderCode"];
               } 
            }
            if (dr.Table.Columns.Contains("DepID"))
            {
               if(dr["DepID"]!=DBNull.Value)
               {
                   this.DepID= (System.Int32)dr["DepID"];
               } 
            }
            if (dr.Table.Columns.Contains("DepName"))
            {
               if(dr["DepName"]!=DBNull.Value)
               {
                   this.DepName= (System.String)dr["DepName"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerIDCardType"))
            {
               if(dr["CustomerIDCardType"]!=DBNull.Value)
               {
                   this.CustomerIDCardType= (System.Byte)dr["CustomerIDCardType"];
               } 
            }
            if (dr.Table.Columns.Contains("SignUserStaffCode"))
            {
               if(dr["SignUserStaffCode"]!=DBNull.Value)
               {
                   this.SignUserStaffCode= (System.String)dr["SignUserStaffCode"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentIDCard"))
            {
               if(dr["StudentIDCard"]!=DBNull.Value)
               {
                   this.StudentIDCard= (System.String)dr["StudentIDCard"];
               } 
            }
            if (dr.Table.Columns.Contains("ClassPermitCode"))
            {
               if(dr["ClassPermitCode"]!=DBNull.Value)
               {
                   this.ClassPermitCode= (System.String)dr["ClassPermitCode"];
               } 
            }
            if (dr.Table.Columns.Contains("CustomerAddressFinished"))
            {
               if(dr["CustomerAddressFinished"]!=DBNull.Value)
               {
                   this.CustomerAddressFinished= (System.Boolean)dr["CustomerAddressFinished"];
               } 
            }
            if (dr.Table.Columns.Contains("CompanyName"))
            {
               if(dr["CompanyName"]!=DBNull.Value)
               {
                   this.CompanyName= (System.String)dr["CompanyName"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentType"))
            {
               if(dr["StudentType"]!=DBNull.Value)
               {
                   this.StudentType= (System.Int32)dr["StudentType"];
               } 
            }
            if (dr.Table.Columns.Contains("TeachingPlaceName"))
            {
               if(dr["TeachingPlaceName"]!=DBNull.Value)
               {
                   this.TeachingPlaceName= (System.String)dr["TeachingPlaceName"];
               } 
            }
            if (dr.Table.Columns.Contains("InquiryPlaceName"))
            {
               if(dr["InquiryPlaceName"]!=DBNull.Value)
               {
                   this.InquiryPlaceName= (System.String)dr["InquiryPlaceName"];
               } 
            }
            if (dr.Table.Columns.Contains("SignUserJobName"))
            {
               if(dr["SignUserJobName"]!=DBNull.Value)
               {
                   this.SignUserJobName= (System.String)dr["SignUserJobName"];
               } 
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
               if(dr["LastModified"]!=DBNull.Value)
               {
                   this.LastModified= (System.Byte[])dr["LastModified"];
               } 
            }
        }
    }
}