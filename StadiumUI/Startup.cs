using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StadiumUI.Startup))]
namespace StadiumUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
