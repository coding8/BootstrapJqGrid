using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapJqGrid.Startup))]
namespace BootstrapJqGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
