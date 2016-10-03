namespace YiYuan.Enums
{
    /// <summary>
    /// 期号状态
    /// </summary>
    public enum IssueStatus : byte
    {
        //1.未开始 
        //2.进行中 
        //3.待开奖，表示所有都买完，这个状态时继续生成下一期  4.已开奖  5.已发货 6.客户已收到

        None = 0,

        /// <summary>
        /// 未开始
        /// </summary>
        NotStart = 1,

        /// <summary>
        /// 进行中
        /// </summary>
        Ongoing = 2,

        /// <summary>
        /// 待开奖，表示所有都买完，这个状态时继续生成下一期
        /// </summary>
        WaitLottery = 3,

        /// <summary>
        /// 已开奖
        /// </summary>
        HasLottery = 4,

        /// <summary>
        /// 已发货
        /// </summary>
        Shipped = 5,

        /// <summary>
        /// 客户已收到
        /// </summary>
        CustomerReceived = 6
    }
}
