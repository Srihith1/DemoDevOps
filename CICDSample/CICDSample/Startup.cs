using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICDSample.Startup))]
namespace CICDSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
