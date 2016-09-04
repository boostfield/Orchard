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
    public class ENTeacherPartHandler : ContentHandler
    {
        public ENTeacherPartHandler(IRepository<ENTeacherPartRecord> repo,
            IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));


            OnLoaded<ENTeacherPart>((context, teacher) => {
                teacher.CoursesField.Loader(() => teacher.Record.RecordCourses == null ? null :
                contentManager.GetMany<ENCoursesPart>
                (teacher.Record.RecordCourses.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                .ToList());
            });
        }
    }
}