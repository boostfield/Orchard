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
                       .Add(T("中文门户资讯"), "2", menu => menu.Action("List", "InformationAdmin", new { area = "Orchard.Xmu" }));
        }
    }
}