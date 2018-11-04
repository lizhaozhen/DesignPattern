using System;

namespace Lib.Bridge
{
    public class RedCircle : IDraw
    {
        public string DrawCircle(int radius, int x, int y)
        {
            return $"Red circle with radius {radius} at {x} {y}";
        }
    }
}
