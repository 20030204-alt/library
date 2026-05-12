using System.Web.Mvc;

namespace LibraryMVC.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
