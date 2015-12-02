using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReclamaPoaS2B.Startup))]
namespace ReclamaPoaS2B
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
