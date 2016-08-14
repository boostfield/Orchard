using NGM.ContentViewCounter.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Core.Common.Models;
using Orchard.Core.Title.Models;
using Orchard.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class XmContentPart:ContentPart
    {
        public string Title
        {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }

        public string Text
        {
            get { return this.As<BodyPart>().Text; }
            set { this.As<BodyPart>().Text = value; }
        }

        public IUser Creator
        {
            get { return this.As<ICommonPart>().Owner; }
            set { this.As<ICommonPart>().Owner = value; }
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

        public int ViewCount
        {
            get { return this.As<UserViewPart>().TotalViews; }
            set { this.As<UserViewPart>().TotalViews = value; }
        }

    }
}