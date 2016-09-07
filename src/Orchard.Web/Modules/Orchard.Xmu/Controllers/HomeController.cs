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
using Orchard.Core.Navigation.ViewModels;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IFrontEndService _frontEndService;
        private readonly IContentManager _contentManager;
        private readonly ISiteService _siteService;
        private readonly IXmMenuService _xmMenuService;

        public HomeController(IOrchardServices service,
             IFrontEndService frontEndService,
             IContentManager contentManager,
            ISiteService siteService,
            IXmMenuService xmMenuService


            )
        {
            _service = service;
            _frontEndService = frontEndService;
            _contentManager = contentManager;
            _siteService = siteService;
            _xmMenuService = xmMenuService;
         }

        public ActionResult Index()
        {
            return RedirectToAction("Home");
        }

        // GET: Home
        public ActionResult Home()
        {
            
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.items = _frontEndService.LatestContentOfType("CollegeAffairsNotify")
                .Select(p => p.As<XmContentPart>()).ToList();

            var b = _contentManager.Query(VersionOptions.Latest, XmContentType.CNBanner.ContentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
            .List()
            .Select(p => p.As<BannerPart>()).ToList();

            ViewBag.banners = b;

            var m = _xmMenuService.Get2LevelMenu("RelatedLinks");
            ViewBag.menus = m;

            //---------------------------------------
            ViewBag.topNews = _frontEndService.TopContentsOfType("CollegeNews")
                  .Select(p => p.As<XmContentPart>()).OrderByDescending(i => i.CreatedUtc).ToList();
            ViewBag.news = _contentManager.Query(VersionOptions.Latest, "CollegeNews")
               .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
               .Slice(0, 8)
               .Select(p => p.As<XmContentPart>()).ToList();

            ViewBag.lectures = _contentManager.Query(VersionOptions.Latest, XmContentType.LectureInfo.ContentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
            .Slice(0, 3)
            .Select(p => p.As<LectureInfoPart>()).ToList();

            ViewBag.notice = _contentManager.Query(VersionOptions.Latest, XmContentType.CNNotify.ContentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
            .Slice(0,8)
            .Select(p => p.As<CNNotifyPart>()).ToList();

            return View();

            
        }

    
    }

     
}