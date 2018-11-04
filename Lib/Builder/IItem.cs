using System;

namespace Lib.Restaurant
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        decimal Price();
    }
}
