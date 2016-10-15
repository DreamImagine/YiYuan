using System;
using System.Collections.Generic;

namespace YiYuan.ViewModel
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Name = "";
            Title = "";
            Description = "";
            EndTime = DateTime.Now;

            ImgUrls = new List<string>();
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 期号
        /// <para>针对每个商品进行累加</para>
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 结束次数
        /// </summary>
        public int EndNumber { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 开奖时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        public List<string> ImgUrls { get; set; }

    }
}
