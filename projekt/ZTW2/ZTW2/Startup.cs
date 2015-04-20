using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZTW2.Startup))]
namespace ZTW2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
