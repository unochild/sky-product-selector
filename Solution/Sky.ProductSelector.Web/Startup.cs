using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sky.ProductSelector.Web.Startup))]
namespace Sky.ProductSelector.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
