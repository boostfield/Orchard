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


    }


    public class XmContentDefinition
    {
        public string ContentTypeName { get; set; }
        public string ContentTypeDisplayName { get; set; }
        public string PermissionDesc { get; set; }

    }
}