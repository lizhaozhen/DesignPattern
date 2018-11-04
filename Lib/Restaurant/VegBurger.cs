using System;

namespace Lib.Restaurant
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override decimal Price()
        {
            return (decimal)5.5;
        }
    }
}
