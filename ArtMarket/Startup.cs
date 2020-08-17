using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtMarket.Startup))]
namespace ArtMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
