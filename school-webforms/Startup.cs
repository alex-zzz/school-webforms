using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(school_webforms.Startup))]
namespace school_webforms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
