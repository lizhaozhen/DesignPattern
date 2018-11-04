using System;

namespace Lib.ShapesAndColors
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            if(color == "RED") return new Red();
            if(color == "GREEN") return new Green();
            return null;
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
