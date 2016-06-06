using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LA.WebProjects.LA.Web.Startup))]
namespace LA.WebProjects.LA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
