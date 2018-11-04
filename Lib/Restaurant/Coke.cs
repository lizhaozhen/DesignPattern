using System;

namespace Lib.Restaurant
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override decimal Price()
        {
            return (decimal)3;
        }
    }
}
