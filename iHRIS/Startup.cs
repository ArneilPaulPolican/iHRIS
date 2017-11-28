using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iHRIS.Startup))]
namespace iHRIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
