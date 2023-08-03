using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppCSharp48.Startup))]
namespace WebAppCSharp48
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
