using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldCategory
    {
        public int ID { get; set; }
        public string TopicName { get; set; }
        public string ParentTopicID { get; set; }

    }
}