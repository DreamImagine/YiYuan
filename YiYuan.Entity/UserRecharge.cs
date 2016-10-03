using YiYuan.Enums;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户充值
    /// </summary>
    public class UserRecharge : EntityBase<int>
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 充值金额
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public RechargeType RechargeType { get; set; }

        /// <summary>
        /// 支付返回的流水凭证
        /// </summary>
        public string OpenId { get; set; }


    }
}