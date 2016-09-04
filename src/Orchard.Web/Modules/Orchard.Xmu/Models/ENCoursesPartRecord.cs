using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENCoursesPartRecord: ContentPartRecord
    {

        public virtual string CourseName { get; set; }


        public virtual IList<ENTeacherPartRecord> RecordTeachers { get; set; }

        public ENCoursesPartRecord()
        {

            RecordTeachers = new List<ENTeacherPartRecord>();
        }
    }
}