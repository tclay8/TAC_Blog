using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAC_Blog.Startup))]
namespace TAC_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
