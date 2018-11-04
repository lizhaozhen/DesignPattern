using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib.Restaurant
{
    public class Meal
    {
        private List<IItem> _items = new List<IItem>();

        public void AddItem(IItem item)
        {
            _items.Add(item);
        }

        public decimal Price()
        {
            return _items.Sum(x => x.Price());
        }

        public List<string> Names()
        {
            return _items.Select(x => x.Name()).ToList();
        }
    }
}
