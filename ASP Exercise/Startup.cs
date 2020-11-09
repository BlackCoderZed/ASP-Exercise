using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Exercise.Startup))]
namespace ASP_Exercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
