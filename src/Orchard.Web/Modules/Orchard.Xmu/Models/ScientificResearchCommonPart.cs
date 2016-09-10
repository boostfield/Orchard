using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ScientificResearchCommonPart:ContentPart
    {

        public bool IsTop
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = (Boolean?)content.ScientificResearchCommonPart.istop.Value ?? false;
                return v;
            }
        }

    }
}