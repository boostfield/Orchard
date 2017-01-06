using Orchard.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Orchard.Xmu
{
    public class XmuRoutes : IRouteProvider
    {
        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[]
            { new RouteDescriptor
                {
                  Priority = 50,

            Route = new Route(
             "personalcenter",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "PersonalCenter"},
                                        {"action", "Index"}
                                       },
             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                }
                ,
                new RouteDescriptor
                {
                  Priority = 100,

            Route = new Route(
             "",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "Home"},
                                        {"action", "Index"}
                                       },
             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                }
                ,
                     new RouteDescriptor
                {
                  Priority = 100,

            Route = new Route(
             "home",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "Home"},
                                        {"action", "Home"}
                                       },
             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                }
                ,
             new RouteDescriptor
                {
                  Priority = 100,

            Route = new Route(
             "en",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "ENHome"},
                                        {"action", "Index"}
                                       },
             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                new RouteDescriptor
                {
                  Priority = 100,

            Route = new Route(
             "en/home",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "ENHome"},
                                        {"action", "Home"}
                                       },
             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },
                new RouteDescriptor
                            {
                    Priority = 100,
                                    Route = new Route(
                                        "90",

                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "AnniversaryHome"},
                                                                    {"action", "Index"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                            },
                new RouteDescriptor
                            {
                    Priority = 100,
                                    Route = new Route(
                                        "90/home",

                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "AnniversaryHome"},
                                                                    {"action", "Home"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                            },
                 new RouteDescriptor
                            {
                                    Route = new Route(
                                        "Admin/DataImporter/{action}",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "DataImporter"},
                                                                    {"action", "Index"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                            },

                                  new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/NinetyDonation",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "NinetyCelebrationDonationAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                           new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/LectureInfo",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "LectureInfoAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                 new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/ENBanner",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "ENBannerAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },


                                 new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/ENTeacher",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "ENTeacherAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                 new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/ENCourse",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "ENCourseAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                            new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNBanner",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNBannerAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },
                                new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CelBanner",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "NinetyCelBannerAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                             new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CelMatesPic",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CelMatesPicAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                  new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/Notify",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNNotifyAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },


                                  new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNCop",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNCopAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                                                    new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNAward",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNAwardAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },


                                                                    new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNAcademicPaper",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNAcademicPaperAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },



                                                                    new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNAcademicWork",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNAcademicWorkAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },
                                                                    new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNTeacher",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNTeacherAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                                                                                                                  new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNProject",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNProjectAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },
                            new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CNCollegeShow",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CNCollegeShowAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                     new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/ENSection",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "ENSectionAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

                                  new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/XmContent/{contentTypeName}",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "XmContentAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },




                new RouteDescriptor {
                                    Priority = 22,
                                    Route = new Route(
                                        "Detail/{contentTypeName}/{Id}",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "XmContent"},
                                                                    {"action", "Item"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },
                        new RouteDescriptor {
                                    Priority = 22,
                                    Route = new Route(
                                        "en/Detail/{contentTypeName}/{Id}",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "XmContent"},
                                                                    {"action", "ENItem"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },
                                new RouteDescriptor {
                                    Priority = 22,
                                    Route = new Route(
                                        "90/Detail/{contentTypeName}/{Id}",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "XmContent"},
                                                                    {"action", "ANItem"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                },
                                        new MvcRouteHandler())
                             },

              new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "ScientificResearchPaging/{contentTypeName}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ScientificResearchPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

              new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "Paging/{contentTypeName}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "Paging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                         new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "en/Paging/{contentTypeName}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ENPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "90/Paging/{contentTypeName}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ANPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },



                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "90/DonationPaging",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "DonationPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

            new RouteDescriptor
                {
                  Priority = 23,

            Route = new Route(
             "90/DonationItem/{Id}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "DonationItem"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "en/CoursePaging",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ENCoursePaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "cnteachers",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "CNTeachers"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },


                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "en/TeacherPaging",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ENTeacherPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },



                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "en/teacher/{Id}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ENTeacherItem"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },



                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "en/course/{Id}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ENCourseItem"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },

                  new RouteDescriptor
                {
                  Priority = 30,

            Route = new Route(
             "NoticePaging/{type}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "NoticePaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },
                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "ScienceItem/{contentTypeName}/{Id}",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ScienceItem"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                },
                  new RouteDescriptor
                {
                  Priority = 22,

            Route = new Route(
             "ShowPaging",
             new RouteValueDictionary {

                 { "area", "Orchard.Xmu"},

                 { "controller", "XmContent"},

                 { "action", "ShowPaging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                }
            };

        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }


    }
}