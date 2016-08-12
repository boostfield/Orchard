using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu
{
    public class XmContentType
    {


        public static XmContentDefinition CollegeNews = new XmContentDefinition {
            ContentTypeDisplayName = "学院新闻",
            PermissionDesc = "管理学院新闻",
            ContentTypeName = "CollegeNews"
        };

        public static XmContentDefinition CollegeAffairsNotify = new XmContentDefinition
        {
            ContentTypeDisplayName = "院务通知",
            PermissionDesc = "管理院务通知",
            ContentTypeName = "CollegeAffairsNotify"
        };


        public static XmContentDefinition UndergraduateAffairs = new XmContentDefinition
        {
            ContentTypeDisplayName = "本科生教务",
            PermissionDesc = "管理本科生教务",
            ContentTypeName = "UndergraduateAffairs"
        };


        public static XmContentDefinition GraduateAffairs = new XmContentDefinition
        {
            ContentTypeDisplayName = "研究生教务",
            PermissionDesc = "管理研究生教务",
            ContentTypeName = "GraduateAffairs"
        };

        public static XmContentDefinition StudentInfo = new XmContentDefinition
        {
            ContentTypeDisplayName = "学生资讯",
            PermissionDesc = "管理学生资讯",
            ContentTypeName = "StudentInfo"
        };

        public static XmContentDefinition PublicPartyCollegeAffairs = new XmContentDefinition
        {
            ContentTypeDisplayName = "党务院务公开",
            PermissionDesc = "管理党务院务公开",
            ContentTypeName = "PublicPartyCollegeAffairs"
        };


        public static XmContentDefinition RecruitInfo = new XmContentDefinition
        {
            ContentTypeDisplayName = "招录信息",
            PermissionDesc = "管理招录信息",
            ContentTypeName = "RecruitInfo"
        };

    }


    public class XmContentDefinition
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeDisplayName { get; set; }
        public string PermissionDesc { get; set; }

    }
}