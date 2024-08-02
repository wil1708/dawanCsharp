using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_DemoMVC
{
    public class RouteConfig
    {
        //URL : /X/Y/Z -> classe X pour le controller
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                //Les routes personalisées doivent être définies par défaut
                name: "HelloPersonne",
                url: "Hello/{action}/{nom}/{prenom}",
                defaults: new { controller = "Hello", action = "SayHello", nom = UrlParameter.Optional, prenom = UrlParameter.Optional }
                );

            routes.MapRoute(
                //Les routes personalisées doivent être définies par défaut
                name: "RouteCalculatrice",
                url: "{controller}/{action}/{nb1}/{nb2}",
                defaults: new {controller = "Home", action = "Index", nb1 = UrlParameter.Optional, nb2 = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
