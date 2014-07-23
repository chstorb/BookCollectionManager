using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCM.WebFormsApplication.Startup))]
namespace BCM.WebFormsApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
