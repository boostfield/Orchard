using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENCoursesPart:ContentPart<ENCoursesPartRecord>
    {
        public string CourseName
        {
            get
            {
                return Retrieve(i => i.CourseName);
            }

            set
            {
                Store(i => i.CourseName, value);
            }
        }


        private readonly LazyField<IList<ENTeacherPart>> _teachers = new LazyField<IList<ENTeacherPart>>();
        public LazyField<IList<ENTeacherPart>>  TeachersField { get { return _teachers; } } 
        public IList<ENTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<ENTeacherPart>(); }
            set { _teachers.Value = value; }
        }

    }
}