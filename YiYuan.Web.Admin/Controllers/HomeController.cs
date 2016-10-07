using System.Web.Mvc;

namespace YiYuan.Web.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "后台首页";

            return View();
        }
    }
}
