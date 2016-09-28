using System.Web.Mvc;

namespace Payu.Web.Controllers
{
    /// <summary>
    /// 登陆
    /// </summary>
    public class LoginController : Controller
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {

        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial()
        {
            return PartialView("_PartialLogin");
        }


        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Out()
        {

            return View();
        }
    }
}