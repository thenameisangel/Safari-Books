using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafariBooks24.Startup))]
namespace SafariBooks24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
