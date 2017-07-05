using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FourSSecurityPortal.Startup))]
namespace FourSSecurityPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
