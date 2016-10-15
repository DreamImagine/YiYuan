using System.Collections.Generic;
using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.Enums;
using YiYuan.ViewModel;

namespace YiYuan.Web.Controllers
{
    /// <summary>
    /// 商品
    /// <para>产品</para>
    /// </summary>
    public class ProductController : Controller
    {
        /// <summary>
        /// 价格商品列表
        /// </summary>
        /// <param name="id">十元，是二元</param>
        /// <returns></returns>
        [Route("product/{id}")]
        public ActionResult Index(int id = 0)
        {

            var list = new List<ProductListViewModel>();

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            return View(list);
        }


        /// <summary>
        /// 商品详情
        /// </summary>
        /// <param name="id">商品编号</param>
        /// <returns></returns>
        public ActionResult Detail(int id = 0)
        {
            var issueBusiness = new IssueBusiness();

            //ViewBag.Data = issueBusiness.GetFirstByWhere(t => t.GoodsId == id, t => new
            //{
            //    t.Goods.Name,
            //    t.Goods.Title,
            //    t.No,
            //    t.EndNumber,
            //    t.EndTime,
            //    t.Goods.Description
            //});

            var model = new ProductViewModel();
            //ViewBag.Data = model;
            return View(model);
        }

        /// <summary>
        /// 分类
        /// </summary>
        /// <returns></returns>
        public ActionResult Sort(int typeId = 0)
        {
            var list = new List<ProductListViewModel>();

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());
            list.Add(new ProductListViewModel());

            return View(list);
        }



    }
}