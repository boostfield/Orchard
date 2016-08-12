using Contrib.Voting.Services;
using Newtonsoft.Json;
using NGM.ContentViewCounter.Models;
using Orchard.ContentManagement;
using Orchard.Data;
using Orchard.Security;
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

        private readonly int MAX = 300;

        public DataImporter(
            
            ITaxonomyService taxonomyService,
            IContentManager contentManager,
            ITransactionManager transactionManager,
            IMembershipService memberShipService,
            IVotingService votingService,
            IOrchardServices orchardService

            )
        {
            _taxonomyService = taxonomyService;
            _contentManager = contentManager;
            _transactionManager = transactionManager;
            _memberShipService = memberShipService;
            _votingService = votingService;
            _orchardService = orchardService;
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
            var info = _contentManager.New(XmContentType.CollegeNews.ContentTypeName);
            var infopart = info.As<CollegeNewsPart>();


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
           i => GenerateImportSingleOldContent<UndergraduateAffairsPart>(XmContentType.UndergraduateAffairs)(i),
           r => r.ID,
           @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\本科生教务ID对照.txt"
           );
        }


        public void ImportGraduateAffairs()
        {
            ImportDataTemplate<OldContent>(
          () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务.txt"),
          i => GenerateImportSingleOldContent<GraduateAffairsPart>(XmContentType.GraduateAffairs)(i),
          r => r.ID,
          @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\研究生教务ID对照.txt"
          );
        }



        /// <summary>
        /// 院务通知
        /// </summary>
        public void ImportCollegeAffairsNoti()
        {
            ImportDataTemplate<OldContent>(
            () => ReadDataFromJsonFile<OldContent>(@"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知.txt"),
            i => GenerateImportSingleOldContent<CollegeAffairsNotifyPart>(XmContentType.CollegeAffairsNotify)(i),
            r => r.ID,
            @"C:\Users\qingpengchen\Documents\GitHub\HiFiDBDataTool\HifiData\院务通知ID对照.txt"
            );
        }

        /// <summary>
        ///导入单一的InformationDBS
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contentDefinition"></param>
        /// <returns></returns>
        private Func<OldContent,int> GenerateImportSingleOldContent<T>(XmContentDefinition contentDefinition) where T: BaseContentPart

        {
            return (oldContent) =>
            {

                var info = _contentManager.New(contentDefinition.ContentTypeName);
                var infopart = info.As<T>();
                infopart.Title = oldContent.Title;
                infopart.Text = oldContent.Content;
                infopart.PublishedUtc = oldContent.PubTime;
                infopart.Author = oldContent.Author;
                infopart.Editor = oldContent.Editor;


                _contentManager.Create(info, VersionOptions.Published);
                System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", contentDefinition.ContentTypeDisplayName, info.Id));
                DoVote(infopart.ContentItem, oldContent.Clicks);
                return info.Id;
            };
        }

        private int ImportSingleCollegeAffairsNotify(OldContent oldPartyNews)
        {
             
            var info = _contentManager.New(XmContentType.CollegeAffairsNotify.ContentTypeName);
            var infopart = info.As<CollegeAffairsNotifyPart>();
            infopart.Title = oldPartyNews.Title;
            infopart.Text = oldPartyNews.Content;
            infopart.PublishedUtc = oldPartyNews.PubTime;
            infopart.Author = oldPartyNews.Author;
            infopart.Editor = oldPartyNews.Editor;


            _contentManager.Create(info, VersionOptions.Published);
            System.Diagnostics.Debug.WriteLine(string.Format(" {0} newId: {1}", XmContentType.CollegeAffairsNotify.ContentTypeDisplayName, info.Id ));
            DoVote(infopart.ContentItem, oldPartyNews.Clicks);
            return info.Id;

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
                ids.Add(new NewOldID
                {
                    OldId = GetOldIDFromItem(item),
                    NewId = SingerItemImporter(item)
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