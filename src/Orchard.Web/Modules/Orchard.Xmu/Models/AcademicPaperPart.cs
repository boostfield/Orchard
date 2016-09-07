using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class AcademicPaperPart:ContentPart<AcademicPaperRecord>
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

        public DateTime ReleaseDate
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
    }
}