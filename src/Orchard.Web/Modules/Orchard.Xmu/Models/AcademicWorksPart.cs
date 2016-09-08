using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
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

        public DateTime InputDate
        {
            get
            {
                return Retrieve(i => i.InputDate);
            }
            set
            {
                Store(i => i.InputDate, value);
            }
        }

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

        public DateTime RefreshDate
        {
            get
            {
                return Retrieve(i => i.RefreshDate);
            }
            set
            {
                Store(i => i.RefreshDate, value);
            }
        }

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