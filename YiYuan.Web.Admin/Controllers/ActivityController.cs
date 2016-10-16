using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Entity;
using YiYuan.Business;
namespace YiYuan.Web.Admin.Controllers
{
    /// <summary>
    /// 活动
    /// </summary>
    public class ActivityController : Controller
    {
        readonly ActivityBusiness _activityBusiness;

        readonly ActivityGoodsBusiness _activityGoodsBusiness;

        public ActivityController()
        {
            _activityBusiness = new ActivityBusiness();

            _activityGoodsBusiness = new ActivityGoodsBusiness();
        }

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

        /// <summary>
        /// 创建活动
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(Activity activitys)
        {
            _activityBusiness.Add(activitys, true);

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

        /// <summary>
        /// 活动添加商品
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        public ActionResult AddGodds(int activityId)
        {
            return View();
        }

        /// <summary>
        /// 保存活动添加商品
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddGodds(List<ActivityGoods> list)
        {
            //var list = new ActivityGoods();
            _activityGoodsBusiness.Add(list);

            return View();
        }





    }
}