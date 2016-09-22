using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class ScientificResearchVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentTypeName { get; set; }
        public string TypeDisplayName { get; set; }

        public string ImageAddress { get; set; }

        public string AuthorName { get; set; }
    }
}