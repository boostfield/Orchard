using Contrib.Voting.Services;
using Newtonsoft.Json;
using NGM.ContentViewCounter.Models;
using Orchard.ContentManagement;
using Orchard.Data;
using Orchard.Security;
using Orchard.Services;
using Orchard.Taxonomies.Models;
using Orchard.Taxonomies.Services;
using Orchard.Users.Models;
using Orchard.Xmu;
using Orchard.Xmu.Models;
using Orchard.Xmu.Service.DataImport.Model;
using System;
using System.Collections.Generic;
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
        private readonly IClock _clock;

        private readonly int MAX = 300;

        public DataImporter(
            
            ITaxonomyService taxonomyService,
            IContentManager contentManager,
            ITransactionManager transactionManager,
            IMembershipService memberShipService,
            IVotingService votingService,
            IOrchardServices orchardService,
            IClock clock

            )
        {
            _taxonomyService = taxonomyService;
            _contentManager = contentManager;
            _transactionManager = transactionManager;
            _memberShipService = memberShipService;
            _votingService = votingService;
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



        public void BuildCategory()
        {
            var artistTaxo = _contentManager.New<TaxonomyPart>("Taxonomy");
            artistTaxo.Name = XmTaxonomyNames.CNInformation;
            _contentManager.Create(artistTaxo, VersionOptions.Published);
            //string[] categories = new string[] {"学院新闻", "院务通知","科研成果" };
            var categories = ReadDataFromJsonFile<OldCategory>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\栏目分类.txt")
                .Select(i => i.TopicName).ToList();
                        
            foreach (var c in categories)
            {
                CreateTerm(artistTaxo, c);
            }
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
           i => GenerateImportSingleOldContent<XmContentPart, OldContent>("UndergraduateAffairs","本科生教务")(i,null),
           r => r.ID,
           @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\本科生教务ID对照.txt"
           );
        }



        public void ImportGraduateAffairs()
        {
            ImportDataTemplate<OldContent>(
          () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务.txt"),
          i => GenerateImportSingleOldContent<XmContentPart, OldContent>("GraduateAffairs", "研究生教务")(i,null),
          r => r.ID,
          @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务ID对照.txt"
          );
        }

        public void ImportStudentInfo()
        {
            ImportDataTemplate<OldContent>(
         () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\学生资讯.txt"),
         i => GenerateImportSingleOldContent<XmContentPart, OldContent>("StudentInfo", "学生资讯")(i,null),
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

        /// <summary>
        /// 院务通知
        /// </summary>
        public void ImportCollegeAffairsNoti()
        {

            ImportDataTemplate<OldContent>(
            () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知.txt"),
            i => GenerateImportSingleOldContent<XmContentPart,OldContent>("CollegeAffairsNotify","院务通知")(i, null),
            r => r.ID,
            @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知ID对照.txt"
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