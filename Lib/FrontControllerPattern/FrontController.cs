using System;

namespace Lib.FrontControllerPattern
{
    public class FrontController
    {
        private Dispatcher dispatcher = new Dispatcher();

        public void DispacthRequest(string request)
        {
            dispatcher.Dispatch(request);
        }
    }
}
