using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.Entity;

namespace YiYuan.Web.Admin.Controllers
{
    public class GoodsController : Controller
    {
        readonly GoodsBusiness _goodsBusiness;

        public GoodsController()
        {
            _goodsBusiness = new GoodsBusiness();
        }


        // GET: Goods
        public ActionResult Index()
        {

            var list = _goodsBusiness.GetQueryable().ToList();

            return View(list);
        }



        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Goods goods)
        {
            _goodsBusiness.Add(goods);
            return View();
        }

        /// <summary>
        /// 上传商品图片
        /// </summary>
        /// <returns></returns>
        public ActionResult AddImg()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddImg(int goosId,List<string> imagerUrlsList )
        {

            var list=new List<GoodsImg>();

            foreach (var item   in imagerUrlsList)
            {
                list.Add(new GoodsImg
                {
                   GoodsId = goosId,
                   Path = item
                });
            }

            var business=new GoodsBusiness();

            business.AddImage(list);

            return View();
        }


        public ActionResult Edit(int id)
        {
            var goods = _goodsBusiness.GetById(id).Data;

            return View(goods);
        }

        [HttpPost]
        public ActionResult Edit(Goods goods)
        {
            return View();
        }


        /// <summary>
        /// 编辑商品图片
        /// </summary>
        /// <returns></returns>
        public ActionResult EditImg(int  goodsId)
        {
            return View();
        }






    }
}