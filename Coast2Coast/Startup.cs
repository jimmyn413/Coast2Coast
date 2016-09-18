using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coast2Coast.Startup))]
namespace Coast2Coast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
