using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 商品类型
    /// </summary>
    public class GoodsType : EntityBase<int>
    {
        /// <summary>
        /// 类型名称
        /// </summary>
        public string Name { get; set; }
    }
}
