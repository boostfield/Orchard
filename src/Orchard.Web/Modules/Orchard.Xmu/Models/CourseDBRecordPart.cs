using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CourseDBRecordPart: ContentPart<CourseDBRecord>
    {
        [DisplayName("课题名称")]

        public string Name
        {
            get { return Retrieve(i => i.Name); }
            set { Store(i => i.Name, value); }
        }

        [DisplayName("简介")]

        public string Intro
        {
            get { return Retrieve(i => i.Intro); }
            set { Store(i => i.Intro, value); }
        }
        [DisplayName("上课师资")]

        public string Instructor
        {
            get { return Retrieve(i => i.Instructor); }
            set { Store(i => i.Instructor, value); }
        }
        [DisplayName("指定书目")]

        public string RecommandBooks
        {
            get { return Retrieve(i => i.RecommandBooks); }
            set { Store(i => i.RecommandBooks, value); }
        }
        [DisplayName("教学计划提纲")]

        public string TeachPlan
        {
            get { return Retrieve(i => i.TeachPlan); }
            set { Store(i => i.TeachPlan, value); }
        }
        [DisplayName("面向年级")]

        public string ForGrade
        {
            get { return Retrieve(i => i.ForGrade); }
            set { Store(i => i.ForGrade, value); }
        }
        [DisplayName("语言")]

        public string Lan
        {
            get { return Retrieve(i => i.Lan); }
            set { Store(i => i.Lan, value); }
        }
        [DisplayName("面向专业")]

        public string Major
        {
            get { return Retrieve(i => i.Major); }
            set { Store(i => i.Major, value); }
        }
    }
}