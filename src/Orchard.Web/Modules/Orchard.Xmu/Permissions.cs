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

        public static readonly Permission ManageCelBanner = new Permission
        {
            Description = XmContentType.NinetyCelBanner.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.NinetyCelBanner.ContentTypeName)

        };

        public static readonly Permission ManageCelMatesPic = new Permission
        {
            Description = XmContentType.NinetyCelMatesOldPic.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.NinetyCelMatesOldPic.ContentTypeName)

        };


        public static readonly Permission ManageCNNotify = new Permission
        {
            Description = XmContentType.CNNotify.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNNotify.ContentTypeName)
        };

        public static readonly Permission ManageENTeacher = new Permission
        {
            Description = XmContentType.ENTeacher.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.ENTeacher.ContentTypeName)
        };

        public static readonly Permission ManageENCourse = new Permission
        {
            Description = XmContentType.ENCourse.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.ENCourse.ContentTypeName)
        };

        public static readonly Permission ManageCNCop = new Permission
        {
            Description = XmContentType.CNCop.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNCop.ContentTypeName)
        };


        public static readonly Permission ManageCNCollegeShow = new Permission
        {
            Description = XmContentType.CNCollegeShow.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNCollegeShow.ContentTypeName)
        };


        public static readonly Permission ManageCNTeacher = new Permission
        {
            Description = XmContentType.CNTeacher.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNTeacher.ContentTypeName)
        };
        public static readonly Permission ManageCNAcademicPaper = new Permission
        {
            Description = XmContentType.CNAcademicPaper.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNAcademicPaper.ContentTypeName)
        };


        public static readonly Permission ManageCNAcademicWork = new Permission
        {
            Description = XmContentType.CNAcademicWork.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNAcademicWork.ContentTypeName)
        };

        public static readonly Permission ManageCNAward = new Permission
        {
            Description = XmContentType.CNAward.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNAward.ContentTypeName)
        };
        public static readonly Permission ManageCNProject = new Permission
        {
            Description = XmContentType.CNProject.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.CNProject.ContentTypeName)
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
                ManageLectureInfo,
                ManageCNNotify,
                ManageCNBanner,
                ManageENBanner,
                ManageENSection,
                ManageCelBanner,
                ManageCelMatesPic,
                ManageENTeacher,
                ManageENCourse,
                ManageCNCop


            };


            var contentPermissions = XmContentType.CNCMSMappings
                .Select(p => p.Permission).ToList();
            contentPermissions.AddRange(staticPermissions);


            return contentPermissions;
        }
    }
}
