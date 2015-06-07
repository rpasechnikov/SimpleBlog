using SimpleBlog.Controllers;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Used in this example to constrain routes below to the specified namespace,
            // removing conflict between 2 PostsControllers
            var namespaces = new[] { typeof(PostsController).Namespace };

            // .axd extension is files that dont actually exist on file system but used for debugging
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
            routes.MapRoute("Logout", "logout", new { controller = "Auth", action = "Logout" }, namespaces);

            // Name is Home, url is blank - so that default (no extra url params) route goes to home page
            // Controller is a class, action is a method
            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);
        }
    }
}
