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

    }


    public class XmContentDefinition
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeDisplayName { get; set; }
        public string PermissionDesc { get; set; }

    }
}