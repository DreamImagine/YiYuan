using System.Web.Mvc;
namespace Payu.Web.Controllers
{
    /// <summary>
    /// 注册
    /// </summary>
    public class RegisterController : Controller
    {
        public RegisterController()
        {

        }

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register
        public ActionResult Validate()
        {
            return View();
        }

        // GET: Register
        public ActionResult Success()
        {
            return View();
        }

        /// <summary>
        /// 完善资料
        /// </summary>
        /// <returns></returns>
        public ActionResult Perfect()
        {
            return View();
        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <returns></returns>
        public ActionResult FindPwd()
        {
            return View();
        }
    }
}