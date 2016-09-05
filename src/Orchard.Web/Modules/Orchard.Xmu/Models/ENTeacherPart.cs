using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Core.Common.Models;

namespace Orchard.Xmu.Models
{
    public class ENTeacherPart: ContentPart<ENTeacherPartRecord>
    {

        public string AvatarAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.ENTeacherPart.avatar.FirstMediaUrl;
                return v;
            }
        }

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
            get { return Retrieve(i => i.SN); }
            set { Store(i => i.SN, value); }
        }
        public string Text
        {
            get { return this.As<BodyPart>().Text; }
            set { this.As<BodyPart>().Text = value; }
        }
        private readonly LazyField<IList<ENCoursePart>> _courses = new LazyField<IList<ENCoursePart>>();
        public LazyField<IList<ENCoursePart>> CoursesField { get { return _courses; } }
        public IList<ENCoursePart> Courses
        {
            get { return _courses.Value ?? new List<ENCoursePart>(); }
            set { _courses.Value = value; }
        }
    }
}