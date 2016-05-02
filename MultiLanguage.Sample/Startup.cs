using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiLanguage.Sample.Startup))]
namespace MultiLanguage.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
