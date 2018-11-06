using System;

namespace Lib.InterceptingFilterPattern
{
    public class DebugFilter : IFilter
    {
        public void Execute(string request)
        {
            throw new NotImplementedException();
        }
    }
}
