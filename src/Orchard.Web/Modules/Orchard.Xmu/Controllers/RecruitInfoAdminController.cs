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
    public class RecruitInfoAdminController : Controller
    {

        private readonly IAdminPagingService _pagingService;


        public RecruitInfoAdminController(
           IAdminPagingService pagingService
            )
        {
            _pagingService = pagingService;
        }



        public ActionResult List(PagerParameters pagerParameters, string searchText = "")
        {
            var vm = _pagingService.ConstructListViewModel(pagerParameters,
                XmContentType.RecruitInfo.ContentTypeName,
                searchText);

            return View(vm);
        }

    }
}