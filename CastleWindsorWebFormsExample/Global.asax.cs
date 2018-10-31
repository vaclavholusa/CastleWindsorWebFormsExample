using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using Castle.Windsor;
using System;
using System.Web;

namespace CastleWindsorWebFormsExample
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            IWindsorContainer castleContainer = new WindsorContainer();
            HttpRuntime.WebObjectActivator = new CastleWindsorServiceProvider(castleContainer);

            castleContainer.Register(Component.For<ILazyComponentLoader>().ImplementedBy<WebFormsComponentsLoader>());
            castleContainer.Register(Component.For<IDateTimeProvider>().ImplementedBy<LocalDateTimeProvider>());
        }
    }
}