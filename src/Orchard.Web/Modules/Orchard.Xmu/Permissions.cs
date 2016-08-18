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

        public static readonly Permission ManageLectureInfo = new Permission
        {
            Description = XmContentType.LectureInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.LectureInfo.ContentTypeName)
        };

        public static readonly Permission ManageCNBanner = new Permission
        {
            Description = XmContentType.CNBanner.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNBanner.ContentTypeName)

        };

        public static readonly Permission ManageENBanner = new Permission
        {
            Description = XmContentType.ENBanner.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.ENBanner.ContentTypeName)

        };

        public static readonly Permission ManageENSection = new Permission
        {
            Description = XmContentType.ENSection.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.ENSection.ContentTypeName)

        };

        public virtual Feature Feature { get; set; }


        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { 
                    ManageLectureInfo,



                    }
                },
                new PermissionStereotype {
                    Name = "Editor",
                    Permissions = new[] {  
                    ManageLectureInfo,
                    }
                },
                new PermissionStereotype {
                    Name = "Moderator",
                    Permissions = new[] {
                    ManageLectureInfo,
                    }
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
            var staticPermissions = new[]
            {
                ManageLectureInfo
            };


            var contentPermissions = XmContentType.CNCMSMappings
                .Select(p => p.Permission).ToList();
            contentPermissions.AddRange(staticPermissions);


            return contentPermissions;
        }
    }
}
