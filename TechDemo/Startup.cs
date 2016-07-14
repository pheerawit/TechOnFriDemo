using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechDemo.Startup))]
namespace TechDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
