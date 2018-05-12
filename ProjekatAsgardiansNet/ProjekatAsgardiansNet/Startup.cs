using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjekatAsgardiansNet.Startup))]
namespace ProjekatAsgardiansNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
