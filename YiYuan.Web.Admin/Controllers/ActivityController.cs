using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Entity;

namespace YiYuan.Web.Admin.Controllers
{
    public class ActivityController : Controller
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var list = new List<Activity>();

            list.Add(new Activity());

            return View(list);
        }

        public ActionResult Create()
        {

            return View();
        }


        /// <summary>
        /// 活动详情
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        public ActionResult Details(int activityId)
        {
            return View();
        }
    }
}