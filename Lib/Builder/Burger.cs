using System;

namespace Lib.Restaurant
{
    public abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract decimal Price();
    }
}
