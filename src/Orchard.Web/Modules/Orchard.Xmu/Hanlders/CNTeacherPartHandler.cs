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
    public class CNTeacherPartHandler:ContentHandler
    {
        public CNTeacherPartHandler(IRepository<CNTeacherPartRecord> repo,
           IContentManager contentManager)
        {
            Filters.Add(StorageFilter.For(repo));

            OnLoaded<CNTeacherPart>((context,part)=>
            {

                part.PapersField.Loader(
                     () => part.Record.RecordAcademicPapers == null ? null :
                     contentManager.GetMany<AcademicPaperPart>
                     (part.Record.RecordAcademicPapers.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                     .ToList()
                     );


                part.WorksField.Loader(
                     () => part.Record.RecordAcademicWorks == null ? null :
                     contentManager.GetMany<AcademicWorksPart>
                     (part.Record.RecordAcademicWorks.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                     .ToList()
                     );


                part.AwardsField.Loader(
                     () => part.Record.RecordAwards == null ? null :
                     contentManager.GetMany<AwardsPart>
                     (part.Record.RecordAwards.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                     .ToList()
                     );



                part.ProjectsField.Loader(
                     () => part.Record.RecordProjects == null ? null :
                     contentManager.GetMany<ProjectPart>
                     (part.Record.RecordProjects.Select(i => i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                     .ToList()
                     );



                part.CoursesField.Loader(
                    ()=>part.Record.RecordCourses == null ? null :
                    contentManager.GetMany<CourseDBRecordPart>
                    (part.Record.RecordCourses.Select(i=>i.ContentItemRecord.Id), VersionOptions.Latest, QueryHints.Empty)
                    .ToList()
                    );


            });


        }
    }
}