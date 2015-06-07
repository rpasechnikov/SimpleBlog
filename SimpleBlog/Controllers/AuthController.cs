using SimpleBlog.ViewModels;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        /// <summary>
        /// Handle GET login action
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View(new AuthLogin());
        }

        /// <summary>
        /// Handles POST login action
        /// </summary>
        /// <param name="aForm"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(AuthLogin aForm)
        {
            // IsValid ensures that all Required fields have been populated
            if(!ModelState.IsValid)
            {
                return View(aForm);
            }

            if(aForm.Username != "error")
            {
                ModelState.AddModelError("Username", "Username or password is invalid!");
                return View(aForm);
            }

            return Content("The form is valid!");
        }
    }
}