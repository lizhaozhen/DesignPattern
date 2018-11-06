using System;

namespace Lib.InterceptingFilterPattern
{
    public class FilterManager
    {
        private FilterChain filterChain = new FilterChain();

        public void SetFilter(IFilter filter)
        {
            filterChain.AddFilter(filter);
        }

        public void FilterRequest(string request)
        {
            filterChain.Execute(request);
        }
    }
}
