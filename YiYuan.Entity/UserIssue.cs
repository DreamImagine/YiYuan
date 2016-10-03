namespace YiYuan.Entity
{
    /// <summary>
    /// 用户购买期号
    /// </summary>
    public class UserIssue : EntityBase<int>
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public int IssueId { get; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 用户号码
        /// <para>幸运号码</para>
        /// </summary>
        public int Number { get; set; }

    }
}
