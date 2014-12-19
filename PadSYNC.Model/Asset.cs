using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class Asset
    {
        #region 属性
            /// <summary>
            /// 资产ID
            /// </summary>
            public System.Int64  AssetID {get;set;}
            /// <summary>
            /// 0=客户，1=员工，2=公司（暂定）
            /// </summary>
            public System.Byte  OwnerType {get;set;}
            /// <summary>
            /// 所有者ID，即学生的UserID
            /// </summary>
            public System.Int64  OwnerID {get;set;}
            /// <summary>
            /// 所有者身份ID
            /// </summary>
            public System.Int64  OwnerPassportID {get;set;}
            /// <summary>
            /// 资产兑换单ID
            /// </summary>
            public System.Int64  ExchangeID {get;set;}
            /// <summary>
            /// 分公司ID
            /// </summary>
            public System.Int64  SubCompanyID {get;set;}
            /// <summary>
            /// 校区ID
            /// </summary>
            public System.Int64  SchoolID {get;set;}
            /// <summary>
            /// 合同ID
            /// </summary>
            public System.Int64  ContractID {get;set;}
            /// <summary>
            /// 合同编号
            /// </summary>
            public System.String  ContractCode {get;set;}
            /// <summary>
            /// 一对一产品 ：综合服务费=0,通用课时=1,专有课时=2,促销券=3,管理性陪读=4,承诺金 = 5,
            ///班组产品 ：报名费 = 10,班组通用课时 = 11,班组专有课时 = 12,
            ///线上产品产品 ：线上产品通用课时 = 21,线上产品专有课时 = 22,积分 = 30,CCTV网络课时 = 23,

            /// </summary>
            public System.Byte  AssetType {get;set;}
            /// <summary>
            /// 资产创建的时间资产推送时间
            /// </summary>
            public System.DateTime  AssetCreateDate {get;set;}
            /// <summary>
            /// 有效期开始时间
            ///合同开始时间

            /// </summary>
            public System.DateTime  StartTime {get;set;}
            /// <summary>
            /// 有效期结束时间
            ///合同结束时间
            /// </summary>
            public System.DateTime  EndTime {get;set;}
            /// <summary>
            /// 总数量
            /// </summary>
            public System.Decimal  AssetCount {get;set;}
            /// <summary>
            /// 剩余数量
            /// </summary>
            public System.Decimal  RemainCount {get;set;}
            /// <summary>
            /// 锁定数量
            /// </summary>
            public System.Decimal  LockCount {get;set;}
            /// <summary>
            /// 资产状态
            ///0=未使用,1=使用中,2=延期中,3=已过期,4=正常结束,5=人工结课后结束,6=退款后结束
            /// </summary>
            public System.Byte  AssetState {get;set;}
            /// <summary>
            /// 资产冻结类型
            ///0未冻结
            ///1已冻结

            /// </summary>
            public System.Byte  FreezeType {get;set;}
            /// <summary>
            /// 资产来源：合同，赠送

            /// </summary>
            public System.Byte  AssetSource {get;set;}
            /// <summary>
            /// 分区ID
            /// </summary>
            public System.Int64  HostID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Decimal  WaitRMCount {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Int64  ChangeID {get;set;}
            /// <summary>
            /// 
            /// </summary>
            public System.Byte[]  LastModified {get;set;}
        #endregion
        public Asset() { }
        public Asset(DataRow dr)
        {
            if (dr.Table.Columns.Contains("AssetID"))
            {
               if(dr["AssetID"]!=DBNull.Value)
               {
                   this.AssetID= (System.Int64)dr["AssetID"];
               } 
            }
            if (dr.Table.Columns.Contains("OwnerType"))
            {
               if(dr["OwnerType"]!=DBNull.Value)
               {
                   this.OwnerType= (System.Byte)dr["OwnerType"];
               } 
            }
            if (dr.Table.Columns.Contains("OwnerID"))
            {
               if(dr["OwnerID"]!=DBNull.Value)
               {
                   this.OwnerID= (System.Int64)dr["OwnerID"];
               } 
            }
            if (dr.Table.Columns.Contains("OwnerPassportID"))
            {
               if(dr["OwnerPassportID"]!=DBNull.Value)
               {
                   this.OwnerPassportID= (System.Int64)dr["OwnerPassportID"];
               } 
            }
            if (dr.Table.Columns.Contains("ExchangeID"))
            {
               if(dr["ExchangeID"]!=DBNull.Value)
               {
                   this.ExchangeID= (System.Int64)dr["ExchangeID"];
               } 
            }
            if (dr.Table.Columns.Contains("SubCompanyID"))
            {
               if(dr["SubCompanyID"]!=DBNull.Value)
               {
                   this.SubCompanyID= (System.Int64)dr["SubCompanyID"];
               } 
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
               if(dr["SchoolID"]!=DBNull.Value)
               {
                   this.SchoolID= (System.Int64)dr["SchoolID"];
               } 
            }
            if (dr.Table.Columns.Contains("ContractID"))
            {
               if(dr["ContractID"]!=DBNull.Value)
               {
                   this.ContractID= (System.Int64)dr["ContractID"];
               } 
            }
            if (dr.Table.Columns.Contains("ContractCode"))
            {
               if(dr["ContractCode"]!=DBNull.Value)
               {
                   this.ContractCode= (System.String)dr["ContractCode"];
               } 
            }
            if (dr.Table.Columns.Contains("AssetType"))
            {
               if(dr["AssetType"]!=DBNull.Value)
               {
                   this.AssetType= (System.Byte)dr["AssetType"];
               } 
            }
            if (dr.Table.Columns.Contains("AssetCreateDate"))
            {
               if(dr["AssetCreateDate"]!=DBNull.Value)
               {
                   this.AssetCreateDate= (System.DateTime)dr["AssetCreateDate"];
               } 
            }
            if (dr.Table.Columns.Contains("StartTime"))
            {
               if(dr["StartTime"]!=DBNull.Value)
               {
                   this.StartTime= (System.DateTime)dr["StartTime"];
               } 
            }
            if (dr.Table.Columns.Contains("EndTime"))
            {
               if(dr["EndTime"]!=DBNull.Value)
               {
                   this.EndTime= (System.DateTime)dr["EndTime"];
               } 
            }
            if (dr.Table.Columns.Contains("AssetCount"))
            {
               if(dr["AssetCount"]!=DBNull.Value)
               {
                   this.AssetCount= (System.Decimal)dr["AssetCount"];
               } 
            }
            if (dr.Table.Columns.Contains("RemainCount"))
            {
               if(dr["RemainCount"]!=DBNull.Value)
               {
                   this.RemainCount= (System.Decimal)dr["RemainCount"];
               } 
            }
            if (dr.Table.Columns.Contains("LockCount"))
            {
               if(dr["LockCount"]!=DBNull.Value)
               {
                   this.LockCount= (System.Decimal)dr["LockCount"];
               } 
            }
            if (dr.Table.Columns.Contains("AssetState"))
            {
               if(dr["AssetState"]!=DBNull.Value)
               {
                   this.AssetState= (System.Byte)dr["AssetState"];
               } 
            }
            if (dr.Table.Columns.Contains("FreezeType"))
            {
               if(dr["FreezeType"]!=DBNull.Value)
               {
                   this.FreezeType= (System.Byte)dr["FreezeType"];
               } 
            }
            if (dr.Table.Columns.Contains("AssetSource"))
            {
               if(dr["AssetSource"]!=DBNull.Value)
               {
                   this.AssetSource= (System.Byte)dr["AssetSource"];
               } 
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
               if(dr["HostID"]!=DBNull.Value)
               {
                   this.HostID= (System.Int64)dr["HostID"];
               } 
            }
            if (dr.Table.Columns.Contains("WaitRMCount"))
            {
               if(dr["WaitRMCount"]!=DBNull.Value)
               {
                   this.WaitRMCount= (System.Decimal)dr["WaitRMCount"];
               } 
            }
            if (dr.Table.Columns.Contains("ChangeID"))
            {
               if(dr["ChangeID"]!=DBNull.Value)
               {
                   this.ChangeID= (System.Int64)dr["ChangeID"];
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