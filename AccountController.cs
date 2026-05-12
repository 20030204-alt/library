using System.Web.Mvc;

namespace LibraryMVC.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }
    }
}
