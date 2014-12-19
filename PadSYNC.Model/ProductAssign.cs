using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class ProductAssign
    {
        #region 属性
            /// <summary>
            /// 产品排定ID
            /// </summary>
            public System.Int64  ProductAssignID {get;set;}
            /// <summary>
            /// 学生ID
            /// </summary>
            public System.Int64  StudentID {get;set;}
            /// <summary>
            /// 学生PassportID
            /// </summary>
            public System.Int64  StudentPassportID {get;set;}
            /// <summary>
            /// 产品ID
            /// </summary>
            public System.Int64  ProductID {get;set;}
            /// <summary>
            /// 排定数量
            /// </summary>
            public System.Decimal  AssignCount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  HostID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Byte[]  LastModified {get;set;}
        #endregion
        public ProductAssign() { }
        public ProductAssign(DataRow dr)
        {
            if (dr.Table.Columns.Contains("ProductAssignID"))
            {
               if(dr["ProductAssignID"]!=DBNull.Value)
               {
                   this.ProductAssignID= (System.Int64)dr["ProductAssignID"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentID"))
            {
               if(dr["StudentID"]!=DBNull.Value)
               {
                   this.StudentID= (System.Int64)dr["StudentID"];
               } 
            }
            if (dr.Table.Columns.Contains("StudentPassportID"))
            {
               if(dr["StudentPassportID"]!=DBNull.Value)
               {
                   this.StudentPassportID= (System.Int64)dr["StudentPassportID"];
               } 
            }
            if (dr.Table.Columns.Contains("ProductID"))
            {
               if(dr["ProductID"]!=DBNull.Value)
               {
                   this.ProductID= (System.Int64)dr["ProductID"];
               } 
            }
            if (dr.Table.Columns.Contains("AssignCount"))
            {
               if(dr["AssignCount"]!=DBNull.Value)
               {
                   this.AssignCount= (System.Decimal)dr["AssignCount"];
               } 
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
               if(dr["HostID"]!=DBNull.Value)
               {
                   this.HostID= (System.Int64)dr["HostID"];
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