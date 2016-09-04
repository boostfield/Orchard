using Orchard.Mvc.Routes;
using Orchard.WebApi.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Orchard.Xmu
{
    public class ApiRoutes: IHttpRouteProvider
    {

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new RouteDescriptor[] {
            

                //Router for User
                new HttpRouteDescriptor
                {
                    Name = "User Manager Api",
                    Priority = 0,
                    RouteTemplate = "api/{controller}/{action}/{id}",
                      Defaults = new {
                        area = "Orchard.Xmu",
                        action = "Index",
                        id = RouteParameter.Optional
                    }
                }
            };
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (RouteDescriptor routeDescriptor in GetRoutes())
            {
                routes.Add(routeDescriptor);
            }
        }
    }
}