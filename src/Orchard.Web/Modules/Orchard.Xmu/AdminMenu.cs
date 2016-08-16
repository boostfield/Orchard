using Orchard.Localization;
using Orchard.UI.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu
{
    public class AdminMenu : INavigationProvider
    {

        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {

            builder.AddImageSet("")
                .Add(T("中文CMS"), "1.0", BuildCNCmsMenu);

            builder.AddImageSet("")
                .Add(T("院庆CMS"), "1.0", BuildCelCmsMenu);
        }

  

        private void BuildCelCmsMenu(NavigationItemBuilder menu)
        {
            foreach (var mapping in XmContentType.NinetyMappings)
            {
                menu.Add(T(mapping.ContentTypeDisplayName), "2",
                item => item.Action("List", "College90CelebrationAdmin", new { area = "Orchard.Xmu", contentTypeName = mapping.ContentTypeName })
                .Permission(mapping.Permission));
            }

            menu.Add(T(XmContentType.NinetyDonation.ContentTypeDisplayName), "2",
                item => item.Action("List", "NinetyCelebrationDonationAdmin", new { area = "Orchard.Xmu" })
                .Permission(XmContentType.NinetyDonation.Permission));

        }

        private void BuildCNCmsMenu(NavigationItemBuilder menu)
        {
         
            menu
                 .Add(T(XmContentType.GraduateAffairs.ContentTypeDisplayName), "2", item => item.Action("List", "GraduateAffairsAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManageGraduateAffairs));


            menu
                 .Add(T(XmContentType.StudentInfo.ContentTypeDisplayName), "2", item => item.Action("List", "StudentInfoAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManageStudentInfo));

            menu
                 .Add(T(XmContentType.PublicPartyCollegeAffairs.ContentTypeDisplayName), "2", item => item.Action("List", "PublicPartyCollegeAffairsAdmin", new { area = "Orchard.Xmu" })
                 .Permission(Permissions.ManagePublicPartyCollegeAffairs));


            menu
              .Add(T(XmContentType.RecruitInfo.ContentTypeDisplayName), "2", item => item.Action("List", "RecruitInfoAdmin", new { area = "Orchard.Xmu" })
              .Permission(Permissions.ManageRecruitInfo));

            menu
            .Add(T(XmContentType.LectureInfo.ContentTypeDisplayName), "2", item => item.Action("List", "LectureInfoAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageLectureInfo));

            menu
            .Add(T(XmContentType.AcademicNews.ContentTypeDisplayName), "2", item => item.Action("List", "AcademicNewsAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageAcademicNews));



            foreach (var mapping in XmContentType.ENCMSMappings)
            {
                menu.Add(T(mapping.ContentTypeDisplayName), "2",
                item => item.Action("List", "XmContentAdmin", new { area = "Orchard.Xmu", contentTypeName = mapping.ContentTypeName })
                .Permission(mapping.Permission));
            }
        }

    }
}

