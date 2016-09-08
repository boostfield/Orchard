using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class AwardsPart:ContentPart<AwardsRecord>
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

        public string WinnerName
        {
            get
            {
                return Retrieve(i => i.WinnerName);
            }
            set
            {
                Store(i => i.WinnerName, value);
            }
        }

        public string AwardName
        {
            get
            {
                return Retrieve(i => i.AwardName);
            }
            set
            {
                Store(i => i.AwardName, value);
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

        public string BelongDepartment
        {
            get
            {
                return Retrieve(i => i.BelongDepartment);
            }
            set
            {
                Store(i => i.BelongDepartment, value);
            }
        }

        public string AwardDepartment
        {
            get
            {
                return Retrieve(i => i.AwardDepartment);
            }
            set
            {
                Store(i => i.AwardDepartment, value);
            }
        }

        public string AwardDate
        {
            get
            {
                return Retrieve(i => i.AwardDate);
            }
            set
            {
                Store(i => i.AwardDate, value);
            }
        }

        public string AwardRank
        {
            get
            {
                return Retrieve(i => i.AwardRank);
            }
            set
            {
                Store(i => i.AwardRank, value);
            }
        }

        public string AwardLevel
        {
            get
            {
                return Retrieve(i => i.AwardLevel);
            }
            set
            {
                Store(i => i.AwardLevel, value);
            }
        }

        public string ResultProject
        {
            get
            {
                return Retrieve(i => i.ResultProject);
            }
            set
            {
                Store(i => i.ResultProject, value);
            }
        }

        public string ResultForm
        {
            get
            {
                return Retrieve(i => i.ResultForm);
            }
            set
            {
                Store(i => i.ResultForm, value);
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

        public string Collaborator
        {
            get
            {
                return Retrieve(i => i.Collaborator);
            }
            set
            {
                Store(i => i.Collaborator, value);
            }
        }

        public string Codes
        {
            get
            {
                return Retrieve(i => i.Codes);
            }
            set
            {
                Store(i => i.Codes, value);
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

        public string InputDate
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

        public int Clicknumber
        {
            get
            {
                return Retrieve(i => i.Clicknumber);
            }
            set
            {
                Store(i => i.Clicknumber, value);
            }
        }

        public string RefreshDate
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
    }
}