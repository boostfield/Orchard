using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class AnniversaryHomeController : Controller
    {
        private readonly IOrchardServices _service;

        public AnniversaryHomeController(IOrchardServices service)
        {
            _service = service;
        }

        // GET: AnniversaryHome
        public ActionResult Home()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            return View();
        }
        public ActionResult Index()
        {
            return RedirectToAction("Home");
        }
    }
}