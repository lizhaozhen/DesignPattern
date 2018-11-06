using System;
using System.Collections.Generic;

namespace Lib.InterceptingFilterPattern
{
    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();
        private Target target = new Target();

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach(var filter in filters)
            {
                filter.Execute(request);
            }

            target.Execute(request);
        }
    }
}
