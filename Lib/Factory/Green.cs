using System;

namespace Lib.Factory
{
    public class Green : IColor
    {
        public string Fill()
        {
            return "Inside Green::fill() method.";
        }
    }
}
