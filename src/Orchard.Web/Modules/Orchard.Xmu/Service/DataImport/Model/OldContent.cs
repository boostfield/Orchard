using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport.Model
{
    public class OldContent
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public DateTime PubTime { get; set; }
        public DateTime EdiTime { get; set; }
        public int Clicks { get; set; }

        public int Part { get; set; }   //part
        public int Cate { get; set; }   //Cate

    }
}