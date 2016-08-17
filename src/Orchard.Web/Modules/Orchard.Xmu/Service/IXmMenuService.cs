using Orchard.Core.Navigation.Models;
using Orchard.Core.Navigation.ViewModels;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service
{
    public interface IXmMenuService:IDependency
    {
        IEnumerable<MenuItemEntry> GetMenuParts(string MenuName);

        IList<MenuGroupResultVM> Get2LevelMenu(string MenuName);
    }
}