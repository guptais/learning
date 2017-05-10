using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(YCompany.EPolicyPortal.Web.Startup))]
namespace YCompany.EPolicyPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
