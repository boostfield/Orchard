using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Settings;
using Orchard.Themes;
using Orchard.UI.Navigation;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class XmContentController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IFrontEndService _frontEndService;
        private readonly IContentManager _contentManager;
        private readonly ISiteService _siteService;

        public XmContentController(IOrchardServices service,
             IFrontEndService frontEndService,
             IContentManager contentManager,
            ISiteService siteService)
        {

            _service = service;
            _frontEndService = frontEndService;
            _contentManager = contentManager;
            _siteService = siteService;
        }


        // GET: ContentDetail
        public ActionResult Item(string contentTypeName, int Id)
        {
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.Id = Id;

            return View();
        }


        public ActionResult Paging(string contentTypeName,PagerParameters pagerParameters)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var q = _contentManager.Query(VersionOptions.Latest, contentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => p.As<CollegeNewsPart>()).ToList();
            ViewBag.total = total;
            ViewBag.items = items;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.ContentTypeName = contentTypeName;

            return View();



        }
    }
}