using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http.WebHost;
using System.Web.Http;
using System.Net.Http.Headers;
using Microsoft.AspNet.WebApi.Extensions.Compression.Server;
using System.Net.Http.Extensions.Compression.Core.Compressors;
namespace Demo2
{
    public class WebApiConfig
    {
        public static void RegisterRoutes(HttpConfiguration configuration)
        {
            configuration.Routes.MapHttpRoute( name: "API", routeTemplate: "api/{controller}/{id}",
                defaults: new { id = UrlParameter.Optional });


            configuration.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { action = "get", id = RouteParameter.Optional }
                );



            //configuration.MessageHandlers.Insert(0, new ServerCompressionHandler(new GZipCompressor(), new DeflateCompressor()));


            configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }




        //defaults: new { controller = "webapi", action = "Get", id = UrlParameter.Optional });
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        //    routes.MapHttpRoute(
        //       name: "API Default",
        //       routeTemplate: "api/{controller}/{id}",
        //       defaults: new { id = RouteParameter.Optional }
        //   );

        //}

    }
}