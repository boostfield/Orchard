using NGM.ContentViewCounter.Events;
using Orchard.ContentManagement;
using Orchard.ContentManagement.MetaData;
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
        private readonly IContentDefinitionManager _contentDefinitionManager;
        private readonly IItemViewedEventHandler _itemViewedEventHandler;

        public XmContentController(IOrchardServices service,
             IFrontEndService frontEndService,
             IContentManager contentManager,
             IContentDefinitionManager contentDefinitionManager,
             IItemViewedEventHandler itemViewedEventHandler,
            ISiteService siteService)
        {

            _service = service;
            _frontEndService = frontEndService;
            _contentManager = contentManager;
            _itemViewedEventHandler = itemViewedEventHandler;
            _siteService = siteService;
            _contentDefinitionManager = contentDefinitionManager;
        }


        // GET: ContentDetail
        public ActionResult Item(string contentTypeName, int Id)
        {

            GetItem(contentTypeName, Id);

            return View();
        }
        public ActionResult ENItem(string contentTypeName, int Id)
        {

            GetItem(contentTypeName, Id);


            return View();
        }
        public ActionResult ANItem(string contentTypeName, int Id)
        {
            GetItem(contentTypeName, Id);
            return View();
        }

       private void GetItem(string contentTypeName, int Id)
        {
            var item = _contentManager.Get(Id, VersionOptions.Latest);
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return;
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

            _itemViewedEventHandler.ContentItemViewed(item);

        }



        public ActionResult ENPaging(string contentTypeName, PagerParameters pagerParameters)
        {


            GetPagingResult(contentTypeName, pagerParameters);

            return View();


        }

        public ActionResult ANPaging(string contentTypeName, PagerParameters pagerParameters)
        {

            GetPagingResult(contentTypeName, pagerParameters);


            return View();



        }


        public ActionResult Paging(string contentTypeName,PagerParameters pagerParameters)
        {

           GetPagingResult(contentTypeName, pagerParameters);


            return View();

        }

        public ActionResult DonationPaging(PagerParameters pagerParameters)
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
            var q = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyDonation.ContentTypeName)
                .List<NinetyCelebrationDonationPart>().OrderByDescending(i => i.DonationAmount);
            var total = q.Count();
            var items = q.Skip(pager.GetStartIndex()).Take(pager.PageSize);
            var listTitle = XmContentType.NinetyDonation.ListTitle;



            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.items = items;
            ViewBag.ContentTypeName = XmContentType.NinetyDonation.ContentTypeName;
            ViewBag.ListTitle = listTitle;

            return View();

        }

        private void GetPagingResult(string contentTypeName, PagerParameters pagerParameters)
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
            var listTitle = string.Empty;
            var contentType = _contentDefinitionManager.GetTypeDefinition(contentTypeName);
            if(contentType!=null)
            {
                contentType.Settings.TryGetValue("ListTitle", out listTitle); 
                if(string.IsNullOrEmpty(listTitle))
                {
                    listTitle = contentType.DisplayName;
                }

            }

            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.items = items;
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.ListTitle = listTitle;
        }


    }
}