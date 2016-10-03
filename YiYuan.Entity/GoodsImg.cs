namespace YiYuan.Entity
{
    /// <summary>
    /// 商品图
    /// </summary>
    public class GoodsImg : EntityBase<int>
    {

        /// <summary>
        /// 商品编号
        /// </summary>
        
        public int GoodsId { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Goods Goods { get; set; }

    }
}
