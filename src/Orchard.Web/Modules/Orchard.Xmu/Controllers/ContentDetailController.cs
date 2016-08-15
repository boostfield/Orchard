using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    [Themed]
    public class ContentDetailController : Controller
    {
        // GET: ContentDetail
        public ActionResult Item(string contentTypeName, int Id)
        {
            ViewBag.ContentTypeName = contentTypeName;
            ViewBag.Id = Id;

            return View();
        }
    }
}