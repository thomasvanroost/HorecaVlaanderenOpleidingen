using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HorecaVlaanderenOpleidingen.Startup))]
namespace HorecaVlaanderenOpleidingen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
