using System.Web.Mvc;
using YiYuan.Web.Filter;

namespace YiYuan.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new WebOperationAttribute(), 2);
        }
    }
}
