using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yu_Gi_Oh.Startup))]
namespace Yu_Gi_Oh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
