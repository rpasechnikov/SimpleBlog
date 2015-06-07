using SimpleBlog.ViewModels;
using System.Web.Mvc;
using System.Web.Security;

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
        /// <param name="form">The Login form</param>
        /// <param name="returnUrl">(Special param/convention/reserved) to get possible returnUrl - 
        /// a URL from which this page was redirected from, if any</param>
        /// <returns>View to display</returns>
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            // IsValid ensures that all Required fields have been populated
            if(!ModelState.IsValid)
            {
                return View(form);
            }

            // Authentication - tells ASP.NET who this person is
            FormsAuthentication.SetAuthCookie(form.Username, true);

            if(!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToRoute("home");
            }
        }

        /// <summary>
        /// Logs the current user out
        /// </summary>
        /// <returns>Redirects to home view</returns>
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
    }
}