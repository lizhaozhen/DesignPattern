using System;

namespace Lib.ServiceLocatorPattern
{
    public class InitialContext
    {
        public object Lookup(string jndiName)
        {
            if(jndiName == "service1") return new Service1();
            if(jndiName == "service2") return new Service2();
            return null;
        }
    }
}
