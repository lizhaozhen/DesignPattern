using System;

namespace Lib.Factory
{
    public class Rectangle : IShape
    {
        public string Draw()
        {
            return "Inside Square::draw() method.";
        }
    }
}
