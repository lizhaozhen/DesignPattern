using System;

namespace Lib.Factory
{
    public class Circle : IShape
    {
        public string Draw()
        {
            return "Inside Circle::draw() method.";
        }
    }
}
