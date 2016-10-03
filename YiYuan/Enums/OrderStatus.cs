namespace YiYuan.Enums
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus : byte
    {
        None = 0,

        /// <summary>
        /// 待支付
        /// </summary>
        ToBePaid,

        // 1 待支付  2.已支付 3. 支付失败

        /// <summary>
        /// 已支付
        /// </summary>
        AlreadyPaid = 2,

        /// <summary>
        /// 支付失败
        /// </summary>
        PayFailed = 3

    }
}
