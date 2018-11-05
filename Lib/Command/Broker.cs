using System;
using System.Collections.Generic;

namespace Lib.Command
{
    public class Broker
    {
        private List<IOrder> orders  = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(var order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
