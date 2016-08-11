using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zoopedia.Startup))]
namespace Zoopedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
