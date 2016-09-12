using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contoso.University.Web.Startup))]
namespace Contoso.University.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
