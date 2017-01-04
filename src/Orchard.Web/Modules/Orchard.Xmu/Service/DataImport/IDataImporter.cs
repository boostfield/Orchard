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
        void BuildCNNotifyCategory(); //通知的类型： 有院务通知、本科生教务、研究生教务、学生资讯

        void ImportCope(); //导入合作交流,国内合作、国际合作、共建单位三个合成一个
        void ImportCollegeNews();//学院新闻
        void ImportCollegeAffairsNoti();///院务通知
        void ImportUndergraduateAffairs(); //本科生教务
        void ImportGraduateAffairs(); //研究生教务
        void ImportStudentInfo(); //学生资讯
        void ImportPartyCollegeAffairs(); //党务教务
        void ImportRecruitInfo(); //招录信息
        void ImportLectureInfo(); //讲座信息
        void ImportAcademicNews(); //学术动态
        void ImportXmContent(); //导入旧数据库的Contents


        //-------------------------------------
        void ImportAcademicPaper();
        void ImportAcademicWork();
        void ImportAwards();
        void ImportProjects();
        void ImportTeacherInfo();


        void CreateUserFromCNTeacher();
    }
}