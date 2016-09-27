using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户购买活动
    /// </summary>
    public class UserActivity : EntityBase<int>
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public int ActivityId { get; }

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
