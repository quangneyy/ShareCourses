using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareCourses.Startup))]
namespace ShareCourses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
