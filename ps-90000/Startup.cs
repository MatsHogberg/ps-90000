using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ps_90000.Startup))]
namespace ps_90000
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
