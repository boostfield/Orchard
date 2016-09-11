using Orchard.ContentManagement;
using Orchard.ContentManagement.Utilities;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNTeacherPart: ContentPart<CNTeacherPartRecord>
    {
        [DisplayName("编号")]
        public string Number
        {
            get
            {
                return Retrieve(i => i.Number);
            }

            set
            {
                Store(i => i.Number, value);
            }
        }

        [DisplayName("姓名")]
        public string Name
        {
            get
            {
                return Retrieve(i => i.Name);
            }

            set
            {
                Store(i => i.Name, value);
            }
        }

        [DisplayName("职称")]
        public string Rank
        {
            get
            {
                return Retrieve(i => i.Rank);
            }

            set
            {
                Store(i => i.Rank, value);
            }
        }

        [DisplayName("学历")]
        public string Education
        {
            get
            {
                return Retrieve(i => i.Education);
            }

            set
            {
                Store(i => i.Education, value);
            }
        }

        [DisplayName("职务")]
        public string Job
        {
            get
            {
                return Retrieve(i => i.Job);
            }

            set
            {
                Store(i => i.Job, value);
            }
        }

        [DisplayName("研究方向")]
        public string Resfield
        {
            get
            {
                return Retrieve(i => i.Resfield);
            }

            set
            {
                Store(i => i.Resfield, value);
            }
        }

        [DisplayName("所属科室")]
        public string Tecoffice
        {
            get
            {
                return Retrieve(i => i.Tecoffice);
            }

            set
            {
                Store(i => i.Tecoffice, value);
            }
        }

        [DisplayName("办公室")]
        public string Office
        {
            get
            {
                return Retrieve(i => i.Office);
            }

            set
            {
                Store(i => i.Office, value);
            }
        }

        [DisplayName("办公电话")]
        public string Telephone
        {
            get
            {
                return Retrieve(i => i.Telephone);
            }

            set
            {
                Store(i => i.Telephone, value);
            }
        }

        [DisplayName("简介")]
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


        [DisplayName("出生年")]
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

        [DisplayName("出生月")]
        public string Month
        {
            get
            {
                return Retrieve(i => i.Month);
            }

            set
            {
                Store(i => i.Month, value);
            }
        }



        [DisplayName("出生日")]
        public string Day
        {
            get
            {
                return Retrieve(i => i.Day);
            }

            set
            {
                Store(i => i.Day, value);
            }
        }

        [DisplayName("出生日期")]
        public DateTime? Birthday
        {
            get
            {
                return Retrieve(i => i.Birthday);
            }

            set
            {
                Store(i => i.Birthday, value);
            }
        }

        [DisplayName("照片路径")]
        public string Avatar
        {
            get
            {
                return Retrieve(i => i.Avatar);
            }

            set
            {
                Store(i => i.Avatar, value);
            }
        }


        [DisplayName("学术观点")]
        public string Perspective
        {
            get
            {
                return Retrieve(i => i.Perspective);
            }

            set
            {
                Store(i => i.Perspective, value);
            }
        }

        [DisplayName("研究理念")]
        public string Concept
        {
            get
            {
                return Retrieve(i => i.Concept);
            }

            set
            {
                Store(i => i.Concept, value);
            }
        }

        [DisplayName("主要著作")]
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
        [DisplayName("论文")]
        public string Dissertation
        {
            get
            {
                return Retrieve(i => i.Dissertation);
            }

            set
            {
                Store(i => i.Dissertation, value);
            }
        }

        [DisplayName("所受课程")]
        public string Course
        {
            get
            {
                return Retrieve(i => i.Course);
            }

            set
            {
                Store(i => i.Course, value);
            }
        }

        [DisplayName("社会兼职")]
        public string Ptjob
        {
            get
            {
                return Retrieve(i => i.Ptjob);
            }

            set
            {
                Store(i => i.Ptjob, value);
            }
        }

        [DisplayName("承担项目")]
        public string Project
        {
            get
            {
                return Retrieve(i => i.Project);
            }

            set
            {
                Store(i => i.Project, value);
            }
        }

        [DisplayName("联系方式")]
        public string Contact
        {
            get
            {
                return Retrieve(i => i.Contact);
            }

            set
            {
                Store(i => i.Contact, value);
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

        private readonly LazyField<IList<AcademicPaperPart>> _papers = new LazyField<IList<AcademicPaperPart>>();
        public LazyField<IList<AcademicPaperPart>> PapersField { get { return _papers; } }
        public IList<AcademicPaperPart> Papers
        {
            get { return _papers.Value ?? new List<AcademicPaperPart>(); }
            set { _papers.Value = value; }
        }


        private readonly LazyField<IList<AcademicWorksPart>> _works = new LazyField<IList<AcademicWorksPart>>();
        public LazyField<IList<AcademicWorksPart>> WorksField { get { return _works; } }
        public IList<AcademicWorksPart> Works
        {
            get { return _works.Value ?? new List<AcademicWorksPart>(); }
            set { _works.Value = value; }
        }



        private readonly LazyField<IList<AwardsPart>> _awards = new LazyField<IList<AwardsPart>>();
        public LazyField<IList<AwardsPart>> AwardsField { get { return _awards; } }
        public IList<AwardsPart> Awards
        {
            get { return _awards.Value ?? new List<AwardsPart>(); }
            set { _awards.Value = value; }
        }


        private readonly LazyField<IList<ProjectPart>> _projects = new LazyField<IList<ProjectPart>>();
        public LazyField<IList<ProjectPart>> ProjectsField { get { return _projects; } }
        public IList<ProjectPart> Projects
        {
            get { return _projects.Value ?? new List<ProjectPart>(); }
            set { _projects.Value = value; }
        }

        public IList<string> ProjectIds
        {
            get; set;
        }
        public IList<string> AwardIds
        {
            get; set;
        }
        public IList<string> WorkIds
        {
            get; set;
        }
        public IList<string> PaperIds
        {
            get; set;
        }
    }
}