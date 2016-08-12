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
        }
    }
}

