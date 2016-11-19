using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeWebClient.Startup))]
namespace TimeWebClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
