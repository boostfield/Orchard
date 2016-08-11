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
             "column1/co",
             new RouteValueDictionary {
                                        {"area", "Orchard.Xmu"},
                                        {"controller", "Column1"},
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
            };

        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }


    }
}