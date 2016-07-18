using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModalExample.Startup))]
namespace ModalExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
