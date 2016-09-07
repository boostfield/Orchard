using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class CNCollegeShowPart: ContentPart
    {
        public string Title
        {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }

        public string SubTitle
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.CNCollegeShowPart.subtitle.Value;
                return v;
            }
        }

        public string ImageAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.CNCollegeShowPart.image.FirstMediaUrl;
                return v;
            }
        }

        public string LinkAddress
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.CNCollegeShowPart.linkAddress.Value;
                return v;
            }
        }


        public DateTime? PublishedUtc
        {
            get { return this.As<ICommonPart>().PublishedUtc; }
            set { this.As<ICommonPart>().PublishedUtc = value; }
        }



        public string Author
        {
            get { return this.As<CommonPart>().Author; }
            set { this.As<CommonPart>().Author = value; }
        }

        public string Editor
        {
            get { return this.As<CommonPart>().Editor; }
            set { this.As<CommonPart>().Editor = value; }
        }
    }
}