using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using System;
using System.Collections;

namespace CastleWindsorWebFormsExample
{
    public class WebFormsComponentsLoader : ILazyComponentLoader
    {
        public IRegistration Load(string name, Type service, IDictionary arguments)
        {
            if (service == null)
            {
                return null;
            }

            if (service.IsWebFormsComponent())
            {
                return Component.For(service).Named(name).LifestylePerWebRequest();
            }

            return null;
        }
    }
}