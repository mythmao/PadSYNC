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
    public partial class PurchaseOrdersBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudTrade");


        public static List<PurchaseOrders> Search(string sqlStr, params SqlParameter[] parameters)
        {
            List<PurchaseOrders> list = new List<PurchaseOrders>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        PurchaseOrders model = new PurchaseOrders(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(PurchaseOrders model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段


            if (model.OrderCode != null)
            {
                fileds.Add("[OrderCode]");
                pFileds.Add("@OrderCode");
                pms.Add(new SqlParameter("OrderCode", model.OrderCode));
            }

            if (model.PreviousContractID != null)
            {
                fileds.Add("[PreviousContractID]");
                pFileds.Add("@PreviousContractID");
                pms.Add(new SqlParameter("PreviousContractID", model.PreviousContractID));
            }

            if (model.SignUserID != null)
            {
                fileds.Add("[SignUserID]");
                pFileds.Add("@SignUserID");
                pms.Add(new SqlParameter("SignUserID", model.SignUserID));
            }

            if (model.SignUserPassportID != null)
            {
                fileds.Add("[SignUserPassportID]");
                pFileds.Add("@SignUserPassportID");
                pms.Add(new SqlParameter("SignUserPassportID", model.SignUserPassportID));
            }

            if (model.SignUserJobID != null)
            {
                fileds.Add("[SignUserJobID]");
                pFileds.Add("@SignUserJobID");
                pms.Add(new SqlParameter("SignUserJobID", model.SignUserJobID));
            }

            if (model.SignUserJobPassportID != null)
            {
                fileds.Add("[SignUserJobPassportID]");
                pFileds.Add("@SignUserJobPassportID");
                pms.Add(new SqlParameter("SignUserJobPassportID", model.SignUserJobPassportID));
            }

            if (model.ownerUserPath != null)
            {
                fileds.Add("[ownerUserPath]");
                pFileds.Add("@ownerUserPath");
                pms.Add(new SqlParameter("ownerUserPath", model.ownerUserPath));
            }

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]");
                pFileds.Add("@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]");
                pFileds.Add("@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }

            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]");
                pFileds.Add("@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }

            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]");
                pFileds.Add("@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }

            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]");
                pFileds.Add("@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]");
                pFileds.Add("@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }

            if (model.DepID != null)
            {
                fileds.Add("[DepID]");
                pFileds.Add("@DepID");
                pms.Add(new SqlParameter("DepID", model.DepID));
            }

            if (model.ServiceFee != null)
            {
                fileds.Add("[ServiceFee]");
                pFileds.Add("@ServiceFee");
                pms.Add(new SqlParameter("ServiceFee", model.ServiceFee));
            }

            if (model.AccountReceived != null)
            {
                fileds.Add("[AccountReceived]");
                pFileds.Add("@AccountReceived");
                pms.Add(new SqlParameter("AccountReceived", model.AccountReceived));
            }

            if (model.ApproveDiscount != null)
            {
                fileds.Add("[ApproveDiscount]");
                pFileds.Add("@ApproveDiscount");
                pms.Add(new SqlParameter("ApproveDiscount", model.ApproveDiscount));
            }

            if (model.Reason != null)
            {
                fileds.Add("[Reason]");
                pFileds.Add("@Reason");
                pms.Add(new SqlParameter("Reason", model.Reason));
            }

            if (model.SignDate != null && model.SignDate != new DateTime())
            {
                fileds.Add("[SignDate]");
                pFileds.Add("@SignDate");
                pms.Add(new SqlParameter("SignDate", model.SignDate));
            }

            if (model.SubmitDate != null && model.SubmitDate != new DateTime())
            {
                fileds.Add("[SubmitDate]");
                pFileds.Add("@SubmitDate");
                pms.Add(new SqlParameter("SubmitDate", model.SubmitDate));
            }

            if (model.OrderStatus != null)
            {
                fileds.Add("[OrderStatus]");
                pFileds.Add("@OrderStatus");
                pms.Add(new SqlParameter("OrderStatus", model.OrderStatus));
            }

            if (model.ReturnStatus != null)
            {
                fileds.Add("[ReturnStatus]");
                pFileds.Add("@ReturnStatus");
                pms.Add(new SqlParameter("ReturnStatus", model.ReturnStatus));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]");
                pFileds.Add("@CreateDate");
                pms.Add(new SqlParameter("CreateDate", model.CreateDate));
            }

            if (model.LastModifiedDate != null && model.LastModifiedDate != new DateTime())
            {
                fileds.Add("[LastModifiedDate]");
                pFileds.Add("@LastModifiedDate");
                pms.Add(new SqlParameter("LastModifiedDate", model.LastModifiedDate));
            }

            if (model.SubmitUserID != null)
            {
                fileds.Add("[SubmitUserID]");
                pFileds.Add("@SubmitUserID");
                pms.Add(new SqlParameter("SubmitUserID", model.SubmitUserID));
            }

            if (model.SubmitUserJobID != null)
            {
                fileds.Add("[SubmitUserJobID]");
                pFileds.Add("@SubmitUserJobID");
                pms.Add(new SqlParameter("SubmitUserJobID", model.SubmitUserJobID));
            }

            if (model.SubmitUserPassportID != null)
            {
                fileds.Add("[SubmitUserPassportID]");
                pFileds.Add("@SubmitUserPassportID");
                pms.Add(new SqlParameter("SubmitUserPassportID", model.SubmitUserPassportID));
            }

            if (model.SubmitUserJobPassportID != null)
            {
                fileds.Add("[SubmitUserJobPassportID]");
                pFileds.Add("@SubmitUserJobPassportID");
                pms.Add(new SqlParameter("SubmitUserJobPassportID", model.SubmitUserJobPassportID));
            }

            if (model.MJobPassportID != null)
            {
                fileds.Add("[MJobPassportID]");
                pFileds.Add("@MJobPassportID");
                pms.Add(new SqlParameter("MJobPassportID", model.MJobPassportID));
            }

            if (model.ownerJobpassportID != null)
            {
                fileds.Add("[ownerJobpassportID]");
                pFileds.Add("@ownerJobpassportID");
                pms.Add(new SqlParameter("ownerJobpassportID", model.ownerJobpassportID));
            }

            if (model.ownerJobID != null)
            {
                fileds.Add("[ownerJobID]");
                pFileds.Add("@ownerJobID");
                pms.Add(new SqlParameter("ownerJobID", model.ownerJobID));
            }

            if (model.EnterUserID != null)
            {
                fileds.Add("[EnterUserID]");
                pFileds.Add("@EnterUserID");
                pms.Add(new SqlParameter("EnterUserID", model.EnterUserID));
            }

            if (model.EnterUserJobID != null)
            {
                fileds.Add("[EnterUserJobID]");
                pFileds.Add("@EnterUserJobID");
                pms.Add(new SqlParameter("EnterUserJobID", model.EnterUserJobID));
            }

            if (model.EnterUserPassportID != null)
            {
                fileds.Add("[EnterUserPassportID]");
                pFileds.Add("@EnterUserPassportID");
                pms.Add(new SqlParameter("EnterUserPassportID", model.EnterUserPassportID));
            }

            if (model.EnterUserJobPassportID != null)
            {
                fileds.Add("[EnterUserJobPassportID]");
                pFileds.Add("@EnterUserJobPassportID");
                pms.Add(new SqlParameter("EnterUserJobPassportID", model.EnterUserJobPassportID));
            }

            if (model.EnterUserName != null)
            {
                fileds.Add("[EnterUserName]");
                pFileds.Add("@EnterUserName");
                pms.Add(new SqlParameter("EnterUserName", model.EnterUserName));
            }

            if (model.ParentEnterUserID != null)
            {
                fileds.Add("[ParentEnterUserID]");
                pFileds.Add("@ParentEnterUserID");
                pms.Add(new SqlParameter("ParentEnterUserID", model.ParentEnterUserID));
            }

            if (model.ParentEnterUserJobID != null)
            {
                fileds.Add("[ParentEnterUserJobID]");
                pFileds.Add("@ParentEnterUserJobID");
                pms.Add(new SqlParameter("ParentEnterUserJobID", model.ParentEnterUserJobID));
            }

            if (model.ParentEnterUserPassportID != null)
            {
                fileds.Add("[ParentEnterUserPassportID]");
                pFileds.Add("@ParentEnterUserPassportID");
                pms.Add(new SqlParameter("ParentEnterUserPassportID", model.ParentEnterUserPassportID));
            }

            if (model.ParentEnterUserJobPassportID != null)
            {
                fileds.Add("[ParentEnterUserJobPassportID]");
                pFileds.Add("@ParentEnterUserJobPassportID");
                pms.Add(new SqlParameter("ParentEnterUserJobPassportID", model.ParentEnterUserJobPassportID));
            }

            if (model.EnterUserOrgPath != null)
            {
                fileds.Add("[EnterUserOrgPath]");
                pFileds.Add("@EnterUserOrgPath");
                pms.Add(new SqlParameter("EnterUserOrgPath", model.EnterUserOrgPath));
            }

            if (model.ParentEnterUserOrgPath != null)
            {
                fileds.Add("[ParentEnterUserOrgPath]");
                pFileds.Add("@ParentEnterUserOrgPath");
                pms.Add(new SqlParameter("ParentEnterUserOrgPath", model.ParentEnterUserOrgPath));
            }

            if (model.CustomerFromSystem != null)
            {
                fileds.Add("[CustomerFromSystem]");
                pFileds.Add("@CustomerFromSystem");
                pms.Add(new SqlParameter("CustomerFromSystem", model.CustomerFromSystem));
            }

            if (model.StudentFromSystem != null)
            {
                fileds.Add("[StudentFromSystem]");
                pFileds.Add("@StudentFromSystem");
                pms.Add(new SqlParameter("StudentFromSystem", model.StudentFromSystem));
            }

            if (model.CustomerCallType != null)
            {
                fileds.Add("[CustomerCallType]");
                pFileds.Add("@CustomerCallType");
                pms.Add(new SqlParameter("CustomerCallType", model.CustomerCallType));
            }

            if (model.StudentCallType != null)
            {
                fileds.Add("[StudentCallType]");
                pFileds.Add("@StudentCallType");
                pms.Add(new SqlParameter("StudentCallType", model.StudentCallType));
            }

            if (model.TeachingPlaceID != null)
            {
                fileds.Add("[TeachingPlaceID]");
                pFileds.Add("@TeachingPlaceID");
                pms.Add(new SqlParameter("TeachingPlaceID", model.TeachingPlaceID));
            }

            if (model.InquiryPlaceID != null)
            {
                fileds.Add("[InquiryPlaceID]");
                pFileds.Add("@InquiryPlaceID");
                pms.Add(new SqlParameter("InquiryPlaceID", model.InquiryPlaceID));
            }

            if (model.StudentEnterUserType != null)
            {
                fileds.Add("[StudentEnterUserType]");
                pFileds.Add("@StudentEnterUserType");
                pms.Add(new SqlParameter("StudentEnterUserType", model.StudentEnterUserType));
            }

            if (model.SourceTypePath != null)
            {
                fileds.Add("[SourceTypePath]");
                pFileds.Add("@SourceTypePath");
                pms.Add(new SqlParameter("SourceTypePath", model.SourceTypePath));
            }

            if (model.OrderClass != null)
            {
                fileds.Add("[OrderClass]");
                pFileds.Add("@OrderClass");
                pms.Add(new SqlParameter("OrderClass", model.OrderClass));
            }

            if (model.ServiceFeeUnsubscribe != null)
            {
                fileds.Add("[ServiceFeeUnsubscribe]");
                pFileds.Add("@ServiceFeeUnsubscribe");
                pms.Add(new SqlParameter("ServiceFeeUnsubscribe", model.ServiceFeeUnsubscribe));
            }

            if (model.OrderType != null)
            {
                fileds.Add("[OrderType]");
                pFileds.Add("@OrderType");
                pms.Add(new SqlParameter("OrderType", model.OrderType));
            }

            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO PurchaseOrders (");
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

        public static bool Update(PurchaseOrders model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[OrderID]=@OrderID");
            pms.Add(new SqlParameter("OrderID", model.OrderID));

            if (model.OrderCode != null)
            {
                fileds.Add("[OrderCode]=@OrderCode");
                pms.Add(new SqlParameter("OrderCode", model.OrderCode));
            }

            if (model.PreviousContractID != null)
            {
                fileds.Add("[PreviousContractID]=@PreviousContractID");
                pms.Add(new SqlParameter("PreviousContractID", model.PreviousContractID));
            }

            if (model.SignUserID != null)
            {
                fileds.Add("[SignUserID]=@SignUserID");
                pms.Add(new SqlParameter("SignUserID", model.SignUserID));
            }

            if (model.SignUserPassportID != null)
            {
                fileds.Add("[SignUserPassportID]=@SignUserPassportID");
                pms.Add(new SqlParameter("SignUserPassportID", model.SignUserPassportID));
            }

            if (model.SignUserJobID != null)
            {
                fileds.Add("[SignUserJobID]=@SignUserJobID");
                pms.Add(new SqlParameter("SignUserJobID", model.SignUserJobID));
            }

            if (model.SignUserJobPassportID != null)
            {
                fileds.Add("[SignUserJobPassportID]=@SignUserJobPassportID");
                pms.Add(new SqlParameter("SignUserJobPassportID", model.SignUserJobPassportID));
            }

            if (model.ownerUserPath != null)
            {
                fileds.Add("[ownerUserPath]=@ownerUserPath");
                pms.Add(new SqlParameter("ownerUserPath", model.ownerUserPath));
            }

            if (model.CustomerID != null)
            {
                fileds.Add("[CustomerID]=@CustomerID");
                pms.Add(new SqlParameter("CustomerID", model.CustomerID));
            }

            if (model.CustomerPassportID != null)
            {
                fileds.Add("[CustomerPassportID]=@CustomerPassportID");
                pms.Add(new SqlParameter("CustomerPassportID", model.CustomerPassportID));
            }

            if (model.StudentID != null)
            {
                fileds.Add("[StudentID]=@StudentID");
                pms.Add(new SqlParameter("StudentID", model.StudentID));
            }

            if (model.StudentPassportID != null)
            {
                fileds.Add("[StudentPassportID]=@StudentPassportID");
                pms.Add(new SqlParameter("StudentPassportID", model.StudentPassportID));
            }

            if (model.CompanyID != null)
            {
                fileds.Add("[CompanyID]=@CompanyID");
                pms.Add(new SqlParameter("CompanyID", model.CompanyID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]=@SchoolID");
                pms.Add(new SqlParameter("SchoolID", model.SchoolID));
            }

            if (model.DepID != null)
            {
                fileds.Add("[DepID]=@DepID");
                pms.Add(new SqlParameter("DepID", model.DepID));
            }

            if (model.ServiceFee != null)
            {
                fileds.Add("[ServiceFee]=@ServiceFee");
                pms.Add(new SqlParameter("ServiceFee", model.ServiceFee));
            }

            if (model.AccountReceived != null)
            {
                fileds.Add("[AccountReceived]=@AccountReceived");
                pms.Add(new SqlParameter("AccountReceived", model.AccountReceived));
            }

            if (model.ApproveDiscount != null)
            {
                fileds.Add("[ApproveDiscount]=@ApproveDiscount");
                pms.Add(new SqlParameter("ApproveDiscount", model.ApproveDiscount));
            }

            if (model.Reason != null)
            {
                fileds.Add("[Reason]=@Reason");
                pms.Add(new SqlParameter("Reason", model.Reason));
            }

            if (model.SignDate != null && model.SignDate != new DateTime())
            {
                fileds.Add("[SignDate]=@SignDate");
            }

            if (model.SubmitDate != null && model.SubmitDate != new DateTime())
            {
                fileds.Add("[SubmitDate]=@SubmitDate");
            }

            if (model.OrderStatus != null)
            {
                fileds.Add("[OrderStatus]=@OrderStatus");
                pms.Add(new SqlParameter("OrderStatus", model.OrderStatus));
            }

            if (model.ReturnStatus != null)
            {
                fileds.Add("[ReturnStatus]=@ReturnStatus");
                pms.Add(new SqlParameter("ReturnStatus", model.ReturnStatus));
            }

            if (model.CreateDate != null && model.CreateDate != new DateTime())
            {
                fileds.Add("[CreateDate]=@CreateDate");
            }

            if (model.LastModifiedDate != null && model.LastModifiedDate != new DateTime())
            {
                fileds.Add("[LastModifiedDate]=@LastModifiedDate");
            }

            if (model.SubmitUserID != null)
            {
                fileds.Add("[SubmitUserID]=@SubmitUserID");
                pms.Add(new SqlParameter("SubmitUserID", model.SubmitUserID));
            }

            if (model.SubmitUserJobID != null)
            {
                fileds.Add("[SubmitUserJobID]=@SubmitUserJobID");
                pms.Add(new SqlParameter("SubmitUserJobID", model.SubmitUserJobID));
            }

            if (model.SubmitUserPassportID != null)
            {
                fileds.Add("[SubmitUserPassportID]=@SubmitUserPassportID");
                pms.Add(new SqlParameter("SubmitUserPassportID", model.SubmitUserPassportID));
            }

            if (model.SubmitUserJobPassportID != null)
            {
                fileds.Add("[SubmitUserJobPassportID]=@SubmitUserJobPassportID");
                pms.Add(new SqlParameter("SubmitUserJobPassportID", model.SubmitUserJobPassportID));
            }

            if (model.MJobPassportID != null)
            {
                fileds.Add("[MJobPassportID]=@MJobPassportID");
                pms.Add(new SqlParameter("MJobPassportID", model.MJobPassportID));
            }

            if (model.ownerJobpassportID != null)
            {
                fileds.Add("[ownerJobpassportID]=@ownerJobpassportID");
                pms.Add(new SqlParameter("ownerJobpassportID", model.ownerJobpassportID));
            }

            if (model.ownerJobID != null)
            {
                fileds.Add("[ownerJobID]=@ownerJobID");
                pms.Add(new SqlParameter("ownerJobID", model.ownerJobID));
            }

            if (model.EnterUserID != null)
            {
                fileds.Add("[EnterUserID]=@EnterUserID");
                pms.Add(new SqlParameter("EnterUserID", model.EnterUserID));
            }

            if (model.EnterUserJobID != null)
            {
                fileds.Add("[EnterUserJobID]=@EnterUserJobID");
                pms.Add(new SqlParameter("EnterUserJobID", model.EnterUserJobID));
            }

            if (model.EnterUserPassportID != null)
            {
                fileds.Add("[EnterUserPassportID]=@EnterUserPassportID");
                pms.Add(new SqlParameter("EnterUserPassportID", model.EnterUserPassportID));
            }

            if (model.EnterUserJobPassportID != null)
            {
                fileds.Add("[EnterUserJobPassportID]=@EnterUserJobPassportID");
                pms.Add(new SqlParameter("EnterUserJobPassportID", model.EnterUserJobPassportID));
            }

            if (model.EnterUserName != null)
            {
                fileds.Add("[EnterUserName]=@EnterUserName");
                pms.Add(new SqlParameter("EnterUserName", model.EnterUserName));
            }

            if (model.ParentEnterUserID != null)
            {
                fileds.Add("[ParentEnterUserID]=@ParentEnterUserID");
                pms.Add(new SqlParameter("ParentEnterUserID", model.ParentEnterUserID));
            }

            if (model.ParentEnterUserJobID != null)
            {
                fileds.Add("[ParentEnterUserJobID]=@ParentEnterUserJobID");
                pms.Add(new SqlParameter("ParentEnterUserJobID", model.ParentEnterUserJobID));
            }

            if (model.ParentEnterUserPassportID != null)
            {
                fileds.Add("[ParentEnterUserPassportID]=@ParentEnterUserPassportID");
                pms.Add(new SqlParameter("ParentEnterUserPassportID", model.ParentEnterUserPassportID));
            }

            if (model.ParentEnterUserJobPassportID != null)
            {
                fileds.Add("[ParentEnterUserJobPassportID]=@ParentEnterUserJobPassportID");
                pms.Add(new SqlParameter("ParentEnterUserJobPassportID", model.ParentEnterUserJobPassportID));
            }

            if (model.EnterUserOrgPath != null)
            {
                fileds.Add("[EnterUserOrgPath]=@EnterUserOrgPath");
                pms.Add(new SqlParameter("EnterUserOrgPath", model.EnterUserOrgPath));
            }

            if (model.ParentEnterUserOrgPath != null)
            {
                fileds.Add("[ParentEnterUserOrgPath]=@ParentEnterUserOrgPath");
                pms.Add(new SqlParameter("ParentEnterUserOrgPath", model.ParentEnterUserOrgPath));
            }

            if (model.CustomerFromSystem != null)
            {
                fileds.Add("[CustomerFromSystem]=@CustomerFromSystem");
                pms.Add(new SqlParameter("CustomerFromSystem", model.CustomerFromSystem));
            }

            if (model.StudentFromSystem != null)
            {
                fileds.Add("[StudentFromSystem]=@StudentFromSystem");
                pms.Add(new SqlParameter("StudentFromSystem", model.StudentFromSystem));
            }

            if (model.CustomerCallType != null)
            {
                fileds.Add("[CustomerCallType]=@CustomerCallType");
                pms.Add(new SqlParameter("CustomerCallType", model.CustomerCallType));
            }

            if (model.StudentCallType != null)
            {
                fileds.Add("[StudentCallType]=@StudentCallType");
                pms.Add(new SqlParameter("StudentCallType", model.StudentCallType));
            }

            if (model.TeachingPlaceID != null)
            {
                fileds.Add("[TeachingPlaceID]=@TeachingPlaceID");
                pms.Add(new SqlParameter("TeachingPlaceID", model.TeachingPlaceID));
            }

            if (model.InquiryPlaceID != null)
            {
                fileds.Add("[InquiryPlaceID]=@InquiryPlaceID");
                pms.Add(new SqlParameter("InquiryPlaceID", model.InquiryPlaceID));
            }

            if (model.StudentEnterUserType != null)
            {
                fileds.Add("[StudentEnterUserType]=@StudentEnterUserType");
                pms.Add(new SqlParameter("StudentEnterUserType", model.StudentEnterUserType));
            }

            if (model.SourceTypePath != null)
            {
                fileds.Add("[SourceTypePath]=@SourceTypePath");
                pms.Add(new SqlParameter("SourceTypePath", model.SourceTypePath));
            }

            if (model.OrderClass != null)
            {
                fileds.Add("[OrderClass]=@OrderClass");
                pms.Add(new SqlParameter("OrderClass", model.OrderClass));
            }

            if (model.ServiceFeeUnsubscribe != null)
            {
                fileds.Add("[ServiceFeeUnsubscribe]=@ServiceFeeUnsubscribe");
                pms.Add(new SqlParameter("ServiceFeeUnsubscribe", model.ServiceFeeUnsubscribe));
            }

            if (model.OrderType != null)
            {
                fileds.Add("[OrderType]=@OrderType");
                pms.Add(new SqlParameter("OrderType", model.OrderType));
            }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update PurchaseOrders set ");
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

        public static bool Save(PurchaseOrders model)
        {
            string sqlStr = "select count(1) from PurchaseOrders where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
            sqlStr += " and OrderID=@OrderID ";
            pms.Add(new SqlParameter("OrderID", model.OrderID));
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