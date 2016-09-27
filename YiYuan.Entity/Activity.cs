using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 活动（期）
    /// </summary>
    public class Activity : EntityBase<int>
    {

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
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 每注价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public int GoodsId { get; set; }

        /// <summary>
        /// 是否开奖
        /// </summary>
        public bool IsEnd { get; set; }

        /// <summary>
        /// 开奖时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 幸运用户
        /// <para>中奖者</para>
        /// </summary>
        public int LuckyUserId { get; set; }
    }
}
