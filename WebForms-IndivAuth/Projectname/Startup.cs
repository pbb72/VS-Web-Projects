using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projectname.Startup))]
namespace Projectname
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
