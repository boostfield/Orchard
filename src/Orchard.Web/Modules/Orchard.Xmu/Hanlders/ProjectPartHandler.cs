using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Hanlders
{
    public class ProjectPartHandler: ContentHandler
    {
        public ProjectPartHandler(IRepository<ProjectRecord> repo)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}