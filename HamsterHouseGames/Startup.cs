using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamsterHouseGames.Startup))]
namespace HamsterHouseGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
