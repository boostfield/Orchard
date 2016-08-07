using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class Column1Controller : Controller
    {
        private readonly IOrchardServices _service;

        public Column1Controller(IOrchardServices service)
        {
            _service = service;
        }

        // GET: Column1
        public ActionResult Index()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            return View();
        }
    }
}