using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Hanlders
{
    public class AcademicWorkPartHandler: ContentHandler
    {
        public AcademicWorkPartHandler(IRepository<AcademicWorksRecord> repo)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}