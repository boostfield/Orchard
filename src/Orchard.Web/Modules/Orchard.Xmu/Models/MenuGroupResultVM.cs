using Orchard.Core.Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class MenuGroupResultVM
    {
        public char Position { get; set; }
        public IList<MenuItemEntry> List { get; set; }
    }
}