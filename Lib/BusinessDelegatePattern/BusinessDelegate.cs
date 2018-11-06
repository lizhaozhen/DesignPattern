using System;

namespace Lib.BusinessDelegatePattern
{
    public class BusinessDelegate
    {
        private BusinessLookUp businessLookUp = new BusinessLookUp();
        private IBusinessService businessService;
        private string serviceType;

        public void SetServiceType(string serviceType)
        {
            this.serviceType = serviceType;
        }

        public void DoTask()
        {
            businessService = businessLookUp.GetBusinessService(serviceType);
            businessService.DoProcessing();
        }
    }
}
