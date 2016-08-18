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
        public ActionResult ENItem(string contentTypeName, int Id)
        {
            var item = _contentManager.Get(Id, VersionOptions.Latest);
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.Id = Id;
            if (contentTypeName.Equals("LectureInfo"))
            {
                ViewBag.Item = LectureVM.FromLecturePart(item.As<LectureInfoPart>());
            }
            else
            {
                ViewBag.Item = XmContentVM.FromXmContentPart(item.As<XmContentPart>());

            }

            return View();
        }
        public ActionResult ANItem(string contentTypeName, int Id)
        {
            var item = _contentManager.Get(Id, VersionOptions.Latest);
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.Id = Id;
            if (contentTypeName.Equals("LectureInfo"))
            {
                ViewBag.Item = LectureVM.FromLecturePart(item.As<LectureInfoPart>());
            }
            else
            {
                ViewBag.Item = XmContentVM.FromXmContentPart(item.As<XmContentPart>());

            }

            return View();
        }

        

        public ActionResult ENPaging(string contentTypeName, PagerParameters pagerParameters)
        {


            var pagingResult = GetPagingResult(contentTypeName, pagerParameters);

            ViewBag.total = pagingResult.Item1;
            ViewBag.page = pagingResult.Item3.Page;
            ViewBag.pageSize = pagingResult.Item3.PageSize;
            ViewBag.items = pagingResult.Item2;
            ViewBag.ContentTypeName = contentTypeName;

            return View();


        }

        public ActionResult ANPaging(string contentTypeName, PagerParameters pagerParameters)
        {

            var pagingResult = GetPagingResult(contentTypeName, pagerParameters);

            ViewBag.total = pagingResult.Item1;
            ViewBag.page = pagingResult.Item3.Page;
            ViewBag.pageSize = pagingResult.Item3.PageSize;
            ViewBag.items = pagingResult.Item2;
            ViewBag.ContentTypeName = contentTypeName;

            return View();



        }


        public ActionResult Paging(string contentTypeName,PagerParameters pagerParameters)
        {

            var pagingResult = GetPagingResult(contentTypeName, pagerParameters);

            ViewBag.total = pagingResult.Item1;
            ViewBag.page = pagingResult.Item3.Page;
            ViewBag.pageSize = pagingResult.Item3.PageSize;
            ViewBag.items = pagingResult.Item2;
            ViewBag.ContentTypeName = contentTypeName;

            return View();

        }

        private Tuple<int, IList<XmContentVM>, Pager> GetPagingResult(string contentTypeName, PagerParameters pagerParameters)
        {
            if (pagerParameters == null)
            {
                pagerParameters = new PagerParameters
                {
                    Page = 1,
                    PageSize = 10
                };
            }
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);

            var q = _contentManager.Query(VersionOptions.Latest, contentTypeName)
            .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc);

            var total = q.Count();
            IList<XmContentVM> items;
            if (contentTypeName.Equals("LectureInfo"))
            {
                items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => LectureVM.FromXmContentPart(p.As<LectureInfoPart>())).ToList();
            }
            else
            {
                items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => XmContentVM.FromXmContentPart(p.As<XmContentPart>())).ToList();

            }
            return new Tuple<int, IList<XmContentVM>, Pager>(total, items, pager);
        }


    }
}