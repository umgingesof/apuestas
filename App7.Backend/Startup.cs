using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App7.Backend.Startup))]
namespace App7.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
