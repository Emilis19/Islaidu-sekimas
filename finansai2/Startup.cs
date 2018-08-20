using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(finansai2.Startup))]
namespace finansai2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
