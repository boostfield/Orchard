using Orchard.ContentManagement;
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
    }
}