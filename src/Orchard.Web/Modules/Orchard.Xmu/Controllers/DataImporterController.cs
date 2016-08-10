using Orchard.Xmu.Service.DataImport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{
    public class DataImporterController : Controller
    {
        private IDataImporter _dataImporter;
        public DataImporterController(
             IDataImporter dataImporter

            )
        {
            _dataImporter = dataImporter;
        }

        // GET: DataImporter
        public ActionResult BuildCategory()
        {
            _dataImporter.BuildCategory();
            return View("Index");
        }


        public ActionResult ImportNews()
        {

            _dataImporter.ImportNews();
            return View("Index");

        }
    }
}