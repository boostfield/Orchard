using Orchard.Taxonomies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class ItemListViewModel
    {
        public dynamic ViewModel { get; set; }
        public dynamic Pager { get; set; }
        public string SearchText { get; set; }
    }
    
}