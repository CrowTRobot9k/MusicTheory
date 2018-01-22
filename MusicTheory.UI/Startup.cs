using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicTheory.UI.Startup))]
namespace MusicTheory.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
