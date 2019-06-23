using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiContrib.Formatting.Jsonp;
using System.Web.Http.Cors;

namespace WebApiJQueryCall
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
            //var jsonformatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            //config.Formatters.Insert(0, jsonformatter);

            //--Enables for all controller, actions, all clients, all mediatypeformatter, all methods
            //EnableCorsAttribute ecors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(ecors);

            //For specific contoller or action, to enable cors use atttribute based and below snippet
            config.EnableCors();
        }
    }
}
