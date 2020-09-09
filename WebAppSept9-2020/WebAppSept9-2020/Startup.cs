using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSept9_2020.Startup))]
namespace WebAppSept9_2020
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
