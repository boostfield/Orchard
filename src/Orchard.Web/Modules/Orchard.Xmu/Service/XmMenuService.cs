using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Core.Navigation.Models;
using Orchard.Core.Navigation.Services;
using Orchard.Core.Navigation.ViewModels;
using Orchard.UI.Navigation;
using Orchard.ContentManagement;
using Orchard.Xmu.Models;

namespace Orchard.Xmu.Service
{
    public class XmMenuService : IXmMenuService
    {
        private readonly IMenuService _menuService;
        private readonly INavigationManager _navigationManager;
        public IOrchardServices Services { get; set; }


        public XmMenuService(
            IMenuService menuService,
            INavigationManager navigationManager,
            IOrchardServices orchardServices

            )
        {
            _menuService = menuService;
            _navigationManager = navigationManager;
            Services = orchardServices;
        }

        public IEnumerable<MenuItemEntry> GetMenuParts(string MenuName)
        {
            var menu = _menuService.GetMenu(MenuName);
            if (menu == null)
            {
                return new List<MenuItemEntry>();
            }
            var entries = _menuService.GetMenuParts(menu.Id).Select(p => CreateMenuItemEntries(p));
            return entries;
        }



        private MenuItemEntry CreateMenuItemEntries(MenuPart menuPart)
        {
            return new MenuItemEntry
            {
                MenuItemId = menuPart.Id,
                IsMenuItem = menuPart.Is<MenuItemPart>(),
                Text = menuPart.MenuText,
                Position = menuPart.MenuPosition,
                Url = menuPart.Is<MenuItemPart>()
                              ? menuPart.As<MenuItemPart>().Url
                              : _navigationManager.GetUrl(null, Services.ContentManager.GetItemMetadata(menuPart).DisplayRouteValues),
                ContentItem = menuPart.ContentItem,
            };
        }

        public IList<MenuGroupResultVM> Get2LevelMenu(string MenuName)
        {
            var entries = GetMenuParts(MenuName);
            if (!entries.Any())
            {
                return new List<MenuGroupResultVM>();
            }

            return entries
                .GroupBy(p => p.Position.First(), p => p,
                (key, g) =>
                new MenuGroupResultVM
                {
                    Position = key,
                    List = g.OrderBy(i => i.Position).ToList()
                }
                ).OrderBy(j => j.Position).ToList();


        }
    }
}