﻿using Orchard.UI.Admin;
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
    public class NinetyCelBannerAdminController : Controller
    {
        private readonly IAdminPagingService _pagingService;


        public NinetyCelBannerAdminController(
           IAdminPagingService pagingService
            )
        {
            _pagingService = pagingService;
        }



        public ActionResult List(PagerParameters pagerParameters, string searchText = "")
        {
            var vm = _pagingService.ConstructListViewModel(pagerParameters,
                XmContentType.NinetyCelBanner.ContentTypeName,
                searchText);

            return View(vm);
        }
    }
}