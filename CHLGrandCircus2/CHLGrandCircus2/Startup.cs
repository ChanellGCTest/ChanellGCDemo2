using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHLGrandCircus2.Startup))]
namespace CHLGrandCircus2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
