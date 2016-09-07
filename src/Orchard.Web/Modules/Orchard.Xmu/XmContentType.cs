using Orchard.Security.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu
{
    public class XmContentType
    {


        public static XmContentDefinition LectureInfo = new XmContentDefinition
        {
            ContentTypeDisplayName = "讲座会议",
            PermissionDesc = "管理讲座会议",
            ContentTypeName = "LectureInfo",
            ContentTypePartName = "LectureInfoPart"
        };


        public static XmContentDefinition CNBanner = new XmContentDefinition
        {
            ContentTypeDisplayName = "中文首页Banner",
            PermissionDesc = "管理中文CMS首页Banner",
            ContentTypeName = "CNBanner",
            ContentTypePartName = "CNBannerPart"
        };


        public static XmContentDefinition CNCollegeShow = new XmContentDefinition
        {
            ContentTypeDisplayName = "学院风采",
            PermissionDesc = "管理学院风采",
            ContentTypeName = "CNCollegeShow",
            ContentTypePartName = "CNCollegeShowPart",
            ListTitle = "学院风采"
        };

        public static XmContentDefinition CNNotify = new XmContentDefinition
        {
            ContentTypeDisplayName = "中文通知公告",
            PermissionDesc = "管理通知公告",
            ContentTypeName = "CNNotify",
            ContentTypePartName = "CNNotifyPart",
            ListTitle ="通知公告"
        };

        public static XmContentDefinition CNCop = new XmContentDefinition
        {
            ContentTypeDisplayName = "合作交流",
            PermissionDesc = "管理合作交流",
            ContentTypeName = "CNCop",
            ContentTypePartName = "CNCopPart",
            ListTitle = "合作交流"
        };

        public static XmContentDefinition ENBanner = new XmContentDefinition
        {
            ContentTypeDisplayName = "英文首页Banner",
            PermissionDesc = "管理英文CMS首页Banner",
            ContentTypeName = "ENBanner",
            ContentTypePartName = "ENBannerPart"
        };




        public static XmContentDefinition ENSection = new XmContentDefinition
        {
            ContentTypeDisplayName = "英文版块",
            PermissionDesc = "管理英文版块",
            ContentTypeName = "ENSection",
            ContentTypePartName = "ENSectionPart"
        };


        public static XmContentDefinition ENTeacher = new XmContentDefinition
        {
            ContentTypeDisplayName = "教师信息",
            PermissionDesc = "管理老师信息",
            ContentTypeName = "ENTeacher",
            ContentTypePartName = "EnTeacherPart",
            ListTitle = "Teachers List"
        };


        public static XmContentDefinition ENCourse = new XmContentDefinition
        {
            ContentTypeDisplayName = "英文课程信息",
            PermissionDesc = "管理英文课程信息",
            ContentTypeName = "ENCourse",
            ContentTypePartName = "ENCoursePart",
            ListTitle = "Courses List"
        };

        public static XmContentDefinition CNTeacher = new XmContentDefinition
        {
            ContentTypeDisplayName = "中文教师信息",
            PermissionDesc = "管理中文教师信息",
            ContentTypeName = "CNTeacher",
            ContentTypePartName = "CNTeacherPart",
            ListTitle = "Teachers List"
        };


        public static XmContentDefinition CNAcademicPaper = new XmContentDefinition
        {
            ContentTypeDisplayName = "论文",
            PermissionDesc = "管理论文",
            ContentTypeName = "CNAcademicPaper",
            ContentTypePartName = "CNAcademicPaperPart",
            ListTitle = "论文列表"
        };


        public static XmContentDefinition CNAcademicWork = new XmContentDefinition
        {
            ContentTypeDisplayName = "著作",
            PermissionDesc = "管理著作",
            ContentTypeName = "CNAcademicWork",
            ContentTypePartName = "CNAcademicWorkPart",
            ListTitle = "著作列表"
        };

        public static XmContentDefinition CNAward = new XmContentDefinition
        {
            ContentTypeDisplayName = "获奖成果",
            PermissionDesc = "管理获奖成果",
            ContentTypeName = "CNAward",
            ContentTypePartName = "CNAwardPart",
            ListTitle = "获奖成果列表"
        };

        public static XmContentDefinition CNProject = new XmContentDefinition
        {
            ContentTypeDisplayName = "承担课题",
            PermissionDesc = "管理承担课题",
            ContentTypeName = "CNProject",
            ContentTypePartName = "CNProjectPart",
            ListTitle = "承担课题列表"
        };

        //------------- Content Mapping..


        // 90's CMS

        public static NinetyCMSContentMapping NinetyDonation = new NinetyCMSContentMapping
        {

            ContentTypeDisplayName = "院庆捐赠",
            ContentTypeName = "CelDonation",
            PermissionDesc = "管理院庆捐赠",
            ContentTypePartName = "CelDonationPart",
            Permission = new Permission
            {
                Description = "管理院庆捐赠",
                Name = string.Format("Manage{0}", "CelDonation")
            },
            ListTitle = "院庆捐赠"
        };

        public static XmContentDefinition NinetyCelMatesOldPic = new XmContentDefinition
        {
            ContentTypeDisplayName = "院庆首页院友老照片",
            PermissionDesc = "管理院庆首页院友老照片",
            ContentTypeName = "CelOldMatesPic",
            ContentTypePartName = "CelOldMatesPicPart"
        };

        public static XmContentDefinition NinetyCelBanner = new XmContentDefinition
        {
            ContentTypeDisplayName = "院庆首页Banner",
            PermissionDesc = "管理院庆CMS首页Banner",
            ContentTypeName = "CelBanner",
            ContentTypePartName = "CelBannerPart"
        };



        public static NinetyCMSContentMapping[] NinetyMappings =
            new NinetyCMSContentMapping[]
            {
                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "通知公告",
                    ContentTypeName = "CelAnnouncement",
                    PermissionDesc = "管理通知公告",
                    ContentTypePartName = "CelAnnouncementPart",
                    Permission = new Permission
                    {
                        Description = "管理通知公告",
                        Name = string.Format("Manage{0}","CelAnnouncement")
                    },
                },

                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "院庆动态",
                    ContentTypeName = "CelNews",
                    PermissionDesc = "管理院庆动态",
                    ContentTypePartName = "CelNewsPart",
                    Permission = new Permission
                    {
                        Description = "管理院庆动态",
                        Name = string.Format("Manage{0}","CelNews")
                    },
                },



                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "成果展示",
                    ContentTypeName = "CelVictory",
                    PermissionDesc = "管理成果展示",
                    ContentTypePartName = "CelVictoryPart",
                    Permission = new Permission
                    {
                        Description = "管理成果展示",
                        Name = string.Format("Manage{0}","CelVictory")
                    },
                },


                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "院友随笔",
                    ContentTypeName = "CelMatesArticle",
                    PermissionDesc = "管理院友随笔",
                    ContentTypePartName = "CelMatesArticlePart",
                    Permission = new Permission
                    {
                        Description = "管理院友随笔",
                        Name = string.Format("Manage{0}","CelMatesArticle")
                    },
                },



                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "院友风采",
                    ContentTypeName = "CelMatesShows",
                    PermissionDesc = "管理院友风采",
                    ContentTypePartName = "CelMatesShowsPart",
                    Permission = new Permission
                    {
                        Description = "管理院友风采",
                        Name = string.Format("Manage{0}","CelMatesShows")
                    },
                },

                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "学院历程",
                    ContentTypeName = "CelCollegeHistory",
                    PermissionDesc = "管理学院历程",
                    ContentTypePartName = "CelCollegeHistoryPart",
                    Permission = new Permission
                    {
                        Description = "管理学院历程",
                        Name = string.Format("Manage{0}","CelCollegeHistory")
                    },
                },

                new NinetyCMSContentMapping
                {

                    ContentTypeDisplayName = "院友祝福",
                    ContentTypeName = "CelMatesBlessing",
                    PermissionDesc = "管理院友祝福",
                    ContentTypePartName = "CelMatesBlessingPart",
                    Permission = new Permission
                    {
                        Description = "管理院友祝福",
                        Name = string.Format("Manage{0}","CelMatesBlessing")
                    },
                },




            };

        //---EN CMS
        public static XmENCMSContentMapping[] ENCMSMappings =
            new XmENCMSContentMapping[]
            {
                new XmENCMSContentMapping
                {
                    ContentTypeName = "CollegeENNews",
                    PermissionDesc = "管理新闻(News)",
                    ContentTypeDisplayName = "新闻(News)",
                    ContentTypePartName = "CollegeENNewsPart",
                    Permission = new Permission
                    {
                        Description = "管理新闻(News)",
                        Name = string.Format("Manage{0}","CollegeENNews")
                    },
                    ListTitle = "News",
                    EnablePreview = true
                },
                new XmENCMSContentMapping
                {
                    ContentTypeName = "CollegeENNotice",
                    PermissionDesc = "管理通知(Notice)",
                    ContentTypeDisplayName = "通知(Notice)",
                    ContentTypePartName = "CollegeENNoticePart",
                    Permission = new Permission
                    {
                        Description = "管理通知(Notice)",
                        Name = string.Format("Manage{0}","CollegeENNotice")
                    },
                    ListTitle = "Notice",
                    EnablePreview = true
                },
            };


        //------- CN CMS
        public static XmCNCMSContentMapping[] CNCMSMappings =
            new XmCNCMSContentMapping[]
            {

                new XmCNCMSContentMapping
                {
                    ContentTypeName = "CollegeNews",
                    PermissionDesc = "管理学院新闻",
                    ContentTypeDisplayName = "学院新闻",
                    ContentTypePartName = "CollegeNewsPart",
                    Permission = new Permission
                    {
                        Description = "管理学院新闻",
                        Name = string.Format("Manage{0}","CollegeNews")
                    }
                },

                new XmCNCMSContentMapping
                {
                     ContentTypeDisplayName = "党务院务公开",
                     PermissionDesc = "管理党务院务公开",
                    ContentTypeName = "PublicPartyCollegeAffairs",
                    ContentTypePartName = "PublicPartyCollegeAffairsPart",
                    Permission = new Permission
                    {
                        Description = "管理党务院务公开",
                        Name = string.Format("Manage{0}","PublicPartyCollegeAffairs")

                    }

                },

                new XmCNCMSContentMapping
                {
                    ContentTypeDisplayName = "招录信息",
                    PermissionDesc = "管理招录信息",
                    ContentTypeName = "RecruitInfo",
                    ContentTypePartName = "RecruitInfoPart",
                    Permission = new Permission
                    {
                        Description="管理招录信息",
                        Name = string.Format("Manage{0}","RecruitInfo")

                    }
                },

                //用单页创建
                /*
                new XmCNCMSContentMapping
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
                 new XmCNCMSContentMapping
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

               new XmCNCMSContentMapping
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

               new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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
                */

                new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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



                new XmCNCMSContentMapping
                {
                    ContentTypeDisplayName = "学术动态",
                    PermissionDesc = "管理学术动",
                    ContentTypeName = "AcademicNews",
                    ContentTypePartName = "AcademicNewsPart",
                    Permission = new Permission
                    {
                     Description= "管理学术动态",
                     Name = string.Format("Manage{0}","AcademicNews")
                    }
                },

                new XmCNCMSContentMapping
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
                /*
                new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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
                */
                new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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

                 new XmCNCMSContentMapping
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

                 new XmCNCMSContentMapping
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


                new XmCNCMSContentMapping
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
                /*
                new XmCNCMSContentMapping
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
                */
                new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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

                new XmCNCMSContentMapping
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

            };

    }


    public class XmContentDefinition
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeDisplayName { get; set; }
        public string PermissionDesc { get; set; }
        public string ContentTypePartName { get; set; }
        public string ListTitle { get; set; }
        public bool EnablePreview { get; set; }


    }



    public class XmCNCMSContentMapping : XmContentDefinition
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public Permission Permission { get; set; }
    }


    public class NinetyCMSContentMapping : XmContentDefinition
    {
        public Permission Permission { get; set; }
    }

    public class XmENCMSContentMapping : XmContentDefinition
    {
        public Permission Permission { get; set; }
    }
}