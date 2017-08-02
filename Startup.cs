using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aftremath_Nissan.Startup))]
namespace Aftremath_Nissan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
