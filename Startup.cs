using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AICPJOBPORTALJOBPORTAL.Startup))]
namespace AICPJOBPORTALJOBPORTAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
