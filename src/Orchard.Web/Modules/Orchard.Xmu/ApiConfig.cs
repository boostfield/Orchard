using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Core;
using System.Web.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Web.Http.Dispatcher;

namespace Orchard.Xmu
{
    public class ApiConfig: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Console.WriteLine("ApiConfig Load\n");

            var config = GlobalConfiguration.Configuration;
            //config.Filters.Add(new HiFiApiResponseAttribute());
            /*
            var config = GlobalConfiguration.Configuration;
            config.Services.Replace(typeof(IHttpControllerSelector),
            new NamespaceHttpControllerSelector(config));
            */
            var jsonFormatter = GlobalConfiguration.Configuration.Formatters.OfType<JsonMediaTypeFormatter>().FirstOrDefault();

            if (jsonFormatter != null)
            {
                jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }
        }
    }
}