using System;

namespace Lib.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(String color);
        public abstract IShape GetShape(String shape) ;
    }
}
