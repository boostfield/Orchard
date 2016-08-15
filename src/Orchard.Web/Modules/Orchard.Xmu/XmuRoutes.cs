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
                                        "Admin/CollegeNews",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CollegeNewsAdmin"},
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
                                        "Admin/UndergraduateAffairs",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "UndergraduateAffairsAdmin"},
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
                                        "Admin/GraduateAffairs",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "GraduateAffairsAdmin"},
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
                                        "Admin/StudentInfo",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "StudentInfoAdmin"},
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
                                        "Admin/PublicPartCollegeAffairs",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "PublicPartyCollegeAffairsAdmin"},
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
                                        "Admin/RecuritInfo",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "RecuritInfoAdmin"},
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
                                        "Admin/AcademicNews",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "AcademicNewsAdmin"},
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
                                                                    {"controller", "Content"},
                                                                    {"action", "Item"}
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

                 { "controller", "Content"},

                 { "action", "Paging"}

                                       },

             new RouteValueDictionary(),
             new RouteValueDictionary {
                                          {"area", "Orchard.Xmu"}
                                       },
             new MvcRouteHandler())
                }
                ,
                          new RouteDescriptor {
                                    Priority = 20,
                                    Route = new Route(
                                        "Admin/CollegeAffairsNotify",
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
                                                                    {"controller", "CollegeAffairsNotifyAdmin"},
                                                                    {"action", "List"}
                                                                },
                                        new RouteValueDictionary(),
                                        new RouteValueDictionary {
                                                                    {"area", "Orchard.Xmu"},
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