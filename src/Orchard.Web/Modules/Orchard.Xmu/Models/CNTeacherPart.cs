using Orchard.ContentManagement;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNTeacherPart: ContentPart<CNTeacherPartRecord>
    {
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
    }
}