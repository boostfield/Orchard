using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ProjectPart:ContentPart<ProjectRecord>
    {
        public string ImageAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.ProjectPart.image.FirstMediaUrl;
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
        [DisplayName("课题名称")]
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
        [DisplayName("主持人")]
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
        [DisplayName("课题来源")]

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
        [DisplayName("课题级别")]

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
        [DisplayName("课题编号")]

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
        [DisplayName("资助经费")]

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
        [DisplayName("课题组成员")]

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
        [DisplayName("主持人经费")]

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
        [DisplayName("课题期限起期")]

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
        [DisplayName("课题期限止期")]

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
        [DisplayName("结题日期")]

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
        [DisplayName("经费聘用情况")]


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
        [DisplayName("成员1")]

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
        [DisplayName("成员1经费")]

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
        [DisplayName("成员2")]

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
        [DisplayName("成员2经费")]

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
        [DisplayName("成员3")]

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
        [DisplayName("成员3经费")]

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
        [DisplayName("成员4")]

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
        [DisplayName("成员4经费")]

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
        [DisplayName("成员5")]

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
        [DisplayName("成员5经费")]

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
        [DisplayName("成员6")]

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
        [DisplayName("成员6经费")]

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
        [DisplayName("成员7")]

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
        [DisplayName("成员7经费")]

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
        [DisplayName("成员8")]

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
        [DisplayName("成员8经费")]

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
        [DisplayName("成员9")]

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
        [DisplayName("成员9经费")]

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
        [DisplayName("成员10")]

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
        [DisplayName("成员10经费")]

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

        private readonly LazyField<IList<CNTeacherPart>> _teachers = new LazyField<IList<CNTeacherPart>>();
        public LazyField<IList<CNTeacherPart>> TeachersField { get { return _teachers; } }
        public IList<CNTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<CNTeacherPart>(); }
            set { _teachers.Value = value; }
        }
    }
}