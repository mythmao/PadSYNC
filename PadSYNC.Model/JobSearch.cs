using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PadSYNC.Model
{
    public partial class JobSearch
    {
        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 StaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 PassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 UserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StaffCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String RealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String FullPinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SimplePinyin { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OrgID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 JobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 JobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String JobCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String JobName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 JobStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String JobCategoryIDs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte IsFullJob { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime JoinTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentJobID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentJobPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ParentJobName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String ParentJobRealName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentJobStaffID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentJobUserID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 ParentJobUserPassportID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 LastContractID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String LastContractCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastContractEffective { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastContractEffectiveTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastContractEndProbationTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 ContractType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime RegistTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime SignTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ResignTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String JobPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 UserStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgNamePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 HostID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 IsDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OrgShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LeaveTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 RelationStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StaffType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 BranchID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 SchoolID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte OperateFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StatusOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte IsPrimary { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 JobLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String BranchName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SchoolName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Subjects { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String Grades { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 StaffGender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime StaffOperateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String BranchShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String SchoolShortName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StaffEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String StaffPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String PrimaryMobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 JobAttribute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte ISKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 OrgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String JobCategorySelectedIDs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte IsTeacher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte IsHighest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.SByte IsSubjectGroup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int32 SchoolType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.Int64 OfficeID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.String OfficeName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime LastModified { get; set; }
        #endregion
        public JobSearch() { }
        public JobSearch(DataRow dr)
        {
            if (dr.Table.Columns.Contains("ID"))
            {
                if (dr["ID"] != DBNull.Value)
                {
                    this.ID = (System.Int64)dr["ID"];
                }
            }
            if (dr.Table.Columns.Contains("StaffID"))
            {
                if (dr["StaffID"] != DBNull.Value)
                {
                    this.StaffID = (System.Int64)dr["StaffID"];
                }
            }
            if (dr.Table.Columns.Contains("PassportID"))
            {
                if (dr["PassportID"] != DBNull.Value)
                {
                    this.PassportID = (System.Int64)dr["PassportID"];
                }
            }
            if (dr.Table.Columns.Contains("UserID"))
            {
                if (dr["UserID"] != DBNull.Value)
                {
                    this.UserID = (System.Int64)dr["UserID"];
                }
            }
            if (dr.Table.Columns.Contains("UserName"))
            {
                if (dr["UserName"] != DBNull.Value)
                {
                    this.UserName = (System.String)dr["UserName"];
                }
            }
            if (dr.Table.Columns.Contains("StaffCode"))
            {
                if (dr["StaffCode"] != DBNull.Value)
                {
                    this.StaffCode = (System.String)dr["StaffCode"];
                }
            }
            if (dr.Table.Columns.Contains("RealName"))
            {
                if (dr["RealName"] != DBNull.Value)
                {
                    this.RealName = (System.String)dr["RealName"];
                }
            }
            if (dr.Table.Columns.Contains("FullPinyin"))
            {
                if (dr["FullPinyin"] != DBNull.Value)
                {
                    this.FullPinyin = (System.String)dr["FullPinyin"];
                }
            }
            if (dr.Table.Columns.Contains("SimplePinyin"))
            {
                if (dr["SimplePinyin"] != DBNull.Value)
                {
                    this.SimplePinyin = (System.String)dr["SimplePinyin"];
                }
            }
            if (dr.Table.Columns.Contains("OrgID"))
            {
                if (dr["OrgID"] != DBNull.Value)
                {
                    this.OrgID = (System.Int64)dr["OrgID"];
                }
            }
            if (dr.Table.Columns.Contains("OrgName"))
            {
                if (dr["OrgName"] != DBNull.Value)
                {
                    this.OrgName = (System.String)dr["OrgName"];
                }
            }
            if (dr.Table.Columns.Contains("JobID"))
            {
                if (dr["JobID"] != DBNull.Value)
                {
                    this.JobID = (System.Int64)dr["JobID"];
                }
            }
            if (dr.Table.Columns.Contains("JobPassportID"))
            {
                if (dr["JobPassportID"] != DBNull.Value)
                {
                    this.JobPassportID = (System.Int64)dr["JobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("JobCode"))
            {
                if (dr["JobCode"] != DBNull.Value)
                {
                    this.JobCode = (System.String)dr["JobCode"];
                }
            }
            if (dr.Table.Columns.Contains("JobName"))
            {
                if (dr["JobName"] != DBNull.Value)
                {
                    this.JobName = (System.String)dr["JobName"];
                }
            }
            if (dr.Table.Columns.Contains("JobStatus"))
            {
                if (dr["JobStatus"] != DBNull.Value)
                {
                    this.JobStatus = (System.Int32)dr["JobStatus"];
                }
            }
            if (dr.Table.Columns.Contains("JobCategoryIDs"))
            {
                if (dr["JobCategoryIDs"] != DBNull.Value)
                {
                    this.JobCategoryIDs = (System.String)dr["JobCategoryIDs"];
                }
            }
            if (dr.Table.Columns.Contains("IsFullJob"))
            {
                if (dr["IsFullJob"] != DBNull.Value)
                {
                    this.IsFullJob = (System.SByte)dr["IsFullJob"];
                }
            }
            if (dr.Table.Columns.Contains("JoinTime"))
            {
                if (dr["JoinTime"] != DBNull.Value)
                {
                    this.JoinTime = (System.DateTime)dr["JoinTime"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobID"))
            {
                if (dr["ParentJobID"] != DBNull.Value)
                {
                    this.ParentJobID = (System.Int64)dr["ParentJobID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobPassportID"))
            {
                if (dr["ParentJobPassportID"] != DBNull.Value)
                {
                    this.ParentJobPassportID = (System.Int64)dr["ParentJobPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobName"))
            {
                if (dr["ParentJobName"] != DBNull.Value)
                {
                    this.ParentJobName = (System.String)dr["ParentJobName"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobRealName"))
            {
                if (dr["ParentJobRealName"] != DBNull.Value)
                {
                    this.ParentJobRealName = (System.String)dr["ParentJobRealName"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobStaffID"))
            {
                if (dr["ParentJobStaffID"] != DBNull.Value)
                {
                    this.ParentJobStaffID = (System.Int64)dr["ParentJobStaffID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobUserID"))
            {
                if (dr["ParentJobUserID"] != DBNull.Value)
                {
                    this.ParentJobUserID = (System.Int64)dr["ParentJobUserID"];
                }
            }
            if (dr.Table.Columns.Contains("ParentJobUserPassportID"))
            {
                if (dr["ParentJobUserPassportID"] != DBNull.Value)
                {
                    this.ParentJobUserPassportID = (System.Int64)dr["ParentJobUserPassportID"];
                }
            }
            if (dr.Table.Columns.Contains("LastContractID"))
            {
                if (dr["LastContractID"] != DBNull.Value)
                {
                    this.LastContractID = (System.Int64)dr["LastContractID"];
                }
            }
            if (dr.Table.Columns.Contains("LastContractCode"))
            {
                if (dr["LastContractCode"] != DBNull.Value)
                {
                    this.LastContractCode = (System.String)dr["LastContractCode"];
                }
            }
            if (dr.Table.Columns.Contains("LastContractEffective"))
            {
                if (dr["LastContractEffective"] != DBNull.Value)
                {
                    this.LastContractEffective = (System.DateTime)dr["LastContractEffective"];
                }
            }
            if (dr.Table.Columns.Contains("LastContractEffectiveTime"))
            {
                if (dr["LastContractEffectiveTime"] != DBNull.Value)
                {
                    this.LastContractEffectiveTime = (System.DateTime)dr["LastContractEffectiveTime"];
                }
            }
            if (dr.Table.Columns.Contains("LastContractEndProbationTime"))
            {
                if (dr["LastContractEndProbationTime"] != DBNull.Value)
                {
                    this.LastContractEndProbationTime = (System.DateTime)dr["LastContractEndProbationTime"];
                }
            }
            if (dr.Table.Columns.Contains("ContractType"))
            {
                if (dr["ContractType"] != DBNull.Value)
                {
                    this.ContractType = (System.Int32)dr["ContractType"];
                }
            }
            if (dr.Table.Columns.Contains("RegistTime"))
            {
                if (dr["RegistTime"] != DBNull.Value)
                {
                    this.RegistTime = (System.DateTime)dr["RegistTime"];
                }
            }
            if (dr.Table.Columns.Contains("SignTime"))
            {
                if (dr["SignTime"] != DBNull.Value)
                {
                    this.SignTime = (System.DateTime)dr["SignTime"];
                }
            }
            if (dr.Table.Columns.Contains("ResignTime"))
            {
                if (dr["ResignTime"] != DBNull.Value)
                {
                    this.ResignTime = (System.DateTime)dr["ResignTime"];
                }
            }
            if (dr.Table.Columns.Contains("JobPath"))
            {
                if (dr["JobPath"] != DBNull.Value)
                {
                    this.JobPath = (System.String)dr["JobPath"];
                }
            }
            if (dr.Table.Columns.Contains("OrgPath"))
            {
                if (dr["OrgPath"] != DBNull.Value)
                {
                    this.OrgPath = (System.String)dr["OrgPath"];
                }
            }
            if (dr.Table.Columns.Contains("UserStatus"))
            {
                if (dr["UserStatus"] != DBNull.Value)
                {
                    this.UserStatus = (System.Int32)dr["UserStatus"];
                }
            }
            if (dr.Table.Columns.Contains("OrgNamePath"))
            {
                if (dr["OrgNamePath"] != DBNull.Value)
                {
                    this.OrgNamePath = (System.String)dr["OrgNamePath"];
                }
            }
            if (dr.Table.Columns.Contains("HostID"))
            {
                if (dr["HostID"] != DBNull.Value)
                {
                    this.HostID = (System.Int64)dr["HostID"];
                }
            }
            if (dr.Table.Columns.Contains("IsDeleted"))
            {
                if (dr["IsDeleted"] != DBNull.Value)
                {
                    this.IsDeleted = (System.Int32)dr["IsDeleted"];
                }
            }
            if (dr.Table.Columns.Contains("OrgShortName"))
            {
                if (dr["OrgShortName"] != DBNull.Value)
                {
                    this.OrgShortName = (System.String)dr["OrgShortName"];
                }
            }
            if (dr.Table.Columns.Contains("LeaveTime"))
            {
                if (dr["LeaveTime"] != DBNull.Value)
                {
                    this.LeaveTime = (System.DateTime)dr["LeaveTime"];
                }
            }
            if (dr.Table.Columns.Contains("RelationStatus"))
            {
                if (dr["RelationStatus"] != DBNull.Value)
                {
                    this.RelationStatus = (System.Int32)dr["RelationStatus"];
                }
            }
            if (dr.Table.Columns.Contains("StaffType"))
            {
                if (dr["StaffType"] != DBNull.Value)
                {
                    this.StaffType = (System.Int32)dr["StaffType"];
                }
            }
            if (dr.Table.Columns.Contains("BranchID"))
            {
                if (dr["BranchID"] != DBNull.Value)
                {
                    this.BranchID = (System.Int64)dr["BranchID"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolID"))
            {
                if (dr["SchoolID"] != DBNull.Value)
                {
                    this.SchoolID = (System.Int64)dr["SchoolID"];
                }
            }
            if (dr.Table.Columns.Contains("OperateFlag"))
            {
                if (dr["OperateFlag"] != DBNull.Value)
                {
                    this.OperateFlag = (System.SByte)dr["OperateFlag"];
                }
            }
            if (dr.Table.Columns.Contains("StatusOrder"))
            {
                if (dr["StatusOrder"] != DBNull.Value)
                {
                    this.StatusOrder = (System.Int32)dr["StatusOrder"];
                }
            }
            if (dr.Table.Columns.Contains("IsPrimary"))
            {
                if (dr["IsPrimary"] != DBNull.Value)
                {
                    this.IsPrimary = (System.SByte)dr["IsPrimary"];
                }
            }
            if (dr.Table.Columns.Contains("JobLevel"))
            {
                if (dr["JobLevel"] != DBNull.Value)
                {
                    this.JobLevel = (System.Int32)dr["JobLevel"];
                }
            }
            if (dr.Table.Columns.Contains("BranchName"))
            {
                if (dr["BranchName"] != DBNull.Value)
                {
                    this.BranchName = (System.String)dr["BranchName"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolName"))
            {
                if (dr["SchoolName"] != DBNull.Value)
                {
                    this.SchoolName = (System.String)dr["SchoolName"];
                }
            }
            if (dr.Table.Columns.Contains("Subjects"))
            {
                if (dr["Subjects"] != DBNull.Value)
                {
                    this.Subjects = (System.String)dr["Subjects"];
                }
            }
            if (dr.Table.Columns.Contains("Grades"))
            {
                if (dr["Grades"] != DBNull.Value)
                {
                    this.Grades = (System.String)dr["Grades"];
                }
            }
            if (dr.Table.Columns.Contains("StaffGender"))
            {
                if (dr["StaffGender"] != DBNull.Value)
                {
                    this.StaffGender = (System.Int32)dr["StaffGender"];
                }
            }
            if (dr.Table.Columns.Contains("StaffOperateTime"))
            {
                if (dr["StaffOperateTime"] != DBNull.Value)
                {
                    this.StaffOperateTime = (System.DateTime)dr["StaffOperateTime"];
                }
            }
            if (dr.Table.Columns.Contains("Birthday"))
            {
                if (dr["Birthday"] != DBNull.Value)
                {
                    this.Birthday = (System.DateTime)dr["Birthday"];
                }
            }
            if (dr.Table.Columns.Contains("BranchShortName"))
            {
                if (dr["BranchShortName"] != DBNull.Value)
                {
                    this.BranchShortName = (System.String)dr["BranchShortName"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolShortName"))
            {
                if (dr["SchoolShortName"] != DBNull.Value)
                {
                    this.SchoolShortName = (System.String)dr["SchoolShortName"];
                }
            }
            if (dr.Table.Columns.Contains("StaffEmail"))
            {
                if (dr["StaffEmail"] != DBNull.Value)
                {
                    this.StaffEmail = (System.String)dr["StaffEmail"];
                }
            }
            if (dr.Table.Columns.Contains("StaffPhone"))
            {
                if (dr["StaffPhone"] != DBNull.Value)
                {
                    this.StaffPhone = (System.String)dr["StaffPhone"];
                }
            }
            if (dr.Table.Columns.Contains("PrimaryMobile"))
            {
                if (dr["PrimaryMobile"] != DBNull.Value)
                {
                    this.PrimaryMobile = (System.String)dr["PrimaryMobile"];
                }
            }
            if (dr.Table.Columns.Contains("JobAttribute"))
            {
                if (dr["JobAttribute"] != DBNull.Value)
                {
                    this.JobAttribute = (System.Int32)dr["JobAttribute"];
                }
            }
            if (dr.Table.Columns.Contains("ISKey"))
            {
                if (dr["ISKey"] != DBNull.Value)
                {
                    this.ISKey = (System.SByte)dr["ISKey"];
                }
            }
            if (dr.Table.Columns.Contains("OrgType"))
            {
                if (dr["OrgType"] != DBNull.Value)
                {
                    this.OrgType = (System.Int32)dr["OrgType"];
                }
            }
            if (dr.Table.Columns.Contains("JobCategorySelectedIDs"))
            {
                if (dr["JobCategorySelectedIDs"] != DBNull.Value)
                {
                    this.JobCategorySelectedIDs = (System.String)dr["JobCategorySelectedIDs"];
                }
            }
            if (dr.Table.Columns.Contains("IsTeacher"))
            {
                if (dr["IsTeacher"] != DBNull.Value)
                {
                    this.IsTeacher = (System.SByte)dr["IsTeacher"];
                }
            }
            if (dr.Table.Columns.Contains("IsHighest"))
            {
                if (dr["IsHighest"] != DBNull.Value)
                {
                    this.IsHighest = (System.SByte)dr["IsHighest"];
                }
            }
            if (dr.Table.Columns.Contains("IsSubjectGroup"))
            {
                if (dr["IsSubjectGroup"] != DBNull.Value)
                {
                    this.IsSubjectGroup = (System.SByte)dr["IsSubjectGroup"];
                }
            }
            if (dr.Table.Columns.Contains("SchoolType"))
            {
                if (dr["SchoolType"] != DBNull.Value)
                {
                    this.SchoolType = (System.Int32)dr["SchoolType"];
                }
            }
            if (dr.Table.Columns.Contains("OfficeID"))
            {
                if (dr["OfficeID"] != DBNull.Value)
                {
                    this.OfficeID = (System.Int64)dr["OfficeID"];
                }
            }
            if (dr.Table.Columns.Contains("OfficeName"))
            {
                if (dr["OfficeName"] != DBNull.Value)
                {
                    this.OfficeName = (System.String)dr["OfficeName"];
                }
            }
            if (dr.Table.Columns.Contains("LastModified"))
            {
                if (dr["LastModified"] != DBNull.Value)
                {
                    this.LastModified = (System.DateTime)dr["LastModified"];
                }
            }
        }
    }
}