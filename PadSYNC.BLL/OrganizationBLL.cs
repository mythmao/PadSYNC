using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using PadSYNC.Model;
using MySql.Data.MySqlClient;

namespace PadSYNC.BLL
{
    public partial class OrganizationBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudOrganization");


        public static List<Organization> Search(string sqlStr, params MySqlParameter[] parameters)
        {
            List<Organization> list = new List<Organization>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        Organization model = new Organization(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(Organization model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<MySqlParameter> pms = new List<MySqlParameter>();
            #region 添加字段


            if (model.ParentOrgID != null)
            {
                fileds.Add("[ParentOrgID]");
                pFileds.Add("@ParentOrgID");
                pms.Add(new MySqlParameter("ParentOrgID", model.ParentOrgID));
            }

            if (model.Path != null)
            {
                fileds.Add("[Path]");
                pFileds.Add("@Path");
                pms.Add(new MySqlParameter("Path", model.Path));
            }

            if (model.OrgCode != null)
            {
                fileds.Add("[OrgCode]");
                pFileds.Add("@OrgCode");
                pms.Add(new MySqlParameter("OrgCode", model.OrgCode));
            }

            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]");
                pFileds.Add("@OrgName");
                pms.Add(new MySqlParameter("OrgName", model.OrgName));
            }

            if (model.OrgCommName != null)
            {
                fileds.Add("[OrgCommName]");
                pFileds.Add("@OrgCommName");
                pms.Add(new MySqlParameter("OrgCommName", model.OrgCommName));
            }

            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]");
                pFileds.Add("@FullPinyin");
                pms.Add(new MySqlParameter("FullPinyin", model.FullPinyin));
            }

            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]");
                pFileds.Add("@SimplePinyin");
                pms.Add(new MySqlParameter("SimplePinyin", model.SimplePinyin));
            }

            if (model.OtherName != null)
            {
                fileds.Add("[OtherName]");
                pFileds.Add("@OtherName");
                pms.Add(new MySqlParameter("OtherName", model.OtherName));
            }

            if (model.ShortName != null)
            {
                fileds.Add("[ShortName]");
                pFileds.Add("@ShortName");
                pms.Add(new MySqlParameter("ShortName", model.ShortName));
            }

            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]");
                pFileds.Add("@OrgType");
                pms.Add(new MySqlParameter("OrgType", model.OrgType));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]");
                pFileds.Add("@Status");
                pms.Add(new MySqlParameter("Status", model.Status));
            }

            if (model.OrgProvince != null)
            {
                fileds.Add("[OrgProvince]");
                pFileds.Add("@OrgProvince");
                pms.Add(new MySqlParameter("OrgProvince", model.OrgProvince));
            }

            if (model.OrgProvinceName != null)
            {
                fileds.Add("[OrgProvinceName]");
                pFileds.Add("@OrgProvinceName");
                pms.Add(new MySqlParameter("OrgProvinceName", model.OrgProvinceName));
            }

            if (model.OrgCity != null)
            {
                fileds.Add("[OrgCity]");
                pFileds.Add("@OrgCity");
                pms.Add(new MySqlParameter("OrgCity", model.OrgCity));
            }

            if (model.OrgCityName != null)
            {
                fileds.Add("[OrgCityName]");
                pFileds.Add("@OrgCityName");
                pms.Add(new MySqlParameter("OrgCityName", model.OrgCityName));
            }

            if (model.LeagleOwner != null)
            {
                fileds.Add("[LeagleOwner]");
                pFileds.Add("@LeagleOwner");
                pms.Add(new MySqlParameter("LeagleOwner", model.LeagleOwner));
            }

            if (model.OfficeAddress != null)
            {
                fileds.Add("[OfficeAddress]");
                pFileds.Add("@OfficeAddress");
                pms.Add(new MySqlParameter("OfficeAddress", model.OfficeAddress));
            }

            if (model.LinkPhone != null)
            {
                fileds.Add("[LinkPhone]");
                pFileds.Add("@LinkPhone");
                pms.Add(new MySqlParameter("LinkPhone", model.LinkPhone));
            }

            if (model.CreateTime != null && model.CreateTime != new DateTime())
            {
                fileds.Add("[CreateTime]");
                pFileds.Add("@CreateTime");
                pms.Add(new MySqlParameter("CreateTime", model.CreateTime));
            }

            if (model.OrderNumber != null)
            {
                fileds.Add("[OrderNumber]");
                pFileds.Add("@OrderNumber");
                pms.Add(new MySqlParameter("OrderNumber", model.OrderNumber));
            }

            if (model.OrgLevel != null)
            {
                fileds.Add("[OrgLevel]");
                pFileds.Add("@OrgLevel");
                pms.Add(new MySqlParameter("OrgLevel", model.OrgLevel));
            }

            if (model.BusiLevel != null)
            {
                fileds.Add("[BusiLevel]");
                pFileds.Add("@BusiLevel");
                pms.Add(new MySqlParameter("BusiLevel", model.BusiLevel));
            }

            if (model.IsDel != null)
            {
                fileds.Add("[IsDel]");
                pFileds.Add("@IsDel");
                pms.Add(new MySqlParameter("IsDel", model.IsDel));
            }

            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]");
                pFileds.Add("@FromSysID");
                pms.Add(new MySqlParameter("FromSysID", model.FromSysID));
            }

            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]");
                pFileds.Add("@FromSys");
                pms.Add(new MySqlParameter("FromSys", model.FromSys));
            }

            if (model.ParentShortName != null)
            {
                fileds.Add("[ParentShortName]");
                pFileds.Add("@ParentShortName");
                pms.Add(new MySqlParameter("ParentShortName", model.ParentShortName));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new MySqlParameter("HostID", model.HostID));
            }

            if (model.IsEntity != null)
            {
                fileds.Add("[IsEntity]");
                pFileds.Add("@IsEntity");
                pms.Add(new MySqlParameter("IsEntity", model.IsEntity));
            }

            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]");
                pFileds.Add("@BranchID");
                pms.Add(new MySqlParameter("BranchID", model.BranchID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]");
                pFileds.Add("@SchoolID");
                pms.Add(new MySqlParameter("SchoolID", model.SchoolID));
            }

            if (model.IsOnline != null)
            {
                fileds.Add("[IsOnline]");
                pFileds.Add("@IsOnline");
                pms.Add(new MySqlParameter("IsOnline", model.IsOnline));
            }

            if (model.OnlineTime != null && model.OnlineTime != new DateTime())
            {
                fileds.Add("[OnlineTime]");
                pFileds.Add("@OnlineTime");
                pms.Add(new MySqlParameter("OnlineTime", model.OnlineTime));
            }

            if (model.sortval != null)
            {
                fileds.Add("[sortval]");
                pFileds.Add("@sortval");
                pms.Add(new MySqlParameter("sortval", model.sortval));
            }

            if (model.Schooltype != null)
            {
                fileds.Add("[Schooltype]");
                pFileds.Add("@Schooltype");
                pms.Add(new MySqlParameter("Schooltype", model.Schooltype));
            }

            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]");
                pFileds.Add("@IsSubjectGroup");
                pms.Add(new MySqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }

            if (model.SchoolArea != null)
            {
                fileds.Add("[SchoolArea]");
                pFileds.Add("@SchoolArea");
                pms.Add(new MySqlParameter("SchoolArea", model.SchoolArea));
            }

            if (model.OpenTime != null && model.OpenTime != new DateTime())
            {
                fileds.Add("[OpenTime]");
                pFileds.Add("@OpenTime");
                pms.Add(new MySqlParameter("OpenTime", model.OpenTime));
            }

            if (model.OfficeType != null)
            {
                fileds.Add("[OfficeType]");
                pFileds.Add("@OfficeType");
                pms.Add(new MySqlParameter("OfficeType", model.OfficeType));
            }

            if (model.HriCon != null)
            {
                fileds.Add("[HriCon]");
                pFileds.Add("@HriCon");
                pms.Add(new MySqlParameter("HriCon", model.HriCon));
            }

            if (model.HriConID != null)
            {
                fileds.Add("[HriConID]");
                pFileds.Add("@HriConID");
                pms.Add(new MySqlParameter("HriConID", model.HriConID));
            }

            
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Organization (");
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

        public static bool Update(Organization model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<MySqlParameter> pms = new List<MySqlParameter>();
            #region 添加字段
            pFileds.Add("[OrgID]=@OrgID");
            pms.Add(new MySqlParameter("OrgID", model.OrgID));

            if (model.ParentOrgID != null)
            {
                fileds.Add("[ParentOrgID]=@ParentOrgID");
                pms.Add(new MySqlParameter("ParentOrgID", model.ParentOrgID));
            }

            if (model.Path != null)
            {
                fileds.Add("[Path]=@Path");
                pms.Add(new MySqlParameter("Path", model.Path));
            }

            if (model.OrgCode != null)
            {
                fileds.Add("[OrgCode]=@OrgCode");
                pms.Add(new MySqlParameter("OrgCode", model.OrgCode));
            }

            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]=@OrgName");
                pms.Add(new MySqlParameter("OrgName", model.OrgName));
            }

            if (model.OrgCommName != null)
            {
                fileds.Add("[OrgCommName]=@OrgCommName");
                pms.Add(new MySqlParameter("OrgCommName", model.OrgCommName));
            }

            if (model.FullPinyin != null)
            {
                fileds.Add("[FullPinyin]=@FullPinyin");
                pms.Add(new MySqlParameter("FullPinyin", model.FullPinyin));
            }

            if (model.SimplePinyin != null)
            {
                fileds.Add("[SimplePinyin]=@SimplePinyin");
                pms.Add(new MySqlParameter("SimplePinyin", model.SimplePinyin));
            }

            if (model.OtherName != null)
            {
                fileds.Add("[OtherName]=@OtherName");
                pms.Add(new MySqlParameter("OtherName", model.OtherName));
            }

            if (model.ShortName != null)
            {
                fileds.Add("[ShortName]=@ShortName");
                pms.Add(new MySqlParameter("ShortName", model.ShortName));
            }

            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]=@OrgType");
                pms.Add(new MySqlParameter("OrgType", model.OrgType));
            }

            if (model.Status != null)
            {
                fileds.Add("[Status]=@Status");
                pms.Add(new MySqlParameter("Status", model.Status));
            }

            if (model.OrgProvince != null)
            {
                fileds.Add("[OrgProvince]=@OrgProvince");
                pms.Add(new MySqlParameter("OrgProvince", model.OrgProvince));
            }

            if (model.OrgProvinceName != null)
            {
                fileds.Add("[OrgProvinceName]=@OrgProvinceName");
                pms.Add(new MySqlParameter("OrgProvinceName", model.OrgProvinceName));
            }

            if (model.OrgCity != null)
            {
                fileds.Add("[OrgCity]=@OrgCity");
                pms.Add(new MySqlParameter("OrgCity", model.OrgCity));
            }

            if (model.OrgCityName != null)
            {
                fileds.Add("[OrgCityName]=@OrgCityName");
                pms.Add(new MySqlParameter("OrgCityName", model.OrgCityName));
            }

            if (model.LeagleOwner != null)
            {
                fileds.Add("[LeagleOwner]=@LeagleOwner");
                pms.Add(new MySqlParameter("LeagleOwner", model.LeagleOwner));
            }

            if (model.OfficeAddress != null)
            {
                fileds.Add("[OfficeAddress]=@OfficeAddress");
                pms.Add(new MySqlParameter("OfficeAddress", model.OfficeAddress));
            }

            if (model.LinkPhone != null)
            {
                fileds.Add("[LinkPhone]=@LinkPhone");
                pms.Add(new MySqlParameter("LinkPhone", model.LinkPhone));
            }

            if (model.CreateTime != null && model.CreateTime != new DateTime())
            {
                fileds.Add("[CreateTime]=@CreateTime");
            }

            if (model.OrderNumber != null)
            {
                fileds.Add("[OrderNumber]=@OrderNumber");
                pms.Add(new MySqlParameter("OrderNumber", model.OrderNumber));
            }

            if (model.OrgLevel != null)
            {
                fileds.Add("[OrgLevel]=@OrgLevel");
                pms.Add(new MySqlParameter("OrgLevel", model.OrgLevel));
            }

            if (model.BusiLevel != null)
            {
                fileds.Add("[BusiLevel]=@BusiLevel");
                pms.Add(new MySqlParameter("BusiLevel", model.BusiLevel));
            }

            if (model.IsDel != null)
            {
                fileds.Add("[IsDel]=@IsDel");
                pms.Add(new MySqlParameter("IsDel", model.IsDel));
            }

            if (model.FromSysID != null)
            {
                fileds.Add("[FromSysID]=@FromSysID");
                pms.Add(new MySqlParameter("FromSysID", model.FromSysID));
            }

            if (model.FromSys != null)
            {
                fileds.Add("[FromSys]=@FromSys");
                pms.Add(new MySqlParameter("FromSys", model.FromSys));
            }

            if (model.ParentShortName != null)
            {
                fileds.Add("[ParentShortName]=@ParentShortName");
                pms.Add(new MySqlParameter("ParentShortName", model.ParentShortName));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new MySqlParameter("HostID", model.HostID));
            }

            if (model.IsEntity != null)
            {
                fileds.Add("[IsEntity]=@IsEntity");
                pms.Add(new MySqlParameter("IsEntity", model.IsEntity));
            }

            if (model.BranchID != null)
            {
                fileds.Add("[BranchID]=@BranchID");
                pms.Add(new MySqlParameter("BranchID", model.BranchID));
            }

            if (model.SchoolID != null)
            {
                fileds.Add("[SchoolID]=@SchoolID");
                pms.Add(new MySqlParameter("SchoolID", model.SchoolID));
            }

            if (model.IsOnline != null)
            {
                fileds.Add("[IsOnline]=@IsOnline");
                pms.Add(new MySqlParameter("IsOnline", model.IsOnline));
            }

            if (model.OnlineTime != null && model.OnlineTime != new DateTime())
            {
                fileds.Add("[OnlineTime]=@OnlineTime");
            }

            if (model.sortval != null)
            {
                fileds.Add("[sortval]=@sortval");
                pms.Add(new MySqlParameter("sortval", model.sortval));
            }

            if (model.Schooltype != null)
            {
                fileds.Add("[Schooltype]=@Schooltype");
                pms.Add(new MySqlParameter("Schooltype", model.Schooltype));
            }

            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]=@IsSubjectGroup");
                pms.Add(new MySqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }

            if (model.SchoolArea != null)
            {
                fileds.Add("[SchoolArea]=@SchoolArea");
                pms.Add(new MySqlParameter("SchoolArea", model.SchoolArea));
            }

            if (model.OpenTime != null && model.OpenTime != new DateTime())
            {
                fileds.Add("[OpenTime]=@OpenTime");
            }

            if (model.OfficeType != null)
            {
                fileds.Add("[OfficeType]=@OfficeType");
                pms.Add(new MySqlParameter("OfficeType", model.OfficeType));
            }

            if (model.HriCon != null)
            {
                fileds.Add("[HriCon]=@HriCon");
                pms.Add(new MySqlParameter("HriCon", model.HriCon));
            }

            if (model.HriConID != null)
            {
                fileds.Add("[HriConID]=@HriConID");
                pms.Add(new MySqlParameter("HriConID", model.HriConID));
            }

            
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update Organization set ");
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

        public static bool Save(Organization model)
        {
            string sqlStr = "select count(1) from Organization where 1=1 ";
            List<MySqlParameter> pms = new List<MySqlParameter>();
            sqlStr += " and OrgID=@OrgID ";
            pms.Add(new MySqlParameter("OrgID", model.OrgID));
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