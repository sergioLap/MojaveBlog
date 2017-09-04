using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MojaveBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Action",
                "{action}",
                new { controller = "Mojave", action = "Posts" }
            );

            routes.MapRoute(
                "Tag",
                "Tag/{tag}",
                new { controller = "Mojave", action = "Tag" }
            );


            routes.MapRoute(
                "Category",
                "Category/{category}",
                new { controller = "Mojave", action = "Category" }
            );




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Mojave",
                    action = "Posts",
                    id = UrlParameter.Optional
                });

        }
    }
}
