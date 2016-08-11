using Orchard.Taxonomies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;

namespace Orchard.Xmu.Service
{
    public class InfoService: IInfoService
    {
        private readonly ITaxonomyService _taxonomyService;

        public InfoService(ITaxonomyService taxonomyService)
        {
            _taxonomyService = taxonomyService;
        }

        public IList<IContent> GetContentItemsOfTaxonomy(string termName,int skip=0,int count=5)
        {
            var result = new List<IContent>();
            var type = _taxonomyService.GetTaxonomyByName(XmTaxonomyNames.CNInformation);
            if (type != null)
            {
                var term = _taxonomyService.GetTermByName(type.Id, termName);
                if(term !=null)
                {
                    result = _taxonomyService.GetContentItems(term,skip,count).ToList();
     
                }
            }
            return result;
        }
    }
}