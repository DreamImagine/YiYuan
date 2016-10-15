using System.Web.Mvc;
using System.Web.UI;

namespace YiYuan.Web.Controllers
{
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 25000, VaryByParam = "none", Location = OutputCacheLocation.Any, Order = 5)]
        public ActionResult Index()
        {
            return View();
        }
    }
}