using System;

namespace Lib.InterceptingFilterPattern
{
    public interface IFilter
    {
        void Execute(string request);
    }
}
