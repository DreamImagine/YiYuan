namespace YiYuan.Entity
{
    /// <summary>
    /// 地址
    /// </summary>
    public class Addres : EntityBase<int>
    {
        /// <summary>
        /// 地址编号
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 地址名称
        /// </summary>
        public string Name { get; set; }



    }
}
