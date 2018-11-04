using System;

namespace Lib
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if(choice == "SHAPE") return new ShapeFactory();
            if(choice == "COLOR") return new ColorFactory();
            return null;
        }
    }
}
