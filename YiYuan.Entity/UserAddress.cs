using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户地址
    /// </summary>
    public class UserAddress : EntityBase<int>
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 地址编号
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// 
        /// </summary>

        public UserInfo UserInfo { get; set; }
    }
}
