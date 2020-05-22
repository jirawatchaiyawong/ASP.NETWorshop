using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterASP.Startup))]
namespace MasterASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
