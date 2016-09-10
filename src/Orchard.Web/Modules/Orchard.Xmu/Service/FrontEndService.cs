using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using Orchard.Core.Common.Models;
using Orchard.Projections.Models;
using Orchard.Xmu.Models;
using Orchard.Xmu.ViewModels;
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

        public IList<ScientificResearchVM> TopOfScientificResearchType()
        {
            var q = _contentManager.HqlQuery()
                .ForType(new string[] { XmContentType.CNProject.ContentTypeName, XmContentType.CNAcademicPaper.ContentTypeName,
                                        XmContentType.CNAcademicWork.ContentTypeName,XmContentType.CNAward.ContentTypeName})
                .ForVersion(VersionOptions.Latest)
                 .Where(
                 x => x.ContentPartRecord<FieldIndexPartRecord>().Property("IntegerFieldIndexRecords", "ScientificResearchCommonPartistop"),
                 z => z.And(y => y.Eq("PropertyName", "ScientificResearchCommonPart.istop."), t => t.Gt("Value", (long)0))
                )
                .Slice(0, 5)
                .Select(i => ScientificResearchService.FromContentItem(i))
                .ToList();
            return q;
        }

        public IList<ContentItem> TopContentsOfType(string contentTypeName)
        {

            var q = _contentManager.HqlQuery()
                .ForType(contentTypeName)
                .ForVersion(VersionOptions.Latest)
                .Where(
                x => x.ContentPartRecord<FieldIndexPartRecord>().Property("IntegerFieldIndexRecords", "XmContentPartistop"),
                 z => z.And(y => y.Eq("PropertyName", "XmContentPart.istop."), t => t.Gt("Value", (long)0))
                )
                .Slice(0,5)
                .ToList();
               
            return q;
           
           // return new List<ContentItem>();
         }
 
    }
}
