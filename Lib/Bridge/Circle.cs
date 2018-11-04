using System;

namespace Lib.Bridge
{
    public class Circle : Shape
    {
        private int radius;
        private int x;
        private int y;

        public Circle(int radius, int x, int y, IDraw draw) : base(draw)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public override string Draw()
        {
            return _draw.DrawCircle(radius, x, y);
        }
    }
}
