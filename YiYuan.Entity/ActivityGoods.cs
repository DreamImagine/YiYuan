namespace YiYuan.Entity
{
    /// <summary>
    /// 活动商品
    /// </summary>
    public class ActivityGoods : EntityBase<int>
    {
        /// <summary>
        /// 活动id 
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 商品id 
        /// </summary>
        public int GoodsId { get; set; }

    }
}