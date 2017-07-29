using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaGatResturant.Startup))]
namespace PizzaGatResturant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
