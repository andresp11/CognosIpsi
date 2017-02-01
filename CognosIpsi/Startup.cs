using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CognosIpsi.Startup))]
namespace CognosIpsi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
