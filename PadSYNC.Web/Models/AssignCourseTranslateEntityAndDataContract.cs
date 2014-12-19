using PadSYNC.Model.AssignCourseServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PadSYNC.Web.Models
{
    public class AssignCourseTranslateEntityAndDataContract
    {
        public static AssignCourseDataContract TranslateAssignCourseEntityToGuest(PadSYNC.Model.AssignCourse from)
        {
            AssignCourseDataContract to = new AssignCourseDataContract();
            to.AssignID = from.AssignID;
            to.AsignCourseID = from.AsignCourseID;
            to.EventID = from.EventID;
            to.StudentUserID = from.StudentUserID;
            to.StudentPassportID = from.StudentPassportID;
            to.StudentName = from.StudentName;
            to.TeacherUserID = from.TeacherUserID;
            to.TeacherPassportID = from.TeacherPassportID;
            to.TeacherJobID = from.TeacherJobID;
            to.TeacherJobPassportID = from.TeacherJobPassportID;
            to.TeacherName = from.TeacherName;
            to.ProductID = from.ProductID;
            to.ProductName = from.ProductName;
            to.MasterProductID = from.MasterProductID;
            to.MasterProductName = from.MasterProductName;
            to.StartTime = from.StartTime;
            to.EndTime = from.EndTime;
            to.Price = from.Price;
            to.AssignCount = from.AssignCount;
            to.AsignType = from.AsignType;
            to.AsignStatus = from.AsignStatus;
            to.LastModifiedDate = from.LastModifiedDate;
            to.SubjectID = from.SubjectID;
            to.GradeID = from.GradeID;
            to.TeacherPatternID = from.TeacherPatternID;
            to.PUserID = from.PUserID;
            to.PUserPassportID = from.PUserPassportID;
            to.ManagerUserName = from.ManagerUserName;
            to.SchoolID = from.SchoolID;
            to.SchoolName = from.SchoolName;
            to.CompanyID = from.CompanyID;
            to.CompanyName = from.CompanyName;
            to.SubjectName = from.SubjectName;
            to.GradeName = from.GradeName;
            //to.HasAnalyse = from.HasAnalyse;
            //to.AnalyseTime = from.AnalyseTime;
            to.HostID = from.HostID;
            to.StuendtCode = from.StuendtCode;
            to.TeacherCode = from.TeacherCode;
            to.TOrgPath = from.TOrgPath;
            to.ManagerJobPassPortID = from.ManagerJobPassPortID;
            to.POrgPath = from.POrgPath;
            to.TeacherPatternName = from.TeacherPatternName;
            to.PJobPassportID = from.PJobPassportID;
            to.PUserName = from.PUserName;
            to.TeacherSchoolID = from.TeacherSchoolID;
            to.OAUserID = from.OAUserID;
            to.OldSchoolID = from.OldSchoolID;
            //2011-5-4 
            to.TeachHours = from.TeachHours;
            to.ConsultatorName = from.ConsultatorName;
            to.ConsultatorUserID = from.ConsultatorUserID;
            to.ConsultatorPassportID = from.ConsultatorPassportID;
            to.ConsultatorPassportJobID = from.ConsultatorPassportJobID;
            to.TeacherType = from.TeacherType;
            to.TeacherTypeName = from.TeacherTypeName;
            to.CourseSourceType = from.CourseSourceType;
            to.ManagerUserID = from.ManagerUserID;
            to.ManagerUserPassportID = from.ManagerUserPassportID;
            to.CourseType = from.CourseType;
            to.CustomerType = from.CustomerType;
            to.ParentAssignID = from.ParentAssignID;
            to.ConsultatorNames = from.ConsultatorNames;
            to.AssignConsumeStatus = from.AssignConsumeStatus;
            to.SubjectGroupID = from.SubjectGroupID;
            to.SubjectGroupName = from.SubjectGroupName;
            to.CourseTimeLong = from.CourseTimeLong;
            to.ConsumeCountHours = from.ConsumeCountHours;
            to.FinancialTime = from.FinancialTime;
            to.CourseConfirmTime = from.CourseConfirmTime;
            to.CancelType = from.CancelType;

            //2012-3-28
            to.TeachingSchoolID = from.TeachingSchoolID;
            to.TeachingSchoolName = from.TeachingSchoolName;

            //2012-05-23
            to.ContractCode = from.ContractCode;
            to.AbnormalReasonType = from.AbnormalReasonType;

            /*-----------------------------------------------为辅导方案添加的新字段（2013-02-26 李辉）—---------------------------------------------------------*/
            //to.TeachingVersion = from.TeachingVersion;
            //to.CoursePlanCount = from.CoursePlanCount;
            //to.AllCourseCount = from.AllCourseCount;
            //to.CourseTask = from.CourseTask;
            //to.InstructionalObjectives = from.InstructionalObjectives;
            //to.TeachingFocus = from.TeachingFocus;
            //to.TeachingDifficulties = from.TeachingDifficulties;
            //to.PlanStatus = from.PlanStatus;
            //to.PlanUserID = from.PlanUserID;
            //to.PlanUserPassportID = from.PlanUserPassportID;
            //to.PlanUserName = from.PlanUserName;
            //to.PlanJobPassportID = from.PlanJobPassportID;
            //to.PlanCreateTime = from.PlanCreateTime;
            //to.TeacherActivity = from.TeacherActivity;
            //to.StudentActivity = from.StudentActivity;
            //to.CreateDate = from.CreateDate;
            //to.ConformStatus = from.ConformStatus;
            //to.ClassTime = from.ClassTime;
            //to.ConfirmPersonStyle = from.ConfirmPersonStyle;
            //to.ConfirmSource = from.ConfirmSource;

            // 2014-09-11 system transformation cuimm
            // to.LastModifyDate = DateTime.Now;

            to.ContractID = from.ContractID;
            return to;
        }
        
    }
}