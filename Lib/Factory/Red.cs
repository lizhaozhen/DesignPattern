using System;

namespace Lib.Factory
{
    public class Red : IColor
    {
        public string Fill()
        {
            return "Inside Red::fill() method.";
        }
    }
}
