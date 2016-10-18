using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 每注价格
        /// </summary>
        [Display(Name = "每注价格")]
        public decimal Price { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [Display(Name = "活动状态")]
        public ActivityStatus ActivityStatus { get; set; }

    }
}