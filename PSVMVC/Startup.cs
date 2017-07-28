using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSVMVC.Startup))]
namespace PSVMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
