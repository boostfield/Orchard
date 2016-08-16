using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Settings;
using Orchard.Themes;
using Orchard.UI.Navigation;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service;
using Orchard.Xmu.ViewModels;
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
            var item = _contentManager.Get(Id, VersionOptions.Latest);
            if(item==null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.Id = Id;
            if (contentTypeName.Equals("LectureInfo"))
            {
                ViewBag.Item = LectureVM.FromLecturePart(item.As<LectureInfoPart>());
            } else
            {
                ViewBag.Item = XmContentVM.FromXmContentPart(item.As<XmContentPart>());

            }

            return View();
        }


        public ActionResult Paging(string contentTypeName,PagerParameters pagerParameters)
        {
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var q = _contentManager.Query(VersionOptions.Latest, contentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);

            var total = q.Count();

            if (contentTypeName.Equals("LectureInfo"))
            {
                ViewBag.items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => LectureVM.FromXmContentPart(p.As<LectureInfoPart>())).ToList();
            }
            else
            {
                ViewBag.items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => XmContentVM.FromXmContentPart(p.As<XmContentPart>())).ToList();

            }


            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.ContentTypeName = contentTypeName;

            return View();



        }
    }
}