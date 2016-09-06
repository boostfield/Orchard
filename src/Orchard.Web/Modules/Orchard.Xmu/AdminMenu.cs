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


            builder.AddImageSet("")
                .Add(T("英文CMS"), "1.0", BuildENCmsMenu);
        }

  
       private void BuildENCmsMenu(NavigationItemBuilder menu)
        {
            menu.LinkToFirstChild(false);
            menu.Add(T(XmContentType.ENBanner.ContentTypeDisplayName), "2", item => item.Action("List", "ENBannerAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageENBanner));

            menu.Add(T(XmContentType.ENSection.ContentTypeDisplayName), "2", item => item.Action("List", "ENSectionAdmin", new { area = "Orchard.Xmu" })
             .Permission(Permissions.ManageENSection));


            menu.Add(T(XmContentType.ENTeacher.ContentTypeDisplayName), "2", item => item.Action("List", "ENTeacherAdmin", new { area = "Orchard.Xmu" })
             .Permission(Permissions.ManageENTeacher));

            menu.Add(T(XmContentType.ENCourse.ContentTypeDisplayName), "2", item => item.Action("List", "ENCourseAdmin", new { area = "Orchard.Xmu" })
                      .Permission(Permissions.ManageENCourse));

            foreach (var mapping in XmContentType.ENCMSMappings)
            {
                menu.Add(T(mapping.ContentTypeDisplayName), "2",
                item => item.Action("List", "XmContentAdmin", new { area = "Orchard.Xmu", contentTypeName = mapping.ContentTypeName })
                .Permission(mapping.Permission));
            }
        }

        private void BuildCelCmsMenu(NavigationItemBuilder menu)
        {
            menu.LinkToFirstChild(false);
            menu.Add(T(XmContentType.NinetyCelBanner.ContentTypeDisplayName), "2", item => item.Action("List", "NinetyCelBannerAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageCelBanner));

            menu.LinkToFirstChild(false);
            menu.Add(T(XmContentType.NinetyCelMatesOldPic.ContentTypeDisplayName), "2", item => item.Action("List", "CelMatesPicAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageCelMatesPic));

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

            menu.LinkToFirstChild(false);

            menu
            .Add(T(XmContentType.LectureInfo.ContentTypeDisplayName), "2", item => item.Action("List", "LectureInfoAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageLectureInfo));

            menu
          .Add(T(XmContentType.CNBanner.ContentTypeDisplayName), "2", item => item.Action("List", "CNBannerAdmin", new { area = "Orchard.Xmu" })
          .Permission(Permissions.ManageCNBanner));


            menu
            .Add(T(XmContentType.CNNotify.ContentTypeDisplayName), "2", item => item.Action("List", "CNNotifyAdmin", new { area = "Orchard.Xmu" })
            .Permission(Permissions.ManageCNNotify));

            menu
              .Add(T(XmContentType.CNCop.ContentTypeDisplayName), "2", item => item.Action("List", "CNCopAdmin", new { area = "Orchard.Xmu" })
              .Permission(Permissions.ManageCNCop));

            foreach (var mapping in XmContentType.CNCMSMappings)
            {
                menu.Add(T(mapping.ContentTypeDisplayName), "2",
                item => item.Action("List", "XmContentAdmin", new { area = "Orchard.Xmu", contentTypeName = mapping.ContentTypeName })
                .Permission(mapping.Permission));
            }
        }

    }
}

