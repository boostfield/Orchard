using Orchard.UI.Navigation;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service
{
    public interface IPagingService: IDependency
    {

        ItemListViewModel ConstructListViewModel(
            PagerParameters pagerParameters,
            string typeName 
            );
    }
}