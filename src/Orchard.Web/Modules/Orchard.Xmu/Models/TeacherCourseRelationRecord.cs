using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class TeacherCourseRelationRecord
    {
        public virtual int Id { get; set; }
        public virtual ENTeacherPartRecord ENTeacherPartRecord { get; set; }
        public virtual ENCoursePartRecord ENCoursesRecord { get; set; }
    }
}