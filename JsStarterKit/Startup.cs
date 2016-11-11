using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JsStarterKit.Startup))]
namespace JsStarterKit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
