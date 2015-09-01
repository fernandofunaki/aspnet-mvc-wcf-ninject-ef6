using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeCurso.UI.MVC.Startup))]
namespace AcmeCurso.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
