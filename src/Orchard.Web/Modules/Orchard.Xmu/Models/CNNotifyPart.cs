using Orchard.ContentManagement;
using Orchard.Tags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNNotifyPart: XmContentPart
    {

        public string Tags
        {
            get
            {
                return string.Join(",", this.As<TagsPart>().CurrentTags);
            }
        }
    }
}