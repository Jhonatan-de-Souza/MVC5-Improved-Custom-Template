using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5_Boilerplate.Startup))]
namespace Mvc5_Boilerplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
