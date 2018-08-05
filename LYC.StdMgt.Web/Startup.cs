using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LYC.StdMgt.Web.Startup))]
namespace LYC.StdMgt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
