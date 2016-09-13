using NGM.ContentViewCounter.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;
using Contrib.Voting.Services;
using Orchard;
using NGM.ContentViewCounter.Models;
using NGM.ContentViewCounter.Settings;

namespace NGM.ContentViewCounter.EventHandlers
{
    public class XmItemViewedHandler : IItemViewedEventHandler
    {
        private readonly IVotingService _votingService;
        private readonly IOrchardServices _orchardServices;
        public XmItemViewedHandler(IVotingService votingService,
            IOrchardServices orchardServices)
        {
            _votingService = votingService;
            _orchardServices = orchardServices;
        }

        public void ContentItemViewed(ContentItem item)
        {
            
            System.Diagnostics.Debug.WriteLine("ContentItemViewed:" + item.ContentType);
            var part = item.As<UserViewPart>();
            if(part!=null)
            {

                part.ViewCount = part.ViewCount + 1;
            }
            
        }




        private void RecordView(UserViewPart part, UserViewTypePartSettings settings)
        {
            var currentUser = _orchardServices.WorkContext.CurrentUser;

            if (currentUser != null)
            {
                Vote(currentUser.UserName, part, settings);
            }
            else if (settings.AllowAnonymousViews)
            {
                var anonHostname = _orchardServices.WorkContext.HttpContext.Request.UserHostAddress;
                if (!string.IsNullOrWhiteSpace(_orchardServices.WorkContext.HttpContext.Request.Headers["X-Forwarded-For"]))
                    anonHostname += "-" + _orchardServices.WorkContext.HttpContext.Request.Headers["X-Forwarded-For"];

                Vote("Anonymous" + anonHostname, part, settings);
            }
        }

        private void Vote(string userName, UserViewPart part, UserViewTypePartSettings settings)
        {
            var currentVote = _votingService.Get(vote =>
                vote.ContentItemRecord == part.ContentItem.Record &&
                vote.Username == userName &&
                vote.Dimension == Constants.Dimension).FirstOrDefault();

            if (currentVote != null && settings.AllowMultipleViewsFromSameUserToCount)
                _votingService.ChangeVote(currentVote, (currentVote.Value + 1));
            else if (currentVote == null)
                _votingService.Vote(part.ContentItem, userName, _orchardServices.WorkContext.HttpContext.Request.UserHostAddress, 1, Constants.Dimension);
        }
    }
}