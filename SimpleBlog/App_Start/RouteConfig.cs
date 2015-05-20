using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // .axd extension is files that dont actually exist on file system but used for debugging
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Name is Home, route is blank - so that default route goes to home page
            // Controller is a class, action is a method
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" });
        }
    }
}
