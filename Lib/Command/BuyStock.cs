using System;

namespace Lib.Command
{
    public class BuyStock : IOrder
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}
