using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fasTasteFood.Startup))]
namespace fasTasteFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
