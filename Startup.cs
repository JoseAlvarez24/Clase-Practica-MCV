using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaMVC2.Startup))]
namespace TiendaMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
