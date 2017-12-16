using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(parneetkaur.Startup))]
namespace parneetkaur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
