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
            ViewBag.items = _frontEndService.LatestContentOfType("CollegeAffairsNotify")
                .Select(p => p.As<XmContentPart>()).ToList();



            return View();
        }

    
    }
}