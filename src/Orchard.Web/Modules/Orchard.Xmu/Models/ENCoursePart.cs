using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENCoursePart:ContentPart<ENCoursePartRecord>
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

        public string CourseNO
        {
            get
            {
                return Retrieve(i => CourseNO);
            }
            set
            {
                Store(i => i.CourseNO, value);
            }
        }


        private readonly LazyField<IList<ENTeacherPart>> _teachers = new LazyField<IList<ENTeacherPart>>();
        public LazyField<IList<ENTeacherPart>>  TeachersField { get { return _teachers; } } 
        public IList<ENTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<ENTeacherPart>(); }
            set { _teachers.Value = value; }
        }


        public IList<string> TeacherIds { get; set; }
    }
}