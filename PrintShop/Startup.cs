using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrintShop.Startup))]
namespace PrintShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
