using Orchard.Security.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Xmu
{
    public class Permissions : IPermissionProvider
    {
        public static readonly Permission ManageCollegeNews = new Permission
        {
            Description = XmContentType.CollegeNews.PermissionDesc,
            Name = string.Format("Manage{0}",XmContentType.CollegeNews.ContentTypeName)
        };


        public static readonly Permission ManageCollegeAffairsNotify = new Permission
        {
            Description = XmContentType.CollegeAffairsNotify.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CollegeAffairsNotify.ContentTypeName)
        };


        public virtual Feature Feature { get; set; }


        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { ManageCollegeNews, ManageCollegeAffairsNotify }
                },
                new PermissionStereotype {
                    Name = "Editor",
                    Permissions = new[] { ManageCollegeNews, ManageCollegeAffairsNotify }
                },
                new PermissionStereotype {
                    Name = "Moderator",
                    Permissions = new[] { ManageCollegeNews, ManageCollegeAffairsNotify }
                },
                new PermissionStereotype {
                    Name = "Author",
                },
                new PermissionStereotype {
                    Name = "Contributor",
                },
            };
        }

        public IEnumerable<Permission> GetPermissions()
        {
            return new[]
            {
                ManageCollegeNews,
                ManageCollegeAffairsNotify,
            };
        }
    }
}
