using Orchard.ContentManagement;
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
        private readonly IFrontEndService _frontEndService;
         public HomeController(IOrchardServices service,
             IFrontEndService frontEndService
              
            )
        {
            _service = service;
            _frontEndService = frontEndService;
         }

        // GET: Home
        public ActionResult Index()
        {
            
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.items = _frontEndService.LatestContentOfType(XmContentType.CollegeNews.ContentTypeName)
                .Select(p => p.As<CollegeNewsPart>()).ToList();

           
            
            return View();
        }
    }
}