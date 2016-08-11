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

        /// <summary>
        /// 学院新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportCollegeNews()
        {
            _dataImporter.ImportCollegeNews();
            return View("Index");

        }
    }
}