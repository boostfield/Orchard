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
    public class AcademicPaperPartHandler : ContentHandler
    {

        public AcademicPaperPartHandler(IRepository<AcademicPaperRecord> repo,
            IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));
            OnLoaded<AcademicPaperPart>((context, part) =>
            {
                part.TeachersField.Loader(
                      () => part.Record.RecordCNTeachers == null ? null :
                         contentManager.GetMany<CNTeacherPart>
                        (part.Record.RecordCNTeachers.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                         .ToList()
                          );
            });

        }
    }
}