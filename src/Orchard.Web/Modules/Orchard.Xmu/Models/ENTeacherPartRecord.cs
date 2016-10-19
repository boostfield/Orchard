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
        public virtual string SN { get; set; } //老师编号

        public virtual string Titles { get; set; } //职称

        public virtual IList<ENCoursePartRecord> RecordCourses { get; set; }


        public ENTeacherPartRecord()
        {
            RecordCourses = new List<ENCoursePartRecord>();
        }
    }
}