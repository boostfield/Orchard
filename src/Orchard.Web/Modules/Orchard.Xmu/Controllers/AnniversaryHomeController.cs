using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Themes;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class AnniversaryHomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IContentManager _contentManager;

        public AnniversaryHomeController(IOrchardServices service, IContentManager contentManager)
        {
            _service = service;
            _contentManager = contentManager;
        }

        // GET: AnniversaryHome
        public ActionResult Home()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            var gallery = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyCelMatesOldPic.ContentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
            .List()
            .Select(p => p.As<CelMatesPicPart>()).ToList();

            ViewBag.gallery = gallery;
            return View();
        }
        public ActionResult Index()
        {
            return RedirectToAction("Home");
        }
    }
}