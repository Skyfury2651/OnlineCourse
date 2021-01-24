using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T1908EOnlineCourse.Startup))]
namespace T1908EOnlineCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
