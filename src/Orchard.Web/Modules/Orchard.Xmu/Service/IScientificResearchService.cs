using Orchard.UI.Navigation;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Orchard.Xmu.Service
{
    public interface IScientificResearchService : IDependency
    {
        Tuple<int, IEnumerable<ScientificResearchVM>> PagingForAllTypeOfScientificResearch(string contentTypeName,Pager pager);

    }
}
