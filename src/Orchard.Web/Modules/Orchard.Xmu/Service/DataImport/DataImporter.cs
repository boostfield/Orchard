using Orchard.ContentManagement;
using Orchard.Taxonomies.Models;
using Orchard.Taxonomies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Service.DataImport
{
    public class DataImporter : IDataImporter
    {
        private readonly ITaxonomyService _taxonomyService;
        private readonly IContentManager _contentManager;

        public DataImporter(
            
            ITaxonomyService taxonomyService,
            IContentManager contentManager

            )
        {
            _taxonomyService = taxonomyService;
            _contentManager = contentManager;
        }


        public void BuildCategory()
        {
            var artistTaxo = _contentManager.New<TaxonomyPart>("Taxonomy");
            artistTaxo.Name = "InfoType";
            _contentManager.Create(artistTaxo, VersionOptions.Published);
            string[] categories = new string[] {"学院新闻", "院务通知","科研成果" };
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
    }
}