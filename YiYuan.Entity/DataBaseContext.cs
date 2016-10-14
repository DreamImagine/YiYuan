using System.Data.Entity;

namespace YiYuan.Entity
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("YiYuanConnection")
        {
            Database.SetInitializer<DataBaseContext>(null);
        }

        public IDbSet<Activity> Activity { get; set; }

        public IDbSet<ActivityGoods> ActivityGoods { get; set; }


        public IDbSet<Addres> Addres { get; set; }


        public IDbSet<AdminInfo> AdminInfo { get; set; }

        public IDbSet<AdminRule> AdminRule { get; set; }

        public IDbSet<CityInfo> CityInfo { get; set; }

        public IDbSet<Goods> Goods { get; set; }

        public IDbSet<GoodsImg> GoodsImg { get; set; }

        public IDbSet<GoodsType> GoodsType { get; set; }

        public IDbSet<Issue> Issue { get; set; }

        public IDbSet<IssueNumber> IssueNumber { get; set; }

        public IDbSet<UserAddress> UserAddress { get; set; }

        public IDbSet<UserInfo> UserInfo { get; set; }

        public IDbSet<UserIntegralCurrency> UserIntegralCurrency { get; set; }

        public IDbSet<UserIntegralCurrencyUse> UserIntegralCurrencyUse { get; set; }

        public IDbSet<UserLoginRecord> UserLoginRecord { get; set; }

        public IDbSet<UserMessage> UserMessage { get; set; }

        public IDbSet<UserOperateWebRecord> UserOperateWebRecord { get; set; }

        public IDbSet<UserOrder> UserOrder { get; set; }

        public IDbSet<UserOrderDetails> UserOrderDetails { get; set; }

        public IDbSet<UserRecharge> UserRecharge { get; set; }

    }
}
