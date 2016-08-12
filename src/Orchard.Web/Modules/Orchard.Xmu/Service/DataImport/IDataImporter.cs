using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport
{
    public interface IDataImporter: IDependency
    {
       // void BuildCategory();
       // void ImportNews();


        //!!
        void ImportCollegeNews();//学院新闻
        void ImportCollegeAffairsNoti();///院务通知
        void ImportUndergraduateAffairs(); //本科生教务
        void ImportGraduateAffairs(); //研究生教务
        void ImportStudentInfo(); //学生资讯
        void ImportPartyCollegeAffairs(); //党务教务
        void ImportRecruitInfo(); //招录信息
    }
}