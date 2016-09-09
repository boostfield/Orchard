using Orchard.ContentManagement;
using Orchard.Settings;
using Orchard.UI.Navigation;
using Orchard.Xmu.Models;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Orchard.Xmu.ApiControllers
{
    public class ManagerController : ApiController
    {
        private readonly IContentManager _contentManager;

        private readonly ISiteService _siteService;

        public ManagerController(IContentManager contentManager,
            ISiteService siteService
            )
        {
            _contentManager = contentManager;
            _siteService = siteService;
        }

        [HttpGet]
        [ActionName("SearchTeacher")]
        public IHttpActionResult SearchTeacher([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<ENTeacherPart, ENTeacherPartRecord>(VersionOptions.Latest)
                .Where<ENTeacherPartRecord>(i => i.ENName.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    ENName = p.ENName,
                    SN = ""
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });



        }

        [HttpGet]
        [ActionName("SearchCNTeacher")]
        public IHttpActionResult SearchCNTeacher([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<CNTeacherPart, CNTeacherPartRecord>(VersionOptions.Latest)
                .Where<CNTeacherPartRecord>(i => i.Name.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    Number = p.Number
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });


        }


        [HttpGet]
        [ActionName("SearchAcademicPaper")]
        public IHttpActionResult SearchAcademicPaper([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<AcademicPaperPart, AcademicPaperRecord>(VersionOptions.Latest)
                .Where<AcademicPaperRecord>(i => i.Title.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    Title = p.Title
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });
        }

        [HttpGet]
        [ActionName("SearchAcademicWork")]
        public IHttpActionResult SearchAcademicWork([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<AcademicWorksPart, AcademicWorksRecord>(VersionOptions.Latest)
                .Where<AcademicWorksRecord>(i => i.Title.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    Title = p.Title
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });

        }


        [HttpGet]
        [ActionName("SearchAward")]
        public IHttpActionResult SearchAward([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<AwardsPart, AwardsRecord>(VersionOptions.Latest)
                .Where<AwardsRecord>(i => i.AwardName.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    AwardName = p.AwardName
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });

        }

        [HttpGet]
        [ActionName("SearchProject")]
        public IHttpActionResult SearchProject([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<ProjectPart, ProjectRecord>(VersionOptions.Latest)
                .Where<ProjectRecord>(i => i.ProjectTitle.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    Title = p.ProjectTitle
                });

            return Json(new ApiListResponse
            {
                DataList = items,
                TotalCount = total,
                PageSize = pager.PageSize,
                PageNumber = pager.Page
            });

        }

    }
}
