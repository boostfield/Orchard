using Contrib.Voting.Services;
using Newtonsoft.Json;
using NGM.ContentViewCounter.Models;
using Orchard.ContentManagement;
using Orchard.Core.Common.Models;
using Orchard.Data;
using Orchard.Security;
using Orchard.Services;
using Orchard.Tags.Services;
using Orchard.Taxonomies.Models;
using Orchard.Taxonomies.Services;
using Orchard.Users.Models;
using Orchard.Xmu;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service.DataImport.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport
{
    public class DataImporter : IDataImporter
    {
        private readonly ITaxonomyService _taxonomyService;
        private readonly IContentManager _contentManager;
        private readonly ITransactionManager _transactionManager;
        private readonly IMembershipService _memberShipService;
        private readonly IVotingService _votingService;
        private readonly IOrchardServices _orchardService;
        private readonly ITagService _tagService;
        private readonly IClock _clock;

        private readonly int MAX = 300;

        public DataImporter(
            
            ITaxonomyService taxonomyService,
            IContentManager contentManager,
            ITransactionManager transactionManager,
            IMembershipService memberShipService,
            IVotingService votingService,
            IOrchardServices orchardService,
            ITagService tagService,
            IClock clock

            )
        {
            _taxonomyService = taxonomyService;
            _contentManager = contentManager;
            _transactionManager = transactionManager;
            _memberShipService = memberShipService;
            _votingService = votingService;
            _tagService = tagService;
            _orchardService = orchardService;
            _clock = clock;
        }


        /// <summary>
        /// 学院新闻
        /// </summary>
        public void ImportCollegeNews()
        {
            ImportDataTemplate<OldNews>(
           () => ReadDataFromJsonFile<OldNews>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学院新闻.txt"),
           i => ImportSingleCollegeNews(i),
           r => r.ID,
           @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学院新闻ID对照.txt"
           );
        }

        private int ImportSingleCollegeNews(OldNews oldnews)
        {
            var info = _contentManager.New("CollegeNews");
            var infopart = info.As<XmContentPart>();


            infopart.Title = oldnews.Title;
            infopart.Text = oldnews.Content;
            infopart.PublishedUtc = oldnews.PubTime;
            infopart.Author = oldnews.Author;
            infopart.Editor = oldnews.Editor;

             
            //TODO: 其它的一些数据
            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine("学院新闻 newId:" + info.Id);
            DoVote(infopart.ContentItem, oldnews.Clicks);


            return info.Id;
        }

        private void DoVote(ContentItem contentItem, double count)
        {
            _votingService.Vote(contentItem, "admin", _orchardService.WorkContext.HttpContext.Request.UserHostAddress, count, Constants.Dimension);

        }


        public void BuildCNNotifyCategory()
        {
            var artistTaxo = _contentManager.New<TaxonomyPart>("Taxonomy");
            artistTaxo.Name = XmTaxonomyNames.CNNotify;
            _contentManager.Create(artistTaxo, VersionOptions.Published);

            CreateTerm(artistTaxo, "院务通知");
            CreateTerm(artistTaxo, "本科生教务");
            CreateTerm(artistTaxo, "研究生教务");
            CreateTerm(artistTaxo, "学生资讯");
        }

 
        private TermPart CreateTerm(TaxonomyPart taxonomy, string name, TermPart parent = null)
        {
            var term = this._taxonomyService.NewTerm(taxonomy);
            term.Container = parent == null ? taxonomy.ContentItem : parent.ContentItem;
            term.Name = name;
            term.Slug = parent == null ? string.Concat(taxonomy.Slug, "/", term.Name).ToLower().Replace(" ", "-") : string.Concat(taxonomy.Slug, "/", parent.Name, "/", term.Name).ToLower().Replace(" ", "-");

            this._taxonomyService.ProcessPath(term);
            _contentManager.Create(term, VersionOptions.Published);

            return term;
        }


        public void ImportUndergraduateAffairs()
        {
            ImportDataTemplate<OldContent>(
           () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\本科生教务.txt"),
           i => GenerateImportSingleOldContent<CNNotifyPart, OldContent>("CNNotify", "本科生教务")(i, (oldcontent, part) => {
               var taxo = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNNotify);
               var terms = _taxonomyService.GetTerms(taxo.Id);
               var term = terms.Where(j => j.Name.Equals("本科生教务")).FirstOrDefault();
               if (term != null)
               {
                   var tmp = new List<TermPart>();
                   tmp.Add(term);
                   _taxonomyService.UpdateTerms(part.ContentItem, tmp, "taxotype");
               }

           }),
           r => r.ID,
           @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\本科生教务ID对照.txt"
           );
        }

        /// <summary>
        /// 院务通知
        /// </summary>
        public void ImportCollegeAffairsNoti()
        {

            ImportDataTemplate<OldContent>(
            () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知.txt"),
            i => GenerateImportSingleOldContent<CNNotifyPart, OldContent>("CNNotify", "院务通知")(i, (oldcontent, part) => {
                var taxo = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNNotify);
                var terms = _taxonomyService.GetTerms(taxo.Id);
                var term = terms.Where(j => j.Name.Equals("院务通知")).FirstOrDefault();
                if (term != null)
                {
                    var tmp = new List<TermPart>();
                    tmp.Add(term);
                    _taxonomyService.UpdateTerms(part.ContentItem, tmp, "taxotype");
                }

            }),
            r => r.ID,
            @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知ID对照.txt"
            );
        }


        public void ImportGraduateAffairs()
        {
            ImportDataTemplate<OldContent>(
          () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务.txt"),
          i => GenerateImportSingleOldContent<CNNotifyPart, OldContent>("CNNotify", "研究生教务")(i, (oldcontent, part) => {
              var taxo = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNNotify);
              var terms = _taxonomyService.GetTerms(taxo.Id);
              var term = terms.Where(j => j.Name.Equals("研究生教务")).FirstOrDefault();
              if (term != null)
              {
                  var tmp = new List<TermPart>();
                  tmp.Add(term);
                  _taxonomyService.UpdateTerms(part.ContentItem, tmp, "taxotype");
              }

          }),
          r => r.ID,
          @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务ID对照.txt"
          );
        }

        public void ImportStudentInfo()
        {
            ImportDataTemplate<OldContent>(
         () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学生资讯.txt"),
         i => GenerateImportSingleOldContent<CNNotifyPart, OldContent>("CNNotify", "学生资讯")(i, (oldcontent, part) => {
             var taxo = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNNotify);
             var terms = _taxonomyService.GetTerms(taxo.Id);
             var term = terms.Where(j => j.Name.Equals("学生资讯")).FirstOrDefault();
             if (term != null)
             {
                 var tmp = new List<TermPart>();
                 tmp.Add(term);
                 _taxonomyService.UpdateTerms(part.ContentItem, tmp, "taxotype");
             }

         }),
         r => r.ID,
         @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学生资讯ID对照.txt"
         );
        }

        public void ImportPartyCollegeAffairs()
        {
            ImportDataTemplate<OldContent>(
        () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\党务教务公开.txt"),
        i => GenerateImportSingleOldContent<XmContentPart, OldContent>("PublicPartyCollegeAffairs", "党务教务公开")(i,null),
        r => r.ID,
        @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\党务教务公开ID对照.txt"
        );
        }

        public void ImportRecruitInfo()
        {
            ImportDataTemplate<OldContent>(
            () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\招录信息.txt"),
            i => GenerateImportSingleOldContent<XmContentPart, OldContent>("RecruitInfo", "招录信息")(i,null),
            r => r.ID,
            @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\招录信息ID对照.txt"
            );
        }


        public void ImportLectureInfo ()
        {
            ImportDataTemplate<OldLecture>(
           () => ReadDataFromJsonFile<OldLecture>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\讲座信息.txt"),
           i => GenerateImportSingleOldContent<LectureInfoPart, OldLecture>("LectureInfo", "讲座信息")(i, (oldcontent, part)=> {
               part.Lecturer = oldcontent.Lecturer;
               part.LectureAddress = oldcontent.Address;
               part.StartTime = oldcontent.StartTime;
           }),
           r => r.ID,
           @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\讲座信息ID对照.txt"
           );

        }

    


        public void ImportAcademicNews()
        {

            ImportDataTemplate<OldContent>(
            () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学术动态.txt"),
            i => GenerateImportSingleOldContent<XmContentPart, OldContent>("AcademicNews", "学术动态")(i, null),
            r => r.ID,
            @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学术动态ID对照.txt"
            );

        }


        public void ImportCope()
        {
            ImportDataTemplate<OldContent>(
                      () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\Contents.txt")
                      .Where(i=>i.Cate==78 || i.Cate == 79 || i.Cate == 80).ToList(),
                      i => ImportSingleCop(i),
                      r => r.ID,
                      @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\合作交流ID对照.txt"
                      );
        }

        private int ImportSingleCop(OldContent content)
        {
            var info = _contentManager.New(XmContentType.CNCop.ContentTypeName);
            var infopart = info.As<CNCopPart>();
            infopart.Title = content.Title;
            infopart.Text = content.Content;
            infopart.PublishedUtc = content.PubTime.Equals(DateTime.MinValue) ? _clock.UtcNow : content.PubTime;
            infopart.Author = content.Author;
            infopart.Editor = content.Editor;
            infopart.CreatedUtc = infopart.PublishedUtc;


            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNCop.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, content.Clicks);
            return info.Id;
        }


        public void ImportProjects()
        {
            ImportDataTemplate<OldProject>(
            () => ReadDataFromJsonFile<OldProject>(@"D:\法学院6个数据库\承担课题.json"),
                i => ImportSingleProject(i),
                r => r.id,
                @"D:\法学院6个数据库\承担课题ID对照.txt"
            );

        }

        private int ImportSingleProject(OldProject oldproject)
        {
            var info = _contentManager.New(XmContentType.CNProject.ContentTypeName);
            var infopart = info.As<ProjectPart>();
            //assign values
            infopart.ProjectTitle = oldproject.projecttitle;
            infopart.Host = oldproject.host;
            infopart.Year = oldproject.year;
            infopart.Department = oldproject.department;
            infopart.Source = oldproject.source;
            infopart.Level = oldproject.level;
            infopart.SerialNumber = oldproject.serialnumber;
            infopart.Aidfunds = oldproject.aidfunds;
            infopart.Members = oldproject.group;
            infopart.Aidhost = oldproject.aidhost;
            infopart.StartDate = oldproject.startdate;
            infopart.EndDate = oldproject.enddate;
            infopart.FinishDate = oldproject.finishdate;
            infopart.AidSituation = oldproject.aidsituation;
            infopart.Remarks = oldproject.remarks;
            infopart.Clicknumber = oldproject.clicknumber;
            infopart.ResultType = oldproject.resulttype;
            infopart.Member1 = oldproject.member1;
            infopart.Member2 = oldproject.member2;
            infopart.Member3 = oldproject.member3;
            infopart.Member4 = oldproject.member4;
            infopart.Member5 = oldproject.member5;
            infopart.Member6 = oldproject.member6;
            infopart.Member7 = oldproject.member7;
            infopart.Member8 = oldproject.member8;
            infopart.Member9 = oldproject.member9;
            infopart.Member10 = oldproject.member10;
            infopart.Funds1 = oldproject.textnumber1;
            infopart.Funds2 = oldproject.textnumber2;
            infopart.Funds3 = oldproject.textnumber3;
            infopart.Funds4 = oldproject.textnumber4;
            infopart.Funds5 = oldproject.textnumber5;
            infopart.Funds6 = oldproject.textnumber6;
            infopart.Funds7 = oldproject.textnumber7;
            infopart.Funds8 = oldproject.textnumber8;
            infopart.Funds9 = oldproject.textnumber9;
            infopart.Funds10 = oldproject.textnumber10;


            info.As<CommonPart>().CreatedUtc = DateTime.ParseExact(oldproject.inputdate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);


            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNProject.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, oldproject.clicknumber);
            return info.Id;
        }


        public void ImportAwards()
        {
            ImportDataTemplate<OldReward>(
         () => ReadDataFromJsonFile<OldReward>(@"D:\法学院6个数据库\获奖成果.json"),
         i => ImportSingleAward(i),
         r => r.id,
         @"D:\法学院6个数据库\获奖成果ID对照.txt"
         );
        }


        private int ImportSingleAward(OldReward oldreward)
        {
            var info = _contentManager.New(XmContentType.CNAward.ContentTypeName);
            var infopart = info.As<AwardsPart>();
            //assign values
            infopart.WinnerName = oldreward.winnername;
            infopart.AwardName = oldreward.resultname;
            infopart.Year = oldreward.year;
            infopart.BelongDepartment = oldreward.belongdepartment;
            infopart.AwardDepartment = oldreward.awarddepartment;
            infopart.AwardDate = oldreward.windate;
            infopart.AwardRank = oldreward.winlevel1;
            infopart.AwardLevel = oldreward.winlevel2;
            infopart.ResultProject = oldreward.resultproject;
            infopart.ResultForm = oldreward.resultform;
            infopart.Author = oldreward.author;
            infopart.Collaborator = oldreward.collaborator;
            infopart.Codes = oldreward.codes;
            infopart.Remarks = oldreward.remarks;
            infopart.Clicknumber = oldreward.clicknumber;
            infopart.ResultType = oldreward.resulttype;


            info.As<CommonPart>().CreatedUtc = DateTime.ParseExact(oldreward.inputdate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNAward.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, oldreward.clicknumber);
            return info.Id;
        }


        public void ImportAcademicWork()
        {
            ImportDataTemplate<OldWorks>(
                    () => ReadDataFromJsonFile<OldWorks>(@"D:\法学院6个数据库\著作.json"),
                    i => ImportSingleAcademicWork(i),
                    r => r.id,
                    @"D:\法学院6个数据库\著作ID对照.txt"
                    );
        }

        private int ImportSingleAcademicWork(OldWorks oldwork)
        {

            var info = _contentManager.New(XmContentType.CNAcademicWork.ContentTypeName);
            var infopart = info.As<AcademicWorksPart>();
            //assign values
            infopart.Title = oldwork.title;
            infopart.Author = oldwork.author;
            infopart.Year = oldwork.year;
            infopart.Department = oldwork.department;
            infopart.Publishunit = oldwork.publishunit;
            infopart.Booknumber = oldwork.booknumber;
            infopart.Publishdate = oldwork.publishdate;
            infopart.Booktype = oldwork.booktype;
            infopart.WriterType = oldwork.writetype;
            infopart.AllTextBumber = oldwork.alltextnumber;
            infopart.FinishNumber = oldwork.finishnumber;
            infopart.Author1 = oldwork.author1;
            infopart.Author2 = oldwork.author2;
            infopart.Author3 = oldwork.author3;
            infopart.Author4 = oldwork.author4;
            infopart.Author5 = oldwork.author5;
            infopart.Author6 = oldwork.author6;
            infopart.Author7 = oldwork.author7;
            infopart.Author8 = oldwork.author8;
            infopart.Author9 = oldwork.author9;
            infopart.Author10 = oldwork.author10;
            infopart.TextNumber1 = oldwork.textnumber1;
            infopart.TextNumber2 = oldwork.textnumber2;
            infopart.TextNumber3 = oldwork.textnumber3;
            infopart.TextNumber4 = oldwork.textnumber4;
            infopart.TextNumber5 = oldwork.textnumber5;
            infopart.TextNumber6 = oldwork.textnumber6;
            infopart.TextNumber7 = oldwork.textnumber7;
            infopart.TextNumber8 = oldwork.textnumber8;
            infopart.TextNumber9 = oldwork.textnumber9;
            infopart.TextNumber10 = oldwork.textnumber10;
            infopart.IsResult = oldwork.isresult;
            infopart.SourceName = oldwork.sourcename;
            infopart.ProjectName = oldwork.projectname;
            infopart.Introduce = oldwork.introduce;
            infopart.Remarks = oldwork.remarks;
            infopart.Keyword = oldwork.keyword;
            infopart.Summary = oldwork.summary;
            infopart.Text = oldwork.text;
            infopart.ClickNumber = oldwork.clicknumber;
            infopart.ResultType = oldwork.resulttype;
            infopart.Picture = oldwork.picture;

            info.As<CommonPart>().CreatedUtc = DateTime.ParseExact(oldwork.inputdate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);


            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNAcademicWork.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, oldwork.clicknumber);
            return info.Id;
        }


        public void ImportAcademicPaper()
        {
            ImportDataTemplate<OldPaper>(
                     () => ReadDataFromJsonFile<OldPaper>(@"D:\法学院6个数据库\论文.json"),
                     i => ImportSingleAcademicPaper(i),
                     r => r.id,
                     @"D:\法学院6个数据库\论文ID对照.txt"
                     );

        }


        private int ImportSingleAcademicPaper(OldPaper oldpaper)
        {
            var info = _contentManager.New(XmContentType.CNAcademicPaper.ContentTypeName);
            var infopart = info.As<AcademicPaperPart>();
            //assign values
            infopart.Title = oldpaper.title;
            infopart.Author = oldpaper.author;
            infopart.Year = oldpaper.year;
            infopart.Department = oldpaper.department;
            infopart.Keyword = oldpaper.keyword;
            infopart.Summary = oldpaper.summary;
            infopart.Text = oldpaper.text;
            infopart.ReleaseDate = oldpaper.releasedate;
            infopart.Publication = oldpaper.publication;
            infopart.Pid = oldpaper.pid;
            infopart.Ptime = oldpaper.ptime;
            infopart.Plevel = oldpaper.plevel;
            infopart.Writertype = oldpaper.writetype;
            infopart.TextNumber = oldpaper.textnumber;
            infopart.Remarks = oldpaper.remarks;
            infopart.ClickNumber = oldpaper.clicknumber;
            infopart.IsShow = oldpaper.isshow;
            infopart.Achievement = oldpaper.achievement;
            infopart.ImportantJournal = oldpaper.imptjournal;
            infopart.RePrint = oldpaper.reprint;
            infopart.ResearchResult = oldpaper.researchresult;

            info.As<CommonPart>().CreatedUtc = DateTime.ParseExact(oldpaper.inputdate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNAcademicPaper.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, oldpaper.clicknumber);
            return info.Id;
        }


        public void ImportTeacherInfo()
        {
            ImportDataTemplate<OldTeacherInfo>(
                     () => ReadDataFromJsonFile<OldTeacherInfo>(@"D:\法学院6个数据库\教师信息.json"),
                     i => ImportSingleTeacher(i),
                     r => r.id,
                     @"D:\法学院6个数据库\教师信息ID对照.txt"
                     );
        }

        private int ImportSingleTeacher(OldTeacherInfo oldinfo)
        {
            var info = _contentManager.New(XmContentType.CNTeacher.ContentTypeName);
            var infopart = info.As<CNTeacherPart>();

            //assign values
            infopart.Number = oldinfo.number;
            infopart.Name = oldinfo.name;
            infopart.Rank = oldinfo.rank;
            infopart.Education = oldinfo.education;
            infopart.Job = oldinfo.job;
            infopart.Resfield = oldinfo.resfield;
            infopart.Tecoffice = oldinfo.tecoffice;
            infopart.Office = oldinfo.office;
            infopart.Telephone = oldinfo.telephone;
            infopart.Introduce = oldinfo.introduce;
            infopart.Department = oldinfo.department;
            infopart.Year = oldinfo.year;
            infopart.Month = oldinfo.month;
            infopart.Birthday = oldinfo.birthday;
            infopart.Avatar = oldinfo.avatar;
            infopart.Perspective = oldinfo.view;
            infopart.Concept = oldinfo.concept;
            infopart.Publication = oldinfo.publication;
            infopart.Dissertation = oldinfo.dissertation;
            infopart.Course = oldinfo.course;
            infopart.Ptjob = oldinfo.ptjop;
            infopart.Project = oldinfo.project;
            infopart.Contact = oldinfo.contact;
            infopart.IsShow = oldinfo.isshow;

            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CNTeacher.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, 0);


            return info.Id;
        }

        /// <summary>
        /// 导入原本为Contents的数据
        /// </summary>
        public void ImportXmContent()
        {
            ImportDataTemplate<OldContent>(
                       () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\Contents.txt"),
                       i => ImportSingleContent(i),
                       r => r.ID,
                       @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\ContentsID对照.txt"
                       );
        }

        private int ImportSingleContent(OldContent content)
        {
            var mapping = GetMapping(content.Cate);
            if(mapping==null)
            {
                return -1;
            }

            var info = _contentManager.New(mapping.ContentTypeName);
            var infopart = info.As<XmContentPart>();
            infopart.Title = content.Title;
            infopart.Text = content.Content;
            infopart.PublishedUtc = content.PubTime.Equals(DateTime.MinValue) ? _clock.UtcNow : content.PubTime;
            infopart.Author = content.Author;
            infopart.Editor = content.Editor;
            infopart.CreatedUtc = infopart.PublishedUtc;


            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", mapping.ContentTypeDisplayName, info.Id));
            DoVote(infopart.ContentItem, content.Clicks);
            return info.Id;

        }

        private XmCNCMSContentMapping GetMapping(int Id)
        {
            foreach(var mapping in XmContentType.CNCMSMappings)
            {
                if(mapping.Id == Id)
                {
                    return mapping;
                }
            }
            return null;
            
        }



        /// <summary>
        ///导入单一的InformationDBS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contentDefinition"></param>
        /// <returns></returns>
        private Func<U, Action<U,T>,int> GenerateImportSingleOldContent<T,U>(string contentTypeName, string displayName) where T: XmContentPart where U:OldContent

        {
            return (oldContent, assignAction) =>
            {

                var info = _contentManager.New(contentTypeName);
                var infopart = info.As<T>();
                infopart.Title = oldContent.Title;
                infopart.Text = oldContent.Content;
                infopart.PublishedUtc = oldContent.PubTime.Equals(DateTime.MinValue) ? _clock.UtcNow : oldContent.PubTime;
                infopart.Author = oldContent.Author;
                infopart.Editor = oldContent.Editor;
                infopart.CreatedUtc = infopart.PublishedUtc;



                _contentManager.Create(info, VersionOptions.Published);
                System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", displayName, info.Id));
                DoVote(infopart.ContentItem, oldContent.Clicks);
                if (assignAction != null)
                {
                    assignAction.Invoke(oldContent, infopart);
                }
                
                return info.Id;
            };
        }

      
        

        public void ImportNews()
        {
           
        }

       




        private void ImportDataTemplate<T>(Func<List<T>> dataReader,
            Func<T, int> SingerItemImporter,
            Func<T, int> GetOldIDFromItem,

            string filepath)
        {
            IList<NewOldID> ids = new List<NewOldID>();
            List<T> items = dataReader();

            int i = 0;

            foreach (var item in items)
            {
                var newId = SingerItemImporter(item);
                if(newId == -1)
                {
                    continue;
                }
                ids.Add(new NewOldID
                {
                    OldId = GetOldIDFromItem(item),
                    NewId = newId
                });
                if (++i >= MAX)
                {
                    _transactionManager.RequireNew();
                    _contentManager.Clear();
                    i = 0;
                }

            }
            //写入数据据，获取新连接，再关闭.
            _transactionManager.RequireNew();
            _transactionManager.Cancel();
            WriteDataAsJsonFile(filepath, ids);
        }


        private UserPart _user = null;
        private UserPart getUserWithName(string name = "admin")
        {
            if (_user != null)
            {
                return _user;
            }

            _user = _memberShipService.GetUser(name).As<UserPart>();
            return _user;
        }


        private static List<T> ReadDataFromJsonFile<T>(string dataPath)
        {
            string jsonStr = File.ReadAllText(dataPath);
            return JsonConvert.DeserializeObject<List<T>>
                (jsonStr);
        }

        private void WriteDataAsJsonFile(string filepath, IList<NewOldID> ids)
        {
            File.WriteAllText(filepath, JsonConvert.SerializeObject(ids));
        }

        
    }
}