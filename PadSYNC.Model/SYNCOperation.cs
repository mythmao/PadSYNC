using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class SYNCOperation
    {
        #region 属性
            /// <summary>
            /// 编号
            /// </summary>
            public System.Guid  Gid {get;set;}
            /// <summary>
            /// 更新状态
           ///0：未更新
           ///1：更新成功
           ///2：更新失败
   
            /// </summary>
            public System.Int32  Status {get;set;}
            /// <summary>
            /// 更新内容
            /// </summary>
            public System.String  Content {get;set;}
            /// <summary>
            /// 更新表名
            /// </summary>
            public System.String  Name {get;set;}
            /// <summary>
            /// 时间戳
            /// </summary>
            public System.Byte[]  LastModified {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.DateTime  InsertDate {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  Id {get;set;}
        #endregion
        public SYNCOperation() { }
        public SYNCOperation(DataRow dr)
        {
            if (dr.Table.Columns.Contains("Gid"))
            {
               if(dr["Gid"]!=DBNull.Value)
               {
                   this.Gid= (System.Guid)dr["Gid"];
               } 
            }
            if (dr.Table.Columns.Contains("Status"))
            {
               if(dr["Status"]!=DBNull.Value)
               {
                   this.Status= (System.Int32)dr["Status"];
               } 
            }
            if (dr.Table.Columns.Contains("Content"))
            {
               if(dr["Content"]!=DBNull.Value)
               {
                   this.Content= (System.String)dr["Content"];
               } 
            }
            if (dr.Table.Columns.Contains("Name"))
            {
               if(dr["Name"]!=DBNull.Value)
               {
                   this.Name= (System.String)dr["Name"];
               } 
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
               if(dr["LastModified"]!=DBNull.Value)
               {
                   this.LastModified= (System.Byte[])dr["LastModified"];
               } 
            }
            if (dr.Table.Columns.Contains("InsertDate"))
            {
               if(dr["InsertDate"]!=DBNull.Value)
               {
                   this.InsertDate= (System.DateTime)dr["InsertDate"];
               } 
            }
            if (dr.Table.Columns.Contains("Id"))
            {
               if(dr["Id"]!=DBNull.Value)
               {
                   this.Id= (System.Int64)dr["Id"];
               } 
            }
        }
    }
}