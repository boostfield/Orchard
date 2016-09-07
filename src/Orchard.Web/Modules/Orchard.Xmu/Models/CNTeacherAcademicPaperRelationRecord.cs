using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNTeacherAcademicPaperRelationRecord
    {
        public virtual int Id { get; set; }
        public virtual TeacherRecord TeacherRecord { get; set; }
        public virtual AcademicPaperRecord AcademicPaperRecord { get; set; }
    }
}