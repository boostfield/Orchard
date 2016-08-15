using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using Orchard.Taxonomies.Services;
using Orchard.Themes;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.UI.Navigation;
using Orchard.Settings;
using System.Globalization;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IFrontEndService _frontEndService;
        private readonly IContentManager _contentManager;
        private readonly ISiteService _siteService;

        public HomeController(IOrchardServices service,
             IFrontEndService frontEndService,
             IContentManager contentManager,
            ISiteService siteService


            )
        {
            _service = service;
            _frontEndService = frontEndService;
            _contentManager = contentManager;
            _siteService = siteService;
         }

        // GET: Home
        public ActionResult Index()
        {
            
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.items = _frontEndService.LatestContentOfType(XmContentType.CollegeAffairsNotify.ContentTypeName)
                .Select(p => p.As<CollegeAffairsNotifyPart>()).ToList();



            return View();
        }

        public ActionResult Paging(PagerParameters pagerParameters)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var q = _contentManager.Query(VersionOptions.Latest, XmContentType.CollegeNews.ContentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => p.As<CollegeNewsPart>()).ToList();
            ViewBag.total = total;
            ViewBag.items = items;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;

 

            return View();



        }
    }
}