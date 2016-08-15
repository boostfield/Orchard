using Orchard.UI.Admin;
using Orchard.UI.Navigation;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Admin]

    public class College90CelebrationAdminController : Controller
    {
        private readonly IAdminPagingService _pagingService;


        public College90CelebrationAdminController(
           IAdminPagingService pagingService
            )
        {
            _pagingService = pagingService;
        }

        // GET: CollegeNewsAdmin
        public ActionResult List(string contentTypeName, PagerParameters pagerParameters, string searchText = "")
        {
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.ContentTypeDisplayName = GetDisplayName(contentTypeName);

            var vm = _pagingService.ConstructListViewModel(pagerParameters,
                contentTypeName,
                 searchText);

            return View(vm);

        }



        private string GetDisplayName(string typename)
        {
            foreach (var mapping in XmContentType.NinetyMappings)
            {
                if (mapping.ContentTypeName.Equals(typename))
                {
                    return mapping.ContentTypeDisplayName;
                }
            }

            return "内容";
        }
    }
}