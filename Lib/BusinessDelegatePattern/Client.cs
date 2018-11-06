using System;

namespace Lib.BusinessDelegatePattern
{
    public class Client
    {
        private BusinessDelegate businessDelegate;

        public Client(BusinessDelegate businessDelegate)
        {
            this.businessDelegate = businessDelegate;
        }

        public void DoTask()
        {
            businessDelegate.DoTask();
        }
    }
}
