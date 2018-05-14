using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FunnelBud
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Sport",
                "Sport/{productName}",
                new { controller = "Sport", action = "FindByName" }
            );
            routes.MapRoute(
                "Leksaker",
                "Leksaker/{productName}",
                new { controller = "Leksaker", action = "FindByName" }
            );
            routes.MapRoute(
                "Hemelektronik",
                "Hemelektronik/{productName}",
                new { controller = "Hemelektronik", action = "FindByName" }
            );
            routes.MapRoute(
                name: "Articles",
                url: "{controller}/{action}/{name}",
                defaults: new { controller = "Articles", action = "Index", name = UrlParameter.Optional }
            );
        }
    }
}
