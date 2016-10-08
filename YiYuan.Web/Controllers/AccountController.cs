using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.ViewModel;

namespace YiYuan.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserInfoBusiness _userInfoBusiness;
        public AccountController()
        {
            _userInfoBusiness = new UserInfoBusiness();
        }

        // GET: Account
        public ActionResult Index()
        {
            return View("Login");
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(UserLoginViewModel viewModel)
        {
            _userInfoBusiness.Login(viewModel);

            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Register(UserLoginViewModel view)
        {
            _userInfoBusiness.Register(view);

            return View();
        }


        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Out()
        {
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("/");
            return View();
        }

    }
}