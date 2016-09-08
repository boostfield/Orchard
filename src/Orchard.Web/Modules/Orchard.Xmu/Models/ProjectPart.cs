using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ProjectPart:ContentPart<ProjectRecord>
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

        public string ProjectTitle
        {
            get
            {
                return Retrieve(i => i.ProjectTitle);
            }
            set
            {
                Store(i => i.ProjectTitle, value);
            }
        }

        public string Host
        {
            get
            {
                return Retrieve(i => i.Host);
            }
            set
            {
                Store(i => i.Host, value);
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

        public string Source
        {
            get
            {
                return Retrieve(i => i.Source);
            }
            set
            {
                Store(i => i.Source, value);
            }
        }

        public string Level
        {
            get
            {
                return Retrieve(i => i.Level);
            }
            set
            {
                Store(i => i.Level, value);
            }
        }

        public string SerialNumber
        {
            get
            {
                return Retrieve(i => i.SerialNumber);
            }
            set
            {
                Store(i => i.SerialNumber, value);
            }
        }

        public string Aidfunds
        {
            get
            {
                return Retrieve(i => i.Aidfunds);
            }
            set
            {
                Store(i => i.Aidfunds, value);
            }
        }

        public string Members
        {
            get
            {
                return Retrieve(i => i.Members);
            }
            set
            {
                Store(i => i.Members, value);
            }
        }

        public string Aidhost
        {
            get
            {
                return Retrieve(i => i.Aidhost);
            }
            set
            {
                Store(i => i.Aidhost, value);
            }
        }

        public string StartDate
        {
            get
            {
                return Retrieve(i => i.StartDate);
            }
            set
            {
                Store(i => i.StartDate, value);
            }
        }

        public string EndDate
        {
            get
            {
                return Retrieve(i => i.EndDate);
            }
            set
            {
                Store(i => i.EndDate, value);
            }
        }

        public string FinishDate
        {
            get
            {
                return Retrieve(i => i.FinishDate);
            }
            set
            {
                Store(i => i.FinishDate, value);
            }
        }

        public string AidSituation
        {
            get
            {
                return Retrieve(i => i.AidSituation);
            }
            set
            {
                Store(i => i.AidSituation, value);
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

        public string Inputdate
        {
            get
            {
                return Retrieve(i => i.Inputdate);
            }
            set
            {
                Store(i => i.Inputdate, value);
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

        public string Member1
        {
            get
            {
                return Retrieve(i => i.Member1);
            }
            set
            {
                Store(i => i.Member1, value);
            }
        }

        public string Funds1
        {
            get
            {
                return Retrieve(i => i.Funds1);
            }
            set
            {
                Store(i => i.Funds1, value);
            }
        }

        public string Member2
        {
            get
            {
                return Retrieve(i => i.Member2);
            }
            set
            {
                Store(i => i.Member2, value);
            }
        }

        public string Funds2
        {
            get
            {
                return Retrieve(i => i.Funds2);
            }
            set
            {
                Store(i => i.Funds2, value);
            }
        }

        public string Member3
        {
            get
            {
                return Retrieve(i => i.Member3);
            }
            set
            {
                Store(i => i.Member3, value);
            }
        }

        public string Funds3
        {
            get
            {
                return Retrieve(i => i.Funds3);
            }
            set
            {
                Store(i => i.Funds3, value);
            }
        }

        public string Member4
        {
            get
            {
                return Retrieve(i => i.Member4);
            }
            set
            {
                Store(i => i.Member4, value);
            }
        }

        public string Funds4
        {
            get
            {
                return Retrieve(i => i.Funds4);
            }
            set
            {
                Store(i => i.Funds4, value);
            }
        }

        public string Member5
        {
            get
            {
                return Retrieve(i => i.Member5);
            }
            set
            {
                Store(i => i.Member5, value);
            }
        }

        public string Funds5
        {
            get
            {
                return Retrieve(i => i.Funds5);
            }
            set
            {
                Store(i => i.Funds5, value);
            }
        }

        public string Member6
        {
            get
            {
                return Retrieve(i => i.Member6);
            }
            set
            {
                Store(i => i.Member6, value);
            }
        }

        public string Funds6
        {
            get
            {
                return Retrieve(i => i.Funds6);
            }
            set
            {
                Store(i => i.Funds6, value);
            }
        }

        public string Member7
        {
            get
            {
                return Retrieve(i => i.Member7);
            }
            set
            {
                Store(i => i.Member7, value);
            }
        }

        public string Funds7
        {
            get
            {
                return Retrieve(i => i.Funds7);
            }
            set
            {
                Store(i => i.Funds7, value);
            }
        }

        public string Member8
        {
            get
            {
                return Retrieve(i => i.Member8);
            }
            set
            {
                Store(i => i.Member8, value);
            }
        }

        public string Funds8
        {
            get
            {
                return Retrieve(i => i.Funds8);
            }
            set
            {
                Store(i => i.Funds8, value);
            }
        }

        public string Member9
        {
            get
            {
                return Retrieve(i => i.Member9);
            }
            set
            {
                Store(i => i.Member9, value);
            }
        }

        public string Funds9
        {
            get
            {
                return Retrieve(i => i.Funds9);
            }
            set
            {
                Store(i => i.Funds9, value);
            }
        }

        public string Member10
        {
            get
            {
                return Retrieve(i => i.Member10);
            }
            set
            {
                Store(i => i.Member10, value);
            }
        }

        public string Funds10
        {
            get
            {
                return Retrieve(i => i.Funds10);
            }
            set
            {
                Store(i => i.Funds10, value);
            }
        }
    }
}