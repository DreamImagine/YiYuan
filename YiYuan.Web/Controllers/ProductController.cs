using System.Web.Mvc;
using YiYuan.Business;

namespace YiYuan.Web.Controllers
{
    /// <summary>
    /// 商品
    /// <para>产品</para>
    /// </summary>
    public class ProductController : Controller
    {
        // GET: Product
        [Route("product/{id}")]
        public ActionResult Index(int id=0)
        {
            return View();
        }


        /// <summary>
        /// 商品详情
        /// </summary>
        /// <param name="id">商品编号</param>
        /// <returns></returns>
        public ActionResult Detail(int id = 0)
        {
            var activityBusiness = new ActivityBusiness();

            ViewBag.Data=activityBusiness.GetFirstByWhere(t=>t.GoodsId==id && t.IsEnd==false,t=>new {
               t.Goods.Name,
               t.Goods.Title,
               t.No,
               t.EndNumber,
               t.EndTime,               
               t.Goods.Description
            });

            return View();
        }

        /// <summary>
        /// 分类
        /// </summary>
        /// <returns></returns>
        public ActionResult Sort(int typeId = 0)
        {
            return View();
        }



    }
}