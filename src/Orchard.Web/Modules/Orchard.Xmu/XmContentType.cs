using Orchard.Security.Permissions;
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


        public static XmContentDefinition LectureInfo = new XmContentDefinition
        {
            ContentTypeDisplayName = "讲座会议",
            PermissionDesc = "管理讲座会议",
            ContentTypeName = "LectureInfo",
            ContentTypePartName = "LectureInfoPart"
        };

        public static XmContentDefinition AcademicNews = new XmContentDefinition
        {
            ContentTypeDisplayName = "学术动态",
            PermissionDesc = "管理学术动态",
            ContentTypeName = "AcademicNews",
            ContentTypePartName = "AcademicNewsPart"
        };
        //------------- Content Mapping..
        public static XmContentMapping[] Mappings =
            new XmContentMapping[]
            {
                new XmContentMapping
                {
                    Id = 99,
                    TopicName = "厦大法律人",
                    ContentTypeName = "XmLawyer",
                    PermissionDesc = "管理厦大法律人",
                    ContentTypeDisplayName = "厦大法律人",
                    ContentTypePartName = "XmLawyerPart",
                    permission = new Permission
                    {
                         Description =  "管理厦大法律人",

                         Name = string.Format("Manage{0}","XmLawyer")

                    }
                },

                new XmContentMapping
                {
                    Id=79,
                    TopicName = "国际合作",
                    ContentTypePartName = "InterCopPart",
                    PermissionDesc = "管理国际合作",
                    ContentTypeDisplayName = "国际合作",
                    ContentTypeName = "InterCop",
                    permission = new Permission
                    {
                        Description =  "管理国际合作",
                        Name = string.Format("Manage{0}","InterCopPart")
                    }
                    
                }


            };

    }


    public class XmContentDefinition
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeDisplayName { get; set; }
        public string PermissionDesc { get; set; }
        public string ContentTypePartName { get; set; }

    }



    public class XmContentMapping: XmContentDefinition
    {
        public int Id { get; set; } 
        public string TopicName { get; set; }
        public Permission permission { get; set; }
    }
}