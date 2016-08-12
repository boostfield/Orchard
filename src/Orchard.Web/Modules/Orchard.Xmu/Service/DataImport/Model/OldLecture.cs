using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldLecture: OldContent
    {
        public string Lecturer { get; set; }
        public string Address { get; set; }
        public DateTime StartTime { get; set; }

    }
}