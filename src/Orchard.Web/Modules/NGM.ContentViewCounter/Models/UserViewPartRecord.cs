using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGM.ContentViewCounter.Models
{
    public class UserViewPartRecord: ContentPartRecord
    {
        public int VCount { get; set; }
    }
}