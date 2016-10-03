using System.Data.Entity;

namespace YiYuan.Entity
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("YiYuanConnection")
        {
        }


        public IDbSet<UserInfo> UserInfo { get; set; }

        public IDbSet<AdminInfo> AdminInfo { get; set; }

        public IDbSet<AdminRule> AdminRule { get; set; }
    }
}
