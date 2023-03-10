using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(duongtrinhson_2011063038_lab4.Startup))]
namespace duongtrinhson_2011063038_lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
