using NGM.ContentViewCounter.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Aspects;
using Orchard.Core.Title.Models;
using Orchard.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.Models
{
    public class NinetyCelebrationDonationPart:ContentPart
    {
        public string Title
        {
            get { return this.As<TitlePart>().Title; }
            set { this.As<TitlePart>().Title = value; }
        }

        public DateTime? PublishedUtc
        {
            get { return this.As<ICommonPart>().PublishedUtc; }
            set { this.As<ICommonPart>().PublishedUtc = value; }
        }

        public int ViewCount
        {
            get { return this.As<UserViewPart>().TotalViews; }
            set { this.As<UserViewPart>().TotalViews = value; }
        }


        public IUser Creator
        {
            get { return this.As<ICommonPart>().Owner; }
            set { this.As<ICommonPart>().Owner = value; }
        }

        public string Donator
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.NinetyCelebrationDonationPart.donator.Value;

                return v;
            }
            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.NinetyCelebrationDonationPart.lecturer.Value = value;

            }
        }

        public string DonationAmount
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.NinetyCelebrationDonationPart.donationAmount.Value;

                return v;
            }
        }


        public string DonationTime
        {
            get
            {
                dynamic content = (dynamic)this.ContentItem;
                var v = content.NinetyCelebrationDonationPart.donationTime.DateTime;

                return v;

            }

            set
            {
                dynamic content = (dynamic)this.ContentItem;
                content.NinetyCelebrationDonationPart.donationTime.DateTime = value;
            }
        }
    }
}