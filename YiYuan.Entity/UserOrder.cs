using YiYuan.Enums;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户订单
    /// </summary>
    public class UserOrder : EntityBase<int>
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

    }
}
