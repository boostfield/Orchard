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

    }
}