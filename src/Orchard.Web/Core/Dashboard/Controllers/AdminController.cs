using System.Web.Mvc;

namespace Orchard.Core.Dashboard.Controllers {
    public class AdminController : Controller {

        public ActionResult Index() {
            return RedirectToAction("List", "Admin", new { area = "Contents", id = "" });
        }
    }
}