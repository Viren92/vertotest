using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test123.Startup))]
namespace test123
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
