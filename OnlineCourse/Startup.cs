using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMail.Startup))]
namespace TestMail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
