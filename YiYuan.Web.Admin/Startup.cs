using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YiYuan.Web.Admin.Startup))]
namespace YiYuan.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
