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

namespace Orchard.Xmu.Service
{
    public class PagingService : IPagingService
    {
        private readonly ISiteService _siteService;
        private readonly IContentManager _contentManager;
        private readonly ITaxonomyService _taxonomyService;
        private readonly IInfoService _infoService;
        public IOrchardServices Services { get; set; }
        dynamic Shape { get; set; }


        public PagingService(
             ISiteService siteService,
            IContentManager contentManager,
            IShapeFactory shapeFactory,
            IOrchardServices services,
            ITaxonomyService taxonomySerivce,
            IInfoService infoService
            )
        {
            _siteService = siteService;
            _contentManager = contentManager;
            Services = services;
            Shape = shapeFactory;
            _taxonomyService = taxonomySerivce;
            _infoService = infoService;
        }

        public ItemListViewModel ConstructListViewModel(PagerParameters pagerParameters, string typeName, string taxonomyName, 
            string searchText, int selectedTermId)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var taxo = _taxonomyService.GetTaxonomyByName(taxonomyName);
            var terms = _taxonomyService.GetTerms(taxo.Id);


            var query = _contentManager.Query(VersionOptions.Latest, typeName)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);


            if (!string.IsNullOrEmpty(searchText))
            {
                query.Where<TitlePartRecord>(i => i.Title.Contains(searchText));
            }

            if (selectedTermId != -1)
            {
                query.Where<TermsPartRecord>(tpr => tpr.Terms.Any(tr =>
                       tr.TermRecord.Id == selectedTermId));
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
            return new ItemListViewModel
            {
                Pager = dypager,
                ViewModel = viewModel,
                SearchText = searchText,
                Terms = terms,
                SelectedTermId = selectedTermId
            };

            
        }
    }
}