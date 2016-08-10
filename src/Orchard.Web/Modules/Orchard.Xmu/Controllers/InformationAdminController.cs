using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Containers.Extensions;
using Orchard.Core.Title.Models;
using Orchard.DisplayManagement;
using Orchard.Settings;
using Orchard.Taxonomies.Models;
using Orchard.Taxonomies.Services;
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
    public class InformationAdminController : Controller
    {

        private readonly IPagingService _pagingService;

        public InformationAdminController(
           IPagingService pagingService



            )
        {

            _pagingService = pagingService;
        }

        // GET: InformationAdmin
        public ActionResult List(PagerParameters pagerParameters, string searchText = "", int selectedTermId=-1)
        {
            
            var listViewModel = _pagingService.ConstructListViewModel(pagerParameters,
                XmContentType.InfomationType,
                "InfoType",
                searchText,
                selectedTermId);
            return View(listViewModel);
        }
    }
}