using System;

namespace Lib.ShapesAndColors
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(String color);
        public abstract IShape GetShape(String shape) ;
    }
}
