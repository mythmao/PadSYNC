using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class ProductsBasic
    {
        #region 属性
        /// <summary>
        /// 产品代码
        /// </summary>
        public System.Int64 ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public System.String ProductName { get; set; }
        /// <summary>
        /// 产品编码
        /// </summary>
        public System.String ProductCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ProductCodeNB { get; set; }
        /// <summary>
        /// 产品简介
        /// </summary>
        public System.String ProductSummary { get; set; }
        /// <summary>
        /// 产品描述
        /// </summary>
        public System.String ProductDescription { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public System.DateTime LauchDate { get; set; }
        /// <summary>
        /// 产品状态
        /// </summary>
        public System.Int64 ProductStatus { get; set; }
        /// <summary>
        /// 是否包含其它产品
        /// </summary>
        public System.Byte HaveBatch { get; set; }
        /// <summary>
        /// 是否是促销产品
        /// </summary>
        public System.Byte IsPromotion { get; set; }
        /// <summary>
        /// 是否可单独执行
        /// </summary>
        public System.Byte CanExcuteAlone { get; set; }
        /// <summary>
        /// 最小销售数量
        /// </summary>
        public System.Decimal LessSaleNumber { get; set; }
        /// <summary>
        /// 销售规格个数
        /// </summary>
        public System.Int64 SellingPropertyNumber { get; set; }
        /// <summary>
        /// 销售规格
        /// </summary>
        public System.String SellingPropertyId { get; set; }
        /// <summary>
        /// 单位代码
        /// </summary>
        public System.Int64 UnitTypeId { get; set; }
        /// <summary>
        /// 产品单价
        /// </summary>
        public System.Decimal UnitPrice { get; set; }
        /// <summary>
        /// 单价最大折扣
        /// </summary>
        public System.Decimal MaxDiscount { get; set; }
        /// <summary>
        /// 分期付款次数
        /// </summary>
        public System.Int32 PayTimes { get; set; }
        /// <summary>
        /// 起售(效)时间
        /// </summary>
        public System.DateTime StartSellingDate { get; set; }
        /// <summary>
        /// 止售(效)时间
        /// </summary>
        public System.DateTime EndSellingDate { get; set; }
        /// <summary>
        /// 销售前置产品
        /// </summary>
        public System.Int64 ReliantProductId { get; set; }
        /// <summary>
        /// 合同金额
        /// </summary>
        public System.Decimal ContractMoney { get; set; }
        /// <summary>
        /// 合同金额单位Id
        /// </summary>
        public System.Int64 ContractMoneyUnitTypeId { get; set; }
        /// <summary>
        /// 最多使用次数
        /// </summary>
        public System.Int32 MaxUseTimes { get; set; }
        /// <summary>
        /// 服务有效期时长单位
        /// </summary>
        public System.Int32 ServiceValidTimeUnitId { get; set; }
        /// <summary>
        /// 服务有效期时长
        /// </summary>
        public System.Int32 ServiceValidTimeLength { get; set; }
        /// <summary>
        /// 执行起始时间方式
        /// </summary>
        public System.Int64 ExcuteTimePointId { get; set; }
        /// <summary>
        /// 执行起始延期时长
        /// </summary>
        public System.Int32 ExcuteValidTimeLength { get; set; }
        /// <summary>
        /// 执行起始时间
        /// </summary>
        public System.DateTime ExcuteDate { get; set; }
        /// <summary>
        /// 执行终止时间方式
        /// </summary>
        public System.Int64 EndTimePointId { get; set; }
        /// <summary>
        /// 执行终止延期时长
        /// </summary>
        public System.Int32 EndTimeLength { get; set; }
        /// <summary>
        /// 执行终止时间
        /// </summary>
        public System.DateTime EndDate { get; set; }
        /// <summary>
        /// 是否允许分期执行
        /// </summary>
        public System.Byte IsExcutedInPhases { get; set; }
        /// <summary>
        /// 分期执行次数
        /// </summary>
        public System.Int32 PhaseExcuteTimes { get; set; }
        /// <summary>
        /// 创建者用户Id
        /// </summary>
        public System.Int64 CreatorUserId { get; set; }
        /// <summary>
        /// 创建者身份Id
        /// </summary>
        public System.Int64 CreatorPassportId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 AreaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ServiceFeeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 PromiseCourseCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Decimal PromiseCourseTotalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String CreatorUserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 JobPassportId { get; set; }
        #endregion
        public ProductsBasic() { }
        public ProductsBasic(DataRow dr)
        {
            if (dr.Table.Columns.Contains("ProductId"))
            {
                if (dr["ProductId"] != DBNull.Value)
                {
                    this.ProductId = (System.Int64)dr["ProductId"];
                }
            }
            if (dr.Table.Columns.Contains("ProductName"))
            {
                if (dr["ProductName"] != DBNull.Value)
                {
                    this.ProductName = (System.String)dr["ProductName"];
                }
            }
            if (dr.Table.Columns.Contains("ProductCode"))
            {
                if (dr["ProductCode"] != DBNull.Value)
                {
                    this.ProductCode = (System.String)dr["ProductCode"];
                }
            }
            if (dr.Table.Columns.Contains("ProductCodeNB"))
            {
                if (dr["ProductCodeNB"] != DBNull.Value)
                {
                    this.ProductCodeNB = (System.String)dr["ProductCodeNB"];
                }
            }
            if (dr.Table.Columns.Contains("ProductSummary"))
            {
                if (dr["ProductSummary"] != DBNull.Value)
                {
                    this.ProductSummary = (System.String)dr["ProductSummary"];
                }
            }
            if (dr.Table.Columns.Contains("ProductDescription"))
            {
                if (dr["ProductDescription"] != DBNull.Value)
                {
                    this.ProductDescription = (System.String)dr["ProductDescription"];
                }
            }
            if (dr.Table.Columns.Contains("CreateDate"))
            {
                if (dr["CreateDate"] != DBNull.Value)
                {
                    this.CreateDate = (System.DateTime)dr["CreateDate"];
                }
            }
            if (dr.Table.Columns.Contains("LauchDate"))
            {
                if (dr["LauchDate"] != DBNull.Value)
                {
                    this.LauchDate = (System.DateTime)dr["LauchDate"];
                }
            }
            if (dr.Table.Columns.Contains("ProductStatus"))
            {
                if (dr["ProductStatus"] != DBNull.Value)
                {
                    this.ProductStatus = (System.Int64)dr["ProductStatus"];
                }
            }
            if (dr.Table.Columns.Contains("HaveBatch"))
            {
                if (dr["HaveBatch"] != DBNull.Value)
                {
                    this.HaveBatch = (System.Byte)dr["HaveBatch"];
                }
            }
            if (dr.Table.Columns.Contains("IsPromotion"))
            {
                if (dr["IsPromotion"] != DBNull.Value)
                {
                    this.IsPromotion = (System.Byte)dr["IsPromotion"];
                }
            }
            if (dr.Table.Columns.Contains("CanExcuteAlone"))
            {
                if (dr["CanExcuteAlone"] != DBNull.Value)
                {
                    this.CanExcuteAlone = (System.Byte)dr["CanExcuteAlone"];
                }
            }
            if (dr.Table.Columns.Contains("LessSaleNumber"))
            {
                if (dr["LessSaleNumber"] != DBNull.Value)
                {
                    this.LessSaleNumber = (System.Decimal)dr["LessSaleNumber"];
                }
            }
            if (dr.Table.Columns.Contains("SellingPropertyNumber"))
            {
                if (dr["SellingPropertyNumber"] != DBNull.Value)
                {
                    this.SellingPropertyNumber = (System.Int64)dr["SellingPropertyNumber"];
                }
            }
            if (dr.Table.Columns.Contains("SellingPropertyId"))
            {
                if (dr["SellingPropertyId"] != DBNull.Value)
                {
                    this.SellingPropertyId = (System.String)dr["SellingPropertyId"];
                }
            }
            if (dr.Table.Columns.Contains("UnitTypeId"))
            {
                if (dr["UnitTypeId"] != DBNull.Value)
                {
                    this.UnitTypeId = (System.Int64)dr["UnitTypeId"];
                }
            }
            if (dr.Table.Columns.Contains("UnitPrice"))
            {
                if (dr["UnitPrice"] != DBNull.Value)
                {
                    this.UnitPrice = (System.Decimal)dr["UnitPrice"];
                }
            }
            if (dr.Table.Columns.Contains("MaxDiscount"))
            {
                if (dr["MaxDiscount"] != DBNull.Value)
                {
                    this.MaxDiscount = (System.Decimal)dr["MaxDiscount"];
                }
            }
            if (dr.Table.Columns.Contains("PayTimes"))
            {
                if (dr["PayTimes"] != DBNull.Value)
                {
                    this.PayTimes = (System.Int32)dr["PayTimes"];
                }
            }
            if (dr.Table.Columns.Contains("StartSellingDate"))
            {
                if (dr["StartSellingDate"] != DBNull.Value)
                {
                    this.StartSellingDate = (System.DateTime)dr["StartSellingDate"];
                }
            }
            if (dr.Table.Columns.Contains("EndSellingDate"))
            {
                if (dr["EndSellingDate"] != DBNull.Value)
                {
                    this.EndSellingDate = (System.DateTime)dr["EndSellingDate"];
                }
            }
            if (dr.Table.Columns.Contains("ReliantProductId"))
            {
                if (dr["ReliantProductId"] != DBNull.Value)
                {
                    this.ReliantProductId = (System.Int64)dr["ReliantProductId"];
                }
            }
            if (dr.Table.Columns.Contains("ContractMoney"))
            {
                if (dr["ContractMoney"] != DBNull.Value)
                {
                    this.ContractMoney = (System.Decimal)dr["ContractMoney"];
                }
            }
            if (dr.Table.Columns.Contains("ContractMoneyUnitTypeId"))
            {
                if (dr["ContractMoneyUnitTypeId"] != DBNull.Value)
                {
                    this.ContractMoneyUnitTypeId = (System.Int64)dr["ContractMoneyUnitTypeId"];
                }
            }
            if (dr.Table.Columns.Contains("MaxUseTimes"))
            {
                if (dr["MaxUseTimes"] != DBNull.Value)
                {
                    this.MaxUseTimes = (System.Int32)dr["MaxUseTimes"];
                }
            }
            if (dr.Table.Columns.Contains("ServiceValidTimeUnitId"))
            {
                if (dr["ServiceValidTimeUnitId"] != DBNull.Value)
                {
                    this.ServiceValidTimeUnitId = (System.Int32)dr["ServiceValidTimeUnitId"];
                }
            }
            if (dr.Table.Columns.Contains("ServiceValidTimeLength"))
            {
                if (dr["ServiceValidTimeLength"] != DBNull.Value)
                {
                    this.ServiceValidTimeLength = (System.Int32)dr["ServiceValidTimeLength"];
                }
            }
            if (dr.Table.Columns.Contains("ExcuteTimePointId"))
            {
                if (dr["ExcuteTimePointId"] != DBNull.Value)
                {
                    this.ExcuteTimePointId = (System.Int64)dr["ExcuteTimePointId"];
                }
            }
            if (dr.Table.Columns.Contains("ExcuteValidTimeLength"))
            {
                if (dr["ExcuteValidTimeLength"] != DBNull.Value)
                {
                    this.ExcuteValidTimeLength = (System.Int32)dr["ExcuteValidTimeLength"];
                }
            }
            if (dr.Table.Columns.Contains("ExcuteDate"))
            {
                if (dr["ExcuteDate"] != DBNull.Value)
                {
                    this.ExcuteDate = (System.DateTime)dr["ExcuteDate"];
                }
            }
            if (dr.Table.Columns.Contains("EndTimePointId"))
            {
                if (dr["EndTimePointId"] != DBNull.Value)
                {
                    this.EndTimePointId = (System.Int64)dr["EndTimePointId"];
                }
            }
            if (dr.Table.Columns.Contains("EndTimeLength"))
            {
                if (dr["EndTimeLength"] != DBNull.Value)
                {
                    this.EndTimeLength = (System.Int32)dr["EndTimeLength"];
                }
            }
            if (dr.Table.Columns.Contains("EndDate"))
            {
                if (dr["EndDate"] != DBNull.Value)
                {
                    this.EndDate = (System.DateTime)dr["EndDate"];
                }
            }
            if (dr.Table.Columns.Contains("IsExcutedInPhases"))
            {
                if (dr["IsExcutedInPhases"] != DBNull.Value)
                {
                    this.IsExcutedInPhases = (System.Byte)dr["IsExcutedInPhases"];
                }
            }
            if (dr.Table.Columns.Contains("PhaseExcuteTimes"))
            {
                if (dr["PhaseExcuteTimes"] != DBNull.Value)
                {
                    this.PhaseExcuteTimes = (System.Int32)dr["PhaseExcuteTimes"];
                }
            }
            if (dr.Table.Columns.Contains("CreatorUserId"))
            {
                if (dr["CreatorUserId"] != DBNull.Value)
                {
                    this.CreatorUserId = (System.Int64)dr["CreatorUserId"];
                }
            }
            if (dr.Table.Columns.Contains("CreatorPassportId"))
            {
                if (dr["CreatorPassportId"] != DBNull.Value)
                {
                    this.CreatorPassportId = (System.Int64)dr["CreatorPassportId"];
                }
            }
            if (dr.Table.Columns.Contains("AreaId"))
            {
                if (dr["AreaId"] != DBNull.Value)
                {
                    this.AreaId = (System.Int64)dr["AreaId"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolId"))
            {
                if (dr["SchoolId"] != DBNull.Value)
                {
                    this.SchoolId = (System.Int64)dr["SchoolId"];
                }
            }
            if (dr.Table.Columns.Contains("ServiceFeeType"))
            {
                if (dr["ServiceFeeType"] != DBNull.Value)
                {
                    this.ServiceFeeType = (System.Int32)dr["ServiceFeeType"];
                }
            }
            if (dr.Table.Columns.Contains("PromiseCourseCount"))
            {
                if (dr["PromiseCourseCount"] != DBNull.Value)
                {
                    this.PromiseCourseCount = (System.Int32)dr["PromiseCourseCount"];
                }
            }
            if (dr.Table.Columns.Contains("PromiseCourseTotalPrice"))
            {
                if (dr["PromiseCourseTotalPrice"] != DBNull.Value)
                {
                    this.PromiseCourseTotalPrice = (System.Decimal)dr["PromiseCourseTotalPrice"];
                }
            }
            if (dr.Table.Columns.Contains("CreatorUserName"))
            {
                if (dr["CreatorUserName"] != DBNull.Value)
                {
                    this.CreatorUserName = (System.String)dr["CreatorUserName"];
                }
            }
            if (dr.Table.Columns.Contains("LastModifyDate"))
            {
                if (dr["LastModifyDate"] != DBNull.Value)
                {
                    this.LastModifyDate = (System.DateTime)dr["LastModifyDate"];
                }
            }
            if (dr.Table.Columns.Contains("OrgPath"))
            {
                if (dr["OrgPath"] != DBNull.Value)
                {
                    this.OrgPath = (System.String)dr["OrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("JobPassportId"))
            {
                if (dr["JobPassportId"] != DBNull.Value)
                {
                    this.JobPassportId = (System.Int64)dr["JobPassportId"];
                }
            }
        }
    }
}