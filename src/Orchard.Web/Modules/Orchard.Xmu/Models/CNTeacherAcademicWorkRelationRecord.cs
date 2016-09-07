using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNTeacherAcademicWorkRelationRecord
    {
        public virtual int Id { get; set; }
        public virtual TeacherRecord TeacherRecord { get; set; }
        public virtual AcademicWorksRecord AcademicWorksRecord { get; set; }

    }
}