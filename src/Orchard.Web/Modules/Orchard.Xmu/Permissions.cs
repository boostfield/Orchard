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

        public static readonly Permission ManagePublicPartyCollegeAffairs = new Permission
        {
            Description = XmContentType.PublicPartyCollegeAffairs.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.PublicPartyCollegeAffairs.ContentTypeName)
        };


        public static readonly Permission ManageRecruitInfo = new Permission
        {
            Description = XmContentType.RecruitInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.RecruitInfo.ContentTypeName)
        };


        public static readonly Permission ManageLectureInfo = new Permission
        {
            Description = XmContentType.LectureInfo.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.LectureInfo.ContentTypeName)
        };

        public static readonly Permission ManageAcademicNews = new Permission
        {
            Description = XmContentType.AcademicNews.PermissionDesc,
            Name = string.Format("Manage{0}", XmContentType.AcademicNews.ContentTypeName)
        };




        public virtual Feature Feature { get; set; }


        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[] {
                new PermissionStereotype {
                    Name = "Administrator",
                    Permissions = new[] { 
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
                    ManageLectureInfo,



                    }
                },
                new PermissionStereotype {
                    Name = "Editor",
                    Permissions = new[] {  
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
                    ManageLectureInfo,
                    }
                },
                new PermissionStereotype {
                    Name = "Moderator",
                    Permissions = new[] {
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
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
                
                    ManagePublicPartyCollegeAffairs,
                    ManageRecruitInfo,
            };


            var contentPermissions = XmContentType.ENCMSMappings
                .Select(p => p.Permission).ToList();
            contentPermissions.AddRange(staticPermissions);


            return contentPermissions;
        }
    }
}
