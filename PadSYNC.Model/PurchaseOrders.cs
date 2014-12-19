using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class PurchaseOrders
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrderCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PreviousContractID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SignUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SignUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SignUserJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SignUserJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ownerUserPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CustomerPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StudentPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 CompanyID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 DepID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal ServiceFee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal AccountReceived { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal ApproveDiscount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime SignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime SubmitDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte OrderStatus { get; set; }
        /// <summary>
        /// 1：退部分，2：退全部
        /// </summary>
        public System.Int32 ReturnStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModifiedDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubmitUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubmitUserJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubmitUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SubmitUserJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 MJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ownerJobpassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ownerJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EnterUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EnterUserJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EnterUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 EnterUserJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String EnterUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentEnterUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentEnterUserJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentEnterUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentEnterUserJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String EnterUserOrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ParentEnterUserOrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerFromSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StudentFromSystem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 CustomerCallType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StudentCallType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 TeachingPlaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 InquiryPlaceID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte StudentEnterUserType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SourceTypePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte OrderClass { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ServiceFeeUnsubscribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 OrderType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public PurchaseOrders() { }
        public PurchaseOrders(DataRow dr)
        {
            if (dr.Table.Columns.Contains("OrderID"))
            {
                if (dr["OrderID"] != DBNull.Value)
                {
                    this.OrderID = (System.Int64)dr["OrderID"];
                }
            }
            if (dr.Table.Columns.Contains("OrderCode"))
            {
                if (dr["OrderCode"] != DBNull.Value)
                {
                    this.OrderCode = (System.String)dr["OrderCode"];
                }
            }
            if (dr.Table.Columns.Contains("PreviousContractID"))
            {
                if (dr["PreviousContractID"] != DBNull.Value)
                {
                    this.PreviousContractID = (System.Int64)dr["PreviousContractID"];
                }
            }
            if (dr.Table.Columns.Contains("SignUserID"))
            {
                if (dr["SignUserID"] != DBNull.Value)
                {
                    this.SignUserID = (System.Int64)dr["SignUserID"];
                }
            }
            if (dr.Table.Columns.Contains("SignUserPassportID"))
            {
                if (dr["SignUserPassportID"] != DBNull.Value)
                {
                    this.SignUserPassportID = (System.Int64)dr["SignUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("SignUserJobID"))
            {
                if (dr["SignUserJobID"] != DBNull.Value)
                {
                    this.SignUserJobID = (System.Int64)dr["SignUserJobID"];
                }
            }
            if (dr.Table.Columns.Contains("SignUserJobPassportID"))
            {
                if (dr["SignUserJobPassportID"] != DBNull.Value)
                {
                    this.SignUserJobPassportID = (System.Int64)dr["SignUserJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ownerUserPath"))
            {
                if (dr["ownerUserPath"] != DBNull.Value)
                {
                    this.ownerUserPath = (System.String)dr["ownerUserPath"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerID"))
            {
                if (dr["CustomerID"] != DBNull.Value)
                {
                    this.CustomerID = (System.Int64)dr["CustomerID"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerPassportID"))
            {
                if (dr["CustomerPassportID"] != DBNull.Value)
                {
                    this.CustomerPassportID = (System.Int64)dr["CustomerPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentID"))
            {
                if (dr["StudentID"] != DBNull.Value)
                {
                    this.StudentID = (System.Int64)dr["StudentID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentPassportID"))
            {
                if (dr["StudentPassportID"] != DBNull.Value)
                {
                    this.StudentPassportID = (System.Int64)dr["StudentPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("CompanyID"))
            {
                if (dr["CompanyID"] != DBNull.Value)
                {
                    this.CompanyID = (System.Int64)dr["CompanyID"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
                if (dr["SchoolID"] != DBNull.Value)
                {
                    this.SchoolID = (System.Int64)dr["SchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("DepID"))
            {
                if (dr["DepID"] != DBNull.Value)
                {
                    this.DepID = (System.Int64)dr["DepID"];
                }
            }
            if (dr.Table.Columns.Contains("ServiceFee"))
            {
                if (dr["ServiceFee"] != DBNull.Value)
                {
                    this.ServiceFee = (System.Decimal)dr["ServiceFee"];
                }
            }
            if (dr.Table.Columns.Contains("AccountReceived"))
            {
                if (dr["AccountReceived"] != DBNull.Value)
                {
                    this.AccountReceived = (System.Decimal)dr["AccountReceived"];
                }
            }
            if (dr.Table.Columns.Contains("ApproveDiscount"))
            {
                if (dr["ApproveDiscount"] != DBNull.Value)
                {
                    this.ApproveDiscount = (System.Decimal)dr["ApproveDiscount"];
                }
            }
            if (dr.Table.Columns.Contains("Reason"))
            {
                if (dr["Reason"] != DBNull.Value)
                {
                    this.Reason = (System.String)dr["Reason"];
                }
            }
            if (dr.Table.Columns.Contains("SignDate"))
            {
                if (dr["SignDate"] != DBNull.Value)
                {
                    this.SignDate = (System.DateTime)dr["SignDate"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitDate"))
            {
                if (dr["SubmitDate"] != DBNull.Value)
                {
                    this.SubmitDate = (System.DateTime)dr["SubmitDate"];
                }
            }
            if (dr.Table.Columns.Contains("OrderStatus"))
            {
                if (dr["OrderStatus"] != DBNull.Value)
                {
                    this.OrderStatus = (System.Byte)dr["OrderStatus"];
                }
            }
            if (dr.Table.Columns.Contains("ReturnStatus"))
            {
                if (dr["ReturnStatus"] != DBNull.Value)
                {
                    this.ReturnStatus = (System.Int32)dr["ReturnStatus"];
                }
            }
            if (dr.Table.Columns.Contains("CreateDate"))
            {
                if (dr["CreateDate"] != DBNull.Value)
                {
                    this.CreateDate = (System.DateTime)dr["CreateDate"];
                }
            }
            if (dr.Table.Columns.Contains("LastModifiedDate"))
            {
                if (dr["LastModifiedDate"] != DBNull.Value)
                {
                    this.LastModifiedDate = (System.DateTime)dr["LastModifiedDate"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitUserID"))
            {
                if (dr["SubmitUserID"] != DBNull.Value)
                {
                    this.SubmitUserID = (System.Int64)dr["SubmitUserID"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitUserJobID"))
            {
                if (dr["SubmitUserJobID"] != DBNull.Value)
                {
                    this.SubmitUserJobID = (System.Int64)dr["SubmitUserJobID"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitUserPassportID"))
            {
                if (dr["SubmitUserPassportID"] != DBNull.Value)
                {
                    this.SubmitUserPassportID = (System.Int64)dr["SubmitUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("SubmitUserJobPassportID"))
            {
                if (dr["SubmitUserJobPassportID"] != DBNull.Value)
                {
                    this.SubmitUserJobPassportID = (System.Int64)dr["SubmitUserJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("MJobPassportID"))
            {
                if (dr["MJobPassportID"] != DBNull.Value)
                {
                    this.MJobPassportID = (System.Int64)dr["MJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ownerJobpassportID"))
            {
                if (dr["ownerJobpassportID"] != DBNull.Value)
                {
                    this.ownerJobpassportID = (System.Int64)dr["ownerJobpassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ownerJobID"))
            {
                if (dr["ownerJobID"] != DBNull.Value)
                {
                    this.ownerJobID = (System.Int64)dr["ownerJobID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserID"))
            {
                if (dr["EnterUserID"] != DBNull.Value)
                {
                    this.EnterUserID = (System.Int64)dr["EnterUserID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserJobID"))
            {
                if (dr["EnterUserJobID"] != DBNull.Value)
                {
                    this.EnterUserJobID = (System.Int64)dr["EnterUserJobID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserPassportID"))
            {
                if (dr["EnterUserPassportID"] != DBNull.Value)
                {
                    this.EnterUserPassportID = (System.Int64)dr["EnterUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserJobPassportID"))
            {
                if (dr["EnterUserJobPassportID"] != DBNull.Value)
                {
                    this.EnterUserJobPassportID = (System.Int64)dr["EnterUserJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserName"))
            {
                if (dr["EnterUserName"] != DBNull.Value)
                {
                    this.EnterUserName = (System.String)dr["EnterUserName"];
                }
            }
            if (dr.Table.Columns.Contains("ParentEnterUserID"))
            {
                if (dr["ParentEnterUserID"] != DBNull.Value)
                {
                    this.ParentEnterUserID = (System.Int64)dr["ParentEnterUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentEnterUserJobID"))
            {
                if (dr["ParentEnterUserJobID"] != DBNull.Value)
                {
                    this.ParentEnterUserJobID = (System.Int64)dr["ParentEnterUserJobID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentEnterUserPassportID"))
            {
                if (dr["ParentEnterUserPassportID"] != DBNull.Value)
                {
                    this.ParentEnterUserPassportID = (System.Int64)dr["ParentEnterUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentEnterUserJobPassportID"))
            {
                if (dr["ParentEnterUserJobPassportID"] != DBNull.Value)
                {
                    this.ParentEnterUserJobPassportID = (System.Int64)dr["ParentEnterUserJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("EnterUserOrgPath"))
            {
                if (dr["EnterUserOrgPath"] != DBNull.Value)
                {
                    this.EnterUserOrgPath = (System.String)dr["EnterUserOrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("ParentEnterUserOrgPath"))
            {
                if (dr["ParentEnterUserOrgPath"] != DBNull.Value)
                {
                    this.ParentEnterUserOrgPath = (System.String)dr["ParentEnterUserOrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerFromSystem"))
            {
                if (dr["CustomerFromSystem"] != DBNull.Value)
                {
                    this.CustomerFromSystem = (System.Int32)dr["CustomerFromSystem"];
                }
            }
            if (dr.Table.Columns.Contains("StudentFromSystem"))
            {
                if (dr["StudentFromSystem"] != DBNull.Value)
                {
                    this.StudentFromSystem = (System.Int32)dr["StudentFromSystem"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerCallType"))
            {
                if (dr["CustomerCallType"] != DBNull.Value)
                {
                    this.CustomerCallType = (System.Int32)dr["CustomerCallType"];
                }
            }
            if (dr.Table.Columns.Contains("StudentCallType"))
            {
                if (dr["StudentCallType"] != DBNull.Value)
                {
                    this.StudentCallType = (System.Int32)dr["StudentCallType"];
                }
            }
            if (dr.Table.Columns.Contains("TeachingPlaceID"))
            {
                if (dr["TeachingPlaceID"] != DBNull.Value)
                {
                    this.TeachingPlaceID = (System.Int64)dr["TeachingPlaceID"];
                }
            }
            if (dr.Table.Columns.Contains("InquiryPlaceID"))
            {
                if (dr["InquiryPlaceID"] != DBNull.Value)
                {
                    this.InquiryPlaceID = (System.Int64)dr["InquiryPlaceID"];
                }
            }
            if (dr.Table.Columns.Contains("StudentEnterUserType"))
            {
                if (dr["StudentEnterUserType"] != DBNull.Value)
                {
                    this.StudentEnterUserType = (System.Byte)dr["StudentEnterUserType"];
                }
            }
            if (dr.Table.Columns.Contains("SourceTypePath"))
            {
                if (dr["SourceTypePath"] != DBNull.Value)
                {
                    this.SourceTypePath = (System.String)dr["SourceTypePath"];
                }
            }
            if (dr.Table.Columns.Contains("OrderClass"))
            {
                if (dr["OrderClass"] != DBNull.Value)
                {
                    this.OrderClass = (System.Byte)dr["OrderClass"];
                }
            }
            if (dr.Table.Columns.Contains("ServiceFeeUnsubscribe"))
            {
                if (dr["ServiceFeeUnsubscribe"] != DBNull.Value)
                {
                    this.ServiceFeeUnsubscribe = (System.Int32)dr["ServiceFeeUnsubscribe"];
                }
            }
            if (dr.Table.Columns.Contains("OrderType"))
            {
                if (dr["OrderType"] != DBNull.Value)
                {
                    this.OrderType = (System.Int32)dr["OrderType"];
                }
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
                if (dr["LastModified"] != DBNull.Value)
                {
                    this.LastModified = (System.Byte[])dr["LastModified"];
                }
            }
        }
    }
}