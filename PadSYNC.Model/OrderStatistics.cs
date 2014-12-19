using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class OrderStatistics
    {
        #region 属性
        /// <summary>
        /// 订购单ID
        /// </summary>
        public System.Int64 OrderID { get; set; }
        /// <summary>
        /// 订购单编号
        /// </summary>
        public System.String OrderCode { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public System.Decimal UnitPrice { get; set; }
        /// <summary>
        /// 客户ID
        /// </summary>
        public System.Int64 CustomerID { get; set; }
        /// <summary>
        /// 订购数量
        /// </summary>
        public System.Decimal Amount { get; set; }
        /// <summary>
        /// 已适用的数量
        /// </summary>
        public System.Decimal Used { get; set; }
        /// <summary>
        /// 排课中的数量
        /// </summary>
        public System.Decimal Scheduling { get; set; }
        /// <summary>
        /// 退订数量
        /// </summary>
        public System.Decimal Unsubscribe { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Byte[] LastModified { get; set; }
        #endregion
        public OrderStatistics() { }
        public OrderStatistics(DataRow dr)
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
            if (dr.Table.Columns.Contains("UnitPrice"))
            {
                if (dr["UnitPrice"] != DBNull.Value)
                {
                    this.UnitPrice = (System.Decimal)dr["UnitPrice"];
                }
            }
            if (dr.Table.Columns.Contains("CustomerID"))
            {
                if (dr["CustomerID"] != DBNull.Value)
                {
                    this.CustomerID = (System.Int64)dr["CustomerID"];
                }
            }
            if (dr.Table.Columns.Contains("Amount"))
            {
                if (dr["Amount"] != DBNull.Value)
                {
                    this.Amount = (System.Decimal)dr["Amount"];
                }
            }
            if (dr.Table.Columns.Contains("Used"))
            {
                if (dr["Used"] != DBNull.Value)
                {
                    this.Used = (System.Decimal)dr["Used"];
                }
            }
            if (dr.Table.Columns.Contains("Scheduling"))
            {
                if (dr["Scheduling"] != DBNull.Value)
                {
                    this.Scheduling = (System.Decimal)dr["Scheduling"];
                }
            }
            if (dr.Table.Columns.Contains("Unsubscribe"))
            {
                if (dr["Unsubscribe"] != DBNull.Value)
                {
                    this.Unsubscribe = (System.Decimal)dr["Unsubscribe"];
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