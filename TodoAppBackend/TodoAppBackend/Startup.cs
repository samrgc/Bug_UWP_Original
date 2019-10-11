using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TodoAppBackend.Startup))]

namespace TodoAppBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}