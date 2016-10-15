using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.ViewModel
{
    public class ProductListViewModel
    {
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 总需人次
        /// </summary>
        public int EndNumber { get; set; }


        /// <summary>
        /// 已经参与人次
        /// </summary>
        public int ExistNumber { get; set; }

        /// <summary>
        /// 最小购买次数
        /// </summary>
        public int Min { get; set; }
    }
}
