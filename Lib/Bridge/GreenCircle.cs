using System;

namespace Lib.Bridge
{
    public class GreenCircle : IDraw
    {
        public string DrawCircle(int radius, int x, int y)
        {
            return $"Green circle with radius {radius} at {x} {y}";
        }
    }
}
