using Orchard.ContentManagement;
using Orchard.Data;
using Orchard.Themes;
using Orchard.Users.Models;
using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Orchard.Xmu.Controllers
{

    [Authorize]
    [Themed]
    public class PersonalCenterController : Controller
    {
        private readonly IOrchardServices _orchardServices;
        private readonly IRepository<CNTeacherPartRecord> _teacherRepo;

        public PersonalCenterController(IOrchardServices orchardServices, IRepository<CNTeacherPartRecord> repo)
        {
            _orchardServices = orchardServices;
            _teacherRepo = repo;
        }
        // GET: PersonalCenter
        public ActionResult Index()
        {
            var user = _orchardServices.WorkContext.CurrentUser as UserPart;
            var teacher = _teacherRepo.Fetch(i => i.UserPartRecord == user.Record).FirstOrDefault();
            if (teacher == null)
            {
                return Redirect("\\");
            }

            var teacherPart = _orchardServices.ContentManager.Get<CNTeacherPart>(teacher.ContentItemRecord.Id, VersionOptions.Latest);
            var vm = TeacherVM.FromTeacherPart(teacherPart);

            return View(vm);
        }
    }


    public class ListTeachers
    {
        public IEnumerable<BasicTeacherVM> Professors { get; set; }
        public IEnumerable<BasicTeacherVM> Vice_Processors { get; set; }
        public IEnumerable<BasicTeacherVM> Introductors { get; set; }

    }

    public class BasicTeacherVM {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Avatar { get; set; }
        public string Rank { get; set; }
        public static BasicTeacherVM FromTeacherPart(CNTeacherPart part)
        {
            return new BasicTeacherVM
            {
                Id = part.Id,
                Name = part.Name,
                Number = part.Number,
                Avatar = part.Avatar,
                Rank = part.Rank
            };
        }


    }


    public class TeacherVM
    {
        public int Id { get; set; }
        public string Number { get; set; }//编号
        public string Name { get; set; }//姓名
        public string Rank { get; set; }//职称
        public string Education { get; set; }//学历
        public string Job { get; set; }//职务
        public string Resfield { get; set; }//研究方向

        public string Tecoffice { get; set; }//所属科室

        public string Office { get; set; }//办公室
        public string Telephone { get; set; }   //办公电话
        public string Introduce { get; set; }//简介

        public string Department { get; set; }  //系别

        public string Year { get; set; }//出生年

        public string Month { get; set; }//出生月

        public string Day { get; set; }//出生日

        public string Avatar { get; set; }//照片路径


        public string Perspective { get; set; }//学术观点

        public string Concept { get; set; }//研究理念

        public string Ptjob { get; set; }//社会兼职

        public string Contact { get; set; } //联系方式

        public IList<PaperVM> Papers { get; set; }  

        public IList<AwardVM> Awards { get; set; }  
        public IList<AcademicWorkVM> Workds { get; set; }  

        public IList<ProjectVM> Projects { get; set; }  

        public IList<CourseVM> Courses { get; set; }  

        public static TeacherVM FromTeacherPart(CNTeacherPart part)
        {
            return new TeacherVM
            {
                Id = part.Id,
                Number = part.Number,
                Name = part.Name,
                Rank = part.Rank,
                Education = part.Education,
                Job = part.Job,
                Resfield = part.Resfield,
                Tecoffice = part.Tecoffice,
                Introduce = part.Introduce,
                Department = part.Department,
                Year = part.Year,
                Month = part.Month,
                Day = part.Day,
                Avatar = part.Avatar,
                Perspective = part.Perspective,
                Concept = part.Concept,
                Ptjob = part.Ptjob,
                Contact = part.Contact,
                Office = part.Office,
                Telephone = part.Telephone,
                Papers = part.Papers.Select(i => PaperVM.FromPaperPart(i)).ToList(),
                Awards = part.Awards.Select(i=>AwardVM.FromAwardPart(i)).ToList(),
                Workds = part.Works.Select(i=>AcademicWorkVM.FromWorkPart(i)).ToList(),
                Projects = part.Projects.Select(i=>ProjectVM.FromProjectPart(i)).ToList(),
                Courses =  part.Courses.Select(i=>CourseVM.FromCoursePart(i)).ToList()

            };
        }

    }

    public class PaperVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public static PaperVM FromPaperPart(AcademicPaperPart part)
        {

            return new PaperVM
            {
                Id = part.Id,
                Title = part.Title
            };
        }
    }

    public class AwardVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public static AwardVM FromAwardPart(AwardsPart part)
        {
            return new AwardVM
            {
                Id = part.Id,
                Title = part.AwardName
            };
        }
    }

    public class AcademicWorkVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public static AcademicWorkVM FromWorkPart(AcademicWorksPart part)
        {
            return new AcademicWorkVM
            {
                Id = part.Id,
                Title = part.Title
            };
        }
    }

    public class ProjectVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public static ProjectVM FromProjectPart(ProjectPart part)
        {
            return new ProjectVM
            {
                Id = part.Id,
                Title = part.ProjectTitle
            };
        }
    }


    public class CourseVM
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public static CourseVM FromCoursePart (CourseDBRecordPart part)
        {
            return new CourseVM
            {
                Id = part.Id,
                Title = part.Name
            };
        }
    }
}