using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LevsLogWebForms.Startup))]
namespace LevsLogWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
