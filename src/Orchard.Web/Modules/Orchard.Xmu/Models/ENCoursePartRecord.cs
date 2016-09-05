using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENCoursePartRecord: ContentPartRecord
    {

        public virtual string CourseName { get; set; }
        public virtual string CourseNO { get; set; }//课程编号

        public virtual IList<ENTeacherPartRecord> RecordTeachers { get; set; }

        public ENCoursePartRecord()
        {

            RecordTeachers = new List<ENTeacherPartRecord>();
        }
    }
}