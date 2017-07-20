using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalManagementWeb.Startup))]
namespace HospitalManagementWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
