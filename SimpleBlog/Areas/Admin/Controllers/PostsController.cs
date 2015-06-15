using SimpleBlog.Infrastructure;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAttribute("posts")]
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return View();
        }
    }
}