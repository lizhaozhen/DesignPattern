using System;

namespace Lib.InterceptingFilterPattern
{
    public class Client
    {
        FilterManager filterManager = new FilterManager();

        public void SendRequest(string request)
        {
            filterManager.FilterRequest(request);
        }
    }
}
