using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCdt05132021.Startup))]
namespace MVCdt05132021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
