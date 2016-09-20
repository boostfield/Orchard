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
            ViewBag.banners = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyCelBanner.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
                .Slice(0, 5)
                .Select(p => p.As<BannerPart>())
                .ToList();
            ViewBag.notice = _contentManager.Query(VersionOptions.Latest, "CelAnnouncement")
                .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc)
                .Slice(0, 4)
                .Select(p => p.As<XmContentPart>())
                .ToList(); 
            ViewBag.news = _contentManager.Query(VersionOptions.Latest, "CelNews")
                .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc)
                .Slice(0, 4)
                .Select(p => p.As<XmContentPart>())
                .ToList();
            var donation = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyDonation.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
                .List()
                .Select(p => p.As<NinetyCelebrationDonationPart>())
                .OrderByDescending(i => i.DonationTime).ToList();
            ViewBag.largeDonation = donation.Where(d => Convert.ToDouble(d.DonationAmount) >= 10000).OrderByDescending(i => i.DonationTime);
            ViewBag.smallDonation = donation.Where(d => Convert.ToDouble(d.DonationAmount) < 10000).OrderByDescending(i => i.DonationTime);

            ViewBag.articles = _contentManager.Query(VersionOptions.Latest, "CelMatesArticle")
                .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc)
                .Slice(0, 3)
                .Select(p => p.As<XmContentPart>())
                .ToList();
            ViewBag.shows = _contentManager.Query(VersionOptions.Latest, "CelMatesShows")
                .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc)
                .Slice(0, 3)
                .Select(p => p.As<XmContentPart>())
                .ToList();
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