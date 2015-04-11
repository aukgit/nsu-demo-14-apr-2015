using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NSUDemo.Startup))]
namespace NSUDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
