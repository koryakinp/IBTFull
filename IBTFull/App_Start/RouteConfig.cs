using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IBTFull
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Mail",
                url: "Mail/{action}/{id}",
                defaults: new { controller = "Mail", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "File",
                url: "{language}/File/{action}/{id}",
                defaults: new { language = lang, controller = "File", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default", 
                url: "{language}/{action}/{id}", 
                defaults: new { language = lang, controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
