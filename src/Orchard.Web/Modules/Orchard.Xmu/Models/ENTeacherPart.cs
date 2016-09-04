using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENTeacherPart: ContentPart<ENTeacherPartRecord>
    {
        public string ENName
        {
            get
            {
                return Retrieve(i => i.ENName);
            }
            set
            {
                Store(i => i.ENName, value);
            }
        }

        public string SN
        {
            get { return ""; }
        }
        private readonly LazyField<IList<ENCoursesPart>> _courses = new LazyField<IList<ENCoursesPart>>();
        public LazyField<IList<ENCoursesPart>> CoursesField { get { return _courses; } }
        public IList<ENCoursesPart> Courses
        {
            get { return _courses.Value ?? new List<ENCoursesPart>(); }
            set { _courses.Value = value; }
        }
    }
}