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
    public class StudentPartHandler : ContentHandler
    {

        public StudentPartHandler(IRepository<StudentRecord> repo,
            IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));
        }
    }
}