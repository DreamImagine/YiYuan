using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YiYuan.Web.Controllers
{
    /// <summary>
    /// 商品
    /// <para>产品</para>
    /// </summary>
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 商品详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            return View();
        }

        /// <summary>
        /// 分类
        /// </summary>
        /// <returns></returns>
        public ActionResult Sort()
        {
            return View();
        }




    }
}