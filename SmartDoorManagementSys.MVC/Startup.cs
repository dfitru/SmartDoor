using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartDoorManagementSys.MVC.Startup))]
namespace SmartDoorManagementSys.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
