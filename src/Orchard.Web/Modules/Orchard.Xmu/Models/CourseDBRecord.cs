using Orchard.ContentManagement.Records;
using Orchard.Data.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CourseDBRecord: ContentPartRecord
    {
        public virtual string Name { get; set; } //课程名称
        [StringLengthMax]

        public virtual string Intro { get; set; } //课程简介
        public virtual string Instructor { get; set; }//上课师资
        [StringLengthMax]
        public virtual string RecommandBooks { get; set; }//制定书目
        [StringLengthMax]
        public virtual string TeachPlan { get; set; } //教学计划提纲

        public virtual string ForGrade { get; set; } //哪级课程

        public virtual string Lan { get; set; }  //中英文
        public virtual string Major { get; set; } //专业
    }
}