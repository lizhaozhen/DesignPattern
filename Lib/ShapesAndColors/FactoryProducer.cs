using System;

namespace Lib
{
    public class FactoryProducer
    {
        private static FactoryProducer producer = new FactoryProducer();

        private FactoryProducer(){}

        public static FactoryProducer GetProducer()
        {
            return producer;
        }

        public AbstractFactory GetFactory(string choice)
        {
            if(choice == "SHAPE") return new ShapeFactory();
            if(choice == "COLOR") return new ColorFactory();
            return null;
        }
    }
}
