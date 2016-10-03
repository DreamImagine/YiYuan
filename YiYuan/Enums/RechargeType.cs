namespace YiYuan.Enums
{
    /// <summary>
    /// 充值方式
    /// </summary>
    public enum RechargeType : byte
    {
        None = 0,
        //1 支付宝，2 微信 ,3 网银

        /// <summary>
        /// 支付宝
        /// </summary>
        Alipay = 1,

        /// <summary>
        /// 微信
        /// </summary>
        WeChat = 2,

        /// <summary>
        /// 网银
        /// </summary>
        OnlineBank = 3
    }
}