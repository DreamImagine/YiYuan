using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YiYuan.Entity
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Goods : EntityBase<int>
    {
        /// <summary>
        /// 商品类型
        /// <para>GoodsType 外键</para>
        /// </summary>
        [Display(Name = "商品类型")]
        public int GoodsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 简单标题
        /// </summary>
        [Display(Name = "简单标题")]
        public string Title { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [Display(Name = "价格")]
        public decimal Price { get; set; }

        /// <summary>
        /// 结束次数
        /// </summary>
        [Display(Name = "结束次数")]
        public int EndNumber { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [Column(TypeName = "NTEXT")]
        [Display(Name = "描述")]
        public string Description { get; set; }

        /// <summary>
        /// 是否发布
        /// </summary>
        [Display(Name = "是否发布")]
        public bool IsPublish { get; set; }

        /// <summary>
        /// 商品图
        /// </summary>
        public ICollection<GoodsImg> GoodsImgs { get; set; }

    }
}
