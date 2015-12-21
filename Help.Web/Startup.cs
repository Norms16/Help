using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Help.Web.Startup))]
namespace Help.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
