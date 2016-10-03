using YiYuan.Enums;

namespace YiYuan.Entity
{
    /// <summary>
    /// 活动
    /// </summary>
    public class Activity : EntityBase<int>
    {
        /// <summary>
        ///
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 每注价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        public ActivityStatus ActivityStatus { get; set; }


    }
}