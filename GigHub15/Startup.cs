using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub15.Startup))]
namespace GigHub15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
