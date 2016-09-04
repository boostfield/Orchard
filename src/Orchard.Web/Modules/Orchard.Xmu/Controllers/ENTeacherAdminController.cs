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
    public class ENTeacherAdminController : Controller
    {
        private readonly IAdminPagingService _pagingService;


        public ENTeacherAdminController(
           IAdminPagingService pagingService
            )
        {
            _pagingService = pagingService;
        }



        public ActionResult List(PagerParameters pagerParameters, string searchText = "")
        {
            var vm = _pagingService.ConstructListViewModel(pagerParameters,
                XmContentType.ENTeacher.ContentTypeName,
                searchText);

            return View(vm);
        }
    }
}