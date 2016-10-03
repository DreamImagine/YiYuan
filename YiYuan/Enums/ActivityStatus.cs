namespace YiYuan.Enums
{
    /// <summary>
    /// 活动状态
    /// </summary>
    public enum ActivityStatus : byte
    {
        // 1.未开始 2.活动进行中 3.活动结束,将不自动生成期号
        None = 0,

        /// <summary>
        /// 未开始
        /// </summary>
        NotStart = 1,

        /// <summary>
        /// 活动进行中
        /// </summary>
        Ongoing = 2,

        /// <summary>
        /// 活动结束,将不自动生成期号
        /// </summary>
        End = 3

    }
}