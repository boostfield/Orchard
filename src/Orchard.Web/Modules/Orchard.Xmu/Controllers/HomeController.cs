using Orchard.ContentManagement;
using Orchard.Core.Title.Models;
using Orchard.Taxonomies.Services;
using Orchard.Themes;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IInfoService _infoService;
        public HomeController(IOrchardServices service,
            ITaxonomyService taxonomyService,
            IInfoService infoService
            
            )
        {
            _service = service;
            _infoService = infoService;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.items = _infoService.GetContentItemsOfTaxonomy("学院新闻")
                .Select(i => i.ContentItem.As<TitlePart>())
                .ToList();
            

            return View();
        }
    }
}