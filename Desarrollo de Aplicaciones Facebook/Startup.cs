using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Desarrollo_de_Aplicaciones_Facebook.Startup))]
namespace Desarrollo_de_Aplicaciones_Facebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
