using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Themes;
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
    public class ENHomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IXmMenuService _xmMenuService;
        private readonly IContentManager _contentManager;

        public ENHomeController(IOrchardServices service
            , IContentManager contentManager,
            IFrontEndService frontEndService,
             IXmMenuService xmMenuService)
        {
            _service = service;
            _xmMenuService = xmMenuService;
            _contentManager = contentManager;
        }

        // GET: ENHome
        public ActionResult Index()
        {
            
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.banners = _contentManager.Query(VersionOptions.Latest, XmContentType.ENBanner.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
                .Slice(0,5)
                .Select(p => p.As<BannerPart>())
                .ToList();
            ViewBag.news = _contentManager.Query(VersionOptions.Latest, "CollegeENNews")
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
                .Slice(0, 2)
                .Select(p => p.As<XmContentPart>())
                .ToList();
            ViewBag.notice = _contentManager.Query(VersionOptions.Latest, "CollegeENNotice")
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
                .Slice(0, 5)
                .Select(p => p.As<XmContentPart>())
                .ToList();
            ViewBag.submenu = _xmMenuService.Get2LevelMenu("EnglishMenu");
            ViewBag.sections = _contentManager.Query(VersionOptions.Latest, XmContentType.ENSection.ContentTypeName)
                .Slice(0, 6)
                .Select(p => p.As<ENSectionPart>())
                .OrderByDescending(i => i.Order)
                .ToList();

                
            return View();
        }
    }
}