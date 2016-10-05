using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.Entity;

namespace YiYuan.Admin.Controllers
{
    public class AdminInfoController : Controller
    {
        readonly AdminInfoBusiness adminBusiness;
        public AdminInfoController()
        {
            adminBusiness = new AdminInfoBusiness();

        }
        // GET: AdminInfo
        public ActionResult Index()
        {


            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AdminInfo admin)
        {
           adminBusiness.Create(admin);

            return View();
        }
    }
}