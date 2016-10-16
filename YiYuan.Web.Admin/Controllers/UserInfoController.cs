using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Entity;

namespace YiYuan.Web.Admin.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            var list = new List<UserInfo>();

            list.Add(new UserInfo());
            return View(list);
        }
    }

}
