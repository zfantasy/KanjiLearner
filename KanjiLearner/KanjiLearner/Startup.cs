using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KanjiLearner.Startup))]
namespace KanjiLearner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
