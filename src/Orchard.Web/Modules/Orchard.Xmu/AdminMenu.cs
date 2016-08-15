using Orchard.Localization;
using Orchard.UI.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu
{
    public class AdminMenu: INavigationProvider
    {

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
             
            builder.AddImageSet("")
                      .Add(T(XmContentType.CollegeNews.ContentTypeDisplayName), "2", menu => menu.Action("List", "CollegeNewsAdmin", new { area = "Orchard.Xmu" })
                      .Permission(Permissions.ManageCollegeNews));


            builder.AddImageSet("")
                     .Add(T(XmContentType.CollegeAffairsNotify.ContentTypeDisplayName), "2", menu => menu.Action("List", "CollegeAffairsNotifyAdmin", new { area = "Orchard.Xmu" })
                     .Permission(Permissions.ManageCollegeAffairsNotify));


            builder.AddImageSet("")
                     .Add(T(XmContentType.UndergraduateAffairs.ContentTypeDisplayName), "2", menu => menu.Action("List", "UndergraduateAffairsAdmin", new { area = "Orchard.Xmu" })
                     .Permission(Permissions.ManageUndergraduateAffairs));

            builder.AddImageSet("")
                 .Add(T(XmContentType.GraduateAffairs.ContentTypeDisplayName), "2", menu => menu.Action("List", "GraduateAffairsAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManageGraduateAffairs));


            builder.AddImageSet("")
                 .Add(T(XmContentType.StudentInfo.ContentTypeDisplayName), "2", menu => menu.Action("List", "StudentInfoAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManageStudentInfo));

            builder.AddImageSet("")
                 .Add(T(XmContentType.PublicPartyCollegeAffairs.ContentTypeDisplayName), "2", menu => menu.Action("List", "PublicPartyCollegeAffairsAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManagePublicPartyCollegeAffairs));


            builder.AddImageSet("")
              .Add(T(XmContentType.RecruitInfo.ContentTypeDisplayName), "2", menu => menu.Action("List", "RecruitInfoAdmin", new { area = "Orchard.Xmu" })
              .Permission(Permissions.ManageRecruitInfo));

            builder.AddImageSet("")
            .Add(T(XmContentType.LectureInfo.ContentTypeDisplayName), "2", menu => menu.Action("List", "LectureInfoAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageLectureInfo));

            builder.AddImageSet("")
            .Add(T(XmContentType.AcademicNews.ContentTypeDisplayName), "2", menu => menu.Action("List", "AcademicNewsAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageAcademicNews));



            foreach(var mapping in XmContentType.Mappings)
            {

                builder.AddImageSet("")
                .Add(T(mapping.ContentTypeDisplayName), "2", 
                menu => menu.Action("List", "XmContentAdmin", new { area = "Orchard.Xmu", contentTypeName = mapping.ContentTypeName })
                .Permission(mapping.Permission));


            }

        }

    }
}

