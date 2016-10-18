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
            var list = _activityBusiness.GetByWhere(t => t.Id > 0).Data;       

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
            _activityBusiness.Add(activitys);

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        public ActionResult Edit(int activityId)
        {
            var activity = _activityBusiness.GetFirstByWhere(t => t.Id == activityId).Data;

            return View(activity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(Activity activity)
        {
            _activityBusiness.Update(t => t.Id == activity.Id, t => new Activity
            {
                Name = activity.Name,
                Price = activity.Price

            });
            return View(activity);
        }

        /// <summary>
        /// 活动详情
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        public ActionResult Details(int activityId)
        {
            ViewBag.ActivityName = _activityBusiness.GetFirstByWhere(t => t.Id == activityId, t => t.Name).Data;

            return View();
        }

        /// <summary>
        /// 活动添加商品
        /// </summary>
        /// <param name="activityId"></param>
        /// <returns></returns>
        public ActionResult AddGodds(int activityId)
        {
            ViewBag.ActivityName = _activityBusiness.GetFirstByWhere(t => t.Id == activityId, t => t.Name).Data;
            ViewBag.ActivityId = activityId;

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