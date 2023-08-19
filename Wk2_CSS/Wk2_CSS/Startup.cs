using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wk2_CSS.Startup))]
namespace Wk2_CSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
