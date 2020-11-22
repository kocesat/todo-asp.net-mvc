using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoAspNetMvc.Startup))]
namespace TodoAspNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
