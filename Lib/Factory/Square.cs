using System;

namespace Lib.Factory
{
    public class Square : IShape
    {
        public string Draw()
        {
            return "Inside Square::draw() method.";
        }
    }
}
