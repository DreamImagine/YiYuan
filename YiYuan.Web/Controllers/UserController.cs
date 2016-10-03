using System.Web.Mvc;

namespace YiYuan.Web.Controllers
{
    /// <summary>
    /// 个人中心
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 参与记录
        /// </summary>
        /// <returns></returns>
        public ActionResult Join()
        {
            return View();
        }

        /// <summary>
        /// 中奖记录
        /// </summary>
        /// <returns></returns>
        public ActionResult Win()
        {
            return View();
        }


        /// <summary>
        /// 个人信息
        /// </summary>
        /// <returns></returns>
        public ActionResult Info()
        {
            return View();
        }

        /// <summary>
        /// 红包
        /// </summary>
        /// <returns></returns>
        public ActionResult Redpackets()
        {
            return View();
        }






    }
}