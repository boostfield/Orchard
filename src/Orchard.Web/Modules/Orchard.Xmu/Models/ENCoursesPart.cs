using Orchard.ContentManagement;
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
    }
}