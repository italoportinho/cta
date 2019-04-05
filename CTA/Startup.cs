using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTA.Startup))]
namespace CTA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
