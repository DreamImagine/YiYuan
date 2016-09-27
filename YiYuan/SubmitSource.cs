namespace YiYuan
{
    /// <summary>
    /// 提交来源
    /// </summary>
    public enum SubmitSource : byte
    {
        /// <summary>
        /// 未定义
        /// </summary>
        None = 0,

        /// <summary>
        /// Web 提交
        /// </summary>
        Web = 1,

        /// <summary>
        /// 安卓提交
        /// </summary>
        Android = 2,

        /// <summary>
        ///苹果提交
        /// </summary>
        Ios = 3,

        /// <summary>
        /// 管理员添加
        /// </summary>
        AdministratorAdd = 4
    }
}