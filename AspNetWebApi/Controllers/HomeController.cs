using System.Web.Mvc;

namespace AspNetApiAngular.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
#if DEBUG
            return Content("Solo disponible en producion");
#else
            return File(HttpContext.Server.MapPath("~/index.html"), "text/html");
#endif
        }
    }
}
