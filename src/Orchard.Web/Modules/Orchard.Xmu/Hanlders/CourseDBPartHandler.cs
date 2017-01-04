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
    public class CourseDBPartHandler: ContentHandler
    {
        public CourseDBPartHandler(IRepository<CourseDBRecord> repo, IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));

            OnLoaded<CourseDBRecordPart>((context, part) =>
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