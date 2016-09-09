using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class AcademicWorksPart:ContentPart<AcademicWorksRecord>
    {
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

        [DisplayName("系别")]
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

        [DisplayName("出版单位")]
        public string Publishunit
        {
            get
            {
                return Retrieve(i => i.Publishunit);
            }
            set
            {
                Store(i => i.Publishunit, value);
            }
        }

        [DisplayName("书号")]
        public string Booknumber
        {
            get
            {
                return Retrieve(i => i.Booknumber);
            }
            set
            {
                Store(i => i.Booknumber, value);
            }
        }

        [DisplayName("出版时间")]
        public DateTime Publishdate
        {
            get
            {
                return Retrieve(i => i.Publishdate);
            }
            set
            {
                Store(i => i.Publishdate, value);
            }
        }

        [DisplayName("著作类别")]
        public string Booktype
        {
            get
            {
                return Retrieve(i => i.Booktype);
            }
            set
            {
                Store(i => i.Booktype, value);
            }
        }

        [DisplayName("合作者顺序")]
        public string WriterType
        {
            get
            {
                return Retrieve(i => i.WriterType);
            }
            set
            {
                Store(i => i.WriterType, value);
            }
        }

        [DisplayName("全部字数")]
        public int AllTextBumber
        {
            get
            {
                return Retrieve(i => i.AllTextBumber);
            }
            set
            {
                Store(i => i.AllTextBumber, value);
            }
        }

        [DisplayName("本人完成字数")]
        public int FinishNumber
        {
            get
            {
                return Retrieve(i => i.FinishNumber);
            }
            set
            {
                Store(i => i.FinishNumber, value);
            }
        }

        [DisplayName("参著作者1")]
        public string Author1
        {
            get
            {
                return Retrieve(i => i.Author1);
            }
            set
            {
                Store(i => i.Author1, value);
            }
        }

        [DisplayName("参著字数1")]
        public string TextNumber1
        {
            get
            {
                return Retrieve(i => i.TextNumber1);
            }
            set
            {
                Store(i => i.TextNumber1, value);
            }
        }

        [DisplayName("参著作者2")]
        public string Author2
        {
            get
            {
                return Retrieve(i => i.Author2);
            }
            set
            {
                Store(i => i.Author2, value);
            }
        }

        [DisplayName("参著字数2")]
        public string TextNumber2
        {
            get
            {
                return Retrieve(i => i.TextNumber2);
            }
            set
            {
                Store(i => i.TextNumber2, value);
            }
        }

        [DisplayName("参著作者3")]
        public string Author3
        {
            get
            {
                return Retrieve(i => i.Author3);
            }
            set
            {
                Store(i => i.Author3, value);
            }
        }

        [DisplayName("参著字数3")]
        public string TextNumber3
        {
            get
            {
                return Retrieve(i => i.TextNumber3);
            }
            set
            {
                Store(i => i.TextNumber3, value);
            }
        }

        [DisplayName("参著作者4")]
        public string Author4
        {
            get
            {
                return Retrieve(i => i.Author4);
            }
            set
            {
                Store(i => i.Author4, value);
            }
        }

        [DisplayName("参著字数4")]
        public string TextNumber4
        {
            get
            {
                return Retrieve(i => i.TextNumber4);
            }
            set
            {
                Store(i => i.TextNumber4, value);
            }
        }

        [DisplayName("参著作者5")]
        public string Author5
        {
            get
            {
                return Retrieve(i => i.Author5);
            }
            set
            {
                Store(i => i.Author5, value);
            }
        }
        [DisplayName("参著字数5")]
        public string TextNumber5
        {
            get
            {
                return Retrieve(i => i.TextNumber5);
            }
            set
            {
                Store(i => i.TextNumber5, value);
            }
        }

        [DisplayName("参著作者6")]
        public string Author6
        {
            get
            {
                return Retrieve(i => i.Author6);
            }
            set
            {
                Store(i => i.Author6, value);
            }
        }

        [DisplayName("参著字数6")]
        public string TextNumber6
        {
            get
            {
                return Retrieve(i => i.TextNumber6);
            }
            set
            {
                Store(i => i.TextNumber6, value);
            }
        }

        [DisplayName("参著作者7")]
        public string Author7
        {
            get
            {
                return Retrieve(i => i.Author7);
            }
            set
            {
                Store(i => i.Author7, value);
            }
        }

        [DisplayName("参著字数7")]
        public string TextNumber7
        {
            get
            {
                return Retrieve(i => i.TextNumber7);
            }
            set
            {
                Store(i => i.TextNumber7, value);
            }
        }

        [DisplayName("参著作者8")]
        public string Author8
        {
            get
            {
                return Retrieve(i => i.Author8);
            }
            set
            {
                Store(i => i.Author8, value);
            }
        }

        [DisplayName("参著字数8")]
        public string TextNumber8
        {
            get
            {
                return Retrieve(i => i.TextNumber8);
            }
            set
            {
                Store(i => i.TextNumber8, value);
            }
        }

        [DisplayName("参著作者9")]
        public string Author9
        {
            get
            {
                return Retrieve(i => i.Author9);
            }
            set
            {
                Store(i => i.Author9, value);
            }
        }

        [DisplayName("参著字数9")]
        public string TextNumber9
        {
            get
            {
                return Retrieve(i => i.TextNumber9);
            }
            set
            {
                Store(i => i.TextNumber9, value);
            }
        }

        [DisplayName("参著作者10")]
        public string Author10
        {
            get
            {
                return Retrieve(i => i.Author10);
            }
            set
            {
                Store(i => i.Author10, value);
            }
        }

        [DisplayName("参著字数10")]
        public string TextNumber10
        {
            get
            {
                return Retrieve(i => i.TextNumber10);
            }
            set
            {
                Store(i => i.TextNumber10, value);
            }
        }

        [DisplayName("是否项目成果")]
        public int IsResult
        {
            get
            {
                return Retrieve(i => i.IsResult);
            }
            set
            {
                Store(i => i.IsResult, value);
            }
        }

        [DisplayName("项目来源名称")]
        public string SourceName
        {
            get
            {
                return Retrieve(i => i.SourceName);
            }
            set
            {
                Store(i => i.SourceName, value);
            }
        }

        [DisplayName("项目")]
        public string ProjectName
        {
            get
            {
                return Retrieve(i => i.ProjectName);
            }
            set
            {
                Store(i => i.ProjectName, value);
            }
        }

        [DisplayName("内容简介")]
        public string Introduce
        {
            get
            {
                return Retrieve(i => i.Introduce);
            }
            set
            {
                Store(i => i.Introduce, value);
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

        [DisplayName("正文")]
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

 

        [DisplayName("成果类别")]
        public string ResultType
        {
            get
            {
                return Retrieve(i => i.ResultType);
            }
            set
            {
                Store(i => i.ResultType, value);
            }
        }

        [DisplayName("图片")]
        public string Picture
        {
            get
            {
                return Retrieve(i => i.Picture);
            }
            set
            {
                Store(i => i.Picture, value);
            }
        }

        private readonly LazyField<IList<CNTeacherPart>> _teachers = new LazyField<IList<CNTeacherPart>>();
        public LazyField<IList<CNTeacherPart>> TeachersField { get { return _teachers; } }
        public IList<CNTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<CNTeacherPart>(); }
            set { _teachers.Value = value; }
        }
    }
}