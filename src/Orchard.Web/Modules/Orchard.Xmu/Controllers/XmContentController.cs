using NGM.ContentViewCounter.Events;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Common.Models;
using Orchard.Settings;
using Orchard.Taxonomies.Services;
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
        private readonly ITaxonomyService _taxonomyService;
        private readonly IFrontEndService _frontEndService;
        private readonly IContentManager _contentManager;
        private readonly ISiteService _siteService;
        private readonly IContentDefinitionManager _contentDefinitionManager;
        private readonly IItemViewedEventHandler _itemViewedEventHandler;
        private readonly IScientificResearchService _scientificResearchService;

        public XmContentController(IOrchardServices service,
             IFrontEndService frontEndService,
             ITaxonomyService taxonomyService,
             IContentManager contentManager,
             IContentDefinitionManager contentDefinitionManager,
             IItemViewedEventHandler itemViewedEventHandler,
             IScientificResearchService scientificResearchService,
            ISiteService siteService)
        {

            _service = service;
            _taxonomyService = taxonomyService;
            _frontEndService = frontEndService;
            _contentManager = contentManager;
            _itemViewedEventHandler = itemViewedEventHandler;
            _siteService = siteService;
            _contentDefinitionManager = contentDefinitionManager;
            _scientificResearchService = scientificResearchService;
        }


        // GET: ContentDetail
        [OutputCache(NoStore = true, Duration = 0)]
        public ActionResult Item(string contentTypeName, int Id)
        {

            GetItem(contentTypeName, Id);

            return View();
        }
        [OutputCache(NoStore = true, Duration = 0)]

        public ActionResult ENItem(string contentTypeName, int Id)
        {

            GetItem(contentTypeName, Id);


            return View();
        }
        [OutputCache(NoStore = true, Duration = 0)]
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

        public ActionResult ScientificResearchPaging(string contentTypeName, PagerParameters pagerParameters)
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


            var data = _scientificResearchService.PagingForAllTypeOfScientificResearch(contentTypeName, pager);
            ViewBag.total = data.Item1;
            ViewBag.page = pager.Page;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.items = data.Item2;
            ViewBag.ContentTypeName = contentTypeName;
            if(contentTypeName.Equals(XmContentType.CNAcademicPaper.ContentTypeName))
            {
                ViewBag.TypeDisplayName = XmContentType.CNAcademicPaper.ContentTypeDisplayName;
            }
            else if(contentTypeName.Equals(XmContentType.CNAcademicWork.ContentTypeName))
            {
                ViewBag.TypeDisplayName = XmContentType.CNAcademicWork.ContentTypeDisplayName;
            }
            else if (contentTypeName.Equals(XmContentType.CNAward.ContentTypeName))
            {
                ViewBag.TypeDisplayName = XmContentType.CNAward.ContentTypeDisplayName;
            }
            else if (contentTypeName.Equals(XmContentType.CNProject.ContentTypeName))
            {
                ViewBag.TypeDisplayName = XmContentType.CNProject.ContentTypeDisplayName;
            }
            else
            {
                ViewBag.TypeDisplayName = "全部";
            }
            return View();
        }





        public ActionResult Paging(string contentTypeName, PagerParameters pagerParameters)
        {

            GetPagingResult(contentTypeName, pagerParameters);


            return View();

        }

        public ActionResult DonationPaging(string donationType, PagerParameters pagerParameters)
        {
            if (pagerParameters == null)
            {
                pagerParameters = new PagerParameters
                {
                    Page = 1,
                    PageSize = 10
                };
            }
            if (donationType.Equals("large"))
            {
                Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
                var q = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyDonation.ContentTypeName)
                    .List<NinetyCelebrationDonationPart>().OrderByDescending(i => i.DonationAmount).Where(d => Convert.ToDouble(d.DonationAmount) >= 10000).OrderByDescending(i => i.DonationTime);
                var total = q.Count();
                var items = q.Skip(pager.GetStartIndex()).Take(pager.PageSize);
                var listTitle = XmContentType.NinetyDonation.ListTitle;



                ViewBag.total = total;
                ViewBag.page = pager.Page;
                ViewBag.pageSize = pager.PageSize;
                ViewBag.items = items;
                ViewBag.ContentTypeName = XmContentType.NinetyDonation.ContentTypeName;
                ViewBag.ListTitle = listTitle;
                ViewBag.donationType = "large";
                return View();
            } else
            {
                Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
                var q = _contentManager.Query(VersionOptions.Latest, XmContentType.NinetyDonation.ContentTypeName)
                    .List<NinetyCelebrationDonationPart>().OrderByDescending(i => i.DonationAmount).Where(d => Convert.ToDouble(d.DonationAmount) < 10000).OrderByDescending(i => i.DonationTime);
                var total = q.Count();
                var items = q.Skip(pager.GetStartIndex()).Take(pager.PageSize);
                var listTitle = XmContentType.NinetyDonation.ListTitle;



                ViewBag.total = total;
                ViewBag.page = pager.Page;
                ViewBag.pageSize = pager.PageSize;
                ViewBag.items = items;
                ViewBag.ContentTypeName = XmContentType.NinetyDonation.ContentTypeName;
                ViewBag.ListTitle = listTitle;
                ViewBag.donationType = "small";
                return View();
            }
           

        }


        public ActionResult ENCourseItem(int Id)
        {
            var item = _contentManager.Get<ENCoursePart>(Id, VersionOptions.Latest);
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }

            return View(item);
        }


        public ActionResult ENTeacherItem(int Id)
        {
            var item = _contentManager.Get<ENTeacherPart>(Id, VersionOptions.Latest);
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }

            return View(item);
        }


        public ActionResult ENCoursePaging(PagerParameters pagerParameters)
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
            var q = _contentManager.Query(VersionOptions.Latest, XmContentType.ENCourse.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(i => i.PublishedUtc);
            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => p.As<ENCoursePart>()); ;

            var listTitle = XmContentType.ENCourse.ListTitle;

            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.items = items;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.ContentTypeName = XmContentType.ENCourse.ContentTypeName;
            ViewBag.ListTitle = listTitle;

            return View();

        }

        public ActionResult ENTeacherPaging(PagerParameters pagerParameters)
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
            var q = _contentManager.Query(VersionOptions.Latest, XmContentType.ENTeacher.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(i => i.PublishedUtc);
            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => p.As<ENTeacherPart>()); ;

            var listTitle = XmContentType.ENTeacher.ListTitle;

            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.items = items;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.ContentTypeName = XmContentType.ENTeacher.ContentTypeName;
            ViewBag.ListTitle = listTitle;

            return View();

        }


        public ActionResult ShowPaging(PagerParameters pagerParameters)
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
            var q = _contentManager.Query(VersionOptions.Latest, XmContentType.CNCollegeShow.ContentTypeName)
             .OrderByDescending<CommonPartRecord>(i => i.PublishedUtc);
            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => p.As<CNCollegeShowPart>()); ;

            var listTitle = XmContentType.CNCollegeShow.ListTitle;

            ViewBag.total = total;
            ViewBag.page = pager.Page;
            ViewBag.items = items;
            ViewBag.pageSize = pager.PageSize;
            ViewBag.ContentTypeName = XmContentType.CNCollegeShow.ContentTypeName;
            ViewBag.ListTitle = listTitle;

            return View();

        }

        public ActionResult NoticePaging(PagerParameters pagerParameters, int type)
        {
            if (pagerParameters == null)
            {
                pagerParameters = new PagerParameters
                {
                    Page = 1,
                    PageSize = 10,
                };
            }
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var taxonomy = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNNotify);
            var term = _taxonomyService.GetTerm(type);

            if (type != 0)
            {
                
                var items = _taxonomyService.GetContentItemsQuery(term, "taxotype")
                    .OrderByDescending<CommonPartRecord>(i => i.CreatedUtc)
                    .Slice(pager.GetStartIndex(), pager.PageSize)
                    .Select(p => p.As<CNNotifyPart>());
               /*
                var items = _taxonomyService.GetContentItems(term,pager.GetStartIndex(),pager.PageSize)
                    .Select(p => p.As<CNNotifyPart>());
                    */
                var total = _taxonomyService.GetContentItemsCount(term);
                var listTitle = XmContentType.CNNotify.ListTitle;
                ViewBag.total = total;
                ViewBag.page = pager.Page;
                ViewBag.items = items;
                ViewBag.pageSize = pager.PageSize;
                ViewBag.ContentTypeName = XmContentType.CNNotify.ContentTypeName;
                ViewBag.ListTitle = listTitle;
            } else
            {
                var q = _contentManager.Query(VersionOptions.Latest, XmContentType.CNNotify.ContentTypeName)
                .OrderByDescending<CommonPartRecord>(i => i.CreatedUtc);
                var total = q.Count();
                var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                    .Select(p => p.As<CNNotifyPart>()); ;

                var listTitle = XmContentType.CNNotify.ListTitle;

                ViewBag.total = total;
                ViewBag.page = pager.Page;
                ViewBag.items = items;
                ViewBag.pageSize = pager.PageSize;
                ViewBag.ContentTypeName = XmContentType.CNNotify.ContentTypeName;
                ViewBag.ListTitle = listTitle;

            }

            ViewBag.terms = _taxonomyService.GetTerms(taxonomy.Id)
                .Select(i => new TermName
                {
                    Id = i.Id,
                    Name = i.Name
                }).ToList();
            ViewBag.type = type;
            ViewBag.typeName = type != 0 ? term.Name : "全部";




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
            .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc);

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
            if (contentType != null)
            {
                contentType.Settings.TryGetValue("ListTitle", out listTitle);
                if (string.IsNullOrEmpty(listTitle))
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

        public ActionResult ScienceItem(string ContentTypeName, int Id)
        {
            var item = _contentManager.Get(Id);
            ViewBag.contentTypeName = ContentTypeName;
            if (item == null)
            {
                ModelState.AddModelError("", string.Format("找不到Id为{0}的内容", Id));
                return View();
            }

            if (ContentTypeName.Equals(XmContentType.CNAcademicPaper.ContentTypeName))
            {
                var part = item.Get<AcademicPaperPart>();
                ViewBag.item = part;
                return View();
            }
            else if (ContentTypeName.Equals(XmContentType.CNAcademicWork.ContentTypeName))
            {
                var part = item.Get<AcademicWorksPart>();
                ViewBag.item = part;
                return View();

            }
            else if (ContentTypeName.Equals(XmContentType.CNAward.ContentTypeName))
            {
                var part = item.Get<AwardsPart>();
                ViewBag.item = part;
                return View();

            }
            else if (ContentTypeName.Equals(XmContentType.CNProject.ContentTypeName))
            {
                var part = item.Get<ProjectPart>();
                ViewBag.item = part;
                return View();

            }

            return View(item);
        }
    }
}