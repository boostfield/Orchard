using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Core.Common.Models;
using System.ComponentModel;

namespace Orchard.Xmu.Models
{
    public class ENCoursePart:ContentPart<ENCoursePartRecord>
    {
        [DisplayName("课程名称")]
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

        [DisplayName("课程编号")]
        public string CourseNO
        {
            get
            {
                return Retrieve(i => i.CourseNO);
            }
            set
            {
                Store(i => i.CourseNO, value);
            }
        }

        [DisplayName("课程介绍")]
        public string Text
        {
            get { return this.As<BodyPart>().Text; }
            set { this.As<BodyPart>().Text = value; }
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