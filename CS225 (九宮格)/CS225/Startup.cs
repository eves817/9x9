using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS225.Startup))]
namespace CS225
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
