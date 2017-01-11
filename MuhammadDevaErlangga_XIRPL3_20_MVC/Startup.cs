using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuhammadDevaErlangga_XIRPL3_20_MVC.Startup))]
namespace MuhammadDevaErlangga_XIRPL3_20_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
