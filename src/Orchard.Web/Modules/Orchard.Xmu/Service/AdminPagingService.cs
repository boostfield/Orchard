using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.UI.Navigation;
using Orchard.Xmu.ViewModels;
using Orchard.Settings;
using Orchard.ContentManagement;
using Orchard.Taxonomies.Services;
using Orchard.DisplayManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using Orchard.Taxonomies.Models;
using Orchard.Xmu.Models;

namespace Orchard.Xmu.Service
{
    public class AdminPagingService : IAdminPagingService
    {
        private readonly ISiteService _siteService;
        private readonly IContentManager _contentManager;
        public IOrchardServices Services { get; set; }
        dynamic Shape { get; set; }



        public AdminPagingService(
            ISiteService siteService,
            IContentManager contentManager,
            IShapeFactory shapeFactory,
            IOrchardServices services
            )
        {
            _siteService = siteService;
            _contentManager = contentManager;
            Services = services;
            Shape = shapeFactory;
        }

        public ItemListViewModel ConstructListViewModel(PagerParameters pagerParameters, string typeName, string searchText)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var query = _contentManager.Query(VersionOptions.Latest, typeName)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);
            if (!string.IsNullOrEmpty(searchText))
            {
                query.Where<TitlePartRecord>(i => i.Title.Contains(searchText));
            }


            var list = Services.New.List();

            var totalItemCount = query.Count();
            var items = query.Slice(pager.GetStartIndex(), pager.PageSize);
            foreach (var item in items)
            {
                list.Add(_contentManager.BuildDisplay(item, "SummaryAdmin"));
            }

            var viewModel = Services.New.ViewModel()
             .ContentItems(list);
            var dypager = Shape.Pager(pager).TotalItemCount(totalItemCount);
            var vm = new ItemListViewModel
            {
                Pager = dypager,
                ViewModel = viewModel,
                SearchText = searchText,
            };

            return vm;
        }

        public ItemListViewModel ConstructLisCNTeachertViewModel(PagerParameters pagerParameters, string typeName, string searchText)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var query = _contentManager.Query<CNTeacherPart>(VersionOptions.Latest, typeName)
                .Join<CNTeacherPartRecord>()
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);
            if (!string.IsNullOrEmpty(searchText))
            {
                query.Where<CNTeacherPartRecord>(i=>i.Name.Contains(searchText));
            }

 
            var list = Services.New.List();

            var totalItemCount = query.Count();
            var items = query.Slice(pager.GetStartIndex(), pager.PageSize);
            foreach (var item in items)
            {
                list.Add(_contentManager.BuildDisplay(item, "SummaryAdmin"));
            }

            var viewModel = Services.New.ViewModel()
             .ContentItems(list);
            var dypager = Shape.Pager(pager).TotalItemCount(totalItemCount);
            var vm = new ItemListViewModel
            {
                Pager = dypager,
                ViewModel = viewModel,
                SearchText = searchText,
            };

            return vm;
        }
    }
}