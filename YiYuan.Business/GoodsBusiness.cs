using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiYuan.Entity;

namespace YiYuan.Business
{
    public class GoodsBusiness : BaseBusiness<Goods>
    {
        public void AddImage(List<GoodsImg> list)
        {
            context.Set<GoodsImg>().AddRange(list);
            context.SaveChangesAsync();
        }
    }
}
