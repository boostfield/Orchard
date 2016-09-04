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
        [ActionName("SearchCourse")]
        public IHttpActionResult SearchCourse([FromUri] string keyword, [FromUri]PagerParameters pagerParameters)
        {
            keyword = keyword.Trim();
            Pager pager = new Pager(_siteService.GetSiteSettings(), pagerParameters);
            var q = _contentManager.Query<ENCoursesPart, ENCoursesPartRecord>(VersionOptions.Latest)
                .Where<ENCoursesPartRecord>(i => i.CourseName.Contains(keyword))
                .OrderByDescending(i => i.Id);

            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(p => new
                {
                    Id = p.Id,
                    CourseName = p.CourseName
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
