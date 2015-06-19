using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KcCodeMentors.Startup))]
namespace KcCodeMentors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
