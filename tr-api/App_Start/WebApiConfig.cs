using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Tr_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Filters.Add(new TrExceptionFilter());
            config.Services.Replace(typeof(System.Web.Http.ExceptionHandling.IExceptionHandler), new Services.TrExceptionHandler());
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //config.MessageHandlers.Add(new Services.ActionHandler());
        }
    }
}
