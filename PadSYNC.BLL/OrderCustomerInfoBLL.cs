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
    public  partial class OrderCustomerInfoBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudTrade");
        
        
        public static List<OrderCustomerInfo> Search(string sqlStr,params SqlParameter[] parameters)
        {
            List<OrderCustomerInfo> list = new List<OrderCustomerInfo>();
            using(DbCommand cmd=db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if(ds!=null&&ds.Tables.Count>0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        OrderCustomerInfo model = new OrderCustomerInfo(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(OrderCustomerInfo model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            
            
                if(model.OrderID!=null)
                {
                    fileds.Add("[OrderID]");
                    pFileds.Add("@OrderID");
                    pms.Add(new SqlParameter("OrderID", model.OrderID));
                }
            
                if(model.SignUserID!=null)
                {
                    fileds.Add("[SignUserID]");
                    pFileds.Add("@SignUserID");
                    pms.Add(new SqlParameter("SignUserID", model.SignUserID));
                }
            
                if(model.SignUserName!=null)
                {
                    fileds.Add("[SignUserName]");
                    pFileds.Add("@SignUserName");
                    pms.Add(new SqlParameter("SignUserName", model.SignUserName));
                }
            
                if(model.SchoolID!=null)
                {
                    fileds.Add("[SchoolID]");
                    pFileds.Add("@SchoolID");
                    pms.Add(new SqlParameter("SchoolID", model.SchoolID));
                }
            
                if(model.SchoolName!=null)
                {
                    fileds.Add("[SchoolName]");
                    pFileds.Add("@SchoolName");
                    pms.Add(new SqlParameter("SchoolName", model.SchoolName));
                }
            
                if(model.SchoolPhone!=null)
                {
                    fileds.Add("[SchoolPhone]");
                    pFileds.Add("@SchoolPhone");
                    pms.Add(new SqlParameter("SchoolPhone", model.SchoolPhone));
                }
            
                if(model.SchoolAddress!=null)
                {
                    fileds.Add("[SchoolAddress]");
                    pFileds.Add("@SchoolAddress");
                    pms.Add(new SqlParameter("SchoolAddress", model.SchoolAddress));
                }
            
                if(model.LeagleOwner!=null)
                {
                    fileds.Add("[LeagleOwner]");
                    pFileds.Add("@LeagleOwner");
                    pms.Add(new SqlParameter("LeagleOwner", model.LeagleOwner));
                }
            
                if(model.CustomerID!=null)
                {
                    fileds.Add("[CustomerID]");
                    pFileds.Add("@CustomerID");
                    pms.Add(new SqlParameter("CustomerID", model.CustomerID));
                }
            
                if(model.CustomerName!=null)
                {
                    fileds.Add("[CustomerName]");
                    pFileds.Add("@CustomerName");
                    pms.Add(new SqlParameter("CustomerName", model.CustomerName));
                }
            
                if(model.CustomerCode!=null)
                {
                    fileds.Add("[CustomerCode]");
                    pFileds.Add("@CustomerCode");
                    pms.Add(new SqlParameter("CustomerCode", model.CustomerCode));
                }
            
                if(model.CustomerIDCard!=null)
                {
                    fileds.Add("[CustomerIDCard]");
                    pFileds.Add("@CustomerIDCard");
                    pms.Add(new SqlParameter("CustomerIDCard", model.CustomerIDCard));
                }
            
                if(model.CustomerCellPhone!=null)
                {
                    fileds.Add("[CustomerCellPhone]");
                    pFileds.Add("@CustomerCellPhone");
                    pms.Add(new SqlParameter("CustomerCellPhone", model.CustomerCellPhone));
                }
            
                if(model.CustomerPhone!=null)
                {
                    fileds.Add("[CustomerPhone]");
                    pFileds.Add("@CustomerPhone");
                    pms.Add(new SqlParameter("CustomerPhone", model.CustomerPhone));
                }
            
                if(model.CustomerAddress!=null)
                {
                    fileds.Add("[CustomerAddress]");
                    pFileds.Add("@CustomerAddress");
                    pms.Add(new SqlParameter("CustomerAddress", model.CustomerAddress));
                }
            
                if(model.Province!=null)
                {
                    fileds.Add("[Province]");
                    pFileds.Add("@Province");
                    pms.Add(new SqlParameter("Province", model.Province));
                }
            
                if(model.City!=null)
                {
                    fileds.Add("[City]");
                    pFileds.Add("@City");
                    pms.Add(new SqlParameter("City", model.City));
                }
            
                if(model.County!=null)
                {
                    fileds.Add("[County]");
                    pFileds.Add("@County");
                    pms.Add(new SqlParameter("County", model.County));
                }
            
                if(model.AddressDetail!=null)
                {
                    fileds.Add("[AddressDetail]");
                    pFileds.Add("@AddressDetail");
                    pms.Add(new SqlParameter("AddressDetail", model.AddressDetail));
                }
            
                if(model.CustomerPostCode!=null)
                {
                    fileds.Add("[CustomerPostCode]");
                    pFileds.Add("@CustomerPostCode");
                    pms.Add(new SqlParameter("CustomerPostCode", model.CustomerPostCode));
                }
            
                if(model.CustomerEmail!=null)
                {
                    fileds.Add("[CustomerEmail]");
                    pFileds.Add("@CustomerEmail");
                    pms.Add(new SqlParameter("CustomerEmail", model.CustomerEmail));
                }
            
                if(model.IsPrimary!=null)
                {
                    fileds.Add("[IsPrimary]");
                    pFileds.Add("@IsPrimary");
                    pms.Add(new SqlParameter("IsPrimary", model.IsPrimary));
                }
            
                if(model.StudentID!=null)
                {
                    fileds.Add("[StudentID]");
                    pFileds.Add("@StudentID");
                    pms.Add(new SqlParameter("StudentID", model.StudentID));
                }
            
                if(model.StudentCode!=null)
                {
                    fileds.Add("[StudentCode]");
                    pFileds.Add("@StudentCode");
                    pms.Add(new SqlParameter("StudentCode", model.StudentCode));
                }
            
                if(model.StudentName!=null)
                {
                    fileds.Add("[StudentName]");
                    pFileds.Add("@StudentName");
                    pms.Add(new SqlParameter("StudentName", model.StudentName));
                }
            
                if(model.StudentSex!=null)
                {
                    fileds.Add("[StudentSex]");
                    pFileds.Add("@StudentSex");
                    pms.Add(new SqlParameter("StudentSex", model.StudentSex));
                }
            
                if(model.StudentBirthday!=null&&model.StudentBirthday!=new DateTime())
                {
                    fileds.Add("[StudentBirthday]");
                    pFileds.Add("@StudentBirthday");
                    pms.Add(new SqlParameter("StudentBirthday", model.StudentBirthday));
                }
            
                if(model.StudentSchoolName!=null)
                {
                    fileds.Add("[StudentSchoolName]");
                    pFileds.Add("@StudentSchoolName");
                    pms.Add(new SqlParameter("StudentSchoolName", model.StudentSchoolName));
                }
            
                if(model.StudentGrade!=null)
                {
                    fileds.Add("[StudentGrade]");
                    pFileds.Add("@StudentGrade");
                    pms.Add(new SqlParameter("StudentGrade", model.StudentGrade));
                }
            
                if(model.ParentRole!=null)
                {
                    fileds.Add("[ParentRole]");
                    pFileds.Add("@ParentRole");
                    pms.Add(new SqlParameter("ParentRole", model.ParentRole));
                }
            
                if(model.StudentRole!=null)
                {
                    fileds.Add("[StudentRole]");
                    pFileds.Add("@StudentRole");
                    pms.Add(new SqlParameter("StudentRole", model.StudentRole));
                }
            
                if(model.LastModifiedDate!=null&&model.LastModifiedDate!=new DateTime())
                {
                    fileds.Add("[LastModifiedDate]");
                    pFileds.Add("@LastModifiedDate");
                    pms.Add(new SqlParameter("LastModifiedDate", model.LastModifiedDate));
                }
            
                if(model.OrderCode!=null)
                {
                    fileds.Add("[OrderCode]");
                    pFileds.Add("@OrderCode");
                    pms.Add(new SqlParameter("OrderCode", model.OrderCode));
                }
            
                if(model.DepID!=null)
                {
                    fileds.Add("[DepID]");
                    pFileds.Add("@DepID");
                    pms.Add(new SqlParameter("DepID", model.DepID));
                }
            
                if(model.DepName!=null)
                {
                    fileds.Add("[DepName]");
                    pFileds.Add("@DepName");
                    pms.Add(new SqlParameter("DepName", model.DepName));
                }
            
                if(model.CustomerIDCardType!=null)
                {
                    fileds.Add("[CustomerIDCardType]");
                    pFileds.Add("@CustomerIDCardType");
                    pms.Add(new SqlParameter("CustomerIDCardType", model.CustomerIDCardType));
                }
            
                if(model.SignUserStaffCode!=null)
                {
                    fileds.Add("[SignUserStaffCode]");
                    pFileds.Add("@SignUserStaffCode");
                    pms.Add(new SqlParameter("SignUserStaffCode", model.SignUserStaffCode));
                }
            
                if(model.StudentIDCard!=null)
                {
                    fileds.Add("[StudentIDCard]");
                    pFileds.Add("@StudentIDCard");
                    pms.Add(new SqlParameter("StudentIDCard", model.StudentIDCard));
                }
            
                if(model.ClassPermitCode!=null)
                {
                    fileds.Add("[ClassPermitCode]");
                    pFileds.Add("@ClassPermitCode");
                    pms.Add(new SqlParameter("ClassPermitCode", model.ClassPermitCode));
                }
            
                if(model.CustomerAddressFinished!=null)
                {
                    fileds.Add("[CustomerAddressFinished]");
                    pFileds.Add("@CustomerAddressFinished");
                    pms.Add(new SqlParameter("CustomerAddressFinished", model.CustomerAddressFinished));
                }
            
                if(model.CompanyName!=null)
                {
                    fileds.Add("[CompanyName]");
                    pFileds.Add("@CompanyName");
                    pms.Add(new SqlParameter("CompanyName", model.CompanyName));
                }
            
                if(model.StudentType!=null)
                {
                    fileds.Add("[StudentType]");
                    pFileds.Add("@StudentType");
                    pms.Add(new SqlParameter("StudentType", model.StudentType));
                }
            
                if(model.TeachingPlaceName!=null)
                {
                    fileds.Add("[TeachingPlaceName]");
                    pFileds.Add("@TeachingPlaceName");
                    pms.Add(new SqlParameter("TeachingPlaceName", model.TeachingPlaceName));
                }
            
                if(model.InquiryPlaceName!=null)
                {
                    fileds.Add("[InquiryPlaceName]");
                    pFileds.Add("@InquiryPlaceName");
                    pms.Add(new SqlParameter("InquiryPlaceName", model.InquiryPlaceName));
                }
            
                if(model.SignUserJobName!=null)
                {
                    fileds.Add("[SignUserJobName]");
                    pFileds.Add("@SignUserJobName");
                    pms.Add(new SqlParameter("SignUserJobName", model.SignUserJobName));
                }
            
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO OrderCustomerInfo (");
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
        
        public static bool Update(OrderCustomerInfo model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<SqlParameter> pms = new List<SqlParameter>();
            #region 添加字段
            pFileds.Add("[OrderCustomerInfoID]=@OrderCustomerInfoID");
            pms.Add(new SqlParameter("OrderCustomerInfoID", model.OrderCustomerInfoID));
            
                if(model.OrderID!=null)
                {
                    fileds.Add("[OrderID]=@OrderID");
                    pms.Add(new SqlParameter("OrderID", model.OrderID));
                }
            
                if(model.SignUserID!=null)
                {
                    fileds.Add("[SignUserID]=@SignUserID");
                    pms.Add(new SqlParameter("SignUserID", model.SignUserID));
                }
            
                if(model.SignUserName!=null)
                {
                    fileds.Add("[SignUserName]=@SignUserName");
                    pms.Add(new SqlParameter("SignUserName", model.SignUserName));
                }
            
                if(model.SchoolID!=null)
                {
                    fileds.Add("[SchoolID]=@SchoolID");
                    pms.Add(new SqlParameter("SchoolID", model.SchoolID));
                }
            
                if(model.SchoolName!=null)
                {
                    fileds.Add("[SchoolName]=@SchoolName");
                    pms.Add(new SqlParameter("SchoolName", model.SchoolName));
                }
            
                if(model.SchoolPhone!=null)
                {
                    fileds.Add("[SchoolPhone]=@SchoolPhone");
                    pms.Add(new SqlParameter("SchoolPhone", model.SchoolPhone));
                }
            
                if(model.SchoolAddress!=null)
                {
                    fileds.Add("[SchoolAddress]=@SchoolAddress");
                    pms.Add(new SqlParameter("SchoolAddress", model.SchoolAddress));
                }
            
                if(model.LeagleOwner!=null)
                {
                    fileds.Add("[LeagleOwner]=@LeagleOwner");
                    pms.Add(new SqlParameter("LeagleOwner", model.LeagleOwner));
                }
            
                if(model.CustomerID!=null)
                {
                    fileds.Add("[CustomerID]=@CustomerID");
                    pms.Add(new SqlParameter("CustomerID", model.CustomerID));
                }
            
                if(model.CustomerName!=null)
                {
                    fileds.Add("[CustomerName]=@CustomerName");
                    pms.Add(new SqlParameter("CustomerName", model.CustomerName));
                }
            
                if(model.CustomerCode!=null)
                {
                    fileds.Add("[CustomerCode]=@CustomerCode");
                    pms.Add(new SqlParameter("CustomerCode", model.CustomerCode));
                }
            
                if(model.CustomerIDCard!=null)
                {
                    fileds.Add("[CustomerIDCard]=@CustomerIDCard");
                    pms.Add(new SqlParameter("CustomerIDCard", model.CustomerIDCard));
                }
            
                if(model.CustomerCellPhone!=null)
                {
                    fileds.Add("[CustomerCellPhone]=@CustomerCellPhone");
                    pms.Add(new SqlParameter("CustomerCellPhone", model.CustomerCellPhone));
                }
            
                if(model.CustomerPhone!=null)
                {
                    fileds.Add("[CustomerPhone]=@CustomerPhone");
                    pms.Add(new SqlParameter("CustomerPhone", model.CustomerPhone));
                }
            
                if(model.CustomerAddress!=null)
                {
                    fileds.Add("[CustomerAddress]=@CustomerAddress");
                    pms.Add(new SqlParameter("CustomerAddress", model.CustomerAddress));
                }
            
                if(model.Province!=null)
                {
                    fileds.Add("[Province]=@Province");
                    pms.Add(new SqlParameter("Province", model.Province));
                }
            
                if(model.City!=null)
                {
                    fileds.Add("[City]=@City");
                    pms.Add(new SqlParameter("City", model.City));
                }
            
                if(model.County!=null)
                {
                    fileds.Add("[County]=@County");
                    pms.Add(new SqlParameter("County", model.County));
                }
            
                if(model.AddressDetail!=null)
                {
                    fileds.Add("[AddressDetail]=@AddressDetail");
                    pms.Add(new SqlParameter("AddressDetail", model.AddressDetail));
                }
            
                if(model.CustomerPostCode!=null)
                {
                    fileds.Add("[CustomerPostCode]=@CustomerPostCode");
                    pms.Add(new SqlParameter("CustomerPostCode", model.CustomerPostCode));
                }
            
                if(model.CustomerEmail!=null)
                {
                    fileds.Add("[CustomerEmail]=@CustomerEmail");
                    pms.Add(new SqlParameter("CustomerEmail", model.CustomerEmail));
                }
            
                if(model.IsPrimary!=null)
                {
                    fileds.Add("[IsPrimary]=@IsPrimary");
                    pms.Add(new SqlParameter("IsPrimary", model.IsPrimary));
                }
            
                if(model.StudentID!=null)
                {
                    fileds.Add("[StudentID]=@StudentID");
                    pms.Add(new SqlParameter("StudentID", model.StudentID));
                }
            
                if(model.StudentCode!=null)
                {
                    fileds.Add("[StudentCode]=@StudentCode");
                    pms.Add(new SqlParameter("StudentCode", model.StudentCode));
                }
            
                if(model.StudentName!=null)
                {
                    fileds.Add("[StudentName]=@StudentName");
                    pms.Add(new SqlParameter("StudentName", model.StudentName));
                }
            
                if(model.StudentSex!=null)
                {
                    fileds.Add("[StudentSex]=@StudentSex");
                    pms.Add(new SqlParameter("StudentSex", model.StudentSex));
                }
            
                if(model.StudentBirthday!=null&&model.StudentBirthday!=new DateTime())
                {
                    fileds.Add("[StudentBirthday]=@StudentBirthday");
                }
            
                if(model.StudentSchoolName!=null)
                {
                    fileds.Add("[StudentSchoolName]=@StudentSchoolName");
                    pms.Add(new SqlParameter("StudentSchoolName", model.StudentSchoolName));
                }
            
                if(model.StudentGrade!=null)
                {
                    fileds.Add("[StudentGrade]=@StudentGrade");
                    pms.Add(new SqlParameter("StudentGrade", model.StudentGrade));
                }
            
                if(model.ParentRole!=null)
                {
                    fileds.Add("[ParentRole]=@ParentRole");
                    pms.Add(new SqlParameter("ParentRole", model.ParentRole));
                }
            
                if(model.StudentRole!=null)
                {
                    fileds.Add("[StudentRole]=@StudentRole");
                    pms.Add(new SqlParameter("StudentRole", model.StudentRole));
                }
            
                if(model.LastModifiedDate!=null&&model.LastModifiedDate!=new DateTime())
                {
                    fileds.Add("[LastModifiedDate]=@LastModifiedDate");
                }
            
                if(model.OrderCode!=null)
                {
                    fileds.Add("[OrderCode]=@OrderCode");
                    pms.Add(new SqlParameter("OrderCode", model.OrderCode));
                }
            
                if(model.DepID!=null)
                {
                    fileds.Add("[DepID]=@DepID");
                    pms.Add(new SqlParameter("DepID", model.DepID));
                }
            
                if(model.DepName!=null)
                {
                    fileds.Add("[DepName]=@DepName");
                    pms.Add(new SqlParameter("DepName", model.DepName));
                }
            
                if(model.CustomerIDCardType!=null)
                {
                    fileds.Add("[CustomerIDCardType]=@CustomerIDCardType");
                    pms.Add(new SqlParameter("CustomerIDCardType", model.CustomerIDCardType));
                }
            
                if(model.SignUserStaffCode!=null)
                {
                    fileds.Add("[SignUserStaffCode]=@SignUserStaffCode");
                    pms.Add(new SqlParameter("SignUserStaffCode", model.SignUserStaffCode));
                }
            
                if(model.StudentIDCard!=null)
                {
                    fileds.Add("[StudentIDCard]=@StudentIDCard");
                    pms.Add(new SqlParameter("StudentIDCard", model.StudentIDCard));
                }
            
                if(model.ClassPermitCode!=null)
                {
                    fileds.Add("[ClassPermitCode]=@ClassPermitCode");
                    pms.Add(new SqlParameter("ClassPermitCode", model.ClassPermitCode));
                }
            
                if(model.CustomerAddressFinished!=null)
                {
                    fileds.Add("[CustomerAddressFinished]=@CustomerAddressFinished");
                    pms.Add(new SqlParameter("CustomerAddressFinished", model.CustomerAddressFinished));
                }
            
                if(model.CompanyName!=null)
                {
                    fileds.Add("[CompanyName]=@CompanyName");
                    pms.Add(new SqlParameter("CompanyName", model.CompanyName));
                }
            
                if(model.StudentType!=null)
                {
                    fileds.Add("[StudentType]=@StudentType");
                    pms.Add(new SqlParameter("StudentType", model.StudentType));
                }
            
                if(model.TeachingPlaceName!=null)
                {
                    fileds.Add("[TeachingPlaceName]=@TeachingPlaceName");
                    pms.Add(new SqlParameter("TeachingPlaceName", model.TeachingPlaceName));
                }
            
                if(model.InquiryPlaceName!=null)
                {
                    fileds.Add("[InquiryPlaceName]=@InquiryPlaceName");
                    pms.Add(new SqlParameter("InquiryPlaceName", model.InquiryPlaceName));
                }
            
                if(model.SignUserJobName!=null)
                {
                    fileds.Add("[SignUserJobName]=@SignUserJobName");
                    pms.Add(new SqlParameter("SignUserJobName", model.SignUserJobName));
                }
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update OrderCustomerInfo set ");
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
        
        public static bool Save(OrderCustomerInfo model)
        {
            string sqlStr="select count(1) from OrderCustomerInfo where 1=1 ";
            List<SqlParameter> pms = new List<SqlParameter>();
                    sqlStr+=" and OrderCustomerInfoID=@OrderCustomerInfoID ";
                    pms.Add(new SqlParameter("OrderCustomerInfoID", model.OrderCustomerInfoID));
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(pms.ToArray());
                int i =(int)db.ExecuteScalar(cmd);
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