using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspIdentityMVC.Startup))]
namespace AspIdentityMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
