using Orchard.Users.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Security;
using Orchard.ContentManagement;
using Orchard.Xmu.Models;
using Orchard.Users.Models;

namespace Orchard.Xmu.UserHandler
{
    public class UserHandler : IUserEventHandler
    {
        private readonly IContentManager _contentManager;

        public UserHandler(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }
        public void AccessDenied(IUser user)
        {
        }

        public void Approved(IUser user)
        {
        }

        public void ChangedPassword(IUser user)
        {
        }

        public void ConfirmedEmail(IUser user)
        {
        }

        public void Created(UserContext context)
        {
            var info = _contentManager.New(XmContentType.CNTeacher.ContentTypeName);
            var infopart = info.As<CNTeacherPart>();

            //assign values
            infopart.Number = string.Empty;
            infopart.Name = context.UserParameters.Username;
            infopart.Rank = string.Empty;
            infopart.Education = string.Empty;
            infopart.Job = string.Empty;
            infopart.Resfield = string.Empty;
            infopart.Tecoffice = string.Empty;
            infopart.Office = string.Empty;
            infopart.Telephone = string.Empty;
            infopart.Introduce = string.Empty;
            infopart.Department = string.Empty;
            infopart.Year = string.Empty;
            infopart.Month = string.Empty;
            infopart.Avatar = string.Empty;
            infopart.Perspective = string.Empty;
            infopart.Concept = string.Empty;
            infopart.Publication = string.Empty;
            infopart.Dissertation = string.Empty;
            infopart.Course = string.Empty;
            infopart.Ptjob = string.Empty;
            infopart.Project = string.Empty;
            infopart.Contact = string.Empty;
            infopart.IsShow = true;
            infopart.Record.UserPartRecord = (context.User as UserPart).Record;

            _contentManager.Create(info, VersionOptions.Published);
        }

        public void Creating(UserContext context)
        {
        }

        public void LoggedIn(IUser user)
        {
        }

        public void LoggedOut(IUser user)
        {
        }

        public void LoggingIn(string userNameOrEmail, string password)
        {
        }

        public void LogInFailed(string userNameOrEmail, string password)
        {
        }

        public void SentChallengeEmail(IUser user)
        {
        }
    }
}