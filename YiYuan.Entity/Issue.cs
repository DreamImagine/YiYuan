using System;
using System.ComponentModel.DataAnnotations.Schema;
using YiYuan.Enums;

namespace YiYuan.Entity
{
    /// <summary>
    /// 商品期号
    /// </summary>
    public class Issue : EntityBase<int>
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
        /// 商品编号
        /// </summary>
        public int ActivityGoodsId { get; set; }

        /// <summary>
        /// 期号状态
        /// </summary>
        public IssueStatus IssueStatus { get; set; }

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
