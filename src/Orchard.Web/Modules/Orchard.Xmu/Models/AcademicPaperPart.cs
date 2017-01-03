using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Orchard.Xmu.Models
{
    public class AcademicPaperPart : ContentPart<AcademicPaperRecord>
    {
        public string ImageAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.AcademicPaperPart.image.FirstMediaUrl;
                return v;
            }
        }


        public string Tid
        {
            get
            {
                return Retrieve(i => i.Tid);
            }
            set
            {
                Store(i => i.Tid, value);
            }
        }

        [DisplayName("标题")]
        public string Title
        {
            get
            {
                return Retrieve(i => i.Title);
            }
            set
            {
                Store(i => i.Title, value);
            }
        }

        [DisplayName("作者")]
        public string Author
        {
            get
            {
                return Retrieve(i => i.Author);
            }
            set
            {
                Store(i => i.Author, value);
            }
        }

        [DisplayName("年度")]
        public string Year
        {
            get
            {
                return Retrieve(i => i.Year);
            }
            set
            {
                Store(i => i.Year, value);
            }
        }

        [DisplayName("机构")]
        public string Department
        {
            get
            {
                return Retrieve(i => i.Department);
            }
            set
            {
                Store(i => i.Department, value);
            }
        }

        [DisplayName("关键字")]
        public string Keyword
        {
            get
            {
                return Retrieve(i => i.Keyword);
            }
            set
            {
                Store(i => i.Keyword, value);
            }
        }

        [DisplayName("摘要")]
        public string Summary
        {
            get
            {
                return Retrieve(i => i.Summary);
            }
            set
            {
                Store(i => i.Summary, value);
            }
        }

        [DisplayName("系别")]
        public string Text
        {
            get
            {
                return Retrieve(i => i.Text);
            }
            set
            {
                Store(i => i.Text, value);
            }
        }

        [DisplayName("发表时间")]
        public string ReleaseDate
        {
            get
            {
                return Retrieve(i => i.ReleaseDate);
            }
            set
            {
                Store(i => i.ReleaseDate, value);
            }
        }

        [DisplayName("刊物名称")]
        public string Publication
        {
            get
            {
                return Retrieve(i => i.Publication);
            }
            set
            {
                Store(i => i.Publication, value);
            }
        }

        [DisplayName("刊号")]
        public string Pid
        {
            get
            {
                return Retrieve(i => i.Pid);
            }
            set
            {
                Store(i => i.Pid, value);
            }
        }

        [DisplayName("刊物期别")]
        public string Ptime
        {
            get
            {
                return Retrieve(i => i.Ptime);
            }
            set
            {
                Store(i => i.Ptime, value);
            }
        }

        [DisplayName("刊物级别")]
        public string Plevel
        {
            get
            {
                return Retrieve(i => i.Plevel);
            }
            set
            {
                Store(i => i.Plevel, value);
            }
        }

        [DisplayName("合作者顺序")]
        public string Writertype
        {
            get
            {
                return Retrieve(i => i.Writertype);
            }
            set
            {
                Store(i => i.Writertype, value);
            }
        }

        [DisplayName("字数")]
        public int TextNumber
        {
            get
            {
                return Retrieve(i => i.TextNumber);
            }
            set
            {
                Store(i => i.TextNumber, value);
            }
        }

        [DisplayName("备注")]
        public string Remarks
        {
            get
            {
                return Retrieve(i => i.Remarks);
            }
            set
            {
                Store(i => i.Remarks, value);
            }
        }

 
        [DisplayName("点击数")]
        public int ClickNumber
        {
            get
            {
                return Retrieve(i => i.ClickNumber);
            }
            set
            {
                Store(i => i.ClickNumber, value);
            }
        }

 
        [DisplayName("是否显示")]
        public bool IsShow
        {
            get
            {
                return Retrieve(i => i.IsShow);
            }
            set
            {
                Store(i => i.IsShow, value);
            }
        }

        [DisplayName("成果类别")]
        public string Achievement
        {
            get
            {
                return Retrieve(i => i.Achievement);
            }
            set
            {
                Store(i => i.Achievement, value);
            }
        }

        [DisplayName("重要期刊")]
        public string ImportantJournal
        {
            get
            {
                return Retrieve(i => i.ImportantJournal);
            }
            set
            {
                Store(i => i.ImportantJournal, value);
            }
        }

        [DisplayName("被转载")]
        public string RePrint
        {
            get
            {
                return Retrieve(i => i.RePrint);
            }
            set
            {
                Store(i => i.RePrint, value);
            }
        }

        [DisplayName("研究成果")]
        public string ResearchResult
        {
            get
            {
                return Retrieve(i => i.ResearchResult);
            }
            set
            {
                Store(i => i.ResearchResult, value);
            }
        }


        private readonly LazyField<IList<CNTeacherPart>> _teachers = new LazyField<IList<CNTeacherPart>>();
        public  LazyField<IList<CNTeacherPart>> TeachersField { get { return _teachers; } }
        public IList<CNTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<CNTeacherPart>(); }
            set { _teachers.Value = value; }
        }
    }
}