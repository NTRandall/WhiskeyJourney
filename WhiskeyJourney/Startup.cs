using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhiskeyJourney.Startup))]
namespace WhiskeyJourney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
