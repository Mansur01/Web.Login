using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.Login.Startup))]
namespace Web.Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
