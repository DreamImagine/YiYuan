namespace YiYuan.Entity
{
    /// <summary>
    /// 用户消息
    /// </summary>
    public class UserMessage : EntityBase<int>
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// 接受方
        /// </summary>
        public int ToId { get; set; }

        /// <summary>
        /// 发送方
        /// </summary>
        public int FromId { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        public bool IsRead { get; set; }
    }
}