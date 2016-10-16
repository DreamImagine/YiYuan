using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.Entity;

namespace YiYuan.Web.Admin.Controllers
{
    public class AdminInfoController : Controller
    {
        readonly AdminInfoBusiness _adminBusiness;
        public AdminInfoController()
        {
            _adminBusiness = new AdminInfoBusiness();

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
           _adminBusiness.Create(admin);

            return View();
        }
    }
}