using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Hanlders
{
    public class CNTeacherPartHandler:ContentHandler
    {
        public CNTeacherPartHandler(IRepository<CNTeacherPartRecord> repo,
           IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}