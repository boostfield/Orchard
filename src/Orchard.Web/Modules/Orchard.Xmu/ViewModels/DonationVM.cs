using Orchard.Xmu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orchard.Xmu.ViewModels
{
    public class DonationVM:XmContentVM
    {

        public string Donator { get; set; }
        public string DonationAmount { get; set; }
        public DateTime DonationTime { get; set; }

        public static DonationVM FromDonationPart(NinetyCelebrationDonationPart part )
        {

            return new DonationVM
            {
                Donator = part.Donator,
                DonationAmount = part.DonationAmount,
                DonationTime = part.DonationTime,
                Title = part.Title,
                Id = part.Id,
                PublishedUtc = part.PublishedUtc,
                ViewCount = part.ViewCount

            };

        }
    }
}