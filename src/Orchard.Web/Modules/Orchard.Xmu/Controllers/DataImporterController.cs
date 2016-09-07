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



        public ActionResult BuildCNNotifyCategory()
        {
            _dataImporter.BuildCNNotifyCategory();
            return View("Index");
        }


        public ActionResult ImportCNTeacher()
        {
            _dataImporter.ImportTeacherInfo();
            return View("Index");

        }

        public ActionResult All()
        {
            _dataImporter.ImportCope();
            _dataImporter.ImportCollegeNews();
            _dataImporter.ImportCollegeAffairsNoti();
            _dataImporter.ImportUndergraduateAffairs();
            _dataImporter.ImportGraduateAffairs();
            _dataImporter.ImportStudentInfo();
            _dataImporter.ImportPartyCollegeAffairs();
            _dataImporter.ImportRecruitInfo();
            _dataImporter.ImportLectureInfo();
            _dataImporter.ImportAcademicNews();
            _dataImporter.ImportXmContent();
            return View("Index");


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


        public ActionResult ImportCop()
        {
            _dataImporter.ImportCope();
            return View("Index");

        }

        /// <summary>
        /// 院务通知
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportCollegeAffairsNotify()
        {
            _dataImporter.ImportCollegeAffairsNoti();
            return View("Index");
        }

        /// <summary>
        /// 本科生教务
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportUndergraduateAffairs()
        {
            _dataImporter.ImportUndergraduateAffairs();
            return View("Index");

        }
        /// <summary>
        /// 研究生教务 
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportGraduateAffairs()
        {
            _dataImporter.ImportGraduateAffairs();
            return View("Index");
        }

        /// <summary>
        /// 学生资讯
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportStudentInfo()
        {
            _dataImporter.ImportStudentInfo();
            return View("Index");

        }

        /// <summary>
        /// 党院教务公开
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportPartyCollegeAffairs()
        {

            _dataImporter.ImportPartyCollegeAffairs();
            return View("Index");

        }

        /// <summary>
        /// 招录信息
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportRecruitInfo()
        {

            _dataImporter.ImportRecruitInfo();
            return View("Index");

        }

        /// <summary>
        /// 讲座信息
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportLectureInfo()
        {

            _dataImporter.ImportLectureInfo();
            return View("Index");

        }

        /// <summary>
        /// 学术动态
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportAcademicNews()
        {

            _dataImporter.ImportAcademicNews();
            return View("Index");

        }


       public ActionResult ImportXmContents()
        {
            _dataImporter.ImportXmContent();
            return View("Index");

        }
    }
}