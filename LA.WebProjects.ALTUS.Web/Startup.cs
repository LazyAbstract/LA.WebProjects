using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LA.WebProjects.ALTUS.Web.Startup))]
namespace LA.WebProjects.ALTUS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
