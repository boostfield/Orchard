using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.UI.Navigation;
using Orchard.Xmu.Models;
using Orchard.Xmu.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service
{
    public class ScientificResearchService : IScientificResearchService
    {
        private IContentManager _contentManager;

        private string[] allTypes = new string[] { XmContentType.CNAcademicPaper.ContentTypeName,
                                                XmContentType.CNAcademicWork.ContentTypeName,
                                                XmContentType.CNAward.ContentTypeName,
                                                XmContentType.CNProject.ContentTypeName};

        public ScientificResearchService(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }
        
        public Tuple<int,IEnumerable<ScientificResearchVM>> PagingForAllTypeOfScientificResearch(Pager pager)
        {
            var q = _contentManager.Query(VersionOptions.Latest, allTypes)
              .OrderByDescending<CommonPartRecord>(cr => cr.CreatedUtc);
            var total = q.Count();
            var items = q.Slice(pager.GetStartIndex(), pager.PageSize)
                .Select(FromContentItem);
            return new Tuple<int,IEnumerable<ScientificResearchVM>>(total, items);


        }




        private ScientificResearchVM FromContentItem(ContentItem contentItem)
        {
           
            var title = string.Empty;
            var contentType = contentItem.ContentType;
            var displayName = contentItem.TypeDefinition.DisplayName;

            foreach (var type in allTypes)
            {
                if (contentItem.ContentType.Equals(XmContentType.CNAcademicPaper.ContentTypeName))
                {
                    var part = contentItem.Get<AcademicPaperPart>();
                    title = part.Title;
                    break;
                }
                else if (contentItem.ContentType.Equals(XmContentType.CNAcademicWork.ContentTypeName))
                {
                    var part = contentItem.Get<AcademicWorksPart>();
                    title = part.Title;
                    break;

                }
                else if (contentItem.ContentType.Equals(XmContentType.CNAward.ContentTypeName))
                {
                    var part = contentItem.Get<AwardsPart>();
                    title = part.AwardName;
                    break;

                }
                else if (contentItem.ContentType.Equals(XmContentType.CNProject.ContentTypeName))
                {
                    var part = contentItem.Get<ProjectPart>();
                    title = part.ProjectTitle;
                    break;

                }
            }

            return new ScientificResearchVM
            {
                Title = title,
                ContentTypeName = contentType,
                TypeDisplayName = displayName
            };
        }
    }
}