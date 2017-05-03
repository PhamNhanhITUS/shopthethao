using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shopthethao.Startup))]
namespace shopthethao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
