using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(analead_taskmanger_appService.Startup))]

namespace analead_taskmanger_appService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}