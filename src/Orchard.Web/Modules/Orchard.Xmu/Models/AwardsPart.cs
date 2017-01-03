using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class AwardsPart:ContentPart<AwardsRecord>
    {
        public string ImageAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.AwardsPart.image.FirstMediaUrl;
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

        [DisplayName("获奖者姓名")]
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

        [DisplayName("获奖成果名称")]
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

        [DisplayName("颁奖部门")]
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

        [DisplayName("获奖时间")]
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

        [DisplayName("获奖等级")]
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

        [DisplayName("获奖级别")]
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

        [DisplayName("成果项目")]
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

        [DisplayName("成果形式")]
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

        [DisplayName("第几作者")]
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

        [DisplayName("合作者")]
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

        [DisplayName("代码")]
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

        private readonly LazyField<IList<CNTeacherPart>> _teachers = new LazyField<IList<CNTeacherPart>>();
        public LazyField<IList<CNTeacherPart>> TeachersField { get { return _teachers; } }
        public IList<CNTeacherPart> Teachers
        {
            get { return _teachers.Value ?? new List<CNTeacherPart>(); }
            set { _teachers.Value = value; }
        }
    }
}