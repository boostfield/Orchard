using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNTeacherAwardRelationRecord
    {
        public virtual int Id { get; set; }
        public virtual CNTeacherPartRecord TeacherRecord { get; set; }
        public virtual AwardsRecord AwardsRecord { get; set; }
    }
}