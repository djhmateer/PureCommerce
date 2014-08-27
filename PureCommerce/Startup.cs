using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PureCommerce.Startup))]
namespace PureCommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
