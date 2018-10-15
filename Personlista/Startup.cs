using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personlista.Startup))]
namespace Personlista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
