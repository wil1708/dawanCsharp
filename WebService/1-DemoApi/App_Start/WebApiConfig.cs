using _1_DemoApi.Formatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _1_DemoApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //Limiter le type de données au format JSON
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //Ajouter du format CSV au formatter
            config.Formatters.Add(new CsvMediaTypeFormatter());
        }
    }
}
