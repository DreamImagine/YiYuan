using System.Web.Mvc;

namespace YiYuan.Web.Controllers
{
    /// <summary>
    /// 帮助
    /// </summary>
    public class HelpController : Controller
    {
        // GET: Help
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 服务协议
        /// </summary>
        /// <returns></returns>
        public ActionResult Protocol()
        {
            return View();
        }

        /// <summary>
        /// 商品配送
        /// </summary>
        /// <returns></returns>
        public ActionResult Distribution()
        {
            return View();
        }

        /// <summary>
        /// 常见问题
        /// </summary>
        /// <returns></returns>

        public ActionResult Question()
        {
            return View();
        }

        /// <summary>
        /// 公正公开
        /// </summary>
        /// <returns></returns>
        public ActionResult Equity()
        {
            return View();
        }


        /// <summary>
        /// 正品保证
        /// </summary>
        /// <returns></returns>
        public ActionResult Guarantee()
        {
            return View();
        }


        /// <summary>
        /// 支付保障
        /// </summary>
        /// <returns></returns>
        public ActionResult Pay()
        {
            return View();
        }


        /// <summary>
        /// 配送费用
        /// </summary>
        /// <returns></returns>
        public ActionResult DistributionCost()
        {

            return View();
        }

        /// <summary>
        /// 验货签收
        /// </summary>
        /// <returns></returns>
        public ActionResult Signin()
        {
            return View();
        }



    }
}