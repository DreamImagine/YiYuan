using System;

namespace YiYuan.Entity
{
    /// <summary>
    /// 期号号码
    /// </summary>
    public class IssueNumber : EntityBase<Int32>
    {
        /// <summary>
        /// 期号
        /// </summary>
        public int IssueId { get; set; }

        /// <summary>
        /// 订单详情id
        /// </summary>
        public int UserOrderDetailsId { get; set; }

        /// <summary>
        /// 是否被分配
        /// </summary>
        public bool IsUsed { get; set; }
    }
}
