using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(identityLesson.Startup))]
namespace identityLesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
