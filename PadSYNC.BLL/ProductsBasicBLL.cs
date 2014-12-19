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
    public partial class ProductsBasicBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudTrade");


        public static List<ProductsBasic> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<ProductsBasic> list = new List<ProductsBasic>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        ProductsBasic model = new ProductsBasic(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(ProductsBasic model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段


            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]");
                pFileds.Add("@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }

            if (model.ProductCode != null)
            {
                fileds.Add("[ProductCode]");
                pFileds.Add("@ProductCode");
                pms.Add(new SqlParameter("ProductCode", model.ProductCode));
            }

            if (model.ProductCodeNB != null)
            {
                fileds.Add("[ProductCodeNB]");
                pFileds.Add("@ProductCodeNB");
                pms.Add(new SqlParameter("ProductCodeNB", model.ProductCodeNB));
            }

            if (model.ProductSummary != null)
            {
                fileds.Add("[ProductSummary]");
                pFileds.Add("@ProductSummary");
                pms.Add(new SqlParameter("ProductSummary", model.ProductSummary));
            }

            if (model.ProductDescription != null)
            {
                fileds.Add("[ProductDescription]");
                pFileds.Add("@ProductDescription");
                pms.Add(new SqlParameter("ProductDescription", model.ProductDescription));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]");
                pFileds.Add("@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }

            if (model.LauchDate != null && model.LauchDate != new DateTime())
            {
                fileds.Add("[LauchDate]");
                pFileds.Add("@LauchDate");
                pms.Add(new SqlParameter("LauchDate", model.LauchDate));
            }

            if (model.ProductStatus != null)
            {
                fileds.Add("[ProductStatus]");
                pFileds.Add("@ProductStatus");
                pms.Add(new SqlParameter("ProductStatus", model.ProductStatus));
            }

            if (model.HaveBatch != null)
            {
                fileds.Add("[HaveBatch]");
                pFileds.Add("@HaveBatch");
                pms.Add(new SqlParameter("HaveBatch", model.HaveBatch));
            }

            if (model.IsPromotion != null)
            {
                fileds.Add("[IsPromotion]");
                pFileds.Add("@IsPromotion");
                pms.Add(new SqlParameter("IsPromotion", model.IsPromotion));
            }

            if (model.CanExcuteAlone != null)
            {
                fileds.Add("[CanExcuteAlone]");
                pFileds.Add("@CanExcuteAlone");
                pms.Add(new SqlParameter("CanExcuteAlone", model.CanExcuteAlone));
            }

            if (model.LessSaleNumber != null)
            {
                fileds.Add("[LessSaleNumber]");
                pFileds.Add("@LessSaleNumber");
                pms.Add(new SqlParameter("LessSaleNumber", model.LessSaleNumber));
            }

            if (model.SellingPropertyNumber != null)
            {
                fileds.Add("[SellingPropertyNumber]");
                pFileds.Add("@SellingPropertyNumber");
                pms.Add(new SqlParameter("SellingPropertyNumber", model.SellingPropertyNumber));
            }

            if (model.SellingPropertyId != null)
            {
                fileds.Add("[SellingPropertyId]");
                pFileds.Add("@SellingPropertyId");
                pms.Add(new SqlParameter("SellingPropertyId", model.SellingPropertyId));
            }

            if (model.UnitTypeId != null)
            {
                fileds.Add("[UnitTypeId]");
                pFileds.Add("@UnitTypeId");
                pms.Add(new SqlParameter("UnitTypeId", model.UnitTypeId));
            }

            if (model.UnitPrice != null)
            {
                fileds.Add("[UnitPrice]");
                pFileds.Add("@UnitPrice");
                pms.Add(new SqlParameter("UnitPrice", model.UnitPrice));
            }

            if (model.MaxDiscount != null)
            {
                fileds.Add("[MaxDiscount]");
                pFileds.Add("@MaxDiscount");
                pms.Add(new SqlParameter("MaxDiscount", model.MaxDiscount));
            }

            if (model.PayTimes != null)
            {
                fileds.Add("[PayTimes]");
                pFileds.Add("@PayTimes");
                pms.Add(new SqlParameter("PayTimes", model.PayTimes));
            }

            if (model.StartSellingDate != null && model.StartSellingDate != new DateTime())
            {
                fileds.Add("[StartSellingDate]");
                pFileds.Add("@StartSellingDate");
                pms.Add(new SqlParameter("StartSellingDate", model.StartSellingDate));
            }

            if (model.EndSellingDate != null && model.EndSellingDate != new DateTime())
            {
                fileds.Add("[EndSellingDate]");
                pFileds.Add("@EndSellingDate");
                pms.Add(new SqlParameter("EndSellingDate", model.EndSellingDate));
            }

            if (model.ReliantProductId != null)
            {
                fileds.Add("[ReliantProductId]");
                pFileds.Add("@ReliantProductId");
                pms.Add(new SqlParameter("ReliantProductId", model.ReliantProductId));
            }

            if (model.ContractMoney != null)
            {
                fileds.Add("[ContractMoney]");
                pFileds.Add("@ContractMoney");
                pms.Add(new SqlParameter("ContractMoney", model.ContractMoney));
            }

            if (model.ContractMoneyUnitTypeId != null)
            {
                fileds.Add("[ContractMoneyUnitTypeId]");
                pFileds.Add("@ContractMoneyUnitTypeId");
                pms.Add(new SqlParameter("ContractMoneyUnitTypeId", model.ContractMoneyUnitTypeId));
            }

            if (model.MaxUseTimes != null)
            {
                fileds.Add("[MaxUseTimes]");
                pFileds.Add("@MaxUseTimes");
                pms.Add(new SqlParameter("MaxUseTimes", model.MaxUseTimes));
            }

            if (model.ServiceValidTimeUnitId != null)
            {
                fileds.Add("[ServiceValidTimeUnitId]");
                pFileds.Add("@ServiceValidTimeUnitId");
                pms.Add(new SqlParameter("ServiceValidTimeUnitId", model.ServiceValidTimeUnitId));
            }

            if (model.ServiceValidTimeLength != null)
            {
                fileds.Add("[ServiceValidTimeLength]");
                pFileds.Add("@ServiceValidTimeLength");
                pms.Add(new SqlParameter("ServiceValidTimeLength", model.ServiceValidTimeLength));
            }

            if (model.ExcuteTimePointId != null)
            {
                fileds.Add("[ExcuteTimePointId]");
                pFileds.Add("@ExcuteTimePointId");
                pms.Add(new SqlParameter("ExcuteTimePointId", model.ExcuteTimePointId));
            }

            if (model.ExcuteValidTimeLength != null)
            {
                fileds.Add("[ExcuteValidTimeLength]");
                pFileds.Add("@ExcuteValidTimeLength");
                pms.Add(new SqlParameter("ExcuteValidTimeLength", model.ExcuteValidTimeLength));
            }

            if (model.ExcuteDate != null && model.ExcuteDate != new DateTime())
            {
                fileds.Add("[ExcuteDate]");
                pFileds.Add("@ExcuteDate");
                pms.Add(new SqlParameter("ExcuteDate", model.ExcuteDate));
            }

            if (model.EndTimePointId != null)
            {
                fileds.Add("[EndTimePointId]");
                pFileds.Add("@EndTimePointId");
                pms.Add(new SqlParameter("EndTimePointId", model.EndTimePointId));
            }

            if (model.EndTimeLength != null)
            {
                fileds.Add("[EndTimeLength]");
                pFileds.Add("@EndTimeLength");
                pms.Add(new SqlParameter("EndTimeLength", model.EndTimeLength));
            }

            if (model.EndDate != null && model.EndDate != new DateTime())
            {
                fileds.Add("[EndDate]");
                pFileds.Add("@EndDate");
                pms.Add(new SqlParameter("EndDate", model.EndDate));
            }

            if (model.IsExcutedInPhases != null)
            {
                fileds.Add("[IsExcutedInPhases]");
                pFileds.Add("@IsExcutedInPhases");
                pms.Add(new SqlParameter("IsExcutedInPhases", model.IsExcutedInPhases));
            }

            if (model.PhaseExcuteTimes != null)
            {
                fileds.Add("[PhaseExcuteTimes]");
                pFileds.Add("@PhaseExcuteTimes");
                pms.Add(new SqlParameter("PhaseExcuteTimes", model.PhaseExcuteTimes));
            }

            if (model.CreatorUserId != null)
            {
                fileds.Add("[CreatorUserId]");
                pFileds.Add("@CreatorUserId");
                pms.Add(new SqlParameter("CreatorUserId", model.CreatorUserId));
            }

            if (model.CreatorPassportId != null)
            {
                fileds.Add("[CreatorPassportId]");
                pFileds.Add("@CreatorPassportId");
                pms.Add(new SqlParameter("CreatorPassportId", model.CreatorPassportId));
            }

            if (model.AreaId != null)
            {
                fileds.Add("[AreaId]");
                pFileds.Add("@AreaId");
                pms.Add(new SqlParameter("AreaId", model.AreaId));
            }

            if (model.SchoolId != null)
            {
                fileds.Add("[SchoolId]");
                pFileds.Add("@SchoolId");
                pms.Add(new SqlParameter("SchoolId", model.SchoolId));
            }

            if (model.ServiceFeeType != null)
            {
                fileds.Add("[ServiceFeeType]");
                pFileds.Add("@ServiceFeeType");
                pms.Add(new SqlParameter("ServiceFeeType", model.ServiceFeeType));
            }

            if (model.PromiseCourseCount != null)
            {
                fileds.Add("[PromiseCourseCount]");
                pFileds.Add("@PromiseCourseCount");
                pms.Add(new SqlParameter("PromiseCourseCount", model.PromiseCourseCount));
            }

            if (model.PromiseCourseTotalPrice != null)
            {
                fileds.Add("[PromiseCourseTotalPrice]");
                pFileds.Add("@PromiseCourseTotalPrice");
                pms.Add(new SqlParameter("PromiseCourseTotalPrice", model.PromiseCourseTotalPrice));
            }

            if (model.CreatorUserName != null)
            {
                fileds.Add("[CreatorUserName]");
                pFileds.Add("@CreatorUserName");
                pms.Add(new SqlParameter("CreatorUserName", model.CreatorUserName));
            }

            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]");
                pFileds.Add("@LastModifyDate");
                pms.Add(new SqlParameter("LastModifyDate", model.LastModifyDate));
            }

            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]");
                pFileds.Add("@OrgPath");
                pms.Add(new SqlParameter("OrgPath", model.OrgPath));
            }

            if (model.JobPassportId != null)
            {
                fileds.Add("[JobPassportId]");
                pFileds.Add("@JobPassportId");
                pms.Add(new SqlParameter("JobPassportId", model.JobPassportId));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ProductsBasic (");
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

        public static bool Update(ProductsBasic model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[ProductId]=@ProductId");
            pms.Add(new SqlParameter("ProductId", model.ProductId));

            if (model.ProductName != null)
            {
                fileds.Add("[ProductName]=@ProductName");
                pms.Add(new SqlParameter("ProductName", model.ProductName));
            }

            if (model.ProductCode != null)
            {
                fileds.Add("[ProductCode]=@ProductCode");
                pms.Add(new SqlParameter("ProductCode", model.ProductCode));
            }

            if (model.ProductCodeNB != null)
            {
                fileds.Add("[ProductCodeNB]=@ProductCodeNB");
                pms.Add(new SqlParameter("ProductCodeNB", model.ProductCodeNB));
            }

            if (model.ProductSummary != null)
            {
                fileds.Add("[ProductSummary]=@ProductSummary");
                pms.Add(new SqlParameter("ProductSummary", model.ProductSummary));
            }

            if (model.ProductDescription != null)
            {
                fileds.Add("[ProductDescription]=@ProductDescription");
                pms.Add(new SqlParameter("ProductDescription", model.ProductDescription));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]=@CreateDate");
            }

            if (model.LauchDate != null && model.LauchDate != new DateTime())
            {
                fileds.Add("[LauchDate]=@LauchDate");
            }

            if (model.ProductStatus != null)
            {
                fileds.Add("[ProductStatus]=@ProductStatus");
                pms.Add(new SqlParameter("ProductStatus", model.ProductStatus));
            }

            if (model.HaveBatch != null)
            {
                fileds.Add("[HaveBatch]=@HaveBatch");
                pms.Add(new SqlParameter("HaveBatch", model.HaveBatch));
            }

            if (model.IsPromotion != null)
            {
                fileds.Add("[IsPromotion]=@IsPromotion");
                pms.Add(new SqlParameter("IsPromotion", model.IsPromotion));
            }

            if (model.CanExcuteAlone != null)
            {
                fileds.Add("[CanExcuteAlone]=@CanExcuteAlone");
                pms.Add(new SqlParameter("CanExcuteAlone", model.CanExcuteAlone));
            }

            if (model.LessSaleNumber != null)
            {
                fileds.Add("[LessSaleNumber]=@LessSaleNumber");
                pms.Add(new SqlParameter("LessSaleNumber", model.LessSaleNumber));
            }

            if (model.SellingPropertyNumber != null)
            {
                fileds.Add("[SellingPropertyNumber]=@SellingPropertyNumber");
                pms.Add(new SqlParameter("SellingPropertyNumber", model.SellingPropertyNumber));
            }

            if (model.SellingPropertyId != null)
            {
                fileds.Add("[SellingPropertyId]=@SellingPropertyId");
                pms.Add(new SqlParameter("SellingPropertyId", model.SellingPropertyId));
            }

            if (model.UnitTypeId != null)
            {
                fileds.Add("[UnitTypeId]=@UnitTypeId");
                pms.Add(new SqlParameter("UnitTypeId", model.UnitTypeId));
            }

            if (model.UnitPrice != null)
            {
                fileds.Add("[UnitPrice]=@UnitPrice");
                pms.Add(new SqlParameter("UnitPrice", model.UnitPrice));
            }

            if (model.MaxDiscount != null)
            {
                fileds.Add("[MaxDiscount]=@MaxDiscount");
                pms.Add(new SqlParameter("MaxDiscount", model.MaxDiscount));
            }

            if (model.PayTimes != null)
            {
                fileds.Add("[PayTimes]=@PayTimes");
                pms.Add(new SqlParameter("PayTimes", model.PayTimes));
            }

            if (model.StartSellingDate != null && model.StartSellingDate != new DateTime())
            {
                fileds.Add("[StartSellingDate]=@StartSellingDate");
            }

            if (model.EndSellingDate != null && model.EndSellingDate != new DateTime())
            {
                fileds.Add("[EndSellingDate]=@EndSellingDate");
            }

            if (model.ReliantProductId != null)
            {
                fileds.Add("[ReliantProductId]=@ReliantProductId");
                pms.Add(new SqlParameter("ReliantProductId", model.ReliantProductId));
            }

            if (model.ContractMoney != null)
            {
                fileds.Add("[ContractMoney]=@ContractMoney");
                pms.Add(new SqlParameter("ContractMoney", model.ContractMoney));
            }

            if (model.ContractMoneyUnitTypeId != null)
            {
                fileds.Add("[ContractMoneyUnitTypeId]=@ContractMoneyUnitTypeId");
                pms.Add(new SqlParameter("ContractMoneyUnitTypeId", model.ContractMoneyUnitTypeId));
            }

            if (model.MaxUseTimes != null)
            {
                fileds.Add("[MaxUseTimes]=@MaxUseTimes");
                pms.Add(new SqlParameter("MaxUseTimes", model.MaxUseTimes));
            }

            if (model.ServiceValidTimeUnitId != null)
            {
                fileds.Add("[ServiceValidTimeUnitId]=@ServiceValidTimeUnitId");
                pms.Add(new SqlParameter("ServiceValidTimeUnitId", model.ServiceValidTimeUnitId));
            }

            if (model.ServiceValidTimeLength != null)
            {
                fileds.Add("[ServiceValidTimeLength]=@ServiceValidTimeLength");
                pms.Add(new SqlParameter("ServiceValidTimeLength", model.ServiceValidTimeLength));
            }

            if (model.ExcuteTimePointId != null)
            {
                fileds.Add("[ExcuteTimePointId]=@ExcuteTimePointId");
                pms.Add(new SqlParameter("ExcuteTimePointId", model.ExcuteTimePointId));
            }

            if (model.ExcuteValidTimeLength != null)
            {
                fileds.Add("[ExcuteValidTimeLength]=@ExcuteValidTimeLength");
                pms.Add(new SqlParameter("ExcuteValidTimeLength", model.ExcuteValidTimeLength));
            }

            if (model.ExcuteDate != null && model.ExcuteDate != new DateTime())
            {
                fileds.Add("[ExcuteDate]=@ExcuteDate");
            }

            if (model.EndTimePointId != null)
            {
                fileds.Add("[EndTimePointId]=@EndTimePointId");
                pms.Add(new SqlParameter("EndTimePointId", model.EndTimePointId));
            }

            if (model.EndTimeLength != null)
            {
                fileds.Add("[EndTimeLength]=@EndTimeLength");
                pms.Add(new SqlParameter("EndTimeLength", model.EndTimeLength));
            }

            if (model.EndDate != null && model.EndDate != new DateTime())
            {
                fileds.Add("[EndDate]=@EndDate");
            }

            if (model.IsExcutedInPhases != null)
            {
                fileds.Add("[IsExcutedInPhases]=@IsExcutedInPhases");
                pms.Add(new SqlParameter("IsExcutedInPhases", model.IsExcutedInPhases));
            }

            if (model.PhaseExcuteTimes != null)
            {
                fileds.Add("[PhaseExcuteTimes]=@PhaseExcuteTimes");
                pms.Add(new SqlParameter("PhaseExcuteTimes", model.PhaseExcuteTimes));
            }

            if (model.CreatorUserId != null)
            {
                fileds.Add("[CreatorUserId]=@CreatorUserId");
                pms.Add(new SqlParameter("CreatorUserId", model.CreatorUserId));
            }

            if (model.CreatorPassportId != null)
            {
                fileds.Add("[CreatorPassportId]=@CreatorPassportId");
                pms.Add(new SqlParameter("CreatorPassportId", model.CreatorPassportId));
            }

            if (model.AreaId != null)
            {
                fileds.Add("[AreaId]=@AreaId");
                pms.Add(new SqlParameter("AreaId", model.AreaId));
            }

            if (model.SchoolId != null)
            {
                fileds.Add("[SchoolId]=@SchoolId");
                pms.Add(new SqlParameter("SchoolId", model.SchoolId));
            }

            if (model.ServiceFeeType != null)
            {
                fileds.Add("[ServiceFeeType]=@ServiceFeeType");
                pms.Add(new SqlParameter("ServiceFeeType", model.ServiceFeeType));
            }

            if (model.PromiseCourseCount != null)
            {
                fileds.Add("[PromiseCourseCount]=@PromiseCourseCount");
                pms.Add(new SqlParameter("PromiseCourseCount", model.PromiseCourseCount));
            }

            if (model.PromiseCourseTotalPrice != null)
            {
                fileds.Add("[PromiseCourseTotalPrice]=@PromiseCourseTotalPrice");
                pms.Add(new SqlParameter("PromiseCourseTotalPrice", model.PromiseCourseTotalPrice));
            }

            if (model.CreatorUserName != null)
            {
                fileds.Add("[CreatorUserName]=@CreatorUserName");
                pms.Add(new SqlParameter("CreatorUserName", model.CreatorUserName));
            }

            if (model.LastModifyDate != null && model.LastModifyDate != new DateTime())
            {
                fileds.Add("[LastModifyDate]=@LastModifyDate");
            }

            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]=@OrgPath");
                pms.Add(new SqlParameter("OrgPath", model.OrgPath));
            }

            if (model.JobPassportId != null)
            {
                fileds.Add("[JobPassportId]=@JobPassportId");
                pms.Add(new SqlParameter("JobPassportId", model.JobPassportId));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update ProductsBasic set ");
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

        public static bool Save(ProductsBasic model)
        {
            string sqlStr = "select count(1) from ProductsBasic where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
            sqlStr += " and ProductId=@ProductId ";
            pms.Add(new SqlParameter("ProductId", model.ProductId));
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i = (int)db.ExecuteScalar(cmd);
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