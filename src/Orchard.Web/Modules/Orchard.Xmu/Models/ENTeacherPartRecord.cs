using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENTeacherPartRecord:ContentPartRecord
    {
        
        public virtual string ENName { get; set; }

        public virtual IList<ENCoursePartRecord> RecordCourses { get; set; }


        public ENTeacherPartRecord()
        {
            RecordCourses = new List<ENCoursePartRecord>();
        }
    }
}