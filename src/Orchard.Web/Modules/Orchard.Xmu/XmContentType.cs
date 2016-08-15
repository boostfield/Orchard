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
                    Id=28,
                    TopicName = "学院简介",
                    ContentTypeName = "CollegeIntro",
                    ContentTypePartName = "CollegeIntroPart",
                    ContentTypeDisplayName = "学院简介",
                    PermissionDesc = "管理学院简介",
                    Permission = new Permission
                    {
                        Description = "管理学院简介",
                        Name = string.Format("Manage{0}","CollegeIntro")
                    }

                },
                 new XmContentMapping
                {
                    Id=29,
                    TopicName = "学院风光",
                    ContentTypeName = "CollegeScene",
                    ContentTypePartName = "CollegeScenePart",
                    ContentTypeDisplayName = "学院风光",
                    PermissionDesc = "管理学院风光",
                    Permission = new Permission
                    {
                        Description = "管理学院风光",
                        Name = string.Format("Manage{0}","CollegeScene")
                    }

                },

               new XmContentMapping
                {
                    Id=31,
                    TopicName = "现任领导",
                    ContentTypeName = "CollegeLeader",
                    ContentTypePartName = "CollegeLeaderPart",
                    ContentTypeDisplayName = "现任领导",
                    PermissionDesc = "管理现任领导",
                    Permission = new Permission
                    {
                        Description = "管理现任领导",
                        Name = string.Format("Manage{0}","CollegeLeader")
                    }

                },

               new XmContentMapping
                {
                    Id=32,
                    TopicName = "工作人员",
                    ContentTypeName = "CollegeEmployee",
                    ContentTypePartName = "CollegeEmployeePart",
                    ContentTypeDisplayName = "工作人员",
                    PermissionDesc = "管理工作人员",
                    Permission = new Permission
                    {
                        Description = "管理工作人员",
                        Name = string.Format("Manage{0}","CollegeEmployee")
                    }

                },

                new XmContentMapping
                {
                    Id=34,
                    TopicName = "联系我们",
                    ContentTypeName = "ContactUs",
                    ContentTypePartName = "ContactUsPart",
                    ContentTypeDisplayName = "联系我们",
                    PermissionDesc = "管理联系我们",
                    Permission = new Permission
                    {
                        Description = "管理联系我们",
                        Name = string.Format("Manage{0}","ContactUs")
                    }

                },

                new XmContentMapping
                {
                    Id=59,
                    TopicName = "退休教师",
                    ContentTypeName = "RetireTeacher",
                    ContentTypePartName = "RetireTeacherPart",
                    ContentTypeDisplayName = "退休教师",
                    PermissionDesc = "管理退休教师",
                    Permission = new Permission
                    {
                        Description = "管理退休教师",
                        Name = string.Format("Manage{0}","RetireTeacher")
                    }

                },


                new XmContentMapping
                {
                    Id=60,
                    TopicName = "永远怀念",
                    ContentTypeName = "ForeverMemo",
                    ContentTypePartName = "ForeverMemoPart",
                    ContentTypeDisplayName = "永远怀念",
                    PermissionDesc = "管理永远怀念",
                    Permission = new Permission
                    {
                        Description = "管理永远怀念",
                        Name = string.Format("Manage{0}","ForeverMemo")
                    }

                },

                new XmContentMapping
                {
                    Id=75,
                    TopicName = "学院刊物",
                    ContentTypeName = "CollegeJournal",
                    ContentTypePartName = "CollegeJournalPart",
                    ContentTypeDisplayName = "学院刊物",
                    PermissionDesc = "管理学院刊物",
                    Permission = new Permission
                    {
                        Description = "管理学院刊物",
                        Name = string.Format("Manage{0}","CollegeJournal")
                    }

                },

                new XmContentMapping
                {
                    Id=78,
                    TopicName = "国内合作",
                    ContentTypePartName = "InlandCopPart",
                    PermissionDesc = "管理国内合作",
                    ContentTypeDisplayName = "国内合作",
                    ContentTypeName = "InlandCop",
                    Permission = new Permission
                    {
                        Description =  "管理国内合作",
                        Name = string.Format("Manage{0}","InlandCop")
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
                    Permission = new Permission
                    {
                        Description =  "管理国际合作",
                        Name = string.Format("Manage{0}","InterCop")
                    }

                },


                new XmContentMapping
                {
                    Id=80,
                    TopicName = "共建单位",
                    ContentTypePartName = "CopUnitPart",
                    PermissionDesc = "管理共建单位",
                    ContentTypeDisplayName = "共建单位",
                    ContentTypeName = "CopUnit",
                    Permission = new Permission
                    {
                        Description =  "管理共建单位",
                        Name = string.Format("Manage{0}","CopUnit")
                    }

                },

                new XmContentMapping
                {
                    Id=87,
                    TopicName = "就业实习",
                    ContentTypePartName = "JobInternshipPart",
                    PermissionDesc = "管理就业实习",
                    ContentTypeDisplayName = "就业实习",
                    ContentTypeName = "JobInternship",
                    Permission = new Permission
                    {
                        Description =  "管理就业实习",
                        Name = string.Format("Manage{0}","JobInternship")
                    }

                },


                new XmContentMapping
                {
                    Id=88,
                    TopicName = "社会实践",
                    ContentTypePartName = "SocialPracticePart",
                    PermissionDesc = "管理社会实践",
                    ContentTypeDisplayName = "社会实践",
                    ContentTypeName = "SocialPractice",
                    Permission = new Permission
                    {
                        Description =  "管理社会实践",
                        Name = string.Format("Manage{0}","SocialPractice")
                    }

                },


                new XmContentMapping
                {
                    Id=89,
                    TopicName = "志愿服务",
                    ContentTypePartName = "VolunteerServicePart",
                    PermissionDesc = "管理志愿服务",
                    ContentTypeDisplayName = "志愿服务",
                    ContentTypeName = "VolunteerService",
                    Permission = new Permission
                    {
                        Description =  "管理志愿服务",
                        Name = string.Format("Manage{0}","VolunteerService")
                    }

                },

                new XmContentMapping
                {
                    Id=90,
                    TopicName = "法律援助",
                    ContentTypePartName = "LegalAidPart",
                    PermissionDesc = "管理法律援助",
                    ContentTypeDisplayName = "法律援助",
                    ContentTypeName = "LegalAid",
                    Permission = new Permission
                    {
                        Description =  "管理法律援助",
                        Name = string.Format("Manage{0}","LegalAid")
                    }

                },

                new XmContentMapping
                {
                    Id=91,
                    TopicName = "学生组织",
                    ContentTypePartName = "StudOrgPart",
                    PermissionDesc = "管理学生组织",
                    ContentTypeDisplayName = "学生组织",
                    ContentTypeName = "StudOrg",
                    Permission = new Permission
                    {
                        Description =  "管理学生组织",
                        Name = string.Format("Manage{0}","StudOrg")
                    }

                },

                new XmContentMapping
                {
                    Id=92,
                    TopicName = "法硕联合会",
                    ContentTypePartName = "LawGraduateUnitOrgPart",
                    PermissionDesc = "管理法硕联合会",
                    ContentTypeDisplayName = "法硕联合会",
                    ContentTypeName = "LawGraduateUnitOrg",
                    Permission = new Permission
                    {
                        Description =  "管理法硕联合会",
                        Name = string.Format("Manage{0}","LawGraduateUnitOrg")
                    }

                },
                new XmContentMapping
                {
                    Id=94,
                    TopicName = "校友通讯",
                    ContentTypePartName = "CollegeMateContactsPart",
                    PermissionDesc = "管理校友通讯",
                    ContentTypeDisplayName = "校友通讯",
                    ContentTypeName = "CollegeMateContacts",
                    Permission = new Permission
                    {
                        Description =  "管理校友通讯",
                        Name = string.Format("Manage{0}","CollegeMateContacts")
                    }

                },

                new XmContentMapping
                {
                    Id=96,
                    TopicName = "校友论坛",
                    ContentTypePartName = "CollegeMateForumPart",
                    PermissionDesc = "管理校友论坛",
                    ContentTypeDisplayName = "校友论坛",
                    ContentTypeName = "CollegeMateForum",
                    Permission = new Permission
                    {
                        Description =  "管理校友论坛",
                        Name = string.Format("Manage{0}","CollegeMateForum")
                    }

                },

                new XmContentMapping
                {
                    Id=97,
                    TopicName = "捐赠芳名",
                    ContentTypePartName = "DonatorPart",
                    PermissionDesc = "管理捐赠芳名",
                    ContentTypeDisplayName = "捐赠芳名",
                    ContentTypeName = "Donator",
                    Permission = new Permission
                    {
                        Description =  "管理捐赠芳名",
                        Name = string.Format("Manage{0}","Donator")
                    }

                },

                new XmContentMapping
                {
                    Id = 99,
                    TopicName = "厦大法律人",
                    ContentTypeName = "XmLawyer",
                    PermissionDesc = "管理厦大法律人",
                    ContentTypeDisplayName = "厦大法律人",
                    ContentTypePartName = "XmLawyerPart",
                    Permission = new Permission
                    {
                         Description =  "管理厦大法律人",

                         Name = string.Format("Manage{0}","XmLawyer")

                    }
                },

                new XmContentMapping
                {
                    Id = 101,
                    TopicName = "法学社",
                    ContentTypeName = "LayGroup",
                    PermissionDesc = "管理法学社",
                    ContentTypeDisplayName = "法学社",
                    ContentTypePartName = "LayGroup",
                    Permission = new Permission
                    {
                         Description =  "管理法学社",

                         Name = string.Format("Manage{0}","LayGroup")

                    }
                },


                new XmContentMapping
                {
                    Id = 102,
                    TopicName = "国辩协会",
                    ContentTypeName = "DebatingGroup",
                    PermissionDesc = "管理国辩协会",
                    ContentTypeDisplayName = "国辩协会",
                    ContentTypePartName = "DebatingGroup",
                    Permission = new Permission
                    {
                         Description =  "管理国辩协会",

                         Name = string.Format("Manage{0}","DebatingGroup")

                    }
                },



                new XmContentMapping
                {
                    Id = 102,
                    TopicName = "国辩协会",
                    ContentTypeName = "DebatingGroup",
                    PermissionDesc = "管理国辩协会",
                    ContentTypeDisplayName = "国辩协会",
                    ContentTypePartName = "DebatingGroup",
                    Permission = new Permission
                    {
                         Description =  "管理国辩协会",

                         Name = string.Format("Manage{0}","DebatingGroup")

                    }
                },

                new XmContentMapping
                {
                    Id = 111,
                    TopicName = "榜样力量",
                    ContentTypeName = "FineModel",
                    PermissionDesc = "管理榜样力量",
                    ContentTypeDisplayName = "榜样力量",
                    ContentTypePartName = "FineModel",
                    Permission = new Permission
                    {
                         Description =  "管理榜样力量",

                         Name = string.Format("Manage{0}","FineModel")

                    }
                },

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
        public Permission Permission { get; set; }
    }
}