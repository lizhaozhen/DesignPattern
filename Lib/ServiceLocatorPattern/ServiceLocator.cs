using System;

namespace Lib.ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private static Cache cache = new Cache();

        public static IService GetService(string serviceName)
        {
            var service = cache.GetService(serviceName);
            if(service != null) return service;

            var context = new InitialContext();
            service = (IService)context.Lookup(serviceName);
            cache.AddService(service);
            return service;
        }
    }
}
