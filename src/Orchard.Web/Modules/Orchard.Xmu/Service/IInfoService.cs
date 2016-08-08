using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service
{
    public interface IInfoService: IDependency
    {
        IList<IContent> GetContentItemsOfTaxonomy(string termName,int skip=0,int count =0);
    }
}