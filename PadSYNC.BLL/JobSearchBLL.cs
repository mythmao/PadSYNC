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
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace PadSYNC.BLL
{
    public partial class JobSearchBLL
    {
        public static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        public static Database db = factory.Create("CloudOrganization");

        
        public static List<JobSearch> Search(string sqlStr, params DbParameter[] parameters)
        {
            List<JobSearch> list = new List<JobSearch>();
            using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            {
                cmd.Parameters.AddRange(parameters);
                DataSet ds = db.ExecuteDataSet(cmd);
                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    foreach (DataRow dr in table.Rows)
                    {
                        JobSearch model = new JobSearch(dr);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        public static bool Insert(JobSearch model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<MySqlParameter> pms = new List<MySqlParameter>();
            #region 添加字段

            if (model.ID != null)
            {
                fileds.Add("[ID]");
                pFileds.Add("@ID");
                pms.Add(new MySqlParameter("ID", model.ID));
            }

            if (model.StaffID != null)
            {
                fileds.Add("[StaffID]");
                pFileds.Add("@StaffID");
                pms.Add(new MySqlParameter("StaffID", model.StaffID));
            }

            if (model.PassportID != null)
            {
                fileds.Add("[PassportID]");
                pFileds.Add("@PassportID");
                pms.Add(new MySqlParameter("PassportID", model.PassportID));
            }

            if (model.UserID != null)
            {
                fileds.Add("[UserID]");
                pFileds.Add("@UserID");
                pms.Add(new MySqlParameter("UserID", model.UserID));
            }

            if (model.UserName != null)
            {
                fileds.Add("[UserName]");
                pFileds.Add("@UserName");
                pms.Add(new MySqlParameter("UserName", model.UserName));
            }

            if (model.StaffCode != null)
            {
                fileds.Add("[StaffCode]");
                pFileds.Add("@StaffCode");
                pms.Add(new MySqlParameter("StaffCode", model.StaffCode));
            }

            if (model.RealName != null)
            {
                fileds.Add("[RealName]");
                pFileds.Add("@RealName");
                pms.Add(new MySqlParameter("RealName", model.RealName));
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

            if (model.OrgID != null)
            {
                fileds.Add("[OrgID]");
                pFileds.Add("@OrgID");
                pms.Add(new MySqlParameter("OrgID", model.OrgID));
            }

            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]");
                pFileds.Add("@OrgName");
                pms.Add(new MySqlParameter("OrgName", model.OrgName));
            }

            if (model.JobID != null)
            {
                fileds.Add("[JobID]");
                pFileds.Add("@JobID");
                pms.Add(new MySqlParameter("JobID", model.JobID));
            }

            if (model.JobPassportID != null)
            {
                fileds.Add("[JobPassportID]");
                pFileds.Add("@JobPassportID");
                pms.Add(new MySqlParameter("JobPassportID", model.JobPassportID));
            }

            if (model.JobCode != null)
            {
                fileds.Add("[JobCode]");
                pFileds.Add("@JobCode");
                pms.Add(new MySqlParameter("JobCode", model.JobCode));
            }

            if (model.JobName != null)
            {
                fileds.Add("[JobName]");
                pFileds.Add("@JobName");
                pms.Add(new MySqlParameter("JobName", model.JobName));
            }

            if (model.JobStatus != null)
            {
                fileds.Add("[JobStatus]");
                pFileds.Add("@JobStatus");
                pms.Add(new MySqlParameter("JobStatus", model.JobStatus));
            }

            if (model.JobCategoryIDs != null)
            {
                fileds.Add("[JobCategoryIDs]");
                pFileds.Add("@JobCategoryIDs");
                pms.Add(new MySqlParameter("JobCategoryIDs", model.JobCategoryIDs));
            }

            if (model.IsFullJob != null)
            {
                fileds.Add("[IsFullJob]");
                pFileds.Add("@IsFullJob");
                pms.Add(new MySqlParameter("IsFullJob", model.IsFullJob));
            }

            if (model.JoinTime != null && model.JoinTime != new DateTime())
            {
                fileds.Add("[JoinTime]");
                pFileds.Add("@JoinTime");
                pms.Add(new MySqlParameter("JoinTime", model.JoinTime));
            }

            if (model.ParentJobID != null)
            {
                fileds.Add("[ParentJobID]");
                pFileds.Add("@ParentJobID");
                pms.Add(new MySqlParameter("ParentJobID", model.ParentJobID));
            }

            if (model.ParentJobPassportID != null)
            {
                fileds.Add("[ParentJobPassportID]");
                pFileds.Add("@ParentJobPassportID");
                pms.Add(new MySqlParameter("ParentJobPassportID", model.ParentJobPassportID));
            }

            if (model.ParentJobName != null)
            {
                fileds.Add("[ParentJobName]");
                pFileds.Add("@ParentJobName");
                pms.Add(new MySqlParameter("ParentJobName", model.ParentJobName));
            }

            if (model.ParentJobRealName != null)
            {
                fileds.Add("[ParentJobRealName]");
                pFileds.Add("@ParentJobRealName");
                pms.Add(new MySqlParameter("ParentJobRealName", model.ParentJobRealName));
            }

            if (model.ParentJobStaffID != null)
            {
                fileds.Add("[ParentJobStaffID]");
                pFileds.Add("@ParentJobStaffID");
                pms.Add(new MySqlParameter("ParentJobStaffID", model.ParentJobStaffID));
            }

            if (model.ParentJobUserID != null)
            {
                fileds.Add("[ParentJobUserID]");
                pFileds.Add("@ParentJobUserID");
                pms.Add(new MySqlParameter("ParentJobUserID", model.ParentJobUserID));
            }

            if (model.ParentJobUserPassportID != null)
            {
                fileds.Add("[ParentJobUserPassportID]");
                pFileds.Add("@ParentJobUserPassportID");
                pms.Add(new MySqlParameter("ParentJobUserPassportID", model.ParentJobUserPassportID));
            }

            if (model.LastContractID != null)
            {
                fileds.Add("[LastContractID]");
                pFileds.Add("@LastContractID");
                pms.Add(new MySqlParameter("LastContractID", model.LastContractID));
            }

            if (model.LastContractCode != null)
            {
                fileds.Add("[LastContractCode]");
                pFileds.Add("@LastContractCode");
                pms.Add(new MySqlParameter("LastContractCode", model.LastContractCode));
            }

            if (model.LastContractEffective != null && model.LastContractEffective != new DateTime())
            {
                fileds.Add("[LastContractEffective]");
                pFileds.Add("@LastContractEffective");
                pms.Add(new MySqlParameter("LastContractEffective", model.LastContractEffective));
            }

            if (model.LastContractEffectiveTime != null && model.LastContractEffectiveTime != new DateTime())
            {
                fileds.Add("[LastContractEffectiveTime]");
                pFileds.Add("@LastContractEffectiveTime");
                pms.Add(new MySqlParameter("LastContractEffectiveTime", model.LastContractEffectiveTime));
            }

            if (model.LastContractEndProbationTime != null && model.LastContractEndProbationTime != new DateTime())
            {
                fileds.Add("[LastContractEndProbationTime]");
                pFileds.Add("@LastContractEndProbationTime");
                pms.Add(new MySqlParameter("LastContractEndProbationTime", model.LastContractEndProbationTime));
            }

            if (model.ContractType != null)
            {
                fileds.Add("[ContractType]");
                pFileds.Add("@ContractType");
                pms.Add(new MySqlParameter("ContractType", model.ContractType));
            }

            if (model.RegistTime != null && model.RegistTime != new DateTime())
            {
                fileds.Add("[RegistTime]");
                pFileds.Add("@RegistTime");
                pms.Add(new MySqlParameter("RegistTime", model.RegistTime));
            }

            if (model.SignTime != null && model.SignTime != new DateTime())
            {
                fileds.Add("[SignTime]");
                pFileds.Add("@SignTime");
                pms.Add(new MySqlParameter("SignTime", model.SignTime));
            }

            if (model.ResignTime != null && model.ResignTime != new DateTime())
            {
                fileds.Add("[ResignTime]");
                pFileds.Add("@ResignTime");
                pms.Add(new MySqlParameter("ResignTime", model.ResignTime));
            }

            if (model.JobPath != null)
            {
                fileds.Add("[JobPath]");
                pFileds.Add("@JobPath");
                pms.Add(new MySqlParameter("JobPath", model.JobPath));
            }

            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]");
                pFileds.Add("@OrgPath");
                pms.Add(new MySqlParameter("OrgPath", model.OrgPath));
            }

            if (model.UserStatus != null)
            {
                fileds.Add("[UserStatus]");
                pFileds.Add("@UserStatus");
                pms.Add(new MySqlParameter("UserStatus", model.UserStatus));
            }

            if (model.OrgNamePath != null)
            {
                fileds.Add("[OrgNamePath]");
                pFileds.Add("@OrgNamePath");
                pms.Add(new MySqlParameter("OrgNamePath", model.OrgNamePath));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]");
                pFileds.Add("@HostID");
                pms.Add(new MySqlParameter("HostID", model.HostID));
            }

            if (model.IsDeleted != null)
            {
                fileds.Add("[IsDeleted]");
                pFileds.Add("@IsDeleted");
                pms.Add(new MySqlParameter("IsDeleted", model.IsDeleted));
            }

            if (model.OrgShortName != null)
            {
                fileds.Add("[OrgShortName]");
                pFileds.Add("@OrgShortName");
                pms.Add(new MySqlParameter("OrgShortName", model.OrgShortName));
            }

            if (model.LeaveTime != null && model.LeaveTime != new DateTime())
            {
                fileds.Add("[LeaveTime]");
                pFileds.Add("@LeaveTime");
                pms.Add(new MySqlParameter("LeaveTime", model.LeaveTime));
            }

            if (model.RelationStatus != null)
            {
                fileds.Add("[RelationStatus]");
                pFileds.Add("@RelationStatus");
                pms.Add(new MySqlParameter("RelationStatus", model.RelationStatus));
            }

            if (model.StaffType != null)
            {
                fileds.Add("[StaffType]");
                pFileds.Add("@StaffType");
                pms.Add(new MySqlParameter("StaffType", model.StaffType));
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

            if (model.OperateFlag != null)
            {
                fileds.Add("[OperateFlag]");
                pFileds.Add("@OperateFlag");
                pms.Add(new MySqlParameter("OperateFlag", model.OperateFlag));
            }

            if (model.StatusOrder != null)
            {
                fileds.Add("[StatusOrder]");
                pFileds.Add("@StatusOrder");
                pms.Add(new MySqlParameter("StatusOrder", model.StatusOrder));
            }

            if (model.IsPrimary != null)
            {
                fileds.Add("[IsPrimary]");
                pFileds.Add("@IsPrimary");
                pms.Add(new MySqlParameter("IsPrimary", model.IsPrimary));
            }

            if (model.JobLevel != null)
            {
                fileds.Add("[JobLevel]");
                pFileds.Add("@JobLevel");
                pms.Add(new MySqlParameter("JobLevel", model.JobLevel));
            }

            if (model.BranchName != null)
            {
                fileds.Add("[BranchName]");
                pFileds.Add("@BranchName");
                pms.Add(new MySqlParameter("BranchName", model.BranchName));
            }

            if (model.SchoolName != null)
            {
                fileds.Add("[SchoolName]");
                pFileds.Add("@SchoolName");
                pms.Add(new MySqlParameter("SchoolName", model.SchoolName));
            }

            if (model.Subjects != null)
            {
                fileds.Add("[Subjects]");
                pFileds.Add("@Subjects");
                pms.Add(new MySqlParameter("Subjects", model.Subjects));
            }

            if (model.Grades != null)
            {
                fileds.Add("[Grades]");
                pFileds.Add("@Grades");
                pms.Add(new MySqlParameter("Grades", model.Grades));
            }

            if (model.StaffGender != null)
            {
                fileds.Add("[StaffGender]");
                pFileds.Add("@StaffGender");
                pms.Add(new MySqlParameter("StaffGender", model.StaffGender));
            }

            if (model.StaffOperateTime != null && model.StaffOperateTime != new DateTime())
            {
                fileds.Add("[StaffOperateTime]");
                pFileds.Add("@StaffOperateTime");
                pms.Add(new MySqlParameter("StaffOperateTime", model.StaffOperateTime));
            }

            if (model.Birthday != null && model.Birthday != new DateTime())
            {
                fileds.Add("[Birthday]");
                pFileds.Add("@Birthday");
                pms.Add(new MySqlParameter("Birthday", model.Birthday));
            }

            if (model.BranchShortName != null)
            {
                fileds.Add("[BranchShortName]");
                pFileds.Add("@BranchShortName");
                pms.Add(new MySqlParameter("BranchShortName", model.BranchShortName));
            }

            if (model.SchoolShortName != null)
            {
                fileds.Add("[SchoolShortName]");
                pFileds.Add("@SchoolShortName");
                pms.Add(new MySqlParameter("SchoolShortName", model.SchoolShortName));
            }

            if (model.StaffEmail != null)
            {
                fileds.Add("[StaffEmail]");
                pFileds.Add("@StaffEmail");
                pms.Add(new MySqlParameter("StaffEmail", model.StaffEmail));
            }

            if (model.StaffPhone != null)
            {
                fileds.Add("[StaffPhone]");
                pFileds.Add("@StaffPhone");
                pms.Add(new MySqlParameter("StaffPhone", model.StaffPhone));
            }

            if (model.PrimaryMobile != null)
            {
                fileds.Add("[PrimaryMobile]");
                pFileds.Add("@PrimaryMobile");
                pms.Add(new MySqlParameter("PrimaryMobile", model.PrimaryMobile));
            }

            if (model.JobAttribute != null)
            {
                fileds.Add("[JobAttribute]");
                pFileds.Add("@JobAttribute");
                pms.Add(new MySqlParameter("JobAttribute", model.JobAttribute));
            }

            if (model.ISKey != null)
            {
                fileds.Add("[ISKey]");
                pFileds.Add("@ISKey");
                pms.Add(new MySqlParameter("ISKey", model.ISKey));
            }

            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]");
                pFileds.Add("@OrgType");
                pms.Add(new MySqlParameter("OrgType", model.OrgType));
            }

            if (model.JobCategorySelectedIDs != null)
            {
                fileds.Add("[JobCategorySelectedIDs]");
                pFileds.Add("@JobCategorySelectedIDs");
                pms.Add(new MySqlParameter("JobCategorySelectedIDs", model.JobCategorySelectedIDs));
            }

            if (model.IsTeacher != null)
            {
                fileds.Add("[IsTeacher]");
                pFileds.Add("@IsTeacher");
                pms.Add(new MySqlParameter("IsTeacher", model.IsTeacher));
            }

            if (model.IsHighest != null)
            {
                fileds.Add("[IsHighest]");
                pFileds.Add("@IsHighest");
                pms.Add(new MySqlParameter("IsHighest", model.IsHighest));
            }

            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]");
                pFileds.Add("@IsSubjectGroup");
                pms.Add(new MySqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }

            if (model.SchoolType != null)
            {
                fileds.Add("[SchoolType]");
                pFileds.Add("@SchoolType");
                pms.Add(new MySqlParameter("SchoolType", model.SchoolType));
            }

            if (model.OfficeID != null)
            {
                fileds.Add("[OfficeID]");
                pFileds.Add("@OfficeID");
                pms.Add(new MySqlParameter("OfficeID", model.OfficeID));
            }

            if (model.OfficeName != null)
            {
                fileds.Add("[OfficeName]");
                pFileds.Add("@OfficeName");
                pms.Add(new MySqlParameter("OfficeName", model.OfficeName));
            }

           
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO JobSearch (");
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

        public static bool Update(JobSearch model)
        {
            string sqlStr = "";
            List<string> fileds = new List<string>();
            List<string> pFileds = new List<string>();
            List<MySqlParameter> pms = new List<MySqlParameter>();
            #region 添加字段

            if (model.ID != null)
            {
                fileds.Add("[ID]=@ID");
                pms.Add(new MySqlParameter("ID", model.ID));
            }

            if (model.StaffID != null)
            {
                fileds.Add("[StaffID]=@StaffID");
                pms.Add(new MySqlParameter("StaffID", model.StaffID));
            }

            if (model.PassportID != null)
            {
                fileds.Add("[PassportID]=@PassportID");
                pms.Add(new MySqlParameter("PassportID", model.PassportID));
            }

            if (model.UserID != null)
            {
                fileds.Add("[UserID]=@UserID");
                pms.Add(new MySqlParameter("UserID", model.UserID));
            }

            if (model.UserName != null)
            {
                fileds.Add("[UserName]=@UserName");
                pms.Add(new MySqlParameter("UserName", model.UserName));
            }

            if (model.StaffCode != null)
            {
                fileds.Add("[StaffCode]=@StaffCode");
                pms.Add(new MySqlParameter("StaffCode", model.StaffCode));
            }

            if (model.RealName != null)
            {
                fileds.Add("[RealName]=@RealName");
                pms.Add(new MySqlParameter("RealName", model.RealName));
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

            if (model.OrgID != null)
            {
                fileds.Add("[OrgID]=@OrgID");
                pms.Add(new MySqlParameter("OrgID", model.OrgID));
            }

            if (model.OrgName != null)
            {
                fileds.Add("[OrgName]=@OrgName");
                pms.Add(new MySqlParameter("OrgName", model.OrgName));
            }

            if (model.JobID != null)
            {
                fileds.Add("[JobID]=@JobID");
                pms.Add(new MySqlParameter("JobID", model.JobID));
            }

            if (model.JobPassportID != null)
            {
                fileds.Add("[JobPassportID]=@JobPassportID");
                pms.Add(new MySqlParameter("JobPassportID", model.JobPassportID));
            }

            if (model.JobCode != null)
            {
                fileds.Add("[JobCode]=@JobCode");
                pms.Add(new MySqlParameter("JobCode", model.JobCode));
            }

            if (model.JobName != null)
            {
                fileds.Add("[JobName]=@JobName");
                pms.Add(new MySqlParameter("JobName", model.JobName));
            }

            if (model.JobStatus != null)
            {
                fileds.Add("[JobStatus]=@JobStatus");
                pms.Add(new MySqlParameter("JobStatus", model.JobStatus));
            }

            if (model.JobCategoryIDs != null)
            {
                fileds.Add("[JobCategoryIDs]=@JobCategoryIDs");
                pms.Add(new MySqlParameter("JobCategoryIDs", model.JobCategoryIDs));
            }

            if (model.IsFullJob != null)
            {
                fileds.Add("[IsFullJob]=@IsFullJob");
                pms.Add(new MySqlParameter("IsFullJob", model.IsFullJob));
            }

            if (model.JoinTime != null && model.JoinTime != new DateTime())
            {
                fileds.Add("[JoinTime]=@JoinTime");
            }

            if (model.ParentJobID != null)
            {
                fileds.Add("[ParentJobID]=@ParentJobID");
                pms.Add(new MySqlParameter("ParentJobID", model.ParentJobID));
            }

            if (model.ParentJobPassportID != null)
            {
                fileds.Add("[ParentJobPassportID]=@ParentJobPassportID");
                pms.Add(new MySqlParameter("ParentJobPassportID", model.ParentJobPassportID));
            }

            if (model.ParentJobName != null)
            {
                fileds.Add("[ParentJobName]=@ParentJobName");
                pms.Add(new MySqlParameter("ParentJobName", model.ParentJobName));
            }

            if (model.ParentJobRealName != null)
            {
                fileds.Add("[ParentJobRealName]=@ParentJobRealName");
                pms.Add(new MySqlParameter("ParentJobRealName", model.ParentJobRealName));
            }

            if (model.ParentJobStaffID != null)
            {
                fileds.Add("[ParentJobStaffID]=@ParentJobStaffID");
                pms.Add(new MySqlParameter("ParentJobStaffID", model.ParentJobStaffID));
            }

            if (model.ParentJobUserID != null)
            {
                fileds.Add("[ParentJobUserID]=@ParentJobUserID");
                pms.Add(new MySqlParameter("ParentJobUserID", model.ParentJobUserID));
            }

            if (model.ParentJobUserPassportID != null)
            {
                fileds.Add("[ParentJobUserPassportID]=@ParentJobUserPassportID");
                pms.Add(new MySqlParameter("ParentJobUserPassportID", model.ParentJobUserPassportID));
            }

            if (model.LastContractID != null)
            {
                fileds.Add("[LastContractID]=@LastContractID");
                pms.Add(new MySqlParameter("LastContractID", model.LastContractID));
            }

            if (model.LastContractCode != null)
            {
                fileds.Add("[LastContractCode]=@LastContractCode");
                pms.Add(new MySqlParameter("LastContractCode", model.LastContractCode));
            }

            if (model.LastContractEffective != null && model.LastContractEffective != new DateTime())
            {
                fileds.Add("[LastContractEffective]=@LastContractEffective");
            }

            if (model.LastContractEffectiveTime != null && model.LastContractEffectiveTime != new DateTime())
            {
                fileds.Add("[LastContractEffectiveTime]=@LastContractEffectiveTime");
            }

            if (model.LastContractEndProbationTime != null && model.LastContractEndProbationTime != new DateTime())
            {
                fileds.Add("[LastContractEndProbationTime]=@LastContractEndProbationTime");
            }

            if (model.ContractType != null)
            {
                fileds.Add("[ContractType]=@ContractType");
                pms.Add(new MySqlParameter("ContractType", model.ContractType));
            }

            if (model.RegistTime != null && model.RegistTime != new DateTime())
            {
                fileds.Add("[RegistTime]=@RegistTime");
            }

            if (model.SignTime != null && model.SignTime != new DateTime())
            {
                fileds.Add("[SignTime]=@SignTime");
            }

            if (model.ResignTime != null && model.ResignTime != new DateTime())
            {
                fileds.Add("[ResignTime]=@ResignTime");
            }

            if (model.JobPath != null)
            {
                fileds.Add("[JobPath]=@JobPath");
                pms.Add(new MySqlParameter("JobPath", model.JobPath));
            }

            if (model.OrgPath != null)
            {
                fileds.Add("[OrgPath]=@OrgPath");
                pms.Add(new MySqlParameter("OrgPath", model.OrgPath));
            }

            if (model.UserStatus != null)
            {
                fileds.Add("[UserStatus]=@UserStatus");
                pms.Add(new MySqlParameter("UserStatus", model.UserStatus));
            }

            if (model.OrgNamePath != null)
            {
                fileds.Add("[OrgNamePath]=@OrgNamePath");
                pms.Add(new MySqlParameter("OrgNamePath", model.OrgNamePath));
            }

            if (model.HostID != null)
            {
                fileds.Add("[HostID]=@HostID");
                pms.Add(new MySqlParameter("HostID", model.HostID));
            }

            if (model.IsDeleted != null)
            {
                fileds.Add("[IsDeleted]=@IsDeleted");
                pms.Add(new MySqlParameter("IsDeleted", model.IsDeleted));
            }

            if (model.OrgShortName != null)
            {
                fileds.Add("[OrgShortName]=@OrgShortName");
                pms.Add(new MySqlParameter("OrgShortName", model.OrgShortName));
            }

            if (model.LeaveTime != null && model.LeaveTime != new DateTime())
            {
                fileds.Add("[LeaveTime]=@LeaveTime");
            }

            if (model.RelationStatus != null)
            {
                fileds.Add("[RelationStatus]=@RelationStatus");
                pms.Add(new MySqlParameter("RelationStatus", model.RelationStatus));
            }

            if (model.StaffType != null)
            {
                fileds.Add("[StaffType]=@StaffType");
                pms.Add(new MySqlParameter("StaffType", model.StaffType));
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

            if (model.OperateFlag != null)
            {
                fileds.Add("[OperateFlag]=@OperateFlag");
                pms.Add(new MySqlParameter("OperateFlag", model.OperateFlag));
            }

            if (model.StatusOrder != null)
            {
                fileds.Add("[StatusOrder]=@StatusOrder");
                pms.Add(new MySqlParameter("StatusOrder", model.StatusOrder));
            }

            if (model.IsPrimary != null)
            {
                fileds.Add("[IsPrimary]=@IsPrimary");
                pms.Add(new MySqlParameter("IsPrimary", model.IsPrimary));
            }

            if (model.JobLevel != null)
            {
                fileds.Add("[JobLevel]=@JobLevel");
                pms.Add(new MySqlParameter("JobLevel", model.JobLevel));
            }

            if (model.BranchName != null)
            {
                fileds.Add("[BranchName]=@BranchName");
                pms.Add(new MySqlParameter("BranchName", model.BranchName));
            }

            if (model.SchoolName != null)
            {
                fileds.Add("[SchoolName]=@SchoolName");
                pms.Add(new MySqlParameter("SchoolName", model.SchoolName));
            }

            if (model.Subjects != null)
            {
                fileds.Add("[Subjects]=@Subjects");
                pms.Add(new MySqlParameter("Subjects", model.Subjects));
            }

            if (model.Grades != null)
            {
                fileds.Add("[Grades]=@Grades");
                pms.Add(new MySqlParameter("Grades", model.Grades));
            }

            if (model.StaffGender != null)
            {
                fileds.Add("[StaffGender]=@StaffGender");
                pms.Add(new MySqlParameter("StaffGender", model.StaffGender));
            }

            if (model.StaffOperateTime != null && model.StaffOperateTime != new DateTime())
            {
                fileds.Add("[StaffOperateTime]=@StaffOperateTime");
            }

            if (model.Birthday != null && model.Birthday != new DateTime())
            {
                fileds.Add("[Birthday]=@Birthday");
            }

            if (model.BranchShortName != null)
            {
                fileds.Add("[BranchShortName]=@BranchShortName");
                pms.Add(new MySqlParameter("BranchShortName", model.BranchShortName));
            }

            if (model.SchoolShortName != null)
            {
                fileds.Add("[SchoolShortName]=@SchoolShortName");
                pms.Add(new MySqlParameter("SchoolShortName", model.SchoolShortName));
            }

            if (model.StaffEmail != null)
            {
                fileds.Add("[StaffEmail]=@StaffEmail");
                pms.Add(new MySqlParameter("StaffEmail", model.StaffEmail));
            }

            if (model.StaffPhone != null)
            {
                fileds.Add("[StaffPhone]=@StaffPhone");
                pms.Add(new MySqlParameter("StaffPhone", model.StaffPhone));
            }

            if (model.PrimaryMobile != null)
            {
                fileds.Add("[PrimaryMobile]=@PrimaryMobile");
                pms.Add(new MySqlParameter("PrimaryMobile", model.PrimaryMobile));
            }

            if (model.JobAttribute != null)
            {
                fileds.Add("[JobAttribute]=@JobAttribute");
                pms.Add(new MySqlParameter("JobAttribute", model.JobAttribute));
            }

            if (model.ISKey != null)
            {
                fileds.Add("[ISKey]=@ISKey");
                pms.Add(new MySqlParameter("ISKey", model.ISKey));
            }

            if (model.OrgType != null)
            {
                fileds.Add("[OrgType]=@OrgType");
                pms.Add(new MySqlParameter("OrgType", model.OrgType));
            }

            if (model.JobCategorySelectedIDs != null)
            {
                fileds.Add("[JobCategorySelectedIDs]=@JobCategorySelectedIDs");
                pms.Add(new MySqlParameter("JobCategorySelectedIDs", model.JobCategorySelectedIDs));
            }

            if (model.IsTeacher != null)
            {
                fileds.Add("[IsTeacher]=@IsTeacher");
                pms.Add(new MySqlParameter("IsTeacher", model.IsTeacher));
            }

            if (model.IsHighest != null)
            {
                fileds.Add("[IsHighest]=@IsHighest");
                pms.Add(new MySqlParameter("IsHighest", model.IsHighest));
            }

            if (model.IsSubjectGroup != null)
            {
                fileds.Add("[IsSubjectGroup]=@IsSubjectGroup");
                pms.Add(new MySqlParameter("IsSubjectGroup", model.IsSubjectGroup));
            }

            if (model.SchoolType != null)
            {
                fileds.Add("[SchoolType]=@SchoolType");
                pms.Add(new MySqlParameter("SchoolType", model.SchoolType));
            }

            if (model.OfficeID != null)
            {
                fileds.Add("[OfficeID]=@OfficeID");
                pms.Add(new MySqlParameter("OfficeID", model.OfficeID));
            }

            if (model.OfficeName != null)
            {
                fileds.Add("[OfficeName]=@OfficeName");
                pms.Add(new MySqlParameter("OfficeName", model.OfficeName));
            }

           
            #endregion
            StringBuilder sb = new StringBuilder();
            sb.Append("update JobSearch set ");
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

        public static bool Save(JobSearch model)
        {
            string sqlStr = "select count(1) from JobSearch where 1=1 ";
            List<MySqlParameter> pms = new List<MySqlParameter>();
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