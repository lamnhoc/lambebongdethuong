using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LEXUANLAM_LAB45.Startup))]
namespace LEXUANLAM_LAB45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
