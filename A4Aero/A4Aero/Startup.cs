using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4Aero.Startup))]
namespace A4Aero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
