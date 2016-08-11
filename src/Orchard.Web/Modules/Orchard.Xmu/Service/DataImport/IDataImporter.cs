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
       // void ImportPartyNews();


        //!!
        void ImportCollegeNews();
    }
}