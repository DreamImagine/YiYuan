using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 商品
    /// </summary>
    public class Goods : EntityBase<int>
    {

        /// <summary>
        /// 商量类型
        /// <para>GoodsType 外键</para>
        /// </summary>
        public int GoodsTypeId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 简单标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [Display(Name = "价格")]
        public decimal Price { get; set; }

        /// <summary>
        /// 结束次数
        /// </summary>
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
        public bool IsPublish { get; set; }

        /// <summary>
        /// 商品图
        /// </summary>
        public ICollection<GoodsImg> GoodsImgs { get; set; }

    }
}
