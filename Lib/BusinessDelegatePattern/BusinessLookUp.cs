using System;

namespace Lib.BusinessDelegatePattern
{
    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if(serviceType == "EJB") return new EJBService();
            return new JMSService();
        }
    }
}
