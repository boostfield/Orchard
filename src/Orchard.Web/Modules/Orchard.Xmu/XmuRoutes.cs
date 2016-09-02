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
            {
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
                                        "anniversary",

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
                                        "anniversary/home",
                                        
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
                                        "anniversary/Detail/{contentTypeName}/{Id}",
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
             "anniversary/Paging/{contentTypeName}",
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
             "anniversary/DonationPaging",
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



            };

        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }


    }
}