using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}