using System;

namespace Lib.Restaurant
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract decimal Price();
    }
}
