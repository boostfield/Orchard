using Orchard.Themes;
using Orchard.Xmu.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class ENHomeController : Controller
    {
        private readonly IOrchardServices _service;
        private readonly IXmMenuService _xmMenuService;

        public ENHomeController(IOrchardServices service
            ,
             IXmMenuService xmMenuService)
        {
            _service = service;
            _xmMenuService = xmMenuService;
        }

        // GET: ENHome
        public ActionResult Index()
        {
            ViewBag.hello = _service.WorkContext.CurrentSite.SiteName;
            ViewBag.submenu = _xmMenuService.Get2LevelMenu("EnglishMenu");
            return View();
        }
    }
}