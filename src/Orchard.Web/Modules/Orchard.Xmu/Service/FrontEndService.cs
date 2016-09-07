using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Core.Common.Models;
using Orchard.Xmu.Models;
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


        public IList<ContentItem> TopContentsOfType(string contentTypeName)
        {
            /*
            var q = _contentManager.HqlQuery()
                .ForType(contentTypeName)
                .ForVersion(VersionOptions.Latest)
                .List()
               // .Cast<dynamic>()
                //.Where(i => (bool)(i.XmContentPart.istop.Value))
                 .Select(i => i.As<XmContentPart>())
                .Where(i => i.IsTop)
                .Select(i => i.ContentItem)
                .ToList();
            return q;
           */
            return new List<ContentItem>();
         }


    }
}
