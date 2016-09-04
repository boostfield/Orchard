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
    public class ENCoursesPartHandler: ContentHandler
    {
        public ENCoursesPartHandler(IRepository<ENCoursesPartRecord> repo,
            IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));

            OnLoaded<ENCoursesPart>((context, course) => {
                course.TeachersField.Loader(() => course.Record.RecordTeachers == null ? null :
                contentManager.GetMany<ENTeacherPart>
                (course.Record.RecordTeachers.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                .ToList());
            });

        }
    }
}