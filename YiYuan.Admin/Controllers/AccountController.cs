using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.ViewModel;

namespace YiYuan.Admin.Controllers
{
    public class AccountController : Controller
    {
        readonly AdminInfoBusiness adminInfoBusiness;

        public AccountController()
        {
            adminInfoBusiness = new AdminInfoBusiness();
        }

        // GET: Account
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AdminInfoLoginViewModel login)
        {
            var result=adminInfoBusiness.Login(login);
            if (!result.Successs)
            {
                return View();
            }

            //http://www.cnblogs.com/firstcsharp/archive/2013/06/08/3127209.html

            Response.Cookies["adminId"].Value = result.Id;
            Response.Cookies["adminId"].Expires = DateTime.Now.AddDays(1);

            return View();
        }


        public ActionResult LoginOut()
        {
            // 清除cookie
            Response.Cookies.Clear();

            return View("Login");
        }
    }
}