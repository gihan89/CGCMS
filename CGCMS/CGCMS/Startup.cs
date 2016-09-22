using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CGCMS.Startup))]
namespace CGCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
