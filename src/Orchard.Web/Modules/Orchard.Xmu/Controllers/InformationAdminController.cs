using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Containers.Extensions;
using Orchard.Core.Title.Models;
using Orchard.DisplayManagement;
using Orchard.Settings;
using Orchard.Taxonomies.Models;
using Orchard.Taxonomies.Services;
using Orchard.UI.Admin;
using Orchard.UI.Navigation;
using Orchard.Xmu.Service;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Admin]
    public class InformationAdminController : Controller
    {
        private readonly ISiteService _siteService;
        private readonly IContentManager _contentManager;
        private readonly ITaxonomyService _taxonomyService;
        private readonly IInfoService _infoService;
        public IOrchardServices Services { get; set; }
        dynamic Shape { get; set; }

        public InformationAdminController(
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

        // GET: InformationAdmin
        public ActionResult List(PagerParameters pagerParameters, string searchText = "", int selectedTermId=-1)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var taxo = _taxonomyService.GetTaxonomyByName("InfoType");
            var terms = _taxonomyService.GetTerms(taxo.Id);

          
            var query = _contentManager.Query(VersionOptions.Latest, XmContentType.InfomationType)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);


            if(!string.IsNullOrEmpty(searchText))
            {
                query.Where<TitlePartRecord>(i => i.Title.Contains(searchText));
            }

            if(selectedTermId!=-1)
            {
                query.Where<TermsPartRecord>(tpr => tpr.Terms.Any(tr =>
                       tr.TermRecord.Id == selectedTermId ));
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
            var listViewModel = new ItemListViewModel
            {
                Pager = dypager,
                ViewModel = viewModel,
                SearchText = searchText,
                Terms = terms,
                SelectedTermId = selectedTermId
            };
            return View(listViewModel);
        }
    }
}