using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using Orchard.DisplayManagement;
using Orchard.Settings;
using Orchard.Taxonomies.Services;
using Orchard.Themes;
using Orchard.UI.Admin;
using Orchard.UI.Navigation;
using Orchard.Xmu.Service;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Admin]
    public class CollegeNewsAdminController : Controller
    {
        private readonly IAdminPagingService _pagingService;


        public CollegeNewsAdminController(
           IAdminPagingService pagingService
            )
        {
            _pagingService = pagingService;
        }

        // GET: CollegeNewsAdmin
        public ActionResult List(PagerParameters pagerParameters, string searchText = "")
        {
            var vm = _pagingService.ConstructListViewModel(pagerParameters,
                XmContentType.CollegeNews.ContentTypeName,
                searchText);

            return View(vm);
        }
    }
}