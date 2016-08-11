using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Core.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.Xmu.Service
{
    public class FrontEndService : IFrontEndService
    {
        private readonly IContentManager _contentManager;

        public FrontEndService(
            IContentManager contentManager
            )
        {
            _contentManager = contentManager;
        }



        public IList<ContentItem> LatestContentOfType (string contentTypeName, int count = 5) 
        {
            return _contentManager.Query(VersionOptions.Latest, contentTypeName)
             .OrderByDescending<CommonPartRecord>(cr => cr.PublishedUtc)
             .Slice(0, count)
             .ToList();
              
        }
    }
}
