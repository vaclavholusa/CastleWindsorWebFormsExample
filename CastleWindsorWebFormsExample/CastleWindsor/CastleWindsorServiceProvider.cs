using Castle.Windsor;
using System;
using System.Reflection;

namespace CastleWindsorWebFormsExample
{
    public class CastleWindsorServiceProvider : IServiceProvider
    {
        private IWindsorContainer Container { get; }

        public CastleWindsorServiceProvider(IWindsorContainer container)
        {
            Container = container;
        }

        public object GetService(Type serviceType)
        {
            if(Container.Kernel.HasComponent(serviceType) || serviceType.IsWebFormsComponent())
            {
                return Container.Resolve(serviceType);
            }

            return Activator.CreateInstance(
                        serviceType,
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.CreateInstance,
                        null,
                        null,
                        null);
        }
    }
}