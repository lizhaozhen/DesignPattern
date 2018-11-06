using System;
using System.Collections.Generic;

namespace Lib.ServiceLocatorPattern
{
    public class Cache
    {
        private List<IService> services = new List<IService>();

        public IService GetService(string serviceName)
        {
            return null;
        }

        public void AddService(IService service)
        {
            services.Add(service);
        }
    }
}
