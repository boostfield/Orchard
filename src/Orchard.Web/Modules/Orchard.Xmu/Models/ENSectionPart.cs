using Orchard.ContentManagement;
using Orchard.Core.Title.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class ENSectionPart:ContentPart
    {
        public string Title
        {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }


        public string ImageAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.ENSectionPart.image.FirstMediaUrl;
                return v;
            }
        }

        public string LinkAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.ENSectionPart.linkAddress.Value;
                return v;
            }
        }

       public decimal Order
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.ENSectionPart.orderWeight.Value;
                return v;
            }
        }
 


      
    }
}