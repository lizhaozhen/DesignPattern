using System;

namespace Lib.Command
{
    public class SellBlock : IOrder
    {
        private readonly Stock abcStock;

        public SellBlock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }

        public void Execute()
        {
            abcStock.Sell();
        }
    }
}
