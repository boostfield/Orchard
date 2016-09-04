using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Hanlders
{
    public class ENTeacherPartHandler: ContentHandler
    {
        public ENTeacherPartHandler(IRepository<ENTeacherPartRecord> repo)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}