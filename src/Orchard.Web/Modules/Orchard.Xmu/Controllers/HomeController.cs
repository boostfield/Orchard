using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{

    public class HomeController : Controller
    {
        private readonly IOrchardServices _service;

        public HomeController(IOrchardServices service)
        {
            _service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            return View();
        }
    }
}