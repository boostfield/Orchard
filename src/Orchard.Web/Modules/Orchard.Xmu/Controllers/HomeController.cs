﻿using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using Orchard.Taxonomies.Services;
using Orchard.Themes;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IInfoService _infoService;
        public HomeController(IOrchardServices service,
            ITaxonomyService taxonomyService,
            IInfoService infoService
            
            )
        {
            _service = service;
            _infoService = infoService;
        }

        // GET: Home
        public ActionResult Index()
        {
            /*
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.items = _infoService.GetContentItemsOfTaxonomy("学院新闻")
                .Select(p=>p.As<InformationPart>()).OrderByDescending(j=> j.PublishedUtc)
                .Take(5)
                .ToList();


            var i = _service.ContentManager.New(XmContentType.InfomationType);
            */
            return View();
        }
    }
}