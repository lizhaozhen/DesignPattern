using System;

namespace Lib.InterceptingFilterPattern
{
    public class AuthenticationFilter : IFilter
    {
        public void Execute(string request)
        {
            throw new NotImplementedException();
        }
    }
}
