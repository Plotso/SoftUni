using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForumProjectBeta.Startup))]
namespace ForumProjectBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
